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

        private void cmbTemas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTemas.Text == "El Ahoyado")
            {
                lblTituloTema.Text = "Dimensiones del Agujero";
                lblDescripcion.Text = "Para el mango, se recomienda cavar un hueco de 40x40x40 cm. " +
                                      "Es vital mezclar la tierra extraída con abono orgánico antes de volver a llenar.";
            }
        }

        private void lblTituloTema_Click(object sender, EventArgs e)
        {

        }
    }
}
