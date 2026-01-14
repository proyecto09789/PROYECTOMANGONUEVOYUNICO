namespace PROYECTOMANGO
{
    partial class CuidaALaMascota
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelJuego;
        private System.Windows.Forms.Panel panelPlanta;
        private System.Windows.Forms.Panel panelMascota;
        private System.Windows.Forms.Label lblOjos;
        private System.Windows.Forms.Label lblBoca;
        private System.Windows.Forms.Label lblBrazos;
        private System.Windows.Forms.Label lblPiernas;
        private System.Windows.Forms.Panel panelEstadisticas;
        private System.Windows.Forms.Label lblVidaTitulo;
        private System.Windows.Forms.ProgressBar pbVida;
        private System.Windows.Forms.Label lblVidaValor;
        private System.Windows.Forms.Label lblComidaTitulo;
        private System.Windows.Forms.ProgressBar pbComida;
        private System.Windows.Forms.Label lblComidaValor;
        private System.Windows.Forms.Label lblEnergiaTitulo;
        private System.Windows.Forms.ProgressBar pbEnergia;
        private System.Windows.Forms.Label lblEnergiaValor;
        private System.Windows.Forms.Label lblFelicidadTitulo;
        private System.Windows.Forms.ProgressBar pbFelicidad;
        private System.Windows.Forms.Label lblFelicidadValor;
        private System.Windows.Forms.Button btnRegar;
        private System.Windows.Forms.Button btnAlimentar;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Button btnDormir;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Label lblMensaje;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelJuego = new System.Windows.Forms.Panel();
            this.panelPlanta = new System.Windows.Forms.Panel();
            this.panelMascota = new System.Windows.Forms.Panel();
            this.lblOjos = new System.Windows.Forms.Label();
            this.lblBoca = new System.Windows.Forms.Label();
            this.lblBrazos = new System.Windows.Forms.Label();
            this.lblPiernas = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.panelEstadisticas = new System.Windows.Forms.Panel();
            this.lblVidaTitulo = new System.Windows.Forms.Label();
            this.pbVida = new System.Windows.Forms.ProgressBar();
            this.lblVidaValor = new System.Windows.Forms.Label();
            this.lblComidaTitulo = new System.Windows.Forms.Label();
            this.pbComida = new System.Windows.Forms.ProgressBar();
            this.lblComidaValor = new System.Windows.Forms.Label();
            this.lblEnergiaTitulo = new System.Windows.Forms.Label();
            this.pbEnergia = new System.Windows.Forms.ProgressBar();
            this.lblEnergiaValor = new System.Windows.Forms.Label();
            this.lblFelicidadTitulo = new System.Windows.Forms.Label();
            this.pbFelicidad = new System.Windows.Forms.ProgressBar();
            this.lblFelicidadValor = new System.Windows.Forms.Label();
            this.btnRegar = new System.Windows.Forms.Button();
            this.btnAlimentar = new System.Windows.Forms.Button();
            this.btnJugar = new System.Windows.Forms.Button();
            this.btnDormir = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.panelJuego.SuspendLayout();
            this.panelMascota.SuspendLayout();
            this.panelEstadisticas.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelJuego
            // 
            this.panelJuego.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(206)))), ((int)(((byte)(235)))));
            this.panelJuego.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelJuego.Controls.Add(this.panelPlanta);
            this.panelJuego.Controls.Add(this.panelMascota);
            this.panelJuego.Controls.Add(this.lblMensaje);
            this.panelJuego.Location = new System.Drawing.Point(20, 80);
            this.panelJuego.Name = "panelJuego";
            this.panelJuego.Size = new System.Drawing.Size(560, 400);
            this.panelJuego.TabIndex = 0;
            // 
            // panelPlanta
            // 
            this.panelPlanta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(69)))), ((int)(((byte)(19)))));
            this.panelPlanta.Location = new System.Drawing.Point(210, 280);
            this.panelPlanta.Name = "panelPlanta";
            this.panelPlanta.Size = new System.Drawing.Size(140, 100);
            this.panelPlanta.TabIndex = 0;
            // 
            // panelMascota
            // 
            this.panelMascota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.panelMascota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMascota.Controls.Add(this.lblOjos);
            this.panelMascota.Controls.Add(this.lblBoca);
            this.panelMascota.Controls.Add(this.lblBrazos);
            this.panelMascota.Controls.Add(this.lblPiernas);
            this.panelMascota.Location = new System.Drawing.Point(30, -80);
            this.panelMascota.Name = "panelMascota";
            this.panelMascota.Size = new System.Drawing.Size(80, 80);
            this.panelMascota.TabIndex = 0;
            // 
            // lblOjos
            // 
            this.lblOjos.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblOjos.Location = new System.Drawing.Point(10, 15);
            this.lblOjos.Name = "lblOjos";
            this.lblOjos.Size = new System.Drawing.Size(60, 25);
            this.lblOjos.TabIndex = 0;
            this.lblOjos.Text = "◉ ◉";
            this.lblOjos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBoca
            // 
            this.lblBoca.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.lblBoca.Location = new System.Drawing.Point(10, 35);
            this.lblBoca.Name = "lblBoca";
            this.lblBoca.Size = new System.Drawing.Size(60, 30);
            this.lblBoca.TabIndex = 1;
            this.lblBoca.Text = "‿";
            this.lblBoca.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblBrazos
            // 
            this.lblBrazos.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblBrazos.Location = new System.Drawing.Point(-5, 30);
            this.lblBrazos.Name = "lblBrazos";
            this.lblBrazos.Size = new System.Drawing.Size(90, 25);
            this.lblBrazos.TabIndex = 2;
            this.lblBrazos.Text = "└ ┘";
            this.lblBrazos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPiernas
            // 
            this.lblPiernas.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblPiernas.Location = new System.Drawing.Point(10, 55);
            this.lblPiernas.Name = "lblPiernas";
            this.lblPiernas.Size = new System.Drawing.Size(60, 20);
            this.lblPiernas.TabIndex = 3;
            this.lblPiernas.Text = "| |";
            this.lblPiernas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblMensaje
            // 
            this.lblMensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.lblMensaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMensaje.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.lblMensaje.Location = new System.Drawing.Point(150, 30);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(260, 50);
            this.lblMensaje.TabIndex = 1;
            this.lblMensaje.Text = "¡Hola! Soy Manguito 🥭";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelEstadisticas
            // 
            this.panelEstadisticas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelEstadisticas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEstadisticas.Controls.Add(this.lblVidaTitulo);
            this.panelEstadisticas.Controls.Add(this.pbVida);
            this.panelEstadisticas.Controls.Add(this.lblVidaValor);
            this.panelEstadisticas.Controls.Add(this.lblComidaTitulo);
            this.panelEstadisticas.Controls.Add(this.pbComida);
            this.panelEstadisticas.Controls.Add(this.lblComidaValor);
            this.panelEstadisticas.Controls.Add(this.lblEnergiaTitulo);
            this.panelEstadisticas.Controls.Add(this.pbEnergia);
            this.panelEstadisticas.Controls.Add(this.lblEnergiaValor);
            this.panelEstadisticas.Controls.Add(this.lblFelicidadTitulo);
            this.panelEstadisticas.Controls.Add(this.pbFelicidad);
            this.panelEstadisticas.Controls.Add(this.lblFelicidadValor);
            this.panelEstadisticas.Location = new System.Drawing.Point(20, 500);
            this.panelEstadisticas.Name = "panelEstadisticas";
            this.panelEstadisticas.Size = new System.Drawing.Size(560, 150);
            this.panelEstadisticas.TabIndex = 1;
            // 
            // lblVidaTitulo
            // 
            this.lblVidaTitulo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblVidaTitulo.ForeColor = System.Drawing.Color.Red;
            this.lblVidaTitulo.Location = new System.Drawing.Point(15, 15);
            this.lblVidaTitulo.Name = "lblVidaTitulo";
            this.lblVidaTitulo.Size = new System.Drawing.Size(80, 20);
            this.lblVidaTitulo.TabIndex = 0;
            this.lblVidaTitulo.Text = "❤️ Vida:";
            // 
            // pbVida
            // 
            this.pbVida.ForeColor = System.Drawing.Color.Red;
            this.pbVida.Location = new System.Drawing.Point(100, 15);
            this.pbVida.Name = "pbVida";
            this.pbVida.Size = new System.Drawing.Size(400, 20);
            this.pbVida.TabIndex = 1;
            this.pbVida.Value = 100;
            // 
            // lblVidaValor
            // 
            this.lblVidaValor.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblVidaValor.Location = new System.Drawing.Point(510, 15);
            this.lblVidaValor.Name = "lblVidaValor";
            this.lblVidaValor.Size = new System.Drawing.Size(40, 20);
            this.lblVidaValor.TabIndex = 2;
            this.lblVidaValor.Text = "100";
            this.lblVidaValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblComidaTitulo
            // 
            this.lblComidaTitulo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblComidaTitulo.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblComidaTitulo.Location = new System.Drawing.Point(15, 50);
            this.lblComidaTitulo.Name = "lblComidaTitulo";
            this.lblComidaTitulo.Size = new System.Drawing.Size(80, 20);
            this.lblComidaTitulo.TabIndex = 3;
            this.lblComidaTitulo.Text = "🍎 Comida:";
            // 
            // pbComida
            // 
            this.pbComida.ForeColor = System.Drawing.Color.Orange;
            this.pbComida.Location = new System.Drawing.Point(100, 50);
            this.pbComida.Name = "pbComida";
            this.pbComida.Size = new System.Drawing.Size(400, 20);
            this.pbComida.TabIndex = 4;
            this.pbComida.Value = 80;
            // 
            // lblComidaValor
            // 
            this.lblComidaValor.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblComidaValor.Location = new System.Drawing.Point(510, 50);
            this.lblComidaValor.Name = "lblComidaValor";
            this.lblComidaValor.Size = new System.Drawing.Size(40, 20);
            this.lblComidaValor.TabIndex = 5;
            this.lblComidaValor.Text = "80";
            this.lblComidaValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEnergiaTitulo
            // 
            this.lblEnergiaTitulo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblEnergiaTitulo.ForeColor = System.Drawing.Color.Blue;
            this.lblEnergiaTitulo.Location = new System.Drawing.Point(15, 85);
            this.lblEnergiaTitulo.Name = "lblEnergiaTitulo";
            this.lblEnergiaTitulo.Size = new System.Drawing.Size(80, 20);
            this.lblEnergiaTitulo.TabIndex = 6;
            this.lblEnergiaTitulo.Text = "⚡ Energía:";
            // 
            // pbEnergia
            // 
            this.pbEnergia.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.pbEnergia.Location = new System.Drawing.Point(100, 85);
            this.pbEnergia.Name = "pbEnergia";
            this.pbEnergia.Size = new System.Drawing.Size(400, 20);
            this.pbEnergia.TabIndex = 7;
            this.pbEnergia.Value = 70;
            // 
            // lblEnergiaValor
            // 
            this.lblEnergiaValor.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblEnergiaValor.Location = new System.Drawing.Point(510, 85);
            this.lblEnergiaValor.Name = "lblEnergiaValor";
            this.lblEnergiaValor.Size = new System.Drawing.Size(40, 20);
            this.lblEnergiaValor.TabIndex = 8;
            this.lblEnergiaValor.Text = "70";
            this.lblEnergiaValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFelicidadTitulo
            // 
            this.lblFelicidadTitulo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblFelicidadTitulo.ForeColor = System.Drawing.Color.HotPink;
            this.lblFelicidadTitulo.Location = new System.Drawing.Point(15, 120);
            this.lblFelicidadTitulo.Name = "lblFelicidadTitulo";
            this.lblFelicidadTitulo.Size = new System.Drawing.Size(80, 20);
            this.lblFelicidadTitulo.TabIndex = 9;
            this.lblFelicidadTitulo.Text = "😊 Humor:";
            // 
            // pbFelicidad
            // 
            this.pbFelicidad.ForeColor = System.Drawing.Color.DeepPink;
            this.pbFelicidad.Location = new System.Drawing.Point(100, 120);
            this.pbFelicidad.Name = "pbFelicidad";
            this.pbFelicidad.Size = new System.Drawing.Size(400, 20);
            this.pbFelicidad.TabIndex = 10;
            this.pbFelicidad.Value = 90;
            // 
            // lblFelicidadValor
            // 
            this.lblFelicidadValor.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblFelicidadValor.Location = new System.Drawing.Point(510, 120);
            this.lblFelicidadValor.Name = "lblFelicidadValor";
            this.lblFelicidadValor.Size = new System.Drawing.Size(40, 20);
            this.lblFelicidadValor.TabIndex = 11;
            this.lblFelicidadValor.Text = "90";
            this.lblFelicidadValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRegar
            // 
            this.btnRegar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.btnRegar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegar.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnRegar.Location = new System.Drawing.Point(20, 670);
            this.btnRegar.Name = "btnRegar";
            this.btnRegar.Size = new System.Drawing.Size(130, 50);
            this.btnRegar.TabIndex = 2;
            this.btnRegar.Text = "💧 Regar";
            this.btnRegar.UseVisualStyleBackColor = false;
            // 
            // btnAlimentar
            // 
            this.btnAlimentar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(100)))));
            this.btnAlimentar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlimentar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlimentar.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnAlimentar.Location = new System.Drawing.Point(165, 670);
            this.btnAlimentar.Name = "btnAlimentar";
            this.btnAlimentar.Size = new System.Drawing.Size(130, 50);
            this.btnAlimentar.TabIndex = 3;
            this.btnAlimentar.Text = "🍎 Alimentar";
            this.btnAlimentar.UseVisualStyleBackColor = false;
            // 
            // btnJugar
            // 
            this.btnJugar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.btnJugar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJugar.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnJugar.Location = new System.Drawing.Point(310, 670);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(130, 50);
            this.btnJugar.TabIndex = 4;
            this.btnJugar.Text = "🎮 Jugar";
            this.btnJugar.UseVisualStyleBackColor = false;
            // 
            // btnDormir
            // 
            this.btnDormir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            this.btnDormir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDormir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDormir.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnDormir.Location = new System.Drawing.Point(455, 670);
            this.btnDormir.Name = "btnDormir";
            this.btnDormir.Size = new System.Drawing.Size(130, 50);
            this.btnDormir.TabIndex = 5;
            this.btnDormir.Text = "😴 Dormir";
            this.btnDormir.UseVisualStyleBackColor = false;
            // 
            // lblEstado
            // 
            this.lblEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(200)))));
            this.lblEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEstado.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold);
            this.lblEstado.Location = new System.Drawing.Point(20, 20);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(420, 45);
            this.lblEstado.TabIndex = 6;
            this.lblEstado.Text = "🌱 Cuida a Manguito";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNivel
            // 
            this.lblNivel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.lblNivel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNivel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblNivel.Location = new System.Drawing.Point(455, 20);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(125, 45);
            this.lblNivel.TabIndex = 7;
            this.lblNivel.Text = "Nivel: Semilla\r\nExp: 0/100";
            this.lblNivel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CuidaALaMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(661, 740);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnDormir);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.btnAlimentar);
            this.Controls.Add(this.btnRegar);
            this.Controls.Add(this.panelEstadisticas);
            this.Controls.Add(this.panelJuego);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CuidaALaMascota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuida a Manguito 🥭";
            this.panelJuego.ResumeLayout(false);
            this.panelMascota.ResumeLayout(false);
            this.panelEstadisticas.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}