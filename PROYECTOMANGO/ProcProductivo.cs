using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTOBETA001
{
    public partial class ProcProductivo : Form
    {
       
        public ProcProductivo()
        {
            InitializeComponent();
        }

        private void bttSiembra_Click(object sender, EventArgs e)
        {
            panelSiembra.Visible = true;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelSiembra.Visible = false;
            panel2Siembra.Visible = false;
        }

        private void bttSiguiente1_Click(object sender, EventArgs e)
        {
            panel2Siembra.Visible = true;
        }

        private void bttRegresar1_Click(object sender, EventArgs e)
        {
            panel2Siembra.Visible = false;
            panelSiembra.Visible = true;
        }

        private void bttSig2_Click(object sender, EventArgs e)
        {

        }

        private void ProcProductivo_Load(object sender, EventArgs e)
        {
            panelSiembra.Visible = false;
            panel2Siembra.Visible = false;
        }

        private void bttRegreProc_Click(object sender, EventArgs e)
        {
            Interfazprinc f23fws = new Interfazprinc();
            f23fws.Show();
            this.Hide();

        }
    }
}
