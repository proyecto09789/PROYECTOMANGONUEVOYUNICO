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
    public partial class FormInstrucciones1 : Form
    {
        public FormInstrucciones1()
        {
            InitializeComponent();
        }

        private void FormInstrucciones1_Load(object sender, EventArgs e)
        {

        }

        private void BtnEasy_Click(object sender, EventArgs e)
        {
            FormPreguntas fp = new FormPreguntas(1);
            fp.Show();
            this.Hide();
        }

        private void BtnInter_Click(object sender, EventArgs e)
        {
            FormPreguntas fp = new FormPreguntas(2);
            fp.Show();
            this.Hide();
        }

        private void BtnHard_Click(object sender, EventArgs e)
        {
            FormPreguntas fp = new FormPreguntas(3);
            fp.Show();
            this.Hide();
        }
    }
}
