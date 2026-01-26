namespace PROYECTOMANGO
{
    partial class CosechaForm
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
            this.btnVolverCosecha = new System.Windows.Forms.Button();
            this.pnlCosecha = new System.Windows.Forms.Panel();
            this.AbrirFormPnlCosecha = new System.Windows.Forms.Panel();
            this.cmbTemasCosecha = new System.Windows.Forms.ComboBox();
            this.lblSeleccionTemaCosecha = new System.Windows.Forms.Label();
            this.pbImagenTemaCosecha = new System.Windows.Forms.PictureBox();
            this.lblEpCosecha = new System.Windows.Forms.Label();
            this.pnlCosecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenTemaCosecha)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolverCosecha
            // 
            this.btnVolverCosecha.BackColor = System.Drawing.Color.Transparent;
            this.btnVolverCosecha.BackgroundImage = global::PROYECTOMANGO.Properties.Resources.Boton_de_Volver11;
            this.btnVolverCosecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolverCosecha.FlatAppearance.BorderSize = 0;
            this.btnVolverCosecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverCosecha.ForeColor = System.Drawing.Color.Transparent;
            this.btnVolverCosecha.Location = new System.Drawing.Point(12, 12);
            this.btnVolverCosecha.Name = "btnVolverCosecha";
            this.btnVolverCosecha.Size = new System.Drawing.Size(103, 75);
            this.btnVolverCosecha.TabIndex = 0;
            this.btnVolverCosecha.UseVisualStyleBackColor = false;
            this.btnVolverCosecha.Click += new System.EventHandler(this.btnVolverCosecha_Click);
            // 
            // pnlCosecha
            // 
            this.pnlCosecha.BackColor = System.Drawing.Color.OldLace;
            this.pnlCosecha.Controls.Add(this.AbrirFormPnlCosecha);
            this.pnlCosecha.Controls.Add(this.cmbTemasCosecha);
            this.pnlCosecha.Controls.Add(this.lblSeleccionTemaCosecha);
            this.pnlCosecha.Controls.Add(this.pbImagenTemaCosecha);
            this.pnlCosecha.Location = new System.Drawing.Point(141, 70);
            this.pnlCosecha.Name = "pnlCosecha";
            this.pnlCosecha.Size = new System.Drawing.Size(888, 512);
            this.pnlCosecha.TabIndex = 1;
            // 
            // AbrirFormPnlCosecha
            // 
            this.AbrirFormPnlCosecha.Location = new System.Drawing.Point(247, 83);
            this.AbrirFormPnlCosecha.Name = "AbrirFormPnlCosecha";
            this.AbrirFormPnlCosecha.Size = new System.Drawing.Size(620, 409);
            this.AbrirFormPnlCosecha.TabIndex = 6;
            // 
            // cmbTemasCosecha
            // 
            this.cmbTemasCosecha.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTemasCosecha.FormattingEnabled = true;
            this.cmbTemasCosecha.Items.AddRange(new object[] {
            "Índices de Madurez",
            "Técnica de Corte",
            "El Desleche",
            "Lavado y Tratamiento",
            "Clasificación y Empaque"});
            this.cmbTemasCosecha.Location = new System.Drawing.Point(486, 36);
            this.cmbTemasCosecha.Name = "cmbTemasCosecha";
            this.cmbTemasCosecha.Size = new System.Drawing.Size(301, 28);
            this.cmbTemasCosecha.TabIndex = 5;
            this.cmbTemasCosecha.SelectedIndexChanged += new System.EventHandler(this.cmbTemasCosecha_SelectedIndexChanged);
            // 
            // lblSeleccionTemaCosecha
            // 
            this.lblSeleccionTemaCosecha.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionTemaCosecha.Location = new System.Drawing.Point(87, 36);
            this.lblSeleccionTemaCosecha.Name = "lblSeleccionTemaCosecha";
            this.lblSeleccionTemaCosecha.Size = new System.Drawing.Size(382, 24);
            this.lblSeleccionTemaCosecha.TabIndex = 4;
            this.lblSeleccionTemaCosecha.Text = "Seleccione un tema para aprender:";
            this.lblSeleccionTemaCosecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbImagenTemaCosecha
            // 
            this.pbImagenTemaCosecha.Image = global::PROYECTOMANGO.Properties.Resources.SQ3;
            this.pbImagenTemaCosecha.Location = new System.Drawing.Point(3, 152);
            this.pbImagenTemaCosecha.Name = "pbImagenTemaCosecha";
            this.pbImagenTemaCosecha.Size = new System.Drawing.Size(238, 253);
            this.pbImagenTemaCosecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagenTemaCosecha.TabIndex = 0;
            this.pbImagenTemaCosecha.TabStop = false;
            // 
            // lblEpCosecha
            // 
            this.lblEpCosecha.AutoSize = true;
            this.lblEpCosecha.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.lblEpCosecha.Font = new System.Drawing.Font("Georgia", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEpCosecha.ForeColor = System.Drawing.Color.Ivory;
            this.lblEpCosecha.Location = new System.Drawing.Point(379, 38);
            this.lblEpCosecha.Name = "lblEpCosecha";
            this.lblEpCosecha.Size = new System.Drawing.Size(409, 49);
            this.lblEpCosecha.TabIndex = 6;
            this.lblEpCosecha.Text = "Etapa de Cosecha";
            // 
            // CosechaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROYECTOMANGO.Properties.Resources.fondsiem123;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1180, 630);
            this.Controls.Add(this.lblEpCosecha);
            this.Controls.Add(this.pnlCosecha);
            this.Controls.Add(this.btnVolverCosecha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CosechaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CosechaForm";
            this.pnlCosecha.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenTemaCosecha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolverCosecha;
        private System.Windows.Forms.Panel pnlCosecha;
        private System.Windows.Forms.Label lblSeleccionTemaCosecha;
        private System.Windows.Forms.ComboBox cmbTemasCosecha;
        private System.Windows.Forms.Label lblEpCosecha;
        private System.Windows.Forms.Panel AbrirFormPnlCosecha;
        private System.Windows.Forms.PictureBox pbImagenTemaCosecha;
    }
}