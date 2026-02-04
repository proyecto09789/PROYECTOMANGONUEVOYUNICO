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
            int nivel;
            int totalPreguntasNivel;
            TimeSpan tiempoRestante;

            bool[] respuestasUsuario;

            string[] preguntas =
            {
            "¿De dónde es originario el mango?",
            "¿Qué tipo de fruta es el mango?",
            "¿Con qué frutos secos está relacionado el mango?",
            "¿Cuántas variedades de mango existen aproximadamente?",
            "¿Qué diseño famoso está inspirado en la forma del mango?",
            "¿Cuántos años puede vivir un árbol de mango?",
            "¿Cómo se llama el hueso del mango?",
            "¿El mango ayuda a qué proceso del cuerpo?",
            "¿Cómo se conoce al mango por su importancia?",
            "¿El mango pertenece a qué clima?"
            };

            string[,] opciones =
            {
            { "África", "Asia", "América" },
            { "Cítrico", "Drupa", "Baya" },
            { "Almendras", "Anacardos y pistachos", "Nueces" },
            { "10", "Más de 1000", "50" },
            { "Patrón paisley", "Diseño floral", "Espiral" },
            { "20 años", "50 años", "Más de 100 años" },
            { "Cáscara", "Semilla", "Pulpa" },
            { "La respiración", "La digestión", "La vista" },
            { "Fruta dorada", "Rey de las frutas", "Fruta dulce" },
            { "Frío", "Templado", "Tropical" }
            };

            int[] respuestasCorrectas = { 1, 1, 1, 1, 0, 2, 1, 1, 1, 2 };


            public FormPreguntas(int nivelSeleccionado)
            {
                InitializeComponent();

                nivel = nivelSeleccionado;
                ConfigurarNivel();

                respuestasUsuario = new bool[totalPreguntasNivel];

                MostrarPreguntas();
                timer1.Start();
            }
            void ConfigurarNivel()
            {
                if (nivel == 1)
                {
                    totalPreguntasNivel = 5;
                    tiempoRestante = new TimeSpan(0, 3, 30);
                }
                else if (nivel == 2)
                {
                    totalPreguntasNivel = 10;
                    tiempoRestante = new TimeSpan(0, 2, 50);
                }
                else
                {
                    totalPreguntasNivel = 10;
                    tiempoRestante = new TimeSpan(0, 2, 00);
                }

                lblTiempo.Text = tiempoRestante.ToString(@"mm\:ss");
            }



            void MostrarPreguntas()
            {
                lblPreguntas.Text = preguntas[indice];
                rbOpcion1.Text = opciones[indice, 0];
                rbOpcion2.Text = opciones[indice, 1];
                rbOpcion3.Text = opciones[indice, 2];

                rbOpcion1.Checked = false;
                rbOpcion2.Checked = false;
                rbOpcion3.Checked = false;

                lblContador.Text = $"Pregunta {indice + 1} de {totalPreguntasNivel}";
            }


            private void labelTitulo_Click(object sender, EventArgs e)
            {

            }

            private void pictureBox1_Click(object sender, EventArgs e)
            {
                Datoscuriosooi frme2 = new Datoscuriosooi();
                frme2.Show();
                this.Hide();
            }

            private void btnResponder1_Click(object sender, EventArgs e)
            {
                int seleccion = -1;

                if (rbOpcion1.Checked) seleccion = 0;
                else if (rbOpcion2.Checked) seleccion = 1;
                else if (rbOpcion3.Checked) seleccion = 2;

                if (seleccion == -1)
                {
                    MessageBox.Show(
                        "Por favor selecciona una opción antes de continuar.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                        );
                    return;
                }

                if (seleccion == respuestasCorrectas[indice])
                {
                    puntos++;
                    respuestasUsuario[indice] = true;
                }
                else
                {
                    respuestasUsuario[indice] = false;
                }

                indice++;

                if (indice < totalPreguntasNivel)
                {
                    MostrarPreguntas();
                }
                else
                {
                    FinalizarQuiz();
                }
            }


            private void FormPreguntas_Load(object sender, EventArgs e)
            {

            }

            private void rbOpcion2_CheckedChanged(object sender, EventArgs e)
            {

            }

            private void timer1_Tick(object sender, EventArgs e)
            {
                if (tiempoRestante.TotalSeconds > 0)
                {
                    tiempoRestante = tiempoRestante.Subtract(TimeSpan.FromSeconds(1));
                    lblTiempo.Text = tiempoRestante.ToString(@"mm\:ss");
                }
                else
                {
                    timer1.Stop();
                    MessageBox.Show("Tiempo terminado");
                    FinalizarQuiz();
                }
            }
            void FinalizarQuiz()
            {
                timer1.Stop();

                FormResultados fr = new FormResultados(
                    preguntas,
                    opciones,
                    respuestasCorrectas,
                    respuestasUsuario,
                    puntos
                );

                fr.Show();
                this.Close();

            }


        }
    }
