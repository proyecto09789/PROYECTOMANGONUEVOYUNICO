using PROYECTOBETA001;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Org.BouncyCastle.Tls.Crypto.Impl.BC;

namespace PROYECTOMANGO
{
    public partial class SiembraForm : Form
    {
        public SiembraForm()
        {
            InitializeComponent();
        }

        private void btnVolverSiembra_Click(object sender, EventArgs e)
        {
            ProcProductivo procProductivo = new ProcProductivo();
            procProductivo.Show();
            this.Hide();
        }

        private void CargarFromulario (object formHijo)
        {
            
            if (this.AbrirFormPnlSiembra.Controls.Count > 0)
                this.AbrirFormPnlSiembra.Controls.RemoveAt(0);

            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            fh.FormBorderStyle = FormBorderStyle.None;

            this.AbrirFormPnlSiembra.Controls.Add(fh);
            this.AbrirFormPnlSiembra.Tag = fh;
            fh.Show();
        }

        private void cmbTemas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temaSeleccionado = cmbTemas.SelectedItem.ToString();

            switch (temaSeleccionado)
            {
                case "Selección del Terreno":
                    CargarFromulario(new SeleccDeTerren());
                    break;

                case "Preparación de la Semilla":
                    CargarFromulario(new PrepraSemilla());
                    break;
                case "El Ahoyado":
                    CargarFromulario(new Ahoyado());
                    break;
                case "El Transplante":
                    CargarFromulario(new ElTrasplante());
                    break;
                case "Riego Inicial":
                    CargarFromulario(new RiegoInicial());
                    break;
            }
        }

        private void SiembraForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRefSiembra_Click(object sender, EventArgs e)
        {
            pnlRefSiembra.Visible = true;
            pnlRefSiembra.BringToFront();
        }

        private void btnRefPnlSiembra_Click(object sender, EventArgs e)
        {
            pnlRefSiembra.Visible = false;
        }

        private void btnCerrarSiembra_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
