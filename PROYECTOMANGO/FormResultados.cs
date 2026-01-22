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
    public partial class FormResultados : Form
    {
        public FormResultados
            (
            string[] preguntas,
            string[,] opciones,
            int[] respuestasCorrectas,
            bool[] resultados,
            int puntos)
        {
            InitializeComponent();
            lblPuntaje.Text = $"Puntaje final: {puntos} / {preguntas.Length}";
            for (int i = 0; i < preguntas.Length; i++)
            {
                string estado = resultados[i] ? "✔ Correcta" : "❌ Incorrecta";
                string respuestaCorrecta = opciones[i, respuestasCorrectas[i]];

                lstResultados.Items.Add($"Pregunta {i + 1}: {estado}");
                lstResultados.Items.Add($"   Respuesta correcta: {respuestaCorrecta}");
                lstResultados.Items.Add("");
            }
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            Interfazprinc inicio = new Interfazprinc();
            inicio.Show();
            this.Close();
        }
    }
}
