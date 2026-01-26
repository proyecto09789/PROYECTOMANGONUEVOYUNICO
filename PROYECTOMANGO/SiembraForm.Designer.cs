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
            this.AbrirFormPnlSiembra = new System.Windows.Forms.Panel();
            this.pbImagenTema = new System.Windows.Forms.PictureBox();
            this.lblSelecciontema = new System.Windows.Forms.Label();
            this.cmbTemas = new System.Windows.Forms.ComboBox();
            this.lblEtpSiembra = new System.Windows.Forms.Label();
            this.pnlSiembra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenTema)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolverSiembra
            // 
            this.btnVolverSiembra.BackColor = System.Drawing.Color.Transparent;
            this.btnVolverSiembra.BackgroundImage = global::PROYECTOMANGO.Properties.Resources.Boton_de_Volver11;
            this.btnVolverSiembra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolverSiembra.FlatAppearance.BorderSize = 0;
            this.btnVolverSiembra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverSiembra.ForeColor = System.Drawing.Color.Transparent;
            this.btnVolverSiembra.Location = new System.Drawing.Point(12, 12);
            this.btnVolverSiembra.Name = "btnVolverSiembra";
            this.btnVolverSiembra.Size = new System.Drawing.Size(103, 75);
            this.btnVolverSiembra.TabIndex = 0;
            this.btnVolverSiembra.UseVisualStyleBackColor = false;
            this.btnVolverSiembra.Click += new System.EventHandler(this.btnVolverSiembra_Click);
            // 
            // pnlSiembra
            // 
            this.pnlSiembra.BackColor = System.Drawing.Color.OldLace;
            this.pnlSiembra.Controls.Add(this.AbrirFormPnlSiembra);
            this.pnlSiembra.Controls.Add(this.pbImagenTema);
            this.pnlSiembra.Controls.Add(this.lblSelecciontema);
            this.pnlSiembra.Controls.Add(this.cmbTemas);
            this.pnlSiembra.Location = new System.Drawing.Point(141, 70);
            this.pnlSiembra.Name = "pnlSiembra";
            this.pnlSiembra.Size = new System.Drawing.Size(888, 512);
            this.pnlSiembra.TabIndex = 1;
            // 
            // AbrirFormPnlSiembra
            // 
            this.AbrirFormPnlSiembra.Location = new System.Drawing.Point(247, 83);
            this.AbrirFormPnlSiembra.Name = "AbrirFormPnlSiembra";
            this.AbrirFormPnlSiembra.Size = new System.Drawing.Size(620, 409);
            this.AbrirFormPnlSiembra.TabIndex = 4;
            // 
            // pbImagenTema
            // 
            this.pbImagenTema.Location = new System.Drawing.Point(41, 159);
            this.pbImagenTema.Name = "pbImagenTema";
            this.pbImagenTema.Size = new System.Drawing.Size(178, 221);
            this.pbImagenTema.TabIndex = 3;
            this.pbImagenTema.TabStop = false;
            // 
            // lblSelecciontema
            // 
            this.lblSelecciontema.AutoSize = true;
            this.lblSelecciontema.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecciontema.Location = new System.Drawing.Point(87, 36);
            this.lblSelecciontema.Name = "lblSelecciontema";
            this.lblSelecciontema.Size = new System.Drawing.Size(370, 24);
            this.lblSelecciontema.TabIndex = 1;
            this.lblSelecciontema.Text = "Selecciona un tema para aprender:";
            // 
            // cmbTemas
            // 
            this.cmbTemas.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTemas.FormattingEnabled = true;
            this.cmbTemas.Items.AddRange(new object[] {
            "Selección del Terreno",
            "Preparación de la Semilla",
            "El Ahoyado",
            "El Trasplante",
            "Riego Inicial"});
            this.cmbTemas.Location = new System.Drawing.Point(475, 36);
            this.cmbTemas.Name = "cmbTemas";
            this.cmbTemas.Size = new System.Drawing.Size(301, 28);
            this.cmbTemas.TabIndex = 0;
            this.cmbTemas.SelectedIndexChanged += new System.EventHandler(this.cmbTemas_SelectedIndexChanged);
            // 
            // lblEtpSiembra
            // 
            this.lblEtpSiembra.AutoSize = true;
            this.lblEtpSiembra.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.lblEtpSiembra.Font = new System.Drawing.Font("Georgia", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtpSiembra.ForeColor = System.Drawing.Color.Ivory;
            this.lblEtpSiembra.Location = new System.Drawing.Point(379, 38);
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
        private System.Windows.Forms.Panel AbrirFormPnlSiembra;
    }
}