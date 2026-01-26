namespace PROYECTOMANGO
{
    partial class FloracionForm
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
            this.btnVolverFloracion = new System.Windows.Forms.Button();
            this.pnlInfFloracion = new System.Windows.Forms.Panel();
            this.AbrirFormPnlFloracion = new System.Windows.Forms.Panel();
            this.lblSeleccionTemaFloracion = new System.Windows.Forms.Label();
            this.cmbTemasFloracion = new System.Windows.Forms.ComboBox();
            this.pbTemaFloracion = new System.Windows.Forms.PictureBox();
            this.lblEtpFloracion = new System.Windows.Forms.Label();
            this.pnlInfFloracion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTemaFloracion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolverFloracion
            // 
            this.btnVolverFloracion.BackColor = System.Drawing.Color.Transparent;
            this.btnVolverFloracion.BackgroundImage = global::PROYECTOMANGO.Properties.Resources.Boton_de_Volver11;
            this.btnVolverFloracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolverFloracion.FlatAppearance.BorderSize = 0;
            this.btnVolverFloracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverFloracion.Location = new System.Drawing.Point(12, 12);
            this.btnVolverFloracion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVolverFloracion.Name = "btnVolverFloracion";
            this.btnVolverFloracion.Size = new System.Drawing.Size(103, 75);
            this.btnVolverFloracion.TabIndex = 0;
            this.btnVolverFloracion.UseVisualStyleBackColor = false;
            this.btnVolverFloracion.Click += new System.EventHandler(this.btnVolverFloracion_Click);
            // 
            // pnlInfFloracion
            // 
            this.pnlInfFloracion.BackColor = System.Drawing.Color.OldLace;
            this.pnlInfFloracion.Controls.Add(this.AbrirFormPnlFloracion);
            this.pnlInfFloracion.Controls.Add(this.lblSeleccionTemaFloracion);
            this.pnlInfFloracion.Controls.Add(this.cmbTemasFloracion);
            this.pnlInfFloracion.Controls.Add(this.pbTemaFloracion);
            this.pnlInfFloracion.Location = new System.Drawing.Point(141, 70);
            this.pnlInfFloracion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlInfFloracion.Name = "pnlInfFloracion";
            this.pnlInfFloracion.Size = new System.Drawing.Size(888, 512);
            this.pnlInfFloracion.TabIndex = 1;
            // 
            // AbrirFormPnlFloracion
            // 
            this.AbrirFormPnlFloracion.Location = new System.Drawing.Point(247, 82);
            this.AbrirFormPnlFloracion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AbrirFormPnlFloracion.Name = "AbrirFormPnlFloracion";
            this.AbrirFormPnlFloracion.Size = new System.Drawing.Size(620, 409);
            this.AbrirFormPnlFloracion.TabIndex = 6;
            // 
            // lblSeleccionTemaFloracion
            // 
            this.lblSeleccionTemaFloracion.AutoSize = true;
            this.lblSeleccionTemaFloracion.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionTemaFloracion.Location = new System.Drawing.Point(87, 36);
            this.lblSeleccionTemaFloracion.Name = "lblSeleccionTemaFloracion";
            this.lblSeleccionTemaFloracion.Size = new System.Drawing.Size(369, 24);
            this.lblSeleccionTemaFloracion.TabIndex = 5;
            this.lblSeleccionTemaFloracion.Text = "Seleccione un tema para aprender:";
            // 
            // cmbTemasFloracion
            // 
            this.cmbTemasFloracion.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTemasFloracion.FormattingEnabled = true;
            this.cmbTemasFloracion.Items.AddRange(new object[] {
            "Inducción Floral",
            "Polinización Natural",
            "Enfermedades (Antracnosis)",
            "El Cuajado del Fruto",
            "Riego Controlado"});
            this.cmbTemasFloracion.Location = new System.Drawing.Point(475, 39);
            this.cmbTemasFloracion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTemasFloracion.Name = "cmbTemasFloracion";
            this.cmbTemasFloracion.Size = new System.Drawing.Size(301, 28);
            this.cmbTemasFloracion.TabIndex = 4;
            this.cmbTemasFloracion.SelectedIndexChanged += new System.EventHandler(this.cmbTemasFloracion_SelectedIndexChanged);
            // 
            // pbTemaFloracion
            // 
            this.pbTemaFloracion.Image = global::PROYECTOMANGO.Properties.Resources.SQ2;
            this.pbTemaFloracion.Location = new System.Drawing.Point(3, 152);
            this.pbTemaFloracion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbTemaFloracion.Name = "pbTemaFloracion";
            this.pbTemaFloracion.Size = new System.Drawing.Size(238, 253);
            this.pbTemaFloracion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTemaFloracion.TabIndex = 0;
            this.pbTemaFloracion.TabStop = false;
            // 
            // lblEtpFloracion
            // 
            this.lblEtpFloracion.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.lblEtpFloracion.Font = new System.Drawing.Font("Georgia", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtpFloracion.ForeColor = System.Drawing.Color.Ivory;
            this.lblEtpFloracion.Location = new System.Drawing.Point(379, 38);
            this.lblEtpFloracion.Name = "lblEtpFloracion";
            this.lblEtpFloracion.Size = new System.Drawing.Size(459, 52);
            this.lblEtpFloracion.TabIndex = 4;
            this.lblEtpFloracion.Text = "Etapa de Floración";
            this.lblEtpFloracion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FloracionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROYECTOMANGO.Properties.Resources.fondsiem123;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1180, 630);
            this.Controls.Add(this.lblEtpFloracion);
            this.Controls.Add(this.pnlInfFloracion);
            this.Controls.Add(this.btnVolverFloracion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FloracionForm";
            this.Text = "FloracionForm";
            this.pnlInfFloracion.ResumeLayout(false);
            this.pnlInfFloracion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTemaFloracion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolverFloracion;
        private System.Windows.Forms.Panel pnlInfFloracion;
        private System.Windows.Forms.PictureBox pbTemaFloracion;
        private System.Windows.Forms.Label lblEtpFloracion;
        private System.Windows.Forms.ComboBox cmbTemasFloracion;
        private System.Windows.Forms.Label lblSeleccionTemaFloracion;
        private System.Windows.Forms.Panel AbrirFormPnlFloracion;
    }
}