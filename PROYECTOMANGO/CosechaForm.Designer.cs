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
            this.pbImagenTemaCosecha = new System.Windows.Forms.PictureBox();
            this.lblTituloTemaCosecha = new System.Windows.Forms.Label();
            this.lblDescripcionTemaCosecha = new System.Windows.Forms.Label();
            this.pnlSBCosecha = new System.Windows.Forms.Panel();
            this.lblSeleccionTemaCosecha = new System.Windows.Forms.Label();
            this.cmbTemasCosecha = new System.Windows.Forms.ComboBox();
            this.lblEpCosecha = new System.Windows.Forms.Label();
            this.pnlCosecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenTemaCosecha)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolverCosecha
            // 
            this.btnVolverCosecha.Location = new System.Drawing.Point(12, 12);
            this.btnVolverCosecha.Name = "btnVolverCosecha";
            this.btnVolverCosecha.Size = new System.Drawing.Size(75, 23);
            this.btnVolverCosecha.TabIndex = 0;
            this.btnVolverCosecha.Text = "Volver";
            this.btnVolverCosecha.UseVisualStyleBackColor = true;
            this.btnVolverCosecha.Click += new System.EventHandler(this.btnVolverCosecha_Click);
            // 
            // pnlCosecha
            // 
            this.pnlCosecha.BackColor = System.Drawing.Color.OldLace;
            this.pnlCosecha.Controls.Add(this.cmbTemasCosecha);
            this.pnlCosecha.Controls.Add(this.lblSeleccionTemaCosecha);
            this.pnlCosecha.Controls.Add(this.pnlSBCosecha);
            this.pnlCosecha.Controls.Add(this.lblDescripcionTemaCosecha);
            this.pnlCosecha.Controls.Add(this.lblTituloTemaCosecha);
            this.pnlCosecha.Controls.Add(this.pbImagenTemaCosecha);
            this.pnlCosecha.Location = new System.Drawing.Point(141, 70);
            this.pnlCosecha.Name = "pnlCosecha";
            this.pnlCosecha.Size = new System.Drawing.Size(888, 512);
            this.pnlCosecha.TabIndex = 1;
            // 
            // pbImagenTemaCosecha
            // 
            this.pbImagenTemaCosecha.Location = new System.Drawing.Point(62, 105);
            this.pbImagenTemaCosecha.Name = "pbImagenTemaCosecha";
            this.pbImagenTemaCosecha.Size = new System.Drawing.Size(277, 274);
            this.pbImagenTemaCosecha.TabIndex = 0;
            this.pbImagenTemaCosecha.TabStop = false;
            // 
            // lblTituloTemaCosecha
            // 
            this.lblTituloTemaCosecha.Location = new System.Drawing.Point(422, 116);
            this.lblTituloTemaCosecha.Name = "lblTituloTemaCosecha";
            this.lblTituloTemaCosecha.Size = new System.Drawing.Size(366, 38);
            this.lblTituloTemaCosecha.TabIndex = 1;
            this.lblTituloTemaCosecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescripcionTemaCosecha
            // 
            this.lblDescripcionTemaCosecha.Location = new System.Drawing.Point(396, 177);
            this.lblDescripcionTemaCosecha.Name = "lblDescripcionTemaCosecha";
            this.lblDescripcionTemaCosecha.Size = new System.Drawing.Size(428, 202);
            this.lblDescripcionTemaCosecha.TabIndex = 2;
            this.lblDescripcionTemaCosecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSBCosecha
            // 
            this.pnlSBCosecha.BackColor = System.Drawing.Color.Honeydew;
            this.pnlSBCosecha.Location = new System.Drawing.Point(62, 413);
            this.pnlSBCosecha.Name = "pnlSBCosecha";
            this.pnlSBCosecha.Size = new System.Drawing.Size(777, 96);
            this.pnlSBCosecha.TabIndex = 3;
            // 
            // lblSeleccionTemaCosecha
            // 
            this.lblSeleccionTemaCosecha.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionTemaCosecha.Location = new System.Drawing.Point(88, 49);
            this.lblSeleccionTemaCosecha.Name = "lblSeleccionTemaCosecha";
            this.lblSeleccionTemaCosecha.Size = new System.Drawing.Size(369, 24);
            this.lblSeleccionTemaCosecha.TabIndex = 4;
            this.lblSeleccionTemaCosecha.Text = "Seleccione un tema para aprender:";
            this.lblSeleccionTemaCosecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbTemasCosecha
            // 
            this.cmbTemasCosecha.FormattingEnabled = true;
            this.cmbTemasCosecha.Location = new System.Drawing.Point(474, 49);
            this.cmbTemasCosecha.Name = "cmbTemasCosecha";
            this.cmbTemasCosecha.Size = new System.Drawing.Size(301, 24);
            this.cmbTemasCosecha.TabIndex = 5;
            // 
            // lblEpCosecha
            // 
            this.lblEpCosecha.AutoSize = true;
            this.lblEpCosecha.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.lblEpCosecha.Font = new System.Drawing.Font("Georgia", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEpCosecha.ForeColor = System.Drawing.Color.Ivory;
            this.lblEpCosecha.Location = new System.Drawing.Point(379, 38);
            this.lblEpCosecha.Name = "lblEpCosecha";
            this.lblEpCosecha.Size = new System.Drawing.Size(414, 51);
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
            this.Text = "CosechaForm";
            this.pnlCosecha.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenTemaCosecha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolverCosecha;
        private System.Windows.Forms.Panel pnlCosecha;
        private System.Windows.Forms.PictureBox pbImagenTemaCosecha;
        private System.Windows.Forms.Label lblTituloTemaCosecha;
        private System.Windows.Forms.Label lblDescripcionTemaCosecha;
        private System.Windows.Forms.Panel pnlSBCosecha;
        private System.Windows.Forms.Label lblSeleccionTemaCosecha;
        private System.Windows.Forms.ComboBox cmbTemasCosecha;
        private System.Windows.Forms.Label lblEpCosecha;
    }
}