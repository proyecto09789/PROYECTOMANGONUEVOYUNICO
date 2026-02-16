using PROYECTOMANGO;
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
            SiembraForm siembraForm = new SiembraForm();
            siembraForm.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void bttSiguiente1_Click(object sender, EventArgs e)
        {
            
        }

        private void bttRegresar1_Click(object sender, EventArgs e)
        {
         
        }

        private void bttSig2_Click(object sender, EventArgs e)
        {

        }

        private void ProcProductivo_Load(object sender, EventArgs e)
        {
           
        }

        private void bttRegreProc_Click(object sender, EventArgs e)
        {
            Interfazprinc f23fws = new Interfazprinc();
            f23fws.Show();
            this.Hide();

        }

        private void bttFloracio_Click(object sender, EventArgs e)
        {
            FloracionForm floracionForm = new FloracionForm();
            floracionForm.Show();
            this.Hide();
        }

        private void bttCosecha_Click(object sender, EventArgs e)
        {
            CosechaForm cosechaForm = new CosechaForm();
            cosechaForm.Show();
            this.Hide();
        }

        private void btnJuegInteractivoProcProduct_Click(object sender, EventArgs e)
        {
            SeleccNvlPrcc seleccionNivel = new SeleccNvlPrcc();
            seleccionNivel.Show();
            this.Hide();
        }

        private void btnCerrarPrcMang_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
