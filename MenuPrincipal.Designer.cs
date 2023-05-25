namespace JuegoQuizzReto {
    partial class MenuPrincipal {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnJugar = new System.Windows.Forms.Button();
            this.btnMarcador = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnReiniciarProgreso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(170, 513);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(250, 61);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            this.btnSalir.MouseEnter += new System.EventHandler(this.btnSalir_MouseEnter);
            this.btnSalir.MouseLeave += new System.EventHandler(this.btnSalir_MouseLeave);
            // 
            // btnJugar
            // 
            this.btnJugar.BackColor = System.Drawing.Color.Transparent;
            this.btnJugar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnJugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnJugar.ForeColor = System.Drawing.Color.White;
            this.btnJugar.Location = new System.Drawing.Point(170, 248);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(250, 95);
            this.btnJugar.TabIndex = 2;
            this.btnJugar.Text = "Jugar Partida";
            this.btnJugar.UseVisualStyleBackColor = false;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            this.btnJugar.MouseEnter += new System.EventHandler(this.btnJugar_MouseEnter);
            this.btnJugar.MouseLeave += new System.EventHandler(this.btnJugar_MouseLeave);
            // 
            // btnMarcador
            // 
            this.btnMarcador.BackColor = System.Drawing.Color.Transparent;
            this.btnMarcador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMarcador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarcador.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnMarcador.ForeColor = System.Drawing.Color.White;
            this.btnMarcador.Location = new System.Drawing.Point(170, 374);
            this.btnMarcador.Name = "btnMarcador";
            this.btnMarcador.Size = new System.Drawing.Size(250, 95);
            this.btnMarcador.TabIndex = 2;
            this.btnMarcador.Text = "Marcador";
            this.btnMarcador.UseVisualStyleBackColor = false;
            this.btnMarcador.Click += new System.EventHandler(this.btnMarcador_Click);
            this.btnMarcador.MouseEnter += new System.EventHandler(this.btnMarcador_MouseEnter);
            this.btnMarcador.MouseLeave += new System.EventHandler(this.btnMarcador_MouseLeave);
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.BackgroundImage = global::JuegoQuizzReto.Properties.Resources.logo_definitivo2;
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLogo.Location = new System.Drawing.Point(170, 5);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(250, 237);
            this.picLogo.TabIndex = 3;
            this.picLogo.TabStop = false;
            // 
            // btnReiniciarProgreso
            // 
            this.btnReiniciarProgreso.BackColor = System.Drawing.Color.Transparent;
            this.btnReiniciarProgreso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReiniciarProgreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReiniciarProgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnReiniciarProgreso.ForeColor = System.Drawing.Color.White;
            this.btnReiniciarProgreso.Location = new System.Drawing.Point(12, 12);
            this.btnReiniciarProgreso.Name = "btnReiniciarProgreso";
            this.btnReiniciarProgreso.Size = new System.Drawing.Size(133, 46);
            this.btnReiniciarProgreso.TabIndex = 4;
            this.btnReiniciarProgreso.Text = "Reiniciar Progreso";
            this.btnReiniciarProgreso.UseVisualStyleBackColor = false;
            this.btnReiniciarProgreso.Click += new System.EventHandler(this.btnReiniciarProgreso_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JuegoQuizzReto.Properties.Resources.Galaxy_repeating;
            this.ClientSize = new System.Drawing.Size(624, 600);
            this.Controls.Add(this.btnReiniciarProgreso);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.btnMarcador);
            this.Controls.Add(this.btnSalir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuPrincipal_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Button btnMarcador;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnReiniciarProgreso;
    }
}