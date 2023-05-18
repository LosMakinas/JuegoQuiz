namespace JuegoQuizzReto
{
    partial class Marcador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Marcador));
            this.lstPuntuaciones = new System.Windows.Forms.ListBox();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.boxCampos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boxAscDesc = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lstPuntuaciones
            // 
            this.lstPuntuaciones.FormattingEnabled = true;
            this.lstPuntuaciones.Location = new System.Drawing.Point(12, 77);
            this.lstPuntuaciones.Name = "lstPuntuaciones";
            this.lstPuntuaciones.Size = new System.Drawing.Size(433, 537);
            this.lstPuntuaciones.TabIndex = 0;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // boxCampos
            // 
            this.boxCampos.FormattingEnabled = true;
            this.boxCampos.Location = new System.Drawing.Point(12, 50);
            this.boxCampos.Name = "boxCampos";
            this.boxCampos.Size = new System.Drawing.Size(121, 21);
            this.boxCampos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtrar por:";
            // 
            // boxAscDesc
            // 
            this.boxAscDesc.FormattingEnabled = true;
            this.boxAscDesc.Location = new System.Drawing.Point(139, 50);
            this.boxAscDesc.Name = "boxAscDesc";
            this.boxAscDesc.Size = new System.Drawing.Size(121, 21);
            this.boxAscDesc.TabIndex = 3;
            // 
            // Marcador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JuegoQuizzReto.Properties.Resources.Galaxy_repeating;
            this.ClientSize = new System.Drawing.Size(457, 626);
            this.Controls.Add(this.boxAscDesc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxCampos);
            this.Controls.Add(this.lstPuntuaciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Marcador";
            this.Text = "Marcador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPuntuaciones;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.ComboBox boxCampos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox boxAscDesc;
    }
}