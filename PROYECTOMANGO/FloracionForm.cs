using PROYECTOBETA001;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTOMANGO
{
    public partial class FloracionForm : Form
    {
        public FloracionForm()
        {
            InitializeComponent();
        }

        private void btnVolverFloracion_Click(object sender, EventArgs e)
        {
            ProcProductivo procProductivo = new ProcProductivo();
            procProductivo.Show();
            this.Hide();    
        }
        private void CargarFromulario(object formHijo)
        {

            if (this.AbrirFormPnlFloracion.Controls.Count > 0)
                this.AbrirFormPnlFloracion.Controls.RemoveAt(0);

            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            fh.FormBorderStyle = FormBorderStyle.None;

            this.AbrirFormPnlFloracion.Controls.Add(fh);
            this.AbrirFormPnlFloracion.Tag = fh;
            fh.Show();
        }

        private void cmbTemasFloracion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temaSeleccionado = cmbTemasFloracion.SelectedItem.ToString();
            switch (temaSeleccionado)
            {
                case "Inducción Floral":
                    CargarFromulario(new InduccionFloral());
                    break;
                case "Polinización Natural":
                    CargarFromulario(new PolinizacionNatural());
                    break;
                case "Enfermedades (Antracnosis)":
                    CargarFromulario(new EnfermedadesAntracnosis());
                    break;
                case "El Cuajado del Fruto":
                    CargarFromulario(new CuajadoDelFruto());
                    break;
                case "Riego Controlado":
                    CargarFromulario(new RiegoControlado());
                    break;
            }

        }

        private void btnRefFloracion_Click(object sender, EventArgs e)
        {
            pnlRefFloracion.Visible = true;
            pnlRefFloracion.BringToFront();
        }

        private void btnRefPnlFlora_Click(object sender, EventArgs e)
        {
            pnlRefFloracion.Visible = false;
        }

        private void btnCerrarFlora_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
