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
            // 1. Limpiamos los paneles de cualquier nivel anterior
            pnlSecuencia.Controls.Clear();
            pnlOpciones.Controls.Clear();

            // Lista temporal para guardar las imágenes de este nivel
            // Usamos una clase simple o tupla: (Imagen, NumeroDeOrden)
            var listaImagenes = new List<(Image img, int orden)>();

            // 2. CONFIGURACIÓN DE NIVELES (Aquí defines tus reglas)
            switch (nivelActual)
            {
                case 1:
                    lblTitulo.Text = "Nivel 1: Fácil";
                    // Asegúrate de usar TUS nombres de recursos aquí
                    listaImagenes.Add((Properties.Resources.SiembraMangoScc11, 1));
                    listaImagenes.Add((Properties.Resources.FloracionMangoScc11, 2));
                    listaImagenes.Add((Properties.Resources.CosechaMangoScc11, 3));
                    break;

                case 2:
                    lblTitulo.Text = "Nivel 2: Siembra (Medio)";
                    listaImagenes.Add((Properties.Resources.SeleccDeTerrenScc2, 1));
                    listaImagenes.Add((Properties.Resources.PrepSemillaScc2, 2));
                    listaImagenes.Add((Properties.Resources.AhoyadoScc2, 3));
                    listaImagenes.Add((Properties.Resources.TrasplanteScc2, 4));
                    break;

                //case 3:
                //    lblTitulo.Text = "Nivel 3: Cosecha (Difícil)";
                //    listaImagenes.Add((Properties.Resources., 1));
                //    listaImagenes.Add((Properties.Resources., 2));
                //    listaImagenes.Add((Properties.Resources., 3));
                //    listaImagenes.Add((Properties.Resources., 4));
                //    listaImagenes.Add((Properties.Resources., 5));
                //    break;

                default:
                    MessageBox.Show("¡Juego Completado! Eres un experto.");
                    ProcProductivo procProductivo = new ProcProductivo();
                    procProductivo.Show();
                    this.Close();
                    break;
            }

            // 3. MEZCLAR Y CREAR 
            // Mezclamos la lista aleatoriamente para que aparezcan desordenadas
            var listaDesordenada = listaImagenes.OrderBy(x => Guid.NewGuid()).ToList();

            foreach (var item in listaDesordenada)
            {
                PictureBox pb = new PictureBox();
                pb.Image = item.img;
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Width = 100;  // Ajusta el tamaño según necesites
                pb.Height = 100;
                pb.Tag = item.orden; // ¡IMPORTANTE! Aquí guardamos la respuesta correcta
                pb.Cursor = Cursors.Hand;

                // Conectamos el evento Click que ya tenías
                pb.Click += Imagen_Click;

                // Lo agregamos al panel de abajo (Opciones)
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
            // 1. Validaciones básicas (si está vacío, etc.)
            if (pnlSecuencia.Controls.Count == 0) return;

            int totalImagenes = pnlSecuencia.Controls.Count + pnlOpciones.Controls.Count;
            if (pnlSecuencia.Controls.Count != totalImagenes)
            {
                MessageBox.Show("Aún faltan imágenes por ordenar.");
                return;
            }

            // 2. Comprobación del orden
            int indice = 0;
            bool esCorrecto = true;

            foreach (Control control in pnlSecuencia.Controls)
            {
                PictureBox imagen = control as PictureBox;
                // Compara el Tag (orden correcto) con el índice actual + 1
                if (imagen.Tag.ToString() != (indice + 1).ToString())
                {
                    esCorrecto = false;
                    break;
                }
                indice++;
            }

            // 3. Resultado
            if (esCorrecto)
            {
                MessageBox.Show("¡Correcto! Has completado la secuencia.");

                // AQUÍ ESTÁ EL TRUCO:
                btnSiguiente.Visible = true;   // Aparece el botón mágico
                btnVerificar.Enabled = false;  // Desactivamos verificar para que no le den click de nuevo
                pnlSecuencia.Enabled = false;  // Bloqueamos el panel para que no muevan las fotos ya ordenadas
            }
            else
            {
                MessageBox.Show("Hay un error en el orden. Inténtalo de nuevo.");
            }

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            // 1. Aumentamos el contador
            nivelActual++;

            // 2. Cargamos el nuevo nivel
            CargarNivel();

            // 3. RESTABLECEMOS LA INTERFAZ (Muy importante)
            // Como acabamos de cargar un nivel nuevo, hay que esconder este botón otra vez
            btnSiguiente.Visible = false;

            // Volvemos a activar el botón de verificar y el panel
            btnVerificar.Enabled = true;
            pnlSecuencia.Enabled = true;
        }
    }
}

