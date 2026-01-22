using PROYECTOMANGO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTOBETA001
{
        public partial class Datoscuriosooi : Form
    {
        int indice = 0;

        string[] datos = new string[]
        {
            "El mango es una fruta tropical originaria del sur de Asia.",
            "Existen más de 1,000 variedades de mango en todo el mundo.",
            "El mango es una drupa, igual que el durazno.",
            "Es rico en vitamina C y vitamina A.",
            "Un árbol de mango puede vivir más de 100 años.",
            "India es el mayor productor de mango del mundo.",
            "El mango ayuda a la digestión.",
            "Su semilla es muy grande en comparación con otras frutas.",
            "El mango es conocido como el rey de las frutas.",
            "El mango crece en climas tropicales."
        };
        public Datoscuriosooi()
        {
            InitializeComponent();
            MostrarDato();
        }
        void MostrarDato()
        {
            txtDatos.Text = datos[indice];
            lblContador.Text = $"Dato {indice + 1} de {datos.Length}";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (indice < datos.Length - 1)
            {
                indice++;
                MostrarDato();
            }
            else
            {
                FormPreguntas fp = new FormPreguntas();
                fp.Show();
                this.Close();
            }
            }

        private void bntAnterio_Click(object sender, EventArgs e)
        {
            if (indice > 0)
            {
                indice--;
                MostrarDato();
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Interfazprinc frme2 = new Interfazprinc(); 
            frme2.Show();
            this.Hide();
        }

        private void LinkFuentes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.mango.org/mango-facts/",
                UseShellExecute = true
            });
        }
    }
}
