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

namespace PROYECTOBETA001
{
        public partial class Datoscuriosooi : Form
    {
        int indice = 0;
        string[] datos = new string[]
        {
"🥭 DATO 1\n\n" +
"El mango es originario del sur de Asia\n" +
"y se cultiva desde hace más de 4,000 años.\n" +
"Su domesticación comenzó en regiones de la India y Myanmar.\n" +
"Con el paso del tiempo, el mango fue considerado un fruto sagrado.\n" +
"Su cultivo se expandió gracias al comercio y la migración.\n" +
"Actualmente se cultiva en casi todas las regiones tropicales.",

"🥭 DATO 2\n\n" +
"El mango es una fruta tropical\n" +
"que pertenece al grupo de las drupas.\n" +
"Esto significa que posee una sola semilla grande en su interior.\n" +
"Las drupas se caracterizan por tener pulpa carnosa.\n" +
"Este tipo de fruto suele ser jugoso y nutritivo.\n" +
"Ejemplos similares son el durazno y la ciruela.",

"🥭 DATO 3\n\n" +
"El mango está relacionado con\n" +
"los anacardos y los pistachos\n" +
"porque pertenecen a la misma familia.\n" +
"Esta familia botánica se llama Anacardiaceae.\n" +
"Muchas especies de esta familia son tropicales.\n" +
"Algunas también se utilizan con fines medicinales.",

"🥭 DATO 4\n\n" +
"Existen más de 1,000 variedades\n" +
"de mango en todo el mundo.\n" +
"Cada una presenta diferencias en sabor, tamaño y color.\n" +
"Algunas variedades son más dulces que otras.\n" +
"También varían en cantidad de fibra y jugosidad.\n" +
"Esto permite su uso en diversas preparaciones.",

"🥭 DATO 5\n\n" +
"El famoso patrón paisley\n" +
"está inspirado en la forma del mango.\n" +
"Este diseño es muy usado en textiles y arte tradicional.\n" +
"Es especialmente popular en Asia y Medio Oriente.\n" +
"Representa fertilidad y abundancia.\n" +
"Con el tiempo se difundió a la moda occidental.",

"🥭 DATO 6\n\n" +
"Un árbol de mango puede vivir\n" +
"más de 100 años y seguir dando frutos.\n" +
"Por esta razón es muy valorado en la agricultura tropical.\n" +
"Alcanza gran tamaño y produce sombra abundante.\n" +
"Su producción aumenta con el paso de los años.\n" +
"Es común encontrar árboles centenarios aún productivos.",

"🥭 DATO 7\n\n" +
"El hueso del mango se llama semilla\n" +
"y se encuentra en el centro del fruto.\n" +
"Protege al embrión que dará origen a una nueva planta.\n" +
"Su forma es plana y alargada.\n" +
"Está recubierta por una capa dura.\n" +
"De ella puede germinar un nuevo árbol.",

"🥭 DATO 8\n\n" +
"Gracias a su fibra natural,\n" +
"el mango ayuda a mejorar la digestión.\n" +
"También contribuye al buen funcionamiento del sistema digestivo.\n" +
"La fibra favorece el tránsito intestinal.\n" +
"Su consumo moderado ayuda a evitar el estreñimiento.\n" +
"Es recomendado dentro de una dieta balanceada.",

"🥭 DATO 9\n\n" +
"El mango es conocido como\n" +
"el Rey de las Frutas en muchos países.\n" +
"Este título se debe a su sabor, aroma y valor nutricional.\n" +
"Es muy apreciado tanto fresco como procesado.\n" +
"Su versatilidad lo hace muy popular.\n" +
"Es símbolo de abundancia en varias culturas.",

"🥭 DATO 10\n\n" +
"El mango crece mejor en climas\n" +
"tropicales con temperaturas cálidas.\n" +
"Necesita buena luz solar y suelos bien drenados.\n" +
"Las lluvias favorecen su desarrollo inicial.\n" +
"No tolera bien las heladas.\n" +
"Las condiciones climáticas influyen en la calidad del fruto."
        };


        public Datoscuriosooi()
        {
            InitializeComponent();

            lblDatos.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblContador.Font = new Font("Segoe UI", 10, FontStyle.Bold); 
            MostrarDato();
        }
        void MostrarDato()
        {
            lblDatos.Text = datos[indice];
            lblContador.Text = $"Dato {indice + 1} de {datos.Length}";
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

        private void btnRegresar_Click(object sender, EventArgs e)
        {
         
        }

        private void LinkFuentes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Interfazprinc frme2 = new Interfazprinc();
            frme2.Show();
            this.Hide();
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
    }
}
