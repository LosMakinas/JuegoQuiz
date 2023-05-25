namespace JuegoQuizzReto
{
    partial class Finalpartida
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Finalpartida));
            this.lblPuntuacion = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.relojPunts = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblPuntuacion
            // 
            this.lblPuntuacion.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntuacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntuacion.ForeColor = System.Drawing.Color.White;
            this.lblPuntuacion.Location = new System.Drawing.Point(126, 197);
            this.lblPuntuacion.Name = "lblPuntuacion";
            this.lblPuntuacion.Size = new System.Drawing.Size(548, 56);
            this.lblPuntuacion.TabIndex = 4;
            this.lblPuntuacion.Text = "0 Puntos";
            this.lblPuntuacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPuntuacion.Click += new System.EventHandler(this.lblPuntuacion_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(268, 343);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(250, 95);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Visible = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            this.btnSalir.MouseEnter += new System.EventHandler(this.btnSalir_MouseEnter);
            this.btnSalir.MouseLeave += new System.EventHandler(this.btnSalir_MouseLeave);
            // 
            // relojPunts
            // 
            this.relojPunts.Interval = 1;
            this.relojPunts.Tick += new System.EventHandler(this.relojPunts_Tick);
            // 
            // Finalpartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JuegoQuizzReto.Properties.Resources.Galaxy_repeating;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblPuntuacion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Finalpartida";
            this.Text = "Final de la partida";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Finalpartida_FormClosing);
            this.Click += new System.EventHandler(this.Finalpartida_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPuntuacion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Timer relojPunts;
    }
}