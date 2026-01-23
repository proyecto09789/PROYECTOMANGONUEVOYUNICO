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
    "🥭 DATO 1\n\n" +
    "El mango es originario del sur de Asia\n" +
    "y se cultiva desde hace más de 4,000 años.",

    "🥭 DATO 2\n\n" +
    "El mango es una fruta tropical\n" +
    "que pertenece al grupo de las drupas.",

    "🥭 DATO 3\n\n" +
    "El mango está relacionado con\n" +
    "los anacardos y los pistachos\n" +
    "porque pertenecen a la misma familia.",

    "🥭 DATO 4\n\n" +
    "Existen más de 1,000 variedades\n" +
    "de mango en todo el mundo.",

    "🥭 DATO 5\n\n" +
    "El famoso patrón paisley\n" +
    "está inspirado en la forma del mango.",

    "🥭 DATO 6\n\n" +
    "Un árbol de mango puede vivir\n" +
    "más de 100 años y seguir dando frutos.",

    "🥭 DATO 7\n\n" +
    "El hueso del mango se llama semilla\n" +
    "y se encuentra en el centro del fruto.",

    "🥭 DATO 8\n\n" +
    "Gracias a su fibra natural,\n" +
    "el mango ayuda a mejorar la digestión.",

    "🥭 DATO 9\n\n" +
    "El mango es conocido como\n" +
    "el Rey de las Frutas en muchos países.",

    "🥭 DATO 10\n\n" +
    "El mango crece mejor en climas\n" +
    "tropicales con temperaturas cálidas."
        };
        public Datoscuriosooi()
        {
            InitializeComponent();
            MostrarDato();
        }
        void MostrarDato()
        {
            lblDatos.Text = datos[indice];
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
