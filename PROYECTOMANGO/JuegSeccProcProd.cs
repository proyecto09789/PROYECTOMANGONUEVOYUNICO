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
        public JuegSeccProcProd()
        {
            InitializeComponent();
        }

        int errores = 0;
        int nivelActual = 1;
        int aciertosEnNivel = 0; // Para saber cuándo completó el nivel

        // Guardamos las posiciones originales para resetear las fichas al cambiar de nivel
        Point posFicha1, posFicha2, posFicha3;
        private void JuegSeccProd_Load(object sender, EventArgs e)
        {
            posFicha1 = pbImgJgScc.Location;
            posFicha2 = pbImgJgScc1.Location;
            posFicha3 = pbImgJgScc2.Location;

            CargarNivel(1); // Iniciamos el nivel 1
        }


        //LÓGICA DE NIVEL
        private void CargarNivel(int nivel)
        {
            nivelActual = nivel;
            aciertosEnNivel = 0; // Reiniciamos aciertos

            // Actualizamos las etiquetas
            lblNivelJgScc.Text = "Nivel: " + nivelActual;

            // Reseteamos las fichas (las habilitamos y las regresamos a su lugar)
            ResetearFicha(pbImgJgScc, posFicha1);
            ResetearFicha(pbImgJgScc1, posFicha2);
            ResetearFicha(pbImgJgScc2, posFicha3);

            // Reseteamos los paneles (color gris original)
            pnlPaso1.BackColor = Color.LightGray;
            pnlPaso2.BackColor = Color.LightGray;
            pnlPaso3.BackColor = Color.LightGray;

            // CONFIGURACIÓN DE IMÁGENES POR NIVEL
            // Aquí es donde tú pones tus imágenes reales usando Properties.Resources
            switch (nivel)
            {
                case 1:
                    MessageBox.Show("Nivel 1: Proceso Productivo del Mango");
                    // Ejemplo: pictureBox1.Image = Properties.Resources.semilla;
                    pbImgJgScc.Image = Properties.Resources.SQ1;   // Ficha 1
                    pbImgJgScc1.Image = Properties.Resources.SQ2; // Ficha 2
                    pbImgJgScc2.Image = Properties.Resources.SQ3;  // Ficha 3
                    break;

                case 2:
                    MessageBox.Show("Nivel 2: Etapa de Siembra");
                    pbImgJgScc.BackColor = Color.Yellow;
                    pbImgJgScc1.BackColor = Color.Orange;
                    pbImgJgScc2.BackColor = Color.Purple;
                    break;

                case 3:
                    MessageBox.Show("Nivel 3: Etapa de Cosecha");
                    pbImgJgScc.BackColor = Color.Gray;
                    pbImgJgScc1.BackColor = Color.Black;
                    pbImgJgScc2.BackColor = Color.Brown;
                    break;

                default:
                    MessageBox.Show("¡Felicidades! Has completado todo el juego.");
                    Application.Exit(); // Cierra el juego
                    break;
            }
        }

        private void ResetearFicha(PictureBox ficha, Point posicionOriginal)
        {
            ficha.Parent = this; // La sacamos del panel y la devolvemos al formulario
            ficha.Location = posicionOriginal; // La movemos a su sitio
            ficha.Enabled = true; // Permitimos que se mueva de nuevo
            ficha.BringToFront(); // Que se vea encima de todo
        }

        private void IniciarArrastre(object sender, MouseEventArgs e)
        {
            PictureBox ficha = sender as PictureBox;
            if (ficha != null) ficha.DoDragDrop(ficha, DragDropEffects.Move);
        }

        private void btnVolverJuegSecc_Click(object sender, EventArgs e)
        {
            ProcProductivo procProductivo = new ProcProductivo();
            procProductivo.Show();
            this.Hide();
        }

        private void ValidarEntrada(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(PictureBox))) e.Effect = DragDropEffects.Move;
            else e.Effect = DragDropEffects.None;
        }

        private void SoltarFicha(object sender, DragEventArgs e)
        {
            PictureBox ficha = (PictureBox)e.Data.GetData(typeof(PictureBox));
            Panel panel = (Panel)sender;

            string tagFicha = ficha.Tag.ToString();
            string tagPanel = panel.Tag.ToString();

            // VALIDACIÓN
            if (tagFicha == tagPanel)
            {
                ficha.Parent = panel;

                int centroX = (panel.Width - ficha.Width) / 2;
                int centroY = (panel.Height - ficha.Height) / 2;

                // 3. Aplicamos la nueva ubicación calculada
                ficha.Location = new Point(centroX, centroY);

                ficha.Enabled = false;
                panel.BackColor = Color.LightGreen;
                ficha.BringToFront(); 

                aciertosEnNivel++; // Sumamos un acierto

                // Verificamos si completó el nivel (3 fichas)
                if (aciertosEnNivel == 3)
                {
                    MessageBox.Show("¡Nivel Completado!");
                    CargarNivel(nivelActual + 1); // Pasamos al siguiente
                }
            }
            else
            {
                // ERROR 
                errores++; // Aumentamos contador
                lblErroresJgScc.Text = "Errores: " + errores.ToString(); // Actualizamos etiqueta

                MessageBox.Show("¡Incorrecto! Cuidado.");
            }
        }

    }
}

