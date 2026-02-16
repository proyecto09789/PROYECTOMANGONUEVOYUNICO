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
            this.components = new System.ComponentModel.Container();
            this.btnVolverJuegSecc = new System.Windows.Forms.Button();
            this.pnlSecuencia = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlOpciones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tmrNivel = new System.Windows.Forms.Timer(this.components);
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblErrores = new System.Windows.Forms.Label();
            this.ttlBienvenido = new System.Windows.Forms.Button();
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
            this.pnlSecuencia.BackgroundImage = global::PROYECTOMANGO.Properties.Resources.FondoPnlJgScc;
            this.pnlSecuencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSecuencia.Location = new System.Drawing.Point(208, 162);
            this.pnlSecuencia.Name = "pnlSecuencia";
            this.pnlSecuencia.Size = new System.Drawing.Size(782, 144);
            this.pnlSecuencia.TabIndex = 1;
            // 
            // pnlOpciones
            // 
            this.pnlOpciones.BackColor = System.Drawing.Color.Transparent;
            this.pnlOpciones.BackgroundImage = global::PROYECTOMANGO.Properties.Resources.FondoPnlJgScc;
            this.pnlOpciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlOpciones.Location = new System.Drawing.Point(208, 360);
            this.pnlOpciones.Name = "pnlOpciones";
            this.pnlOpciones.Size = new System.Drawing.Size(782, 169);
            this.pnlOpciones.TabIndex = 2;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.Transparent;
            this.btnSiguiente.BackgroundImage = global::PROYECTOMANGO.Properties.Resources.BtnSiguientemg;
            this.btnSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Location = new System.Drawing.Point(1018, 486);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(150, 109);
            this.btnSiguiente.TabIndex = 0;
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.Color.Transparent;
            this.btnVerificar.BackgroundImage = global::PROYECTOMANGO.Properties.Resources.BtnVerificarmg;
            this.btnVerificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVerificar.FlatAppearance.BorderSize = 0;
            this.btnVerificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerificar.Location = new System.Drawing.Point(43, 486);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(150, 109);
            this.btnVerificar.TabIndex = 3;
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitulo.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.OliveDrab;
            this.lblTitulo.Location = new System.Drawing.Point(477, 124);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(78, 35);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "___";
            // 
            // tmrNivel
            // 
            this.tmrNivel.Interval = 1000;
            this.tmrNivel.Tick += new System.EventHandler(this.tmrNivel_Tick);
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.BackColor = System.Drawing.Color.Transparent;
            this.lblTiempo.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.ForeColor = System.Drawing.Color.Ivory;
            this.lblTiempo.Location = new System.Drawing.Point(294, 556);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(162, 39);
            this.lblTiempo.TabIndex = 5;
            this.lblTiempo.Text = "Tiempo:";
            // 
            // lblErrores
            // 
            this.lblErrores.AutoSize = true;
            this.lblErrores.BackColor = System.Drawing.Color.Transparent;
            this.lblErrores.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrores.ForeColor = System.Drawing.Color.Red;
            this.lblErrores.Location = new System.Drawing.Point(723, 556);
            this.lblErrores.Name = "lblErrores";
            this.lblErrores.Size = new System.Drawing.Size(166, 39);
            this.lblErrores.TabIndex = 6;
            this.lblErrores.Text = "Errores:";
            // 
            // ttlBienvenido
            // 
            this.ttlBienvenido.BackColor = System.Drawing.Color.Transparent;
            this.ttlBienvenido.BackgroundImage = global::PROYECTOMANGO.Properties.Resources.ttlBienvenidoJgScc;
            this.ttlBienvenido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ttlBienvenido.FlatAppearance.BorderSize = 0;
            this.ttlBienvenido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ttlBienvenido.Location = new System.Drawing.Point(349, 5);
            this.ttlBienvenido.Name = "ttlBienvenido";
            this.ttlBienvenido.Size = new System.Drawing.Size(540, 116);
            this.ttlBienvenido.TabIndex = 7;
            this.ttlBienvenido.UseVisualStyleBackColor = false;
            // 
            // JuegSeccProcProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROYECTOMANGO.Properties.Resources.fondsiem123;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1180, 630);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.ttlBienvenido);
            this.Controls.Add(this.lblErrores);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.pnlOpciones);
            this.Controls.Add(this.pnlSecuencia);
            this.Controls.Add(this.btnVolverJuegSecc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "JuegSeccProcProd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JuegSeccProcProd";
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
        private System.Windows.Forms.Timer tmrNivel;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblErrores;
        private System.Windows.Forms.Button ttlBienvenido;
    }
}