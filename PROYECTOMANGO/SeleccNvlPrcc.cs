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
    public partial class SeleccNvlPrcc : Form
    {
        public SeleccNvlPrcc()
        {
            InitializeComponent();
        }

        private void btnNvlFacil_Click(object sender, EventArgs e)
        {
            JuegSeccProcProd juego = new JuegSeccProcProd(1);
            juego.Show();
            this.Hide();
        }

        private void btnNvlMedio_Click(object sender, EventArgs e)
        {
            JuegSeccProcProd juego = new JuegSeccProcProd(2);
            juego.Show();
            this.Hide();
        }
        private void btnNvlDificil_Click(object sender, EventArgs e)
        {
            JuegSeccProcProd juego = new JuegSeccProcProd(3);
            juego.Show();
            this.Hide();
        }

        private void btnVolverSelecc_Click(object sender, EventArgs e)
        {
            ProcProductivo procProductivo = new ProcProductivo();
            procProductivo.Show();
            this.Hide();
        }

        private void btnComoSeJuega_Click(object sender, EventArgs e)
        {
            pnlComoSeJuega.Visible = true;
            pnlComoSeJuega.BringToFront();
        }

        private void BtnXPnlCmJg_Click(object sender, EventArgs e)
        {
            pnlComoSeJuega.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
