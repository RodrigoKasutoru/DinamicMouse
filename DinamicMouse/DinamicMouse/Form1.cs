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
       


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
            }
            else
            {
                Capturadora.Stop();
                btnIniciar.Text = "Iniciar";

            }
        }
        public void lector(object sender, SpeechRecognizedEventArgs e)
        {
            foreach (RecognizedWordUnit palabra in e.Result.Words)
            {
                switch (palabra.Text)
                {
                    case "click":
                        label1.Text = palabra.Text;

                        break;
                    case "derecho":
                        label1.Text = palabra.Text;

                        break;
                    case "doble":
                        label1.Text = palabra.Text;

                        break;
                    default:
                        break;
                }
            }
        }

    }
}
