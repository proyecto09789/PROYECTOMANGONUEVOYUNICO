namespace PROYECTOMANGO
{
    partial class FormResultados
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
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.lstResultados = new System.Windows.Forms.ListBox();
            this.btnFin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPuntaje
            // 
            this.lblPuntaje.AutoSize = true;
            this.lblPuntaje.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntaje.Font = new System.Drawing.Font("Comic Sans MS", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntaje.ForeColor = System.Drawing.Color.Black;
            this.lblPuntaje.Location = new System.Drawing.Point(154, 9);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(129, 51);
            this.lblPuntaje.TabIndex = 0;
            this.lblPuntaje.Text = "label1";
            // 
            // lstResultados
            // 
            this.lstResultados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(213)))), ((int)(((byte)(104)))));
            this.lstResultados.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstResultados.FormattingEnabled = true;
            this.lstResultados.ItemHeight = 36;
            this.lstResultados.Location = new System.Drawing.Point(12, 61);
            this.lstResultados.Name = "lstResultados";
            this.lstResultados.Size = new System.Drawing.Size(629, 328);
            this.lstResultados.TabIndex = 1;
            // 
            // btnFin
            // 
            this.btnFin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.btnFin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFin.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFin.ForeColor = System.Drawing.Color.Transparent;
            this.btnFin.Location = new System.Drawing.Point(507, 413);
            this.btnFin.Name = "btnFin";
            this.btnFin.Size = new System.Drawing.Size(112, 46);
            this.btnFin.TabIndex = 2;
            this.btnFin.Text = "Salir";
            this.btnFin.UseVisualStyleBackColor = false;
            this.btnFin.Click += new System.EventHandler(this.btnFin_Click);
            // 
            // FormResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROYECTOMANGO.Properties.Resources.WhatsApp_Image_2026_01_25_at_12_18_24_PM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(653, 481);
            this.Controls.Add(this.btnFin);
            this.Controls.Add(this.lstResultados);
            this.Controls.Add(this.lblPuntaje);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MaximizeBox = false;
            this.Name = "FormResultados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPuntaje;
        private System.Windows.Forms.ListBox lstResultados;
        private System.Windows.Forms.Button btnFin;
    }
}