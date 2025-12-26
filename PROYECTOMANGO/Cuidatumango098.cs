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
    public partial class Cuidatumango098 : Form

    {
        int hambre = 100;
        int sed = 100;
        public Cuidatumango098()
        {
            InitializeComponent();
            progressBar1.Value = hambre;
            progressBar2.Value = sed;

            timerEstado.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (hambre <= 90)
                hambre += 10;
            else
            {
                hambre = 100;
                progressBar1.Value = hambre;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hambre > 0) hambre--;
            if (sed > 0) sed--;

            progressBar1.Value = hambre;
            progressBar2.Value = sed;

            if (hambre == 0 || sed == 0)
            {
                timerEstado.Stop();
                MessageBox.Show("manguito esta mal :(");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sed <= 90)
                sed += 10;
            else
            {
                sed = 100;
                progressBar2.Value = sed;
            }
        }

        private void REGREMANG_Click(object sender, EventArgs e)
        {
            Interfazprinc h56s = new Interfazprinc();
            h56s.Show();
            this.Hide();

        }
    }
}
