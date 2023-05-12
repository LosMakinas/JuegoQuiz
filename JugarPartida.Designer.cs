using System.Windows.Forms;

namespace JuegoQuizzReto {
    partial class JugarPartida {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JugarPartida));
            this.picFotoPregunta = new System.Windows.Forms.PictureBox();
            this.lblNumPregunta = new System.Windows.Forms.Label();
            this.lblTiempoRest = new System.Windows.Forms.Label();
            this.picPreguntaResp = new System.Windows.Forms.PictureBox();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.picCorazon1 = new System.Windows.Forms.PictureBox();
            this.picCorazon3 = new System.Windows.Forms.PictureBox();
            this.picCorazon2 = new System.Windows.Forms.PictureBox();
            this.lblResp1 = new System.Windows.Forms.Label();
            this.lblPuntuacion = new System.Windows.Forms.Label();
            this.lblResp4 = new System.Windows.Forms.Label();
            this.lblResp3 = new System.Windows.Forms.Label();
            this.lblResp2 = new System.Windows.Forms.Label();
            this.relojPartida = new System.Windows.Forms.Timer(this.components);
            this.lblSigPregunta = new System.Windows.Forms.Label();
            this.relojEsperarSigPregunta = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picFotoPregunta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPreguntaResp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCorazon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCorazon3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCorazon2)).BeginInit();
            this.SuspendLayout();
            // 
            // picFotoPregunta
            // 
            this.picFotoPregunta.BackColor = System.Drawing.Color.Transparent;
            this.picFotoPregunta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picFotoPregunta.ImageLocation = "";
            this.picFotoPregunta.Location = new System.Drawing.Point(369, -1);
            this.picFotoPregunta.Name = "picFotoPregunta";
            this.picFotoPregunta.Size = new System.Drawing.Size(550, 365);
            this.picFotoPregunta.SizeMode = PictureBoxSizeMode.StretchImage;
            this.picFotoPregunta.TabIndex = 2;
            this.picFotoPregunta.TabStop = false;
            // 
            // lblNumPregunta
            // 
            this.lblNumPregunta.BackColor = System.Drawing.Color.Transparent;
            this.lblNumPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPregunta.ForeColor = System.Drawing.Color.White;
            this.lblNumPregunta.Location = new System.Drawing.Point(369, 390);
            this.lblNumPregunta.Name = "lblNumPregunta";
            this.lblNumPregunta.Size = new System.Drawing.Size(548, 56);
            this.lblNumPregunta.TabIndex = 3;
            this.lblNumPregunta.Text = "Pregunta 1";
            this.lblNumPregunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTiempoRest
            // 
            this.lblTiempoRest.BackColor = System.Drawing.Color.Transparent;
            this.lblTiempoRest.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoRest.ForeColor = System.Drawing.Color.White;
            this.lblTiempoRest.Location = new System.Drawing.Point(1048, 19);
            this.lblTiempoRest.Name = "lblTiempoRest";
            this.lblTiempoRest.Size = new System.Drawing.Size(227, 61);
            this.lblTiempoRest.TabIndex = 4;
            this.lblTiempoRest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picPreguntaResp
            // 
            this.picPreguntaResp.BackColor = System.Drawing.Color.Transparent;
            this.picPreguntaResp.BackgroundImage = global::JuegoQuizzReto.Properties.Resources.Preguntas;
            this.picPreguntaResp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPreguntaResp.Location = new System.Drawing.Point(-138, 449);
            this.picPreguntaResp.Name = "picPreguntaResp";
            this.picPreguntaResp.Size = new System.Drawing.Size(1508, 363);
            this.picPreguntaResp.TabIndex = 5;
            this.picPreguntaResp.TabStop = false;
            // 
            // lblPregunta
            // 
            this.lblPregunta.BackColor = System.Drawing.Color.Transparent;
            this.lblPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblPregunta.ForeColor = System.Drawing.Color.White;
            this.lblPregunta.Image = global::JuegoQuizzReto.Properties.Resources.Pregunta;
            this.lblPregunta.Location = new System.Drawing.Point(359, 457);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(581, 118);
            this.lblPregunta.TabIndex = 6;
            this.lblPregunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picCorazon1
            // 
            this.picCorazon1.BackColor = System.Drawing.Color.Transparent;
            this.picCorazon1.BackgroundImage = global::JuegoQuizzReto.Properties.Resources.corazonFull;
            this.picCorazon1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCorazon1.Location = new System.Drawing.Point(17, 19);
            this.picCorazon1.Name = "picCorazon1";
            this.picCorazon1.Size = new System.Drawing.Size(55, 51);
            this.picCorazon1.TabIndex = 7;
            this.picCorazon1.TabStop = false;
            this.picCorazon1.Tag = "Full";
            // 
            // picCorazon3
            // 
            this.picCorazon3.BackColor = System.Drawing.Color.Transparent;
            this.picCorazon3.BackgroundImage = global::JuegoQuizzReto.Properties.Resources.corazonFull;
            this.picCorazon3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCorazon3.Location = new System.Drawing.Point(139, 19);
            this.picCorazon3.Name = "picCorazon3";
            this.picCorazon3.Size = new System.Drawing.Size(55, 51);
            this.picCorazon3.TabIndex = 7;
            this.picCorazon3.TabStop = false;
            this.picCorazon3.Tag = "Full";
            // 
            // picCorazon2
            // 
            this.picCorazon2.BackColor = System.Drawing.Color.Transparent;
            this.picCorazon2.BackgroundImage = global::JuegoQuizzReto.Properties.Resources.corazonFull;
            this.picCorazon2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCorazon2.Location = new System.Drawing.Point(78, 19);
            this.picCorazon2.Name = "picCorazon2";
            this.picCorazon2.Size = new System.Drawing.Size(55, 51);
            this.picCorazon2.TabIndex = 7;
            this.picCorazon2.TabStop = false;
            this.picCorazon2.Tag = "Full";
            // 
            // lblResp1
            // 
            this.lblResp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblResp1.ForeColor = System.Drawing.Color.White;
            this.lblResp1.Image = global::JuegoQuizzReto.Properties.Resources.Pregunta;
            this.lblResp1.Location = new System.Drawing.Point(169, 631);
            this.lblResp1.Name = "lblResp1";
            this.lblResp1.Size = new System.Drawing.Size(414, 67);
            this.lblResp1.TabIndex = 8;
            this.lblResp1.Tag = "Falsa";
            this.lblResp1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResp1.Click += new System.EventHandler(this.lblResp1_Click);
            // 
            // lblPuntuacion
            // 
            this.lblPuntuacion.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntuacion.Font = new System.Drawing.Font("Source Sans Pro Black", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntuacion.ForeColor = System.Drawing.Color.White;
            this.lblPuntuacion.Location = new System.Drawing.Point(0, 113);
            this.lblPuntuacion.Name = "lblPuntuacion";
            this.lblPuntuacion.Size = new System.Drawing.Size(363, 48);
            this.lblPuntuacion.TabIndex = 9;
            this.lblPuntuacion.Text = "0 Pts";
            // 
            // lblResp4
            // 
            this.lblResp4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblResp4.ForeColor = System.Drawing.Color.White;
            this.lblResp4.Image = global::JuegoQuizzReto.Properties.Resources.Pregunta;
            this.lblResp4.Location = new System.Drawing.Point(759, 740);
            this.lblResp4.Name = "lblResp4";
            this.lblResp4.Size = new System.Drawing.Size(408, 67);
            this.lblResp4.TabIndex = 8;
            this.lblResp4.Tag = "Verdadera";
            this.lblResp4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResp4.Click += new System.EventHandler(this.lblResp4_Click);
            // 
            // lblResp3
            // 
            this.lblResp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblResp3.ForeColor = System.Drawing.Color.White;
            this.lblResp3.Image = global::JuegoQuizzReto.Properties.Resources.Pregunta;
            this.lblResp3.Location = new System.Drawing.Point(169, 740);
            this.lblResp3.Name = "lblResp3";
            this.lblResp3.Size = new System.Drawing.Size(414, 67);
            this.lblResp3.TabIndex = 8;
            this.lblResp3.Tag = "Falsa";
            this.lblResp3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResp3.Click += new System.EventHandler(this.lblResp3_Click);
            // 
            // lblResp2
            // 
            this.lblResp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblResp2.ForeColor = System.Drawing.Color.White;
            this.lblResp2.Image = global::JuegoQuizzReto.Properties.Resources.Pregunta;
            this.lblResp2.Location = new System.Drawing.Point(759, 631);
            this.lblResp2.Name = "lblResp2";
            this.lblResp2.Size = new System.Drawing.Size(408, 67);
            this.lblResp2.TabIndex = 8;
            this.lblResp2.Tag = "Falsa";
            this.lblResp2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResp2.Click += new System.EventHandler(this.lblResp2_Click);
            // 
            // relojPartida
            // 
            this.relojPartida.Interval = 1000;
            this.relojPartida.Tick += new System.EventHandler(this.relojPartida_Tick);
            // 
            // lblSigPregunta
            // 
            this.lblSigPregunta.BackColor = System.Drawing.Color.Transparent;
            this.lblSigPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSigPregunta.ForeColor = System.Drawing.Color.White;
            this.lblSigPregunta.Location = new System.Drawing.Point(459, 167);
            this.lblSigPregunta.Name = "lblSigPregunta";
            this.lblSigPregunta.Size = new System.Drawing.Size(369, 180);
            this.lblSigPregunta.TabIndex = 10;
            this.lblSigPregunta.Text = "Espere un momento. La pregunta está cargando...";
            this.lblSigPregunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSigPregunta.Visible = false;
            // 
            // relojEsperarSigPregunta
            // 
            this.relojEsperarSigPregunta.Interval = 1000;
            this.relojEsperarSigPregunta.Tick += new System.EventHandler(this.relojEsperarSigPregunta_Tick);
            // 
            // JugarPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JuegoQuizzReto.Properties.Resources.Galaxy_repeating;
            this.ClientSize = new System.Drawing.Size(1284, 811);
            this.Controls.Add(this.lblSigPregunta);
            this.Controls.Add(this.lblPuntuacion);
            this.Controls.Add(this.lblResp2);
            this.Controls.Add(this.lblResp4);
            this.Controls.Add(this.lblResp3);
            this.Controls.Add(this.lblResp1);
            this.Controls.Add(this.picCorazon2);
            this.Controls.Add(this.picCorazon3);
            this.Controls.Add(this.picCorazon1);
            this.Controls.Add(this.lblTiempoRest);
            this.Controls.Add(this.lblNumPregunta);
            this.Controls.Add(this.picFotoPregunta);
            this.Controls.Add(this.lblPregunta);
            this.Controls.Add(this.picPreguntaResp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JugarPartida";
            this.Tag = "º";
            this.Text = "Partida";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JugarPartida_FormClosing);
            this.Load += new System.EventHandler(this.JugarPartida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFotoPregunta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPreguntaResp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCorazon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCorazon3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCorazon2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picFotoPregunta;
        private System.Windows.Forms.Label lblNumPregunta;
        private System.Windows.Forms.Label lblTiempoRest;
        private System.Windows.Forms.PictureBox picPreguntaResp;
        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.PictureBox picCorazon1;
        private System.Windows.Forms.PictureBox picCorazon3;
        private System.Windows.Forms.PictureBox picCorazon2;
        private System.Windows.Forms.Label lblResp1;
        private System.Windows.Forms.Label lblPuntuacion;
        private System.Windows.Forms.Label lblResp4;
        private System.Windows.Forms.Label lblResp3;
        private System.Windows.Forms.Label lblResp2;
        private System.Windows.Forms.Timer relojPartida;
        private System.Windows.Forms.Label lblSigPregunta;
        private System.Windows.Forms.Timer relojEsperarSigPregunta;
    }
}