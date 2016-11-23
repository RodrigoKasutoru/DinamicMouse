namespace DinamicMouse
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbDevices = new MetroFramework.Controls.MetroComboBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // cmbDevices
            // 
            this.cmbDevices.FormattingEnabled = true;
            this.cmbDevices.ItemHeight = 23;
            this.cmbDevices.Location = new System.Drawing.Point(5, 42);
            this.cmbDevices.Name = "cmbDevices";
            this.cmbDevices.Size = new System.Drawing.Size(241, 29);
            this.cmbDevices.TabIndex = 0;
            this.cmbDevices.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(252, 42);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 29);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "Iniciar";
            this.metroButton1.UseSelectable = true;
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.Location = new System.Drawing.Point(5, 77);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(328, 235);
            this.videoSourcePlayer1.TabIndex = 2;
            this.videoSourcePlayer1.Text = "videoSourcePlayer1";
            this.videoSourcePlayer1.VideoSource = null;
            // 
            // metroLink1
            // 
            this.metroLink1.Location = new System.Drawing.Point(5, 13);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(167, 23);
            this.metroLink1.TabIndex = 3;
            this.metroLink1.Text = "Selecciona una camara web:";
            this.metroLink1.UseSelectable = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 318);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.videoSourcePlayer1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.cmbDevices);
            this.Name = "Form1";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cmbDevices;
        private MetroFramework.Controls.MetroButton metroButton1;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private MetroFramework.Controls.MetroLink metroLink1;
    }
}

