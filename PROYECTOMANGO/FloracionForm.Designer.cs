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
            this.btnVolverFloracion.Location = new System.Drawing.Point(9, 10);
            this.btnVolverFloracion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVolverFloracion.Name = "btnVolverFloracion";
            this.btnVolverFloracion.Size = new System.Drawing.Size(77, 61);
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
            this.pnlInfFloracion.Location = new System.Drawing.Point(106, 57);
            this.pnlInfFloracion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlInfFloracion.Name = "pnlInfFloracion";
            this.pnlInfFloracion.Size = new System.Drawing.Size(666, 416);
            this.pnlInfFloracion.TabIndex = 1;
            // 
            // AbrirFormPnlFloracion
            // 
            this.AbrirFormPnlFloracion.Location = new System.Drawing.Point(185, 67);
            this.AbrirFormPnlFloracion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AbrirFormPnlFloracion.Name = "AbrirFormPnlFloracion";
            this.AbrirFormPnlFloracion.Size = new System.Drawing.Size(465, 332);
            this.AbrirFormPnlFloracion.TabIndex = 6;
            // 
            // lblSeleccionTemaFloracion
            // 
            this.lblSeleccionTemaFloracion.AutoSize = true;
            this.lblSeleccionTemaFloracion.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionTemaFloracion.Location = new System.Drawing.Point(65, 29);
            this.lblSeleccionTemaFloracion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSeleccionTemaFloracion.Name = "lblSeleccionTemaFloracion";
            this.lblSeleccionTemaFloracion.Size = new System.Drawing.Size(292, 19);
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
            this.cmbTemasFloracion.Location = new System.Drawing.Point(356, 32);
            this.cmbTemasFloracion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbTemasFloracion.Name = "cmbTemasFloracion";
            this.cmbTemasFloracion.Size = new System.Drawing.Size(227, 25);
            this.cmbTemasFloracion.TabIndex = 4;
            this.cmbTemasFloracion.SelectedIndexChanged += new System.EventHandler(this.cmbTemasFloracion_SelectedIndexChanged);
            // 
            // pbTemaFloracion
            // 
            this.pbTemaFloracion.Location = new System.Drawing.Point(31, 129);
            this.pbTemaFloracion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbTemaFloracion.Name = "pbTemaFloracion";
            this.pbTemaFloracion.Size = new System.Drawing.Size(134, 180);
            this.pbTemaFloracion.TabIndex = 0;
            this.pbTemaFloracion.TabStop = false;
            // 
            // lblEtpFloracion
            // 
            this.lblEtpFloracion.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.lblEtpFloracion.Font = new System.Drawing.Font("Georgia", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtpFloracion.ForeColor = System.Drawing.Color.Ivory;
            this.lblEtpFloracion.Location = new System.Drawing.Point(284, 31);
            this.lblEtpFloracion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEtpFloracion.Name = "lblEtpFloracion";
            this.lblEtpFloracion.Size = new System.Drawing.Size(344, 42);
            this.lblEtpFloracion.TabIndex = 4;
            this.lblEtpFloracion.Text = "Etapa de Floración";
            this.lblEtpFloracion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FloracionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROYECTOMANGO.Properties.Resources.fondsiem123;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(885, 512);
            this.Controls.Add(this.lblEtpFloracion);
            this.Controls.Add(this.pnlInfFloracion);
            this.Controls.Add(this.btnVolverFloracion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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