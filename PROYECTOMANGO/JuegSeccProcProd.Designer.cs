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
            this.btnVolverJuegSecc = new System.Windows.Forms.Button();
            this.pnlPaso1 = new System.Windows.Forms.Panel();
            this.pnlPaso2 = new System.Windows.Forms.Panel();
            this.pnlPaso3 = new System.Windows.Forms.Panel();
            this.pbImgJgScc1 = new System.Windows.Forms.PictureBox();
            this.pbImgJgScc2 = new System.Windows.Forms.PictureBox();
            this.pbImgJgScc = new System.Windows.Forms.PictureBox();
            this.lblNivelJgScc = new System.Windows.Forms.Label();
            this.lblErroresJgScc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgJgScc1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgJgScc2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgJgScc)).BeginInit();
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
            // pnlPaso1
            // 
            this.pnlPaso1.AllowDrop = true;
            this.pnlPaso1.Location = new System.Drawing.Point(261, 139);
            this.pnlPaso1.Name = "pnlPaso1";
            this.pnlPaso1.Size = new System.Drawing.Size(150, 150);
            this.pnlPaso1.TabIndex = 1;
            this.pnlPaso1.Tag = "1";
            this.pnlPaso1.DragDrop += new System.Windows.Forms.DragEventHandler(this.SoltarFicha);
            this.pnlPaso1.DragEnter += new System.Windows.Forms.DragEventHandler(this.ValidarEntrada);
            // 
            // pnlPaso2
            // 
            this.pnlPaso2.AllowDrop = true;
            this.pnlPaso2.Location = new System.Drawing.Point(532, 139);
            this.pnlPaso2.Name = "pnlPaso2";
            this.pnlPaso2.Size = new System.Drawing.Size(150, 150);
            this.pnlPaso2.TabIndex = 2;
            this.pnlPaso2.Tag = "2";
            this.pnlPaso2.DragDrop += new System.Windows.Forms.DragEventHandler(this.SoltarFicha);
            this.pnlPaso2.DragEnter += new System.Windows.Forms.DragEventHandler(this.ValidarEntrada);
            // 
            // pnlPaso3
            // 
            this.pnlPaso3.AllowDrop = true;
            this.pnlPaso3.Location = new System.Drawing.Point(796, 139);
            this.pnlPaso3.Name = "pnlPaso3";
            this.pnlPaso3.Size = new System.Drawing.Size(150, 150);
            this.pnlPaso3.TabIndex = 3;
            this.pnlPaso3.Tag = "3";
            this.pnlPaso3.DragDrop += new System.Windows.Forms.DragEventHandler(this.SoltarFicha);
            this.pnlPaso3.DragEnter += new System.Windows.Forms.DragEventHandler(this.ValidarEntrada);
            // 
            // pbImgJgScc1
            // 
            this.pbImgJgScc1.Location = new System.Drawing.Point(532, 393);
            this.pbImgJgScc1.Name = "pbImgJgScc1";
            this.pbImgJgScc1.Size = new System.Drawing.Size(150, 150);
            this.pbImgJgScc1.TabIndex = 5;
            this.pbImgJgScc1.TabStop = false;
            this.pbImgJgScc1.Tag = "2";
            this.pbImgJgScc1.Click += new System.EventHandler(this.pbImgJgScc1_Click);
            this.pbImgJgScc1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.IniciarArrastre);
            // 
            // pbImgJgScc2
            // 
            this.pbImgJgScc2.Location = new System.Drawing.Point(796, 393);
            this.pbImgJgScc2.Name = "pbImgJgScc2";
            this.pbImgJgScc2.Size = new System.Drawing.Size(150, 150);
            this.pbImgJgScc2.TabIndex = 6;
            this.pbImgJgScc2.TabStop = false;
            this.pbImgJgScc2.Tag = "3";
            this.pbImgJgScc2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.IniciarArrastre);
            // 
            // pbImgJgScc
            // 
            this.pbImgJgScc.Location = new System.Drawing.Point(261, 393);
            this.pbImgJgScc.Name = "pbImgJgScc";
            this.pbImgJgScc.Size = new System.Drawing.Size(150, 150);
            this.pbImgJgScc.TabIndex = 7;
            this.pbImgJgScc.TabStop = false;
            this.pbImgJgScc.Tag = "1";
            this.pbImgJgScc.MouseDown += new System.Windows.Forms.MouseEventHandler(this.IniciarArrastre);
            // 
            // lblNivelJgScc
            // 
            this.lblNivelJgScc.AutoSize = true;
            this.lblNivelJgScc.BackColor = System.Drawing.Color.Transparent;
            this.lblNivelJgScc.Font = new System.Drawing.Font("Georgia", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivelJgScc.ForeColor = System.Drawing.Color.DarkKhaki;
            this.lblNivelJgScc.Location = new System.Drawing.Point(12, 578);
            this.lblNivelJgScc.Name = "lblNivelJgScc";
            this.lblNivelJgScc.Size = new System.Drawing.Size(141, 43);
            this.lblNivelJgScc.TabIndex = 8;
            this.lblNivelJgScc.Text = "Nivel: ";
            // 
            // lblErroresJgScc
            // 
            this.lblErroresJgScc.AutoSize = true;
            this.lblErroresJgScc.BackColor = System.Drawing.Color.Transparent;
            this.lblErroresJgScc.Font = new System.Drawing.Font("Georgia", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErroresJgScc.ForeColor = System.Drawing.Color.Brown;
            this.lblErroresJgScc.Location = new System.Drawing.Point(923, 578);
            this.lblErroresJgScc.Name = "lblErroresJgScc";
            this.lblErroresJgScc.Size = new System.Drawing.Size(216, 43);
            this.lblErroresJgScc.TabIndex = 9;
            this.lblErroresJgScc.Text = "Errores: 0";
            // 
            // JuegSeccProcProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROYECTOMANGO.Properties.Resources.fondsiem123;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1180, 630);
            this.Controls.Add(this.lblErroresJgScc);
            this.Controls.Add(this.lblNivelJgScc);
            this.Controls.Add(this.pbImgJgScc);
            this.Controls.Add(this.pbImgJgScc2);
            this.Controls.Add(this.pbImgJgScc1);
            this.Controls.Add(this.pnlPaso3);
            this.Controls.Add(this.pnlPaso2);
            this.Controls.Add(this.pnlPaso1);
            this.Controls.Add(this.btnVolverJuegSecc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "JuegSeccProcProd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JuegSeccProcProd";
            ((System.ComponentModel.ISupportInitialize)(this.pbImgJgScc1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgJgScc2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgJgScc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void pbImgJgScc1_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private System.Windows.Forms.Button btnVolverJuegSecc;
        private System.Windows.Forms.Panel pnlPaso1;
        private System.Windows.Forms.Panel pnlPaso2;
        private System.Windows.Forms.Panel pnlPaso3;
        private System.Windows.Forms.PictureBox pbImgJgScc1;
        private System.Windows.Forms.PictureBox pbImgJgScc2;
        private System.Windows.Forms.PictureBox pbImgJgScc;
        private System.Windows.Forms.Label lblNivelJgScc;
        private System.Windows.Forms.Label lblErroresJgScc;
    }
}