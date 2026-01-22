using PROYECTOBETA001;
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
    public partial class FormPreguntas : Form
    {
        int indice = 0;
        int puntos = 0;

        string[] preguntas =
        {
            "¿De dónde es originario el mango?",
            "¿Qué tipo de fruta es el mango?",
            "¿Qué vitamina abunda en el mango?",
            "¿Cuántas variedades de mango existen?",
            "¿Qué país es el mayor productor de mango?",
            "¿Cuántos años puede vivir un árbol de mango?",
            "¿Cómo se llama el hueso del mango?",
            "¿El mango ayuda a qué proceso?",
            "¿Cómo se conoce al mango?",
            "¿El mango pertenece a qué clima?"
        };

        string[,] opciones =
        {
            { "África", "Asia", "América" },
            { "Cítrico", "Drupa", "Baya" },
            { "Vitamina C", "Vitamina D", "Vitamina B12" },
            { "10", "Más de 1000", "50" },
            { "México", "India", "Brasil" },
            { "20 años", "50 años", "Más de 100 años" },
            { "Cáscara", "Semilla", "Pulpa" },
            { "La respiración", "La digestión", "La vista" },
            { "Rey de las frutas", "Fruta dorada", "Fruta dulce" },
            { "Frío", "Templado", "Tropical" }
        };

        int [] respuestasCorrectas = { 1, 1, 0, 1, 1, 2, 1, 1, 0, 2 };
        public FormPreguntas()
        {
            InitializeComponent();
            MostrarPreguntas();
        }

        void MostrarPreguntas()
        {
            lblPreguntas.Text = preguntas[indice];
            rbOpcion1.Text = opciones[indice, 0];
            rbOpcion2.Text = opciones[indice, 1];
            rbOpcion3.Text = opciones[indice, 2];

            rbOpcion1.Checked = rbOpcion2.Checked = rbOpcion3.Checked = false;
            lblContador.Text = $"Pregunta {indice + 1} de {preguntas.Length}";
        }

        private void btnResponder_Click(object sender, EventArgs e)
        {
            int seleccion = -1;

            if (rbOpcion1.Checked) seleccion = 0;
            if (rbOpcion2.Checked) seleccion = 1;
            if (rbOpcion3.Checked) seleccion = 2;

            if (seleccion == -1)
            {
                MessageBox.Show("Selecciona una opción");
                return;
            }

            if (seleccion == respuestasCorrectas[indice])
            {
                puntos++;
                MessageBox.Show("¡Correcto! :D");
            }
            else
            {
                MessageBox.Show("Incorrecto :(");
            }

            indice++;

            if (indice < preguntas.Length)
            {
                MostrarPreguntas();
            }
            else
            {
                MessageBox.Show($"Quiz terminado\nPuntaje: {puntos} / {preguntas.Length}");

                // Volver al inicio
                Interfazprinc f = new Interfazprinc();
                f.Show();
                this.Close();
            }
        }

        private void labelTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
