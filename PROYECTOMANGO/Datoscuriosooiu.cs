using PROYECTOMANGO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PROYECTOBETA001
{
        public partial class Datoscuriosooi : Form
    {
        int indice = 0;
        string[] datos = new string[]
        {

"* El mango es una drupa.\nTiene cáscara, pulpa y una semilla.",

"* Se cultivó primero en India\nhace más de 5000 años.",

"* Las semillas de mango\nse expandieron desde Asia\na otros continentes.",

"* El diseño paisley\nestá inspirado en la forma del mango.",

"* En India regalar mangos\nsignifica amistad y respeto.",

"* En Asia el mango\nsimboliza amor y prosperidad.",

"* Una leyenda dice que Buda\nmeditó bajo un árbol de mango.",

"* El mango es familia\nde los pistachos y anacardos.",

"* Un mango maduro tiene\naprox. 14% de azúcar.",

"* Su relación azúcar-ácido\ndefine su dulzura.",

"* Los españoles llevaron\nel mango a América\nen el siglo XVII.",

"* Su nombre científico es\nMangifera indica.",

"* Partes del mango\nse usaron en remedios tradicionales.",

"* El hueso protege la semilla\ny ayuda a su germinación.",

"* Es una fruta tropical\nque crece mejor en climas cálidos."
        };
        
       
        public Datoscuriosooi()
        {
            InitializeComponent();

            lblDatos.Font = new Font("Segoe UI", 17, FontStyle.Bold);
            lblContador.Font = new Font("Segoe UI", 13, FontStyle.Bold); 
            MostrarDato();
        }
        void MostrarDato()
        {
            lblDatos.Text = datos[indice];
            lblContador.Text = $"Dato {indice + 1} de {datos.Length}";

            string carpeta = Path.Combine(Application.StartupPath, "DATOS IMAGEN");

            string[] extensiones = { ".png", ".jpg", ".jpeg", ".bmp", ".gif" };

            string rutaImagen = null;

            foreach (string ext in extensiones)
            {
                string posible = Path.Combine(carpeta, "Dato" + (indice + 1) + ext);
                if (File.Exists(posible))
                {
                    rutaImagen = posible;
                    break;
                }

            }

            pictureDato.Image?.Dispose();

            if (rutaImagen != null)
                pictureDato.Image = Image.FromFile(rutaImagen);
            else
                pictureDato.Image = null;
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
            else
            {
                FormInstrucciones1 fi = new FormInstrucciones1();
                fi.Show();

                cerrandoPorCodigo = true;
                this.Close();
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


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Interfazprinc frme2 = new Interfazprinc();
            frme2.Show();

            cerrandoPorCodigo = true;
            this.Close();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.mango.org/mango-facts/",
                UseShellExecute = true
            });
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        bool cerrandoPorCodigo = false;
        private void Datoscuriosooi_FormClosing(object sender, FormClosingEventArgs e)
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
