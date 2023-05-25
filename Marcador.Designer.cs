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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.boxEspeciales = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarEspecial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstPuntuaciones
            // 
            this.lstPuntuaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lstPuntuaciones.FormattingEnabled = true;
            this.lstPuntuaciones.ItemHeight = 16;
            this.lstPuntuaciones.Location = new System.Drawing.Point(12, 77);
            this.lstPuntuaciones.Name = "lstPuntuaciones";
            this.lstPuntuaciones.Size = new System.Drawing.Size(873, 532);
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
            this.boxCampos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxCampos.FormattingEnabled = true;
            this.boxCampos.Items.AddRange(new object[] {
            "Sin Seleccionar",
            "Puntuacion",
            "Aciertos",
            "Tirada",
            "Tiempo"});
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
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtrar por:";
            // 
            // boxAscDesc
            // 
            this.boxAscDesc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxAscDesc.FormattingEnabled = true;
            this.boxAscDesc.Items.AddRange(new object[] {
            "Sin Seleccionar",
            "Ascendiente",
            "Descendiente"});
            this.boxAscDesc.Location = new System.Drawing.Point(139, 50);
            this.boxAscDesc.Name = "boxAscDesc";
            this.boxAscDesc.Size = new System.Drawing.Size(121, 21);
            this.boxAscDesc.TabIndex = 3;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(393, 50);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // boxEspeciales
            // 
            this.boxEspeciales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxEspeciales.FormattingEnabled = true;
            this.boxEspeciales.Items.AddRange(new object[] {
            "Sin seleccionar",
            "Maxima Puntuacion",
            "Partidas Jugadas"});
            this.boxEspeciales.Location = new System.Drawing.Point(266, 50);
            this.boxEspeciales.Name = "boxEspeciales";
            this.boxEspeciales.Size = new System.Drawing.Size(121, 21);
            this.boxEspeciales.TabIndex = 5;
            this.boxEspeciales.SelectedIndexChanged += new System.EventHandler(this.boxEspeciales_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(263, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Filtros especiales:";
            // 
            // btnBuscarEspecial
            // 
            this.btnBuscarEspecial.Location = new System.Drawing.Point(474, 50);
            this.btnBuscarEspecial.Name = "btnBuscarEspecial";
            this.btnBuscarEspecial.Size = new System.Drawing.Size(124, 23);
            this.btnBuscarEspecial.TabIndex = 7;
            this.btnBuscarEspecial.Text = "Busqueda Especial";
            this.btnBuscarEspecial.UseVisualStyleBackColor = true;
            this.btnBuscarEspecial.Visible = false;
            this.btnBuscarEspecial.Click += new System.EventHandler(this.btnBuscarEspecial_Click);
            // 
            // Marcador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JuegoQuizzReto.Properties.Resources.Galaxy_repeating;
            this.ClientSize = new System.Drawing.Size(897, 626);
            this.Controls.Add(this.btnBuscarEspecial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxEspeciales);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.boxAscDesc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxCampos);
            this.Controls.Add(this.lstPuntuaciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Marcador";
            this.Text = "Marcador";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Marcador_FormClosing);
            this.Load += new System.EventHandler(this.Marcador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPuntuaciones;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.ComboBox boxCampos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox boxAscDesc;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox boxEspeciales;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarEspecial;
    }
}