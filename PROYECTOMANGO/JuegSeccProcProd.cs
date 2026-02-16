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
    public partial class JuegSeccProcProd : Form
    {
        private List<NivelDatos> listaNivelesJuego;
        private int indiceNivelActual = 0;         
        private int tiempoRestante;                 
        private int contadorErrores = 0;            

        public JuegSeccProcProd(int dificultad)
        {
            InitializeComponent();
            ConfigurarNiveles(dificultad);
            CargarNivelActual();
        }

        private void ConfigurarNiveles(int dificultad)
        {
            listaNivelesJuego = new List<NivelDatos>();

            if (dificultad == 1) 
            {
                var imgs1 = new List<(Image, int)> {
                    (Properties.Resources.SiembraMangoScc11, 1),
                    (Properties.Resources.FloracionMangoScc11, 2),
                    (Properties.Resources.CosechaMangoScc11, 3)
                };
                listaNivelesJuego.Add(new NivelDatos { Imagenes = imgs1, TiempoLimite = 20, Titulo = "Fácil - Etapa 1" });

                var imgs2 = new List<(Image, int)> {
                    (Properties.Resources.TecnCortScc3, 1),
                    (Properties.Resources.LavadTratamScc3, 2),
                    (Properties.Resources.ClasifEmpaqScc3, 3)
                };
                listaNivelesJuego.Add(new NivelDatos { Imagenes = imgs2, TiempoLimite = 15, Titulo = "Fácil - Etapa 2" });

                // ETAPA 3
                var imgs3 = new List<(Image, int)> {
                    (Properties.Resources.SeleccDeTerrenScc2, 1),
                    (Properties.Resources.PrepSemillaScc2, 2),
                    (Properties.Resources.AhoyadoScc2, 3)
                };
                listaNivelesJuego.Add(new NivelDatos { Imagenes = imgs3, TiempoLimite = 10, Titulo = "Fácil - Etapa 3" });
            }
            else if (dificultad == 2) 
            {
                for (int i = 0; i < 5; i++)
                {
                    var imgs = new List<(Image, int)> {
                        (Properties.Resources.SeleccDeTerrenScc2, 1),
                        (Properties.Resources.PrepSemillaScc2, 2),
                        (Properties.Resources.AhoyadoScc2, 3)
                    };
                    listaNivelesJuego.Add(new NivelDatos { Imagenes = imgs, TiempoLimite = 40, Titulo = $"Medio - Etapa {i + 1}" });
                }
            }
            else if (dificultad == 3) 
            {
                for (int i = 0; i < 8; i++)
                {
                    var imgs = new List<(Image, int)> {
                        (Properties.Resources.IndicMaduScc3, 1),
                        (Properties.Resources.TecnCortScc3, 2),
                        (Properties.Resources.DeslechScc3, 3),
                        (Properties.Resources.LavadTratamScc3, 4)
                    };
                    listaNivelesJuego.Add(new NivelDatos { Imagenes = imgs, TiempoLimite = 25, Titulo = $"Difícil - Etapa {i + 1}" });
                }
            }
        }

        private void CargarNivelActual()
        {
            contadorErrores = 0;
            if (lblErrores != null) 
            {
                lblErrores.Text = "Errores: 0";
                lblErrores.ForeColor = Color.Black;
            }

            pnlSecuencia.Controls.Clear();
            pnlOpciones.Controls.Clear();

            btnSiguiente.Visible = false;
            btnVerificar.Enabled = true;
            pnlSecuencia.Enabled = true;

            if (listaNivelesJuego.Count == 0) return; 
            NivelDatos datos = listaNivelesJuego[indiceNivelActual];

            lblTitulo.Text = datos.Titulo;
            tiempoRestante = datos.TiempoLimite;
            lblTiempo.Text = $"Tiempo: {tiempoRestante}s";

            tmrNivel.Interval = 1000;
            tmrNivel.Stop();
            tmrNivel.Start();

            var listaDesordenada = datos.Imagenes.OrderBy(x => Guid.NewGuid()).ToList();

            foreach (var item in listaDesordenada)
            {
                PictureBox pb = new PictureBox();
                pb.Image = item.img;
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Width = 100;
                pb.Height = 100;
                pb.Tag = item.orden; 
                pb.Cursor = Cursors.Hand;
                pb.Padding = new Padding(0);
                pb.Click += Imagen_Click;
                pnlOpciones.Controls.Add(pb);
            }
        }

        private void Imagen_Click(object sender, EventArgs e)
        {
            PictureBox imagen = sender as PictureBox;

            if (imagen.Parent == pnlOpciones)
                pnlSecuencia.Controls.Add(imagen);
            else
                pnlOpciones.Controls.Add(imagen);

            imagen.BackColor = Color.Transparent;
            imagen.Padding = new Padding(0);
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (pnlSecuencia.Controls.Count == 0) return;

            NivelDatos datos = listaNivelesJuego[indiceNivelActual];

            if (pnlSecuencia.Controls.Count != datos.Imagenes.Count)
            {
                MessageBox.Show("¡Completa la secuencia primero!");
                return;
            }

            int indice = 0;
            bool todoCorrecto = true;

            foreach (Control control in pnlSecuencia.Controls)
            {
                PictureBox imagen = control as PictureBox;

                if (imagen.Tag.ToString() != (indice + 1).ToString())
                {
                    todoCorrecto = false;
                    imagen.BackColor = Color.Red;
                    imagen.Padding = new Padding(3); 
                }
                else
                {
                    imagen.BackColor = Color.Transparent;
                    imagen.Padding = new Padding(0);
                }
                indice++;
            }
            if (todoCorrecto)
            {
                tmrNivel.Stop();

                int tiempoTomado = datos.TiempoLimite - tiempoRestante;

                string mensaje = $"¡Nivel Completado!\n\n" +
                                 $"⏱ Tiempo usado: {tiempoTomado} segundos\n" +
                                 $"❌ Errores cometidos: {contadorErrores}";

                MessageBox.Show(mensaje, "Eres un crack");

                btnSiguiente.Visible = true;
                btnVerificar.Enabled = false;
                pnlSecuencia.Enabled = false; 
            }
            else
            {
                contadorErrores++; 
                lblErrores.Text = $"Errores: {contadorErrores}";
                lblErrores.ForeColor = Color.Red; 

                MessageBox.Show("Hay fichas mal puestas (las marcadas en rojo). ¡Corrige rápido!", "Error");
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (indiceNivelActual < listaNivelesJuego.Count - 1)
            {
                indiceNivelActual++; 
                CargarNivelActual(); 
            }
            else
            {
                MessageBox.Show("¡Te pasaste el juego completo!");
                SeleccNvlPrcc menu = new SeleccNvlPrcc();
                menu.Show();
                this.Close();
            }
        }

        private void tmrNivel_Tick(object sender, EventArgs e)
        {
            tiempoRestante--;
            lblTiempo.Text = $"Tiempo: {tiempoRestante}s";

            if (tiempoRestante <= 0)
            {
                tmrNivel.Stop();
                MessageBox.Show("¡Se te acabó el tiempo! Intenta de nuevo.", "Game Over");
                CargarNivelActual();
            }
        }

        private void btnVolverJuegSecc_Click(object sender, EventArgs e)
        {
            tmrNivel.Stop();
            SeleccNvlPrcc seleccion = new SeleccNvlPrcc();
            seleccion.Show();
            this.Close();
        }

        public class NivelDatos
        {
            public List<(Image img, int orden)> Imagenes { get; set; }
            public int TiempoLimite { get; set; }
            public string Titulo { get; set; }
        }
    }
}

