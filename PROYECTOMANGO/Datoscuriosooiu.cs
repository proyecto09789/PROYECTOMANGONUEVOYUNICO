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
    "El mango es una fruta tropical\n" +
    "que pertenece al grupo de las drupas.",

    "🥭 DATO 2\n\n" +
    "El mango es una excelente fuente\n" +
    "de vitamina C y vitamina A.",

    "🥭 DATO 3\n\n" +
    "Existen más de 1,000 variedades\n" +
    "de mango cultivadas en todo el mundo.",

    "🥭 DATO 4\n\n" +
    "El mango se cultiva en más de\n" +
    "100 países alrededor del planeta.",

    "🥭 DATO 5\n\n" +
    "India es el mayor productor de mango\n" +
    "a nivel mundial.",

    "🥭 DATO 6\n\n" +
    "El mango es la fruta nacional\n" +
    "de países como India, Pakistán\n" +
    "y Filipinas.",

    "🥭 DATO 7\n\n" +
    "Los mangos pueden tener colores\n" +
    "amarillo, verde, naranja o rojo.",

    "🥭 DATO 8\n\n" +
    "El mango contiene antioxidantes\n" +
    "que ayudan a proteger el cuerpo.",

    "🥭 DATO 9\n\n" +
    "El árbol de mango puede vivir\n" +
    "más de 100 años.",

    "🥭 DATO 10\n\n" +
    "El mango es una de las frutas\n" +
    "más consumidas en el mundo."
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
