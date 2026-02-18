using PROYECTOBETA001;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static PROYECTOMANGO.FormPreguntas;

namespace PROYECTOMANGO
{
    public partial class FormResultados : Form
    {
        public FormResultados(List<Preguntas> preguntas, bool[] resultados, int puntos)
        {
            InitializeComponent();
            this.FormClosing += FormResultados_FormClosing;


            lblPuntaje.Text = $"Puntaje final: {puntos} / {preguntas.Count}";


            lstResultados.Items.Clear();

            for (int i = 0; i < preguntas.Count; i++)

            {
                string estado = resultados[i] ? "✔ Correcta" : "❌ Incorrecta";
                string correcta = preguntas[i].Opciones[preguntas[i].Correcta];

                lstResultados.Items.Add($"Pregunta {i + 1}");
                lstResultados.Items.Add(preguntas[i].Texto);
                lstResultados.Items.Add($"Respuesta: {estado}");
                lstResultados.Items.Add($"Respuesta correcta: {correcta}");
                lstResultados.Items.Add("---------------------------------------------------------------");
            }
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            Interfazprinc inicio = new Interfazprinc();
            inicio.Show();

            cerrandoPorCodigo = true;
            this.Close();
        }

        private void btnNivel_Click(object sender, EventArgs e)
        {
            FormInstrucciones1 f = new FormInstrucciones1();
            f.Show();

            cerrandoPorCodigo = true;
            this.Close();
        }
        bool cerrandoPorCodigo = false;

        private void FormResultados_FormClosing(object sender, FormClosingEventArgs e)
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
