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

            cerrandoPorCodigo = true;
            this.Close();
        }

        private void BtnInter_Click(object sender, EventArgs e)
        {
            FormPreguntas fp = new FormPreguntas(2);
            fp.Show();

            cerrandoPorCodigo = true;
            this.Close(); ;
        }

        private void BtnHard_Click(object sender, EventArgs e)
        {
            FormPreguntas fp = new FormPreguntas(3);
            fp.Show();

            cerrandoPorCodigo = true;
            this.Close();
        }

        bool cerrandoPorCodigo = false;
        private void FormInstrucciones1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!cerrandoPorCodigo && e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult resultado = MessageBox.Show(
                    "¿Seguro que quieres cerrar?",
                    "Confirmar salida",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (resultado == DialogResult.No)
                    e.Cancel = true;
            }
        }
    }
}
