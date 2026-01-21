namespace PROYECTOBETA001
{
    partial class ProcProductivo
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
            this.bttRegreProc = new System.Windows.Forms.Button();
            this.lblTituProc = new System.Windows.Forms.Label();
            this.bttCosecha = new System.Windows.Forms.Button();
            this.bttFloracio = new System.Windows.Forms.Button();
            this.bttSiembra = new System.Windows.Forms.Button();
            this.pBoxCosecha = new System.Windows.Forms.PictureBox();
            this.pBoxFloracion = new System.Windows.Forms.PictureBox();
            this.pBoxSiembra = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCosecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxFloracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSiembra)).BeginInit();
            this.SuspendLayout();
            // 
            // bttRegreProc
            // 
            this.bttRegreProc.BackColor = System.Drawing.Color.Firebrick;
            this.bttRegreProc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttRegreProc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttRegreProc.Location = new System.Drawing.Point(16, 15);
            this.bttRegreProc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bttRegreProc.Name = "bttRegreProc";
            this.bttRegreProc.Size = new System.Drawing.Size(107, 42);
            this.bttRegreProc.TabIndex = 0;
            this.bttRegreProc.Text = "Menú";
            this.bttRegreProc.UseVisualStyleBackColor = false;
            this.bttRegreProc.Click += new System.EventHandler(this.bttRegreProc_Click);
            // 
            // lblTituProc
            // 
            this.lblTituProc.AutoSize = true;
            this.lblTituProc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTituProc.Font = new System.Drawing.Font("Sitka Heading", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituProc.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblTituProc.Location = new System.Drawing.Point(191, 44);
            this.lblTituProc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituProc.Name = "lblTituProc";
            this.lblTituProc.Size = new System.Drawing.Size(834, 87);
            this.lblTituProc.TabIndex = 1;
            this.lblTituProc.Text = "Proceso Productivo del Mango";
            // 
            // bttCosecha
            // 
            this.bttCosecha.BackgroundImage = global::PROYECTOMANGO.Properties.Resources.boton;
            this.bttCosecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttCosecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttCosecha.Location = new System.Drawing.Point(891, 413);
            this.bttCosecha.Margin = new System.Windows.Forms.Padding(4);
            this.bttCosecha.Name = "bttCosecha";
            this.bttCosecha.Size = new System.Drawing.Size(144, 66);
            this.bttCosecha.TabIndex = 7;
            this.bttCosecha.UseVisualStyleBackColor = true;
            this.bttCosecha.Click += new System.EventHandler(this.bttCosecha_Click);
            // 
            // bttFloracio
            // 
            this.bttFloracio.BackgroundImage = global::PROYECTOMANGO.Properties.Resources.boton;
            this.bttFloracio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttFloracio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttFloracio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttFloracio.Location = new System.Drawing.Point(528, 413);
            this.bttFloracio.Margin = new System.Windows.Forms.Padding(4);
            this.bttFloracio.Name = "bttFloracio";
            this.bttFloracio.Size = new System.Drawing.Size(144, 66);
            this.bttFloracio.TabIndex = 6;
            this.bttFloracio.UseVisualStyleBackColor = false;
            this.bttFloracio.Click += new System.EventHandler(this.bttFloracio_Click);
            // 
            // bttSiembra
            // 
            this.bttSiembra.BackColor = System.Drawing.Color.Khaki;
            this.bttSiembra.BackgroundImage = global::PROYECTOMANGO.Properties.Resources.boton;
            this.bttSiembra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttSiembra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttSiembra.Location = new System.Drawing.Point(180, 413);
            this.bttSiembra.Margin = new System.Windows.Forms.Padding(4);
            this.bttSiembra.Name = "bttSiembra";
            this.bttSiembra.Size = new System.Drawing.Size(144, 66);
            this.bttSiembra.TabIndex = 5;
            this.bttSiembra.UseVisualStyleBackColor = false;
            this.bttSiembra.Click += new System.EventHandler(this.bttSiembra_Click);
            // 
            // pBoxCosecha
            // 
            this.pBoxCosecha.BackColor = System.Drawing.Color.Silver;
            this.pBoxCosecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBoxCosecha.Image = global::PROYECTOMANGO.Properties.Resources.cosechaimg;
            this.pBoxCosecha.Location = new System.Drawing.Point(829, 190);
            this.pBoxCosecha.Margin = new System.Windows.Forms.Padding(4);
            this.pBoxCosecha.Name = "pBoxCosecha";
            this.pBoxCosecha.Size = new System.Drawing.Size(263, 289);
            this.pBoxCosecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxCosecha.TabIndex = 4;
            this.pBoxCosecha.TabStop = false;
            // 
            // pBoxFloracion
            // 
            this.pBoxFloracion.BackColor = System.Drawing.Color.Silver;
            this.pBoxFloracion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBoxFloracion.Image = global::PROYECTOMANGO.Properties.Resources.floracionimg;
            this.pBoxFloracion.Location = new System.Drawing.Point(472, 190);
            this.pBoxFloracion.Margin = new System.Windows.Forms.Padding(4);
            this.pBoxFloracion.Name = "pBoxFloracion";
            this.pBoxFloracion.Size = new System.Drawing.Size(263, 289);
            this.pBoxFloracion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxFloracion.TabIndex = 3;
            this.pBoxFloracion.TabStop = false;
            // 
            // pBoxSiembra
            // 
            this.pBoxSiembra.BackColor = System.Drawing.Color.Khaki;
            this.pBoxSiembra.BackgroundImage = global::PROYECTOMANGO.Properties.Resources.boton;
            this.pBoxSiembra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBoxSiembra.Image = global::PROYECTOMANGO.Properties.Resources.siembraimg;
            this.pBoxSiembra.Location = new System.Drawing.Point(124, 190);
            this.pBoxSiembra.Margin = new System.Windows.Forms.Padding(4);
            this.pBoxSiembra.Name = "pBoxSiembra";
            this.pBoxSiembra.Size = new System.Drawing.Size(263, 289);
            this.pBoxSiembra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxSiembra.TabIndex = 2;
            this.pBoxSiembra.TabStop = false;
            // 
            // ProcProductivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(1180, 630);
            this.Controls.Add(this.bttCosecha);
            this.Controls.Add(this.bttFloracio);
            this.Controls.Add(this.bttSiembra);
            this.Controls.Add(this.pBoxCosecha);
            this.Controls.Add(this.pBoxFloracion);
            this.Controls.Add(this.pBoxSiembra);
            this.Controls.Add(this.lblTituProc);
            this.Controls.Add(this.bttRegreProc);
            this.ForeColor = System.Drawing.Color.Khaki;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ProcProductivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProcProductivo";
            this.Load += new System.EventHandler(this.ProcProductivo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCosecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxFloracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSiembra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttRegreProc;
        private System.Windows.Forms.Label lblTituProc;
        private System.Windows.Forms.PictureBox pBoxSiembra;
        private System.Windows.Forms.PictureBox pBoxFloracion;
        private System.Windows.Forms.PictureBox pBoxCosecha;
        private System.Windows.Forms.Button bttSiembra;
        private System.Windows.Forms.Button bttFloracio;
        private System.Windows.Forms.Button bttCosecha;
    }
}