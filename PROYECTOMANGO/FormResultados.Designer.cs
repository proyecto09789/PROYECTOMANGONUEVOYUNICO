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
            this.lblPuntaje.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntaje.Location = new System.Drawing.Point(102, 9);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(92, 40);
            this.lblPuntaje.TabIndex = 0;
            this.lblPuntaje.Text = "label1";
            // 
            // lstResultados
            // 
            this.lstResultados.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstResultados.FormattingEnabled = true;
            this.lstResultados.ItemHeight = 30;
            this.lstResultados.Location = new System.Drawing.Point(51, 61);
            this.lstResultados.Name = "lstResultados";
            this.lstResultados.Size = new System.Drawing.Size(412, 304);
            this.lstResultados.TabIndex = 1;
            // 
            // btnFin
            // 
            this.btnFin.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFin.Location = new System.Drawing.Point(390, 395);
            this.btnFin.Name = "btnFin";
            this.btnFin.Size = new System.Drawing.Size(99, 46);
            this.btnFin.TabIndex = 2;
            this.btnFin.Text = "Salir";
            this.btnFin.UseVisualStyleBackColor = true;
            this.btnFin.Click += new System.EventHandler(this.btnFin_Click);
            // 
            // FormResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROYECTOMANGO.Properties.Resources.Gemini_Generated_Image_bxnn55bxnn55bxnn;
            this.ClientSize = new System.Drawing.Size(514, 453);
            this.Controls.Add(this.btnFin);
            this.Controls.Add(this.lstResultados);
            this.Controls.Add(this.lblPuntaje);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "FormResultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPuntaje;
        private System.Windows.Forms.ListBox lstResultados;
        private System.Windows.Forms.Button btnFin;
    }
}