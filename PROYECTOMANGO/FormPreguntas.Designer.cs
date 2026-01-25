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
            this.lblPreguntas = new System.Windows.Forms.Label();
            this.lblContador = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.rbOpcion1 = new System.Windows.Forms.RadioButton();
            this.rbOpcion2 = new System.Windows.Forms.RadioButton();
            this.rbOpcion3 = new System.Windows.Forms.RadioButton();
            this.btnResponder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPreguntas
            // 
            this.lblPreguntas.AutoSize = true;
            this.lblPreguntas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(213)))), ((int)(((byte)(104)))));
            this.lblPreguntas.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblPreguntas.Location = new System.Drawing.Point(49, 132);
            this.lblPreguntas.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblPreguntas.Name = "lblPreguntas";
            this.lblPreguntas.Size = new System.Drawing.Size(79, 33);
            this.lblPreguntas.TabIndex = 0;
            this.lblPreguntas.Text = "label1";
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(213)))), ((int)(((byte)(104)))));
            this.lblContador.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblContador.Location = new System.Drawing.Point(71, 450);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(79, 33);
            this.lblContador.TabIndex = 1;
            this.lblContador.Text = "label1";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(213)))), ((int)(((byte)(104)))));
            this.labelTitulo.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelTitulo.Location = new System.Drawing.Point(223, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(330, 60);
            this.labelTitulo.TabIndex = 2;
            this.labelTitulo.Text = "Pon a prueba tus conocimeintos\r\n             del mango";
            this.labelTitulo.Click += new System.EventHandler(this.labelTitulo_Click);
            // 
            // rbOpcion1
            // 
            this.rbOpcion1.AutoSize = true;
            this.rbOpcion1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(213)))), ((int)(((byte)(104)))));
            this.rbOpcion1.ForeColor = System.Drawing.Color.DarkGreen;
            this.rbOpcion1.Location = new System.Drawing.Point(136, 220);
            this.rbOpcion1.Name = "rbOpcion1";
            this.rbOpcion1.Size = new System.Drawing.Size(174, 37);
            this.rbOpcion1.TabIndex = 3;
            this.rbOpcion1.TabStop = true;
            this.rbOpcion1.Text = "radioButton1";
            this.rbOpcion1.UseVisualStyleBackColor = false;
            // 
            // rbOpcion2
            // 
            this.rbOpcion2.AutoSize = true;
            this.rbOpcion2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(213)))), ((int)(((byte)(104)))));
            this.rbOpcion2.ForeColor = System.Drawing.Color.DarkGreen;
            this.rbOpcion2.Location = new System.Drawing.Point(136, 263);
            this.rbOpcion2.Name = "rbOpcion2";
            this.rbOpcion2.Size = new System.Drawing.Size(178, 37);
            this.rbOpcion2.TabIndex = 4;
            this.rbOpcion2.TabStop = true;
            this.rbOpcion2.Text = "radioButton2";
            this.rbOpcion2.UseVisualStyleBackColor = false;
            // 
            // rbOpcion3
            // 
            this.rbOpcion3.AutoSize = true;
            this.rbOpcion3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(213)))), ((int)(((byte)(104)))));
            this.rbOpcion3.ForeColor = System.Drawing.Color.DarkGreen;
            this.rbOpcion3.Location = new System.Drawing.Point(136, 306);
            this.rbOpcion3.Name = "rbOpcion3";
            this.rbOpcion3.Size = new System.Drawing.Size(178, 37);
            this.rbOpcion3.TabIndex = 5;
            this.rbOpcion3.TabStop = true;
            this.rbOpcion3.Text = "radioButton3";
            this.rbOpcion3.UseVisualStyleBackColor = false;
            // 
            // btnResponder
            // 
            this.btnResponder.Location = new System.Drawing.Point(612, 442);
            this.btnResponder.Name = "btnResponder";
            this.btnResponder.Size = new System.Drawing.Size(142, 49);
            this.btnResponder.TabIndex = 6;
            this.btnResponder.Text = "Responder";
            this.btnResponder.UseVisualStyleBackColor = true;
            this.btnResponder.Click += new System.EventHandler(this.btnResponder_Click);
            // 
            // FormPreguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROYECTOMANGO.Properties.Resources.Gemini_Generated_Image_ug0szfug0szfug0s;
            this.ClientSize = new System.Drawing.Size(792, 511);
            this.Controls.Add(this.btnResponder);
            this.Controls.Add(this.rbOpcion3);
            this.Controls.Add(this.rbOpcion2);
            this.Controls.Add(this.rbOpcion1);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.lblPreguntas);
            this.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "FormPreguntas";
            this.Text = "FormPreguntas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPreguntas;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.RadioButton rbOpcion1;
        private System.Windows.Forms.RadioButton rbOpcion2;
        private System.Windows.Forms.RadioButton rbOpcion3;
        private System.Windows.Forms.Button btnResponder;
    }
}