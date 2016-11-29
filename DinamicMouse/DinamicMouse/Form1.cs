using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Vision.Motion;
using System.Speech;
using System.Speech.Recognition;

namespace DinamicMouse
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private FilterInfoCollection devices;
        private VideoCaptureDevice videoCapture;
        private MotionDetector Motion;
        private SpeechRecognitionEngine escucha = new SpeechRecognitionEngine();
        private float levelDetection;

        Rectangle A1,A2,A3,A4;
    


        //Esto reemplaza a Cursor.Position en WinForms
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool SetCursorPos(int x, int y);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;
        public const int MOUSEEVENTF_RIGHTDOWN = 0X08;
        public const int MOUSEEVENTF_RIGHTUP = 0X10;

        //Esto simula un click con el botón izquierdo del ratón
        public static void LeftMouseClick(int xpos, int ypos)
        {
            SetCursorPos(xpos, ypos);
            mouse_event(MOUSEEVENTF_LEFTDOWN, xpos, ypos, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, xpos, ypos, 0, 0);
        }

        public static void RightMouseClick(int xpos, int ypos)
        {
            SetCursorPos(xpos, ypos);
            mouse_event(MOUSEEVENTF_RIGHTDOWN, xpos, ypos, 0, 0);
            mouse_event(MOUSEEVENTF_RIGHTUP, xpos, ypos, 0, 0);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Motion = new MotionDetector(new TwoFramesDifferenceDetector(), new MotionBorderHighlighting());
            devices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo dev in devices)
            {
                cmbDevices.Items.Add(dev.Name);
            }
            cmbDevices.SelectedIndex = 0;

            if (cmbDevices.Items.Count == 0)
            {
              btnIniciar.Enabled = false;
            }

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (btnIniciar.Text == "Iniciar")
            {
                videoCapture = new VideoCaptureDevice(devices[cmbDevices.SelectedIndex].MonikerString);
                Capturadora.VideoSource = videoCapture;
                Capturadora.Start();
                btnIniciar.Text = "Detener";
                /*Activación de microfono*/
                escucha.SetInputToDefaultAudioDevice();
                escucha.LoadGrammar(new DictationGrammar());
                escucha.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(lector);
                escucha.RecognizeAsync(RecognizeMode.Multiple);
                timer1.Interval = 10;
                timer1.Start();

            
            }
            else
            {
                Capturadora.Stop();
                escucha.RecognizeAsyncStop();
                btnIniciar.Text = "Iniciar";
                timer1.Stop();

            }
        }
        public void lector(object sender, SpeechRecognizedEventArgs e)
        {
            foreach (RecognizedWordUnit palabra in e.Result.Words)
            {
                label1.Text = ". . .";
                switch (palabra.Text)
                {
                    case "izquierdo":
                        label1.Text = palabra.Text;
                        LeftMouseClick(Cursor.Position.X,Cursor.Position.Y);

                        break;
                    case "derecho":
                        label1.Text = palabra.Text;
                        RightMouseClick(Cursor.Position.X, Cursor.Position.Y);

                        break;
                    case "doble":
                        label1.Text = palabra.Text;
                        LeftMouseClick(Cursor.Position.X, Cursor.Position.Y);
                        LeftMouseClick(Cursor.Position.X, Cursor.Position.Y);
                        break;
                    case "cortada":
                        MessageBox.Show("No soy Cortana, pero estoy en proceso de ser mejor que ella :v","Hola usuario",MessageBoxButtons.OK);
                        break;
                    default:
                        label1.Text = palabra.Text;
                        break;
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Capturadora.Stop();
            escucha.RecognizeAsyncStop();
            btnIniciar.Text = "Iniciar";
            Application.Exit();
        }

        private void Capturadora_NewFrame(object sender, ref Bitmap image)
        {
            levelDetection = Motion.ProcessFrame(image);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Pen Marco = new Pen(Brushes.Blue, 2);
            Graphics cuadrado;
            A1 = new Rectangle(0, 0, 328, 25);
            cuadrado = Capturadora.CreateGraphics();
            cuadrado.DrawRectangle(Marco, A1);
            A2 = new Rectangle(0, 26, 25, 180);
            cuadrado = Capturadora.CreateGraphics();
            cuadrado.DrawRectangle(Marco, A2);
            A2 = new Rectangle(308, 26, 25, 180);
            cuadrado = Capturadora.CreateGraphics();
            cuadrado.DrawRectangle(Marco, A2);
            A4 = new Rectangle(0, 208, 328, 25);
            cuadrado = Capturadora.CreateGraphics();
            cuadrado.DrawRectangle(Marco, A4);
         
        }

    }
}
