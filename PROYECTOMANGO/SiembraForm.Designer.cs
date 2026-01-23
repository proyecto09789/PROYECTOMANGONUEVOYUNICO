namespace PROYECTOMANGO
{
    partial class SiembraForm
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
            this.btnVolverSiembra = new System.Windows.Forms.Button();
            this.pnlSiembra = new System.Windows.Forms.Panel();
            this.lblTituloTema = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.pbImagenTema = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSelecciontema = new System.Windows.Forms.Label();
            this.cmbTemas = new System.Windows.Forms.ComboBox();
            this.lblEtpSiembra = new System.Windows.Forms.Label();
            this.pnlSiembra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenTema)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolverSiembra
            // 
            this.btnVolverSiembra.Location = new System.Drawing.Point(12, 12);
            this.btnVolverSiembra.Name = "btnVolverSiembra";
            this.btnVolverSiembra.Size = new System.Drawing.Size(95, 31);
            this.btnVolverSiembra.TabIndex = 0;
            this.btnVolverSiembra.Text = "REGRESAR";
            this.btnVolverSiembra.UseVisualStyleBackColor = true;
            this.btnVolverSiembra.Click += new System.EventHandler(this.btnVolverSiembra_Click);
            // 
            // pnlSiembra
            // 
            this.pnlSiembra.BackColor = System.Drawing.Color.OldLace;
            this.pnlSiembra.Controls.Add(this.lblTituloTema);
            this.pnlSiembra.Controls.Add(this.lblDescripcion);
            this.pnlSiembra.Controls.Add(this.pbImagenTema);
            this.pnlSiembra.Controls.Add(this.panel1);
            this.pnlSiembra.Controls.Add(this.lblSelecciontema);
            this.pnlSiembra.Controls.Add(this.cmbTemas);
            this.pnlSiembra.Location = new System.Drawing.Point(141, 70);
            this.pnlSiembra.Name = "pnlSiembra";
            this.pnlSiembra.Size = new System.Drawing.Size(888, 512);
            this.pnlSiembra.TabIndex = 1;
            // 
            // lblTituloTema
            // 
            this.lblTituloTema.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloTema.Location = new System.Drawing.Point(422, 116);
            this.lblTituloTema.Name = "lblTituloTema";
            this.lblTituloTema.Size = new System.Drawing.Size(366, 38);
            this.lblTituloTema.TabIndex = 5;
            this.lblTituloTema.Click += new System.EventHandler(this.lblTituloTema_Click);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(396, 177);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(428, 202);
            this.lblDescripcion.TabIndex = 4;
            // 
            // pbImagenTema
            // 
            this.pbImagenTema.Location = new System.Drawing.Point(62, 105);
            this.pbImagenTema.Name = "pbImagenTema";
            this.pbImagenTema.Size = new System.Drawing.Size(277, 274);
            this.pbImagenTema.TabIndex = 3;
            this.pbImagenTema.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Location = new System.Drawing.Point(62, 413);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 96);
            this.panel1.TabIndex = 2;
            // 
            // lblSelecciontema
            // 
            this.lblSelecciontema.AutoSize = true;
            this.lblSelecciontema.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecciontema.Location = new System.Drawing.Point(88, 49);
            this.lblSelecciontema.Name = "lblSelecciontema";
            this.lblSelecciontema.Size = new System.Drawing.Size(370, 24);
            this.lblSelecciontema.TabIndex = 1;
            this.lblSelecciontema.Text = "Selecciona un tema para aprender:";
            // 
            // cmbTemas
            // 
            this.cmbTemas.FormattingEnabled = true;
            this.cmbTemas.Items.AddRange(new object[] {
            "Selección del Terreno",
            "Preparación de la Semilla",
            "El Ahoyado",
            "El Transplante",
            "Riego Inicial "});
            this.cmbTemas.Location = new System.Drawing.Point(474, 49);
            this.cmbTemas.Name = "cmbTemas";
            this.cmbTemas.Size = new System.Drawing.Size(301, 24);
            this.cmbTemas.TabIndex = 0;
            this.cmbTemas.SelectedIndexChanged += new System.EventHandler(this.cmbTemas_SelectedIndexChanged);
            // 
            // lblEtpSiembra
            // 
            this.lblEtpSiembra.AutoSize = true;
            this.lblEtpSiembra.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.lblEtpSiembra.Font = new System.Drawing.Font("Georgia", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtpSiembra.ForeColor = System.Drawing.Color.Ivory;
            this.lblEtpSiembra.Location = new System.Drawing.Point(376, 33);
            this.lblEtpSiembra.Name = "lblEtpSiembra";
            this.lblEtpSiembra.Size = new System.Drawing.Size(414, 49);
            this.lblEtpSiembra.TabIndex = 0;
            this.lblEtpSiembra.Text = "Etapa de Siembra";
            // 
            // SiembraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROYECTOMANGO.Properties.Resources.fondsiem123;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1160, 630);
            this.Controls.Add(this.lblEtpSiembra);
            this.Controls.Add(this.pnlSiembra);
            this.Controls.Add(this.btnVolverSiembra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SiembraForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SiembraForm";
            this.pnlSiembra.ResumeLayout(false);
            this.pnlSiembra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenTema)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolverSiembra;
        private System.Windows.Forms.Panel pnlSiembra;
        private System.Windows.Forms.Label lblEtpSiembra;
        private System.Windows.Forms.ComboBox cmbTemas;
        private System.Windows.Forms.Label lblSelecciontema;
        private System.Windows.Forms.PictureBox pbImagenTema;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblTituloTema;
    }
}