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
        int nivelActual = 1; // Controla en qué nivel estamos
        public JuegSeccProcProd()
        {
            InitializeComponent();
        }

        private void JuegSeccProcProd_Load(object sender, EventArgs e)
        {
            // Al abrir el juego, cargamos el nivel 1
            CargarNivel();
        }

        private void btnVolverJuegSecc_Click(object sender, EventArgs e)
        {
            ProcProductivo procProductivo = new ProcProductivo();
            procProductivo.Show();
            this.Hide();
        }

        private void CargarNivel()
        {
            // Limpia los paneles de cualquier nivel anterior
            pnlSecuencia.Controls.Clear();
            pnlOpciones.Controls.Clear();

            // (Imagen, NumeroDeOrden)
            var listaImagenes = new List<(Image img, int orden)>();

            switch (nivelActual)
            {
                case 1:
                    lblTitulo.Text = "Nivel 1: Fácil";
                    listaImagenes.Add((Properties.Resources.SiembraMangoScc11, 1));
                    listaImagenes.Add((Properties.Resources.FloracionMangoScc11, 2));
                    listaImagenes.Add((Properties.Resources.CosechaMangoScc11, 3));
                    break;

                case 2:
                    lblTitulo.Text = "Nivel 2: Medio";
                    listaImagenes.Add((Properties.Resources.SeleccDeTerrenScc2, 1));
                    listaImagenes.Add((Properties.Resources.PrepSemillaScc2, 2));
                    listaImagenes.Add((Properties.Resources.AhoyadoScc2, 3));
                    listaImagenes.Add((Properties.Resources.TrasplanteScc2, 4));
                    break;

                case 3:
                    lblTitulo.Text = "Nivel 3: Difícil";
                    listaImagenes.Add((Properties.Resources.IndicMaduScc3, 1));
                    listaImagenes.Add((Properties.Resources.TecnCortScc3, 2));
                    listaImagenes.Add((Properties.Resources.DeslechScc3, 3));
                    listaImagenes.Add((Properties.Resources.LavadTratamScc3, 4));
                    listaImagenes.Add((Properties.Resources.ClasifEmpaqScc3, 5));
                    break;

                default:
                    MessageBox.Show("¡Juego Completado! Eres un experto.");
                    ProcProductivo procProductivo = new ProcProductivo();
                    procProductivo.Show();
                    this.Close();
                    break;
            }

            // Mezcla la lista aleatoriamente para que aparezcan desordenadas
            var listaDesordenada = listaImagenes.OrderBy(x => Guid.NewGuid()).ToList();

            foreach (var item in listaDesordenada)
            {
                PictureBox pb = new PictureBox();
                pb.Image = item.img;
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Width = 100;  
                pb.Height = 100;
                pb.Tag = item.orden; //guarda la respuesta correcta
                pb.Cursor = Cursors.Hand;
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
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (pnlSecuencia.Controls.Count == 0) return;

            int totalImagenes = pnlSecuencia.Controls.Count + pnlOpciones.Controls.Count;
            if (pnlSecuencia.Controls.Count != totalImagenes)
            {
                MessageBox.Show("Aún faltan imágenes por ordenar.");
                return;
            }

            // Comprobación del orden
            int indice = 0;
            bool esCorrecto = true;

            foreach (Control control in pnlSecuencia.Controls)
            {
                PictureBox imagen = control as PictureBox;
                if (imagen.Tag.ToString() != (indice + 1).ToString())
                {
                    esCorrecto = false;
                    break;
                }
                indice++;
            }

            if (esCorrecto)
            {
                MessageBox.Show("¡Correcto! Has completado la secuencia.");

                btnSiguiente.Visible = true;  
                btnVerificar.Enabled = false;  // Desactiva verificar para que no le den click de nuevo
                pnlSecuencia.Enabled = false;  // Bloquea el panel para que no muevan las fotos ya ordenadas
            }
            else
            {
                MessageBox.Show("Hay un error en el orden. Inténtalo de nuevo.");
            }

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            nivelActual++;
            CargarNivel();
            btnSiguiente.Visible = false;
            btnVerificar.Enabled = true;
            pnlSecuencia.Enabled = true;
        }

        private void btnXInstrucc_Click(object sender, EventArgs e)
        {
           pnlComoSeJuega.Visible = false; 
        }

        private void btnComoSeJuega_Click(object sender, EventArgs e)
        {
            pnlComoSeJuega.Visible = true;
            pnlComoSeJuega.BringToFront();
        }
    }
}

