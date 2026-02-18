namespace PROYECTOMANGO
{
    partial class FormPreguntas
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
            this.components = new System.ComponentModel.Container();
            this.lblPreguntas = new System.Windows.Forms.Label();
            this.lblContador = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.btnResponder = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rbOpcion1 = new System.Windows.Forms.RadioButton();
            this.rbOpcion2 = new System.Windows.Forms.RadioButton();
            this.rbOpcion3 = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTiempo = new System.Windows.Forms.Label();
            this.rbOpcion4 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnResponder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPreguntas
            // 
            this.lblPreguntas.AutoSize = true;
            this.lblPreguntas.BackColor = System.Drawing.Color.Transparent;
            this.lblPreguntas.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreguntas.ForeColor = System.Drawing.Color.Black;
            this.lblPreguntas.Location = new System.Drawing.Point(4, 131);
            this.lblPreguntas.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblPreguntas.Name = "lblPreguntas";
            this.lblPreguntas.Size = new System.Drawing.Size(84, 35);
            this.lblPreguntas.TabIndex = 0;
            this.lblPreguntas.Text = "label1";
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.BackColor = System.Drawing.Color.Transparent;
            this.lblContador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblContador.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador.ForeColor = System.Drawing.Color.Black;
            this.lblContador.Location = new System.Drawing.Point(71, 450);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(86, 37);
            this.lblContador.TabIndex = 1;
            this.lblContador.Text = "label1";
            // 
            // labelTitulo
            // 
            this.labelTitulo.BackColor = System.Drawing.Color.Transparent;
            this.labelTitulo.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.Black;
            this.labelTitulo.Location = new System.Drawing.Point(59, 30);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(686, 66);
            this.labelTitulo.TabIndex = 2;
            this.labelTitulo.Text = "Pon a prueba tus conocimientos del mango";
            this.labelTitulo.Click += new System.EventHandler(this.labelTitulo_Click);
            // 
            // btnResponder
            // 
            this.btnResponder.BackColor = System.Drawing.Color.Transparent;
            this.btnResponder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResponder.Image = global::PROYECTOMANGO.Properties.Resources.btnPP_1__removebg_preview;
            this.btnResponder.Location = new System.Drawing.Point(322, 394);
            this.btnResponder.Name = "btnResponder";
            this.btnResponder.Size = new System.Drawing.Size(134, 118);
            this.btnResponder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnResponder.TabIndex = 7;
            this.btnResponder.TabStop = false;
            this.btnResponder.Click += new System.EventHandler(this.btnResponder1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PROYECTOMANGO.Properties.Resources.ANI_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(436, 227);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 298);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // rbOpcion1
            // 
            this.rbOpcion1.AutoSize = true;
            this.rbOpcion1.BackColor = System.Drawing.Color.Gainsboro;
            this.rbOpcion1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOpcion1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rbOpcion1.Location = new System.Drawing.Point(24, 315);
            this.rbOpcion1.Name = "rbOpcion1";
            this.rbOpcion1.Size = new System.Drawing.Size(182, 39);
            this.rbOpcion1.TabIndex = 3;
            this.rbOpcion1.TabStop = true;
            this.rbOpcion1.Text = "radioButton1";
            this.rbOpcion1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rbOpcion1.UseVisualStyleBackColor = false;
            // 
            // rbOpcion2
            // 
            this.rbOpcion2.AutoSize = true;
            this.rbOpcion2.BackColor = System.Drawing.Color.Gainsboro;
            this.rbOpcion2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOpcion2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rbOpcion2.Location = new System.Drawing.Point(24, 264);
            this.rbOpcion2.Name = "rbOpcion2";
            this.rbOpcion2.Size = new System.Drawing.Size(182, 39);
            this.rbOpcion2.TabIndex = 4;
            this.rbOpcion2.TabStop = true;
            this.rbOpcion2.Text = "radioButton2";
            this.rbOpcion2.UseVisualStyleBackColor = false;
            this.rbOpcion2.CheckedChanged += new System.EventHandler(this.rbOpcion2_CheckedChanged);
            // 
            // rbOpcion3
            // 
            this.rbOpcion3.AutoSize = true;
            this.rbOpcion3.BackColor = System.Drawing.Color.Gainsboro;
            this.rbOpcion3.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOpcion3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rbOpcion3.Location = new System.Drawing.Point(24, 213);
            this.rbOpcion3.Name = "rbOpcion3";
            this.rbOpcion3.Size = new System.Drawing.Size(182, 39);
            this.rbOpcion3.TabIndex = 5;
            this.rbOpcion3.TabStop = true;
            this.rbOpcion3.Text = "radioButton3";
            this.rbOpcion3.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.BackColor = System.Drawing.Color.Transparent;
            this.lblTiempo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTiempo.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.ForeColor = System.Drawing.Color.Black;
            this.lblTiempo.Location = new System.Drawing.Point(344, 341);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(86, 37);
            this.lblTiempo.TabIndex = 9;
            this.lblTiempo.Text = "label1";
            // 
            // rbOpcion4
            // 
            this.rbOpcion4.AutoSize = true;
            this.rbOpcion4.BackColor = System.Drawing.Color.Gainsboro;
            this.rbOpcion4.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOpcion4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rbOpcion4.Location = new System.Drawing.Point(24, 374);
            this.rbOpcion4.Name = "rbOpcion4";
            this.rbOpcion4.Size = new System.Drawing.Size(182, 39);
            this.rbOpcion4.TabIndex = 10;
            this.rbOpcion4.TabStop = true;
            this.rbOpcion4.Text = "radioButton4";
            this.rbOpcion4.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rbOpcion4.UseVisualStyleBackColor = false;
            // 
            // FormPreguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROYECTOMANGO.Properties.Resources.WhatsApp_Image_2026_01_25_at_12_18_24_PM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(717, 511);
            this.Controls.Add(this.rbOpcion4);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rbOpcion1);
            this.Controls.Add(this.rbOpcion2);
            this.Controls.Add(this.rbOpcion3);
            this.Controls.Add(this.btnResponder);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.lblPreguntas);
            this.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8);
            this.MaximizeBox = false;
            this.Name = "FormPreguntas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPreguntas_FormClosing);
            this.Load += new System.EventHandler(this.FormPreguntas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnResponder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPreguntas;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.PictureBox btnResponder;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rbOpcion1;
        private System.Windows.Forms.RadioButton rbOpcion2;
        private System.Windows.Forms.RadioButton rbOpcion3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.RadioButton rbOpcion4;
    }
}