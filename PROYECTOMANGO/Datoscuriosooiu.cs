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
        public partial class Datoscuriosooi : Form
    {
        int indice = 0;

        string[] datos = new string[]
        {
            "El mango es una de las frutas más antiguas del mundo: se cultiva desde hace más de 4.000 años, sobre todo en la India.",
            "El árbol del mango puede vivir muchísimo: algunos pueden vivir más de 100 años y seguir dando frutos.",
            "Existe en muchos tipos: hay más de 1.000 variedades de mango en todo el mundo, con distintos tamaños, colores y sabores.",
        };
        public Datoscuriosooi()
        {
            InitializeComponent();
            MostrarDato();
        }
        void MostrarDato()
        {
            labelDatos.Text = datos[indice];
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
    }
}
