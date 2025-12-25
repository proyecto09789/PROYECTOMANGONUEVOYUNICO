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
    public partial class Interfazprinc : Form
    {
        public Interfazprinc()
        {
            InitializeComponent();
        }

        private void Interfazprinc_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcProductivo f23s = new ProcProductivo();
            f23s.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mangomayinterf hg46 = new mangomayinterf();
            hg46.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
