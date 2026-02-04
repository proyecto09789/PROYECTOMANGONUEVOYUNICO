using PROYECTOBETA001;
using System;
using System.Windows.Forms;

namespace PROYECTOMANGO
{
    public partial class FormResultados : Form
    {
        public FormResultados(
            string[] preguntas,
            string[,] opciones,
            int[] respuestasCorrectas,
            bool[] resultados,
            int puntos)
        {
            InitializeComponent();

            lblPuntaje.Text = $"Puntaje final: {puntos} / {resultados.Length}";


            lstResultados.Items.Clear();

            for (int i = 0; i < resultados.Length; i++)

            {
                string estado = resultados[i] ? "✔ Correcta" : "❌ Incorrecta";
                string respuestaCorrecta = opciones[i, respuestasCorrectas[i]];

                lstResultados.Items.Add($"Pregunta {i + 1}");
                lstResultados.Items.Add(preguntas[i]);
                lstResultados.Items.Add($"Estado: {estado}");
                lstResultados.Items.Add($"Respuesta correcta: {respuestaCorrecta}");
                lstResultados.Items.Add("---------------------------------------------------------------"); 
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
