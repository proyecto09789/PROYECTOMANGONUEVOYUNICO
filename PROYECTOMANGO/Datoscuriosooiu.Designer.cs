namespace PROYECTOBETA001
{
    partial class Datoscuriosooi
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
            this.bntAnterio = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.txtDatos = new System.Windows.Forms.TextBox();
            this.lblContador = new System.Windows.Forms.Label();
            this.LinkFuentes = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // bntAnterio
            // 
            this.bntAnterio.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntAnterio.Location = new System.Drawing.Point(105, 409);
            this.bntAnterio.Name = "bntAnterio";
            this.bntAnterio.Size = new System.Drawing.Size(129, 36);
            this.bntAnterio.TabIndex = 1;
            this.bntAnterio.Text = "Anterior";
            this.bntAnterio.UseVisualStyleBackColor = true;
            this.bntAnterio.Click += new System.EventHandler(this.bntAnterio_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(592, 409);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(129, 36);
            this.btnSiguiente.TabIndex = 2;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(25, 12);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(129, 36);
            this.btnRegresar.TabIndex = 3;
            this.btnRegresar.Text = "Anterior";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // txtDatos
            // 
            this.txtDatos.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtDatos.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatos.Location = new System.Drawing.Point(174, 107);
            this.txtDatos.Multiline = true;
            this.txtDatos.Name = "txtDatos";
            this.txtDatos.Size = new System.Drawing.Size(403, 247);
            this.txtDatos.TabIndex = 4;
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.BackColor = System.Drawing.Color.Transparent;
            this.lblContador.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.lblContador.Location = new System.Drawing.Point(345, 465);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(61, 23);
            this.lblContador.TabIndex = 5;
            this.lblContador.Text = "label1";
            // 
            // LinkFuentes
            // 
            this.LinkFuentes.AutoSize = true;
            this.LinkFuentes.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkFuentes.Location = new System.Drawing.Point(620, 23);
            this.LinkFuentes.Name = "LinkFuentes";
            this.LinkFuentes.Size = new System.Drawing.Size(145, 62);
            this.LinkFuentes.TabIndex = 6;
            this.LinkFuentes.TabStop = true;
            this.LinkFuentes.Text = "Fuentes de \r\ninformacion";
            this.LinkFuentes.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkFuentes_LinkClicked);
            // 
            // Datoscuriosooi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROYECTOMANGO.Properties.Resources.Gemini_Generated_Image_booz9dbooz9dbooz;
            this.ClientSize = new System.Drawing.Size(792, 511);
            this.Controls.Add(this.LinkFuentes);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.txtDatos);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.bntAnterio);
            this.Name = "Datoscuriosooi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DATOS CURIOSO";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bntAnterio;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.TextBox txtDatos;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.LinkLabel LinkFuentes;
    }
}