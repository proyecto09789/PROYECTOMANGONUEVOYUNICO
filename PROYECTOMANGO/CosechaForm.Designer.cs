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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CosechaForm));
            this.btnVolverCosecha = new System.Windows.Forms.Button();
            this.pnlCosecha = new System.Windows.Forms.Panel();
            this.AbrirFormPnlCosecha = new System.Windows.Forms.Panel();
            this.cmbTemasCosecha = new System.Windows.Forms.ComboBox();
            this.lblSeleccionTemaCosecha = new System.Windows.Forms.Label();
            this.pbImagenTemaCosecha = new System.Windows.Forms.PictureBox();
            this.lblEpCosecha = new System.Windows.Forms.Label();
            this.btnRefCosecha = new System.Windows.Forms.Button();
            this.pnlRefCosecha = new System.Windows.Forms.Panel();
            this.lblTitRefCosech = new System.Windows.Forms.Label();
            this.lblRefCosech1 = new System.Windows.Forms.Label();
            this.lblRefCosech2 = new System.Windows.Forms.Label();
            this.linklblRefCosech1 = new System.Windows.Forms.LinkLabel();
            this.btnRefPnlCosech = new System.Windows.Forms.Button();
            this.pnlCosecha.SuspendLayout();
            this.AbrirFormPnlCosecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenTemaCosecha)).BeginInit();
            this.pnlRefCosecha.SuspendLayout();
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
            this.pnlCosecha.BackColor = System.Drawing.Color.Transparent;
            this.pnlCosecha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlCosecha.BackgroundImage")));
            this.pnlCosecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCosecha.Controls.Add(this.btnRefCosecha);
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
            this.AbrirFormPnlCosecha.Controls.Add(this.pnlRefCosecha);
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
            // btnRefCosecha
            // 
            this.btnRefCosecha.BackgroundImage = global::PROYECTOMANGO.Properties.Resources.BotonRef;
            this.btnRefCosecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefCosecha.FlatAppearance.BorderSize = 0;
            this.btnRefCosecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefCosecha.Location = new System.Drawing.Point(793, 3);
            this.btnRefCosecha.Name = "btnRefCosecha";
            this.btnRefCosecha.Size = new System.Drawing.Size(92, 74);
            this.btnRefCosecha.TabIndex = 7;
            this.btnRefCosecha.UseVisualStyleBackColor = true;
            this.btnRefCosecha.Click += new System.EventHandler(this.btnRefCosecha_Click);
            // 
            // pnlRefCosecha
            // 
            this.pnlRefCosecha.BackColor = System.Drawing.Color.White;
            this.pnlRefCosecha.Controls.Add(this.btnRefPnlCosech);
            this.pnlRefCosecha.Controls.Add(this.linklblRefCosech1);
            this.pnlRefCosecha.Controls.Add(this.lblRefCosech2);
            this.pnlRefCosecha.Controls.Add(this.lblRefCosech1);
            this.pnlRefCosecha.Controls.Add(this.lblTitRefCosech);
            this.pnlRefCosecha.Location = new System.Drawing.Point(0, 0);
            this.pnlRefCosecha.Name = "pnlRefCosecha";
            this.pnlRefCosecha.Size = new System.Drawing.Size(417, 350);
            this.pnlRefCosecha.TabIndex = 0;
            this.pnlRefCosecha.Visible = false;
            // 
            // lblTitRefCosech
            // 
            this.lblTitRefCosech.AutoSize = true;
            this.lblTitRefCosech.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitRefCosech.Location = new System.Drawing.Point(113, 11);
            this.lblTitRefCosech.Name = "lblTitRefCosech";
            this.lblTitRefCosech.Size = new System.Drawing.Size(185, 32);
            this.lblTitRefCosech.TabIndex = 0;
            this.lblTitRefCosech.Text = "Referencias";
            // 
            // lblRefCosech1
            // 
            this.lblRefCosech1.AutoSize = true;
            this.lblRefCosech1.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefCosech1.Location = new System.Drawing.Point(27, 56);
            this.lblRefCosech1.Name = "lblRefCosech1";
            this.lblRefCosech1.Size = new System.Drawing.Size(289, 80);
            this.lblRefCosech1.TabIndex = 1;
            this.lblRefCosech1.Text = "Autor: C.Navamani\r\nAño: 2025\r\nDocumento: The Majesty of Mangoes\r\nLink:\r\n";
            // 
            // lblRefCosech2
            // 
            this.lblRefCosech2.AutoSize = true;
            this.lblRefCosech2.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefCosech2.Location = new System.Drawing.Point(13, 191);
            this.lblRefCosech2.Name = "lblRefCosech2";
            this.lblRefCosech2.Size = new System.Drawing.Size(392, 100);
            this.lblRefCosech2.TabIndex = 2;
            this.lblRefCosech2.Text = "Autores: Juan Mora Montero,\r\n Jimmy Gamboa Porras, Ricardo Elizondo Murillo.\r\nAño" +
    ": 2002\r\nDocumento: Guía para el cultivo del mango\r\nISBN: 9968-877-01-8";
            // 
            // linklblRefCosech1
            // 
            this.linklblRefCosech1.AutoSize = true;
            this.linklblRefCosech1.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblRefCosech1.Location = new System.Drawing.Point(27, 136);
            this.linklblRefCosech1.Name = "linklblRefCosech1";
            this.linklblRefCosech1.Size = new System.Drawing.Size(337, 20);
            this.linklblRefCosech1.TabIndex = 3;
            this.linklblRefCosech1.TabStop = true;
            this.linklblRefCosech1.Text = "https://doi.org/10.38124/ijisrt/25may2178";
            // 
            // btnRefPnlCosech
            // 
            this.btnRefPnlCosech.BackgroundImage = global::PROYECTOMANGO.Properties.Resources.BotnXRef;
            this.btnRefPnlCosech.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefPnlCosech.FlatAppearance.BorderSize = 0;
            this.btnRefPnlCosech.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefPnlCosech.Location = new System.Drawing.Point(356, 4);
            this.btnRefPnlCosech.Name = "btnRefPnlCosech";
            this.btnRefPnlCosech.Size = new System.Drawing.Size(58, 54);
            this.btnRefPnlCosech.TabIndex = 4;
            this.btnRefPnlCosech.UseVisualStyleBackColor = true;
            this.btnRefPnlCosech.Click += new System.EventHandler(this.btnRefPnlCosech_Click);
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
            this.AbrirFormPnlCosecha.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenTemaCosecha)).EndInit();
            this.pnlRefCosecha.ResumeLayout(false);
            this.pnlRefCosecha.PerformLayout();
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
        private System.Windows.Forms.Button btnRefCosecha;
        private System.Windows.Forms.Panel pnlRefCosecha;
        private System.Windows.Forms.LinkLabel linklblRefCosech1;
        private System.Windows.Forms.Label lblRefCosech2;
        private System.Windows.Forms.Label lblRefCosech1;
        private System.Windows.Forms.Label lblTitRefCosech;
        private System.Windows.Forms.Button btnRefPnlCosech;
    }
}