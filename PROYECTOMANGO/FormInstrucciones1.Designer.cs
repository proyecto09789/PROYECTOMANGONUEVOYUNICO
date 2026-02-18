namespace PROYECTOMANGO
{
    partial class FormInstrucciones1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInstrucciones1));
            this.PnlNiveles = new System.Windows.Forms.Panel();
            this.BtnHard = new System.Windows.Forms.Button();
            this.BtnInter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEasy = new System.Windows.Forms.Button();
            this.PnlLista = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PnlNiveles.SuspendLayout();
            this.PnlLista.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlNiveles
            // 
            this.PnlNiveles.BackColor = System.Drawing.Color.Transparent;
            this.PnlNiveles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PnlNiveles.Controls.Add(this.BtnHard);
            this.PnlNiveles.Controls.Add(this.BtnInter);
            this.PnlNiveles.Controls.Add(this.label1);
            this.PnlNiveles.Controls.Add(this.BtnEasy);
            this.PnlNiveles.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlNiveles.Location = new System.Drawing.Point(0, 0);
            this.PnlNiveles.Name = "PnlNiveles";
            this.PnlNiveles.Size = new System.Drawing.Size(252, 483);
            this.PnlNiveles.TabIndex = 1;
            // 
            // BtnHard
            // 
            this.BtnHard.BackColor = System.Drawing.Color.Transparent;
            this.BtnHard.BackgroundImage = global::PROYECTOMANGO.Properties.Resources.LVLDificil_PNG;
            this.BtnHard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnHard.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BtnHard.FlatAppearance.BorderSize = 0;
            this.BtnHard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHard.Location = new System.Drawing.Point(81, 329);
            this.BtnHard.Name = "BtnHard";
            this.BtnHard.Size = new System.Drawing.Size(84, 79);
            this.BtnHard.TabIndex = 3;
            this.BtnHard.UseVisualStyleBackColor = false;
            this.BtnHard.Click += new System.EventHandler(this.BtnHard_Click);
            // 
            // BtnInter
            // 
            this.BtnInter.BackColor = System.Drawing.Color.Transparent;
            this.BtnInter.BackgroundImage = global::PROYECTOMANGO.Properties.Resources.hardd;
            this.BtnInter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnInter.FlatAppearance.BorderSize = 0;
            this.BtnInter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInter.Location = new System.Drawing.Point(72, 223);
            this.BtnInter.Name = "BtnInter";
            this.BtnInter.Size = new System.Drawing.Size(103, 100);
            this.BtnInter.TabIndex = 2;
            this.BtnInter.UseVisualStyleBackColor = false;
            this.BtnInter.Click += new System.EventHandler(this.BtnInter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 76);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione un nivel\r\n   de dificultad";
            // 
            // BtnEasy
            // 
            this.BtnEasy.BackColor = System.Drawing.Color.Transparent;
            this.BtnEasy.BackgroundImage = global::PROYECTOMANGO.Properties.Resources.gd;
            this.BtnEasy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnEasy.FlatAppearance.BorderSize = 0;
            this.BtnEasy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEasy.Location = new System.Drawing.Point(72, 131);
            this.BtnEasy.Name = "BtnEasy";
            this.BtnEasy.Size = new System.Drawing.Size(103, 86);
            this.BtnEasy.TabIndex = 0;
            this.BtnEasy.UseVisualStyleBackColor = false;
            this.BtnEasy.Click += new System.EventHandler(this.BtnEasy_Click);
            // 
            // PnlLista
            // 
            this.PnlLista.BackColor = System.Drawing.Color.Transparent;
            this.PnlLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlLista.Controls.Add(this.label3);
            this.PnlLista.Controls.Add(this.label2);
            this.PnlLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlLista.Location = new System.Drawing.Point(252, 0);
            this.PnlLista.Name = "PnlLista";
            this.PnlLista.Size = new System.Drawing.Size(371, 483);
            this.PnlLista.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(351, 378);
            this.label3.TabIndex = 3;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Intrucciones del QUIZ!!";
            // 
            // FormInstrucciones1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROYECTOMANGO.Properties.Resources.WhatsApp_Image_2026_01_25_at_12_18_24_PM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(623, 483);
            this.Controls.Add(this.PnlLista);
            this.Controls.Add(this.PnlNiveles);
            this.Name = "FormInstrucciones1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInstrucciones1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormInstrucciones1_FormClosing);
            this.Load += new System.EventHandler(this.FormInstrucciones1_Load);
            this.PnlNiveles.ResumeLayout(false);
            this.PnlNiveles.PerformLayout();
            this.PnlLista.ResumeLayout(false);
            this.PnlLista.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlNiveles;
        private System.Windows.Forms.Button BtnHard;
        private System.Windows.Forms.Button BtnInter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEasy;
        private System.Windows.Forms.Panel PnlLista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}