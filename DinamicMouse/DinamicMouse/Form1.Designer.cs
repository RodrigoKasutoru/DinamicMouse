﻿namespace DinamicMouse
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
            this.btnIniciar = new MetroFramework.Controls.MetroButton();
            this.Capturadora = new AForge.Controls.VideoSourcePlayer();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(252, 42);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 29);
            this.btnIniciar.TabIndex = 1;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseSelectable = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // Capturadora
            // 
            this.Capturadora.Location = new System.Drawing.Point(5, 77);
            this.Capturadora.Name = "Capturadora";
            this.Capturadora.Size = new System.Drawing.Size(328, 235);
            this.Capturadora.TabIndex = 2;
            this.Capturadora.Text = "videoSourcePlayer1";
            this.Capturadora.VideoSource = null;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = ". . .";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Palabra:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 355);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.Capturadora);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.cmbDevices);
            this.Name = "Form1";
            this.Resizable = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cmbDevices;
        private MetroFramework.Controls.MetroButton btnIniciar;
        private AForge.Controls.VideoSourcePlayer Capturadora;
        private MetroFramework.Controls.MetroLink metroLink1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

