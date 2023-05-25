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
            this.lblExplicacionRespCorrecta = new System.Windows.Forms.Label();
            this.relojPreguntasCor = new System.Windows.Forms.Timer(this.components);
            this.picCom50 = new System.Windows.Forms.PictureBox();
            this.picComSaltar = new System.Windows.Forms.PictureBox();
            this.picExplCom = new System.Windows.Forms.PictureBox();
            this.lbl50 = new System.Windows.Forms.Label();
            this.lblSiguiente = new System.Windows.Forms.Label();
            this.lblPista = new System.Windows.Forms.Label();
            this.picComodin = new System.Windows.Forms.PictureBox();
            this.lblComodin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoPregunta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPreguntaResp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCorazon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCorazon3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCorazon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCom50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComSaltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExplCom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComodin)).BeginInit();
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
            this.picFotoPregunta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
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
            this.lblResp1.Click += new System.EventHandler(this.lblResp1_Click_1);
            // 
            // lblPuntuacion
            // 
            this.lblPuntuacion.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntuacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.lblResp4.Click += new System.EventHandler(this.lblResp1_Click_1);
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
            this.lblResp3.Click += new System.EventHandler(this.lblResp1_Click_1);
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
            this.lblResp2.Click += new System.EventHandler(this.lblResp1_Click_1);
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
            this.lblSigPregunta.Location = new System.Drawing.Point(472, 518);
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
            // lblExplicacionRespCorrecta
            // 
            this.lblExplicacionRespCorrecta.BackColor = System.Drawing.Color.Transparent;
            this.lblExplicacionRespCorrecta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplicacionRespCorrecta.ForeColor = System.Drawing.Color.White;
            this.lblExplicacionRespCorrecta.Location = new System.Drawing.Point(918, 84);
            this.lblExplicacionRespCorrecta.Name = "lblExplicacionRespCorrecta";
            this.lblExplicacionRespCorrecta.Size = new System.Drawing.Size(365, 362);
            this.lblExplicacionRespCorrecta.TabIndex = 11;
            this.lblExplicacionRespCorrecta.Text = "Explicación:";
            // 
            // relojPreguntasCor
            // 
            this.relojPreguntasCor.Interval = 1000;
            this.relojPreguntasCor.Tick += new System.EventHandler(this.relojPreguntasCor_Tick);
            // 
            // picCom50
            // 
            this.picCom50.BackColor = System.Drawing.Color.Transparent;
            this.picCom50.Image = global::JuegoQuizzReto.Properties.Resources._50_final;
            this.picCom50.Location = new System.Drawing.Point(7, 176);
            this.picCom50.Name = "picCom50";
            this.picCom50.Size = new System.Drawing.Size(86, 57);
            this.picCom50.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCom50.TabIndex = 12;
            this.picCom50.TabStop = false;
            this.picCom50.Visible = false;
            this.picCom50.Click += new System.EventHandler(this.picCom50_Click);
            // 
            // picComSaltar
            // 
            this.picComSaltar.BackColor = System.Drawing.Color.Transparent;
            this.picComSaltar.Image = global::JuegoQuizzReto.Properties.Resources.flecha_como;
            this.picComSaltar.Location = new System.Drawing.Point(116, 176);
            this.picComSaltar.Name = "picComSaltar";
            this.picComSaltar.Size = new System.Drawing.Size(86, 57);
            this.picComSaltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picComSaltar.TabIndex = 13;
            this.picComSaltar.TabStop = false;
            this.picComSaltar.Visible = false;
            this.picComSaltar.Click += new System.EventHandler(this.picComSaltar_Click);
            // 
            // picExplCom
            // 
            this.picExplCom.BackColor = System.Drawing.Color.Transparent;
            this.picExplCom.Image = global::JuegoQuizzReto.Properties.Resources.expl_como;
            this.picExplCom.Location = new System.Drawing.Point(7, 239);
            this.picExplCom.Name = "picExplCom";
            this.picExplCom.Size = new System.Drawing.Size(86, 57);
            this.picExplCom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExplCom.TabIndex = 14;
            this.picExplCom.TabStop = false;
            this.picExplCom.Visible = false;
            this.picExplCom.Click += new System.EventHandler(this.picExplCom_Click);
            // 
            // lbl50
            // 
            this.lbl50.AutoSize = true;
            this.lbl50.BackColor = System.Drawing.Color.Transparent;
            this.lbl50.ForeColor = System.Drawing.Color.White;
            this.lbl50.Location = new System.Drawing.Point(96, 176);
            this.lbl50.Name = "lbl50";
            this.lbl50.Size = new System.Drawing.Size(18, 13);
            this.lbl50.TabIndex = 15;
            this.lbl50.Text = "x0";
            this.lbl50.Visible = false;
            // 
            // lblSiguiente
            // 
            this.lblSiguiente.AutoSize = true;
            this.lblSiguiente.BackColor = System.Drawing.Color.Transparent;
            this.lblSiguiente.ForeColor = System.Drawing.Color.White;
            this.lblSiguiente.Location = new System.Drawing.Point(208, 176);
            this.lblSiguiente.Name = "lblSiguiente";
            this.lblSiguiente.Size = new System.Drawing.Size(18, 13);
            this.lblSiguiente.TabIndex = 16;
            this.lblSiguiente.Text = "x0";
            this.lblSiguiente.Visible = false;
            // 
            // lblPista
            // 
            this.lblPista.AutoSize = true;
            this.lblPista.BackColor = System.Drawing.Color.Transparent;
            this.lblPista.ForeColor = System.Drawing.Color.White;
            this.lblPista.Location = new System.Drawing.Point(96, 239);
            this.lblPista.Name = "lblPista";
            this.lblPista.Size = new System.Drawing.Size(18, 13);
            this.lblPista.TabIndex = 17;
            this.lblPista.Text = "x0";
            this.lblPista.Visible = false;
            // 
            // picComodin
            // 
            this.picComodin.BackColor = System.Drawing.Color.Transparent;
            this.picComodin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picComodin.ImageLocation = "";
            this.picComodin.Location = new System.Drawing.Point(116, 249);
            this.picComodin.Name = "picComodin";
            this.picComodin.Size = new System.Drawing.Size(247, 115);
            this.picComodin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picComodin.TabIndex = 18;
            this.picComodin.TabStop = false;
            // 
            // lblComodin
            // 
            this.lblComodin.BackColor = System.Drawing.Color.Transparent;
            this.lblComodin.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComodin.ForeColor = System.Drawing.Color.White;
            this.lblComodin.Location = new System.Drawing.Point(117, 367);
            this.lblComodin.Name = "lblComodin";
            this.lblComodin.Size = new System.Drawing.Size(246, 56);
            this.lblComodin.TabIndex = 19;
            this.lblComodin.Text = "lblComodin";
            this.lblComodin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblComodin.Visible = false;
            // 
            // JugarPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JuegoQuizzReto.Properties.Resources.Galaxy_repeating;
            this.ClientSize = new System.Drawing.Size(1284, 811);
            this.Controls.Add(this.lblComodin);
            this.Controls.Add(this.picComodin);
            this.Controls.Add(this.lblPista);
            this.Controls.Add(this.lblSiguiente);
            this.Controls.Add(this.lbl50);
            this.Controls.Add(this.picExplCom);
            this.Controls.Add(this.picComSaltar);
            this.Controls.Add(this.picCom50);
            this.Controls.Add(this.lblExplicacionRespCorrecta);
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
            this.MaximizeBox = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.picCom50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComSaltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExplCom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComodin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Label lblExplicacionRespCorrecta;
        private Timer relojPreguntasCor;
        private PictureBox picCom50;
        private PictureBox picComSaltar;
        private PictureBox picExplCom;
        private Label lbl50;
        private Label lblSiguiente;
        private Label lblPista;
        private PictureBox picComodin;
        private Label lblComodin;
    }
}