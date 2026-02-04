using System;

namespace PROYECTOMANGO
{
    partial class JuegSeccProcProd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JuegSeccProcProd));
            this.btnVolverJuegSecc = new System.Windows.Forms.Button();
            this.pnlSecuencia = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlOpciones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlComoSeJuega = new System.Windows.Forms.Panel();
            this.lblComoSeJuega2 = new System.Windows.Forms.Label();
            this.lblComoSeJuega = new System.Windows.Forms.Label();
            this.btnXInstrucc = new System.Windows.Forms.Button();
            this.btnComoSeJuega = new System.Windows.Forms.Button();
            this.pnlComoSeJuega.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVolverJuegSecc
            // 
            this.btnVolverJuegSecc.BackColor = System.Drawing.Color.Transparent;
            this.btnVolverJuegSecc.BackgroundImage = global::PROYECTOMANGO.Properties.Resources.Boton_de_Volver11;
            this.btnVolverJuegSecc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolverJuegSecc.FlatAppearance.BorderSize = 0;
            this.btnVolverJuegSecc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverJuegSecc.ForeColor = System.Drawing.Color.Transparent;
            this.btnVolverJuegSecc.Location = new System.Drawing.Point(12, 12);
            this.btnVolverJuegSecc.Name = "btnVolverJuegSecc";
            this.btnVolverJuegSecc.Size = new System.Drawing.Size(103, 75);
            this.btnVolverJuegSecc.TabIndex = 0;
            this.btnVolverJuegSecc.UseVisualStyleBackColor = false;
            this.btnVolverJuegSecc.Click += new System.EventHandler(this.btnVolverJuegSecc_Click);
            // 
            // pnlSecuencia
            // 
            this.pnlSecuencia.BackColor = System.Drawing.Color.Transparent;
            this.pnlSecuencia.BackgroundImage = global::PROYECTOMANGO.Properties.Resources.FondoPanelProccInterac;
            this.pnlSecuencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSecuencia.Location = new System.Drawing.Point(208, 139);
            this.pnlSecuencia.Name = "pnlSecuencia";
            this.pnlSecuencia.Size = new System.Drawing.Size(782, 133);
            this.pnlSecuencia.TabIndex = 1;
            // 
            // pnlOpciones
            // 
            this.pnlOpciones.BackColor = System.Drawing.Color.Transparent;
            this.pnlOpciones.Location = new System.Drawing.Point(208, 335);
            this.pnlOpciones.Name = "pnlOpciones";
            this.pnlOpciones.Size = new System.Drawing.Size(782, 157);
            this.pnlOpciones.TabIndex = 2;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.Transparent;
            this.btnSiguiente.BackgroundImage = global::PROYECTOMANGO.Properties.Resources.BtnSiguiente;
            this.btnSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Location = new System.Drawing.Point(1018, 486);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(150, 67);
            this.btnSiguiente.TabIndex = 0;
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.Color.Transparent;
            this.btnVerificar.BackgroundImage = global::PROYECTOMANGO.Properties.Resources.BtnVerificar;
            this.btnVerificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVerificar.FlatAppearance.BorderSize = 0;
            this.btnVerificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerificar.Location = new System.Drawing.Point(43, 486);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(150, 67);
            this.btnVerificar.TabIndex = 3;
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Georgia", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblTitulo.Location = new System.Drawing.Point(444, 44);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(314, 43);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "¡BIENVENIDO!";
            // 
            // pnlComoSeJuega
            // 
            this.pnlComoSeJuega.BackgroundImage = global::PROYECTOMANGO.Properties.Resources.fondoInstruccionesJgProc;
            this.pnlComoSeJuega.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlComoSeJuega.Controls.Add(this.lblComoSeJuega2);
            this.pnlComoSeJuega.Controls.Add(this.lblComoSeJuega);
            this.pnlComoSeJuega.Controls.Add(this.btnXInstrucc);
            this.pnlComoSeJuega.Location = new System.Drawing.Point(285, 116);
            this.pnlComoSeJuega.Name = "pnlComoSeJuega";
            this.pnlComoSeJuega.Size = new System.Drawing.Size(603, 459);
            this.pnlComoSeJuega.TabIndex = 7;
            this.pnlComoSeJuega.Visible = false;
            // 
            // lblComoSeJuega2
            // 
            this.lblComoSeJuega2.AutoSize = true;
            this.lblComoSeJuega2.BackColor = System.Drawing.Color.Transparent;
            this.lblComoSeJuega2.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComoSeJuega2.ForeColor = System.Drawing.Color.White;
            this.lblComoSeJuega2.Location = new System.Drawing.Point(28, 174);
            this.lblComoSeJuega2.Name = "lblComoSeJuega2";
            this.lblComoSeJuega2.Size = new System.Drawing.Size(524, 189);
            this.lblComoSeJuega2.TabIndex = 2;
            this.lblComoSeJuega2.Text = resources.GetString("lblComoSeJuega2.Text");
            // 
            // lblComoSeJuega
            // 
            this.lblComoSeJuega.AutoSize = true;
            this.lblComoSeJuega.BackColor = System.Drawing.Color.Transparent;
            this.lblComoSeJuega.Font = new System.Drawing.Font("Georgia", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComoSeJuega.ForeColor = System.Drawing.Color.White;
            this.lblComoSeJuega.Location = new System.Drawing.Point(79, 77);
            this.lblComoSeJuega.Name = "lblComoSeJuega";
            this.lblComoSeJuega.Size = new System.Drawing.Size(422, 54);
            this.lblComoSeJuega.TabIndex = 1;
            this.lblComoSeJuega.Text = "¿Cómo se juega?";
            // 
            // btnXInstrucc
            // 
            this.btnXInstrucc.BackColor = System.Drawing.Color.Transparent;
            this.btnXInstrucc.BackgroundImage = global::PROYECTOMANGO.Properties.Resources.btnInstruccJgProcc;
            this.btnXInstrucc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXInstrucc.FlatAppearance.BorderSize = 0;
            this.btnXInstrucc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXInstrucc.Location = new System.Drawing.Point(527, 12);
            this.btnXInstrucc.Name = "btnXInstrucc";
            this.btnXInstrucc.Size = new System.Drawing.Size(64, 59);
            this.btnXInstrucc.TabIndex = 0;
            this.btnXInstrucc.UseVisualStyleBackColor = false;
            this.btnXInstrucc.Click += new System.EventHandler(this.btnXInstrucc_Click);
            // 
            // btnComoSeJuega
            // 
            this.btnComoSeJuega.BackColor = System.Drawing.Color.Transparent;
            this.btnComoSeJuega.BackgroundImage = global::PROYECTOMANGO.Properties.Resources.btnComoSeJuega;
            this.btnComoSeJuega.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnComoSeJuega.FlatAppearance.BorderSize = 0;
            this.btnComoSeJuega.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComoSeJuega.Location = new System.Drawing.Point(1093, 12);
            this.btnComoSeJuega.Name = "btnComoSeJuega";
            this.btnComoSeJuega.Size = new System.Drawing.Size(75, 60);
            this.btnComoSeJuega.TabIndex = 8;
            this.btnComoSeJuega.UseMnemonic = false;
            this.btnComoSeJuega.UseVisualStyleBackColor = false;
            this.btnComoSeJuega.Click += new System.EventHandler(this.btnComoSeJuega_Click);
            // 
            // JuegSeccProcProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROYECTOMANGO.Properties.Resources.fondsiem123;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1180, 630);
            this.Controls.Add(this.btnComoSeJuega);
            this.Controls.Add(this.pnlComoSeJuega);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.pnlOpciones);
            this.Controls.Add(this.pnlSecuencia);
            this.Controls.Add(this.btnVolverJuegSecc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "JuegSeccProcProd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JuegSeccProcProd";
            this.Load += new System.EventHandler(this.JuegSeccProcProd_Load);
            this.pnlComoSeJuega.ResumeLayout(false);
            this.pnlComoSeJuega.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolverJuegSecc;
        private System.Windows.Forms.FlowLayoutPanel pnlSecuencia;
        private System.Windows.Forms.FlowLayoutPanel pnlOpciones;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlComoSeJuega;
        private System.Windows.Forms.Button btnXInstrucc;
        private System.Windows.Forms.Button btnComoSeJuega;
        private System.Windows.Forms.Label lblComoSeJuega2;
        private System.Windows.Forms.Label lblComoSeJuega;
    }
}