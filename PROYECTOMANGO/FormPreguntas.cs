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
using static PROYECTOMANGO.FormPreguntas;

    namespace PROYECTOMANGO
    {
        public partial class FormPreguntas : Form
        {

            int indice = 0;
            int puntos = 0;
            int nivel;
            TimeSpan tiempoRestante;

        List<Preguntas> preguntasNivel;
        bool[] respuestaUsuario;
        Random rnd = new Random();

        public class Preguntas
        {
            public string Texto;
            public List<string> Opciones;
            public int Correcta;

            public Preguntas(string t, string[] op, int c)
            {
                Texto = t;
                Opciones= op.ToList();
                Correcta = c;
            }

            public void Mezclar()
            {
                var correcta = Opciones[Correcta];
                Opciones = Opciones.OrderBy(x => Guid.NewGuid()).ToList();
                Correcta = Opciones.IndexOf(correcta);
            }

        }


        List<Preguntas> bancoFacil = new List<Preguntas>()
        {

         new Preguntas("¿Cuál es el color más común del mango maduro?", new[]{"Amarillo","Morado","Gris","Azul"},0),
         new Preguntas("¿Qué sabor tiene normalmente el mango?", new[]{"Dulce","Salado","Ácido extremo","Amargo"},0),

         new Preguntas("¿Dónde crece el mango?", new[]{"En árboles","En el suelo","En el agua","En rocas"},0),
         new Preguntas("¿Qué parte comemos?", new[]{"Pulpa","Raíz","Hoja","Tronco"},0),
         new Preguntas("¿El mango es fruta o verdura?", new[]{"Fruta","Verdura","Cereal","Semilla"},0),
         new Preguntas("¿Qué contiene en el centro?", new[]{"Semilla","Aire","Agua","Gel"},0),
         new Preguntas("¿Qué clima favorece al mango?", new[]{"Tropical","Nevado","Polar","Seco extremo"},0),
         new Preguntas("¿Qué textura tiene la pulpa?", new[]{"Suave","Dura","Metálica","Rocosa"},0)
        };

        List<Preguntas> bancoMedio = new List<Preguntas>()
        {
         new Preguntas("¿De qué continente es originario el mango?", new[]{"Asia","Europa","América","Oceanía"},0),
         new Preguntas("¿A qué familia pertenece?", new[]{"Anacardiaceae","Rosaceae","Poaceae","Fabaceae"},0),
         new Preguntas("¿Qué fruto es pariente del mango?", new[]{"Pistacho","Manzana","Banana","Uva"},0),
         new Preguntas("¿Cuánto azúcar aprox tiene?", new[]{"14%","2%","50%","70%"},0),
         new Preguntas("¿Qué diseño famoso se inspira en su forma?", new[]{"Paisley","Cuadros","Rayas","Puntos"},0),
         new Preguntas("¿Qué parte protege la semilla?", new[]{"Hueso","Pulpa","Cáscara fina","Jugo"},0),
         new Preguntas("¿Cuál es la parte comestible?", new[]{"Pulpa","Semilla","Hoja","Raíz"},0),
         new Preguntas("¿Qué influye en su sabor?", new[]{"Clima","Sonido","Metal","Sombras"},0),
         new Preguntas("¿Qué simboliza en muchas culturas?", new[]{"Amor","Odio","Miedo","Celos"},0),
         new Preguntas("¿Hace cuántos años se cultiva aprox?", new[]{"5000","100","300","800"},0),
         new Preguntas("¿Dónde se difundió primero fuera de Asia?", new[]{"África","Antártida","Ártico","Luna"},0),
         new Preguntas("¿Qué parte tiene fibra?", new[]{"Pulpa","Aire","Luz","Agua"},0)
        };

        List<Preguntas> bancoDificil = new List<Preguntas>()
        {
         new Preguntas("¿Nombre científico del mango?", new[]{"Mangifera indica","Mangus real","Fructus mango","Mangium"},0),
         new Preguntas("¿En qué siglo llegó a América?", new[]{"XVII","XX","X","XXI"},0),
         new Preguntas("¿Qué tipo de fruto es botánicamente?", new[]{"Drupa","Baya","Tubérculo","Bulbo"},0),
         new Preguntas("¿Qué porcentaje ácido tiene aprox?", new[]{"0.5%","10%","25%","60%"},0),
         new Preguntas("¿Quién difundió el mango a América?", new[]{"Exploradores españoles","Romanos","Griegos","Vikingos"},0),
         new Preguntas("¿Qué clima no tolera?", new[]{"Heladas","Sol","Calor","Humedad"},0),
         new Preguntas("¿Cuántas partes estructurales tiene el fruto?", new[]{"Tres","Dos","Cinco","Una"},0),
         new Preguntas("¿Qué parte protege al embrión?", new[]{"Semilla","Pulpa","Fibra","Cáscara"},0),
         new Preguntas("¿Qué simboliza regalar mangos?", new[]{"Amistad","Odio","Tristeza","Celos"},0),
         new Preguntas("¿Dónde se intentó cultivar en 1833?", new[]{"Florida","España","México","Perú"},0),
         new Preguntas("¿Qué representa en Asia?", new[]{"Prosperidad","Miedo","Guerra","Caos"},0),
        new Preguntas("¿Qué ayudó a expandir su cultivo?", new[]{"Migración humana","Volcanes","Rayos","Huracanes"},0),
        new Preguntas("¿Qué parte se usa en medicina tradicional?", new[]{"Cáscara","Metal","Roca","Plástico"},0),
        new Preguntas("¿Qué contiene más fibra?", new[]{"Pulpa","Agua","Aire","Luz"},0),
        new Preguntas("¿Relación azúcar-ácido aproximada?", new[]{"28","2","100","7"},0),
        new Preguntas("¿Quién meditó bajo un árbol de mango según tradición?", new[]{"Buda","Einstein","Newton","Tesla"},0),
        new Preguntas("¿Qué pigmento da color amarillo al mango?", new[]{"Carotenoides","Clorofila","Melanina","Hemoglobina"},0)
        };


        public FormPreguntas(int nivelSeleccionado)
            {
                InitializeComponent();

                nivel = nivelSeleccionado;
                ConfigurarNivel();

            respuestaUsuario = new bool[preguntasNivel.Count];

                MostrarPreguntas();
                timer1.Start();
            }
            void ConfigurarNivel()
            {
                if (nivel == 1)
                {
                preguntasNivel = bancoFacil.OrderBy(x => rnd.Next()).Take(6).ToList();
                tiempoRestante = new TimeSpan(0, 3, 0);
            }
                else if (nivel == 2)
                {
                preguntasNivel = bancoMedio.OrderBy(x => rnd.Next()).Take(10).ToList();
                tiempoRestante = new TimeSpan(0, 2, 30);
            }
                else
                {
                preguntasNivel = bancoDificil.OrderBy(x => rnd.Next()).Take(15).ToList();
                tiempoRestante = new TimeSpan(0, 2, 0);
            }

                foreach(var p in preguntasNivel)
                p.Mezclar();
                lblTiempo.Text = tiempoRestante.ToString(@"mm\:ss");
            }



            void MostrarPreguntas()
            {
            if (indice >= preguntasNivel.Count)
                return;

            var p = preguntasNivel[indice];
            lblPreguntas.Text = p.Texto;

            rbOpcion1.Text = p.Opciones[0];
            rbOpcion2.Text = p.Opciones[1];
            rbOpcion3.Text = p.Opciones[2];
            rbOpcion4.Text = p.Opciones[3];

            rbOpcion1.Checked = false;
            rbOpcion2.Checked = false;
            rbOpcion3.Checked = false;
            rbOpcion4.Checked = false;

            lblContador.Text = $"Pregunta {indice + 1} de {preguntasNivel.Count}";
        }


            private void labelTitulo_Click(object sender, EventArgs e)
            {

            }

            private void pictureBox1_Click(object sender, EventArgs e)
            {
            Datoscuriosooi frme2 = new Datoscuriosooi();
            frme2.Show();

            cerrandoPorCodigo = true;
            this.Close();
        }

            private void btnResponder1_Click(object sender, EventArgs e)
            {
            int seleccion =
             rbOpcion1.Checked ? 0 :
             rbOpcion2.Checked ? 1 :
             rbOpcion3.Checked ? 2 :
             rbOpcion4.Checked ? 3 : -1;

            if (seleccion == -1)
            {
                MessageBox.Show(
                 "Selecciona una opción",
                   "Aviso",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning
     );
                return;
            }

            if (seleccion == preguntasNivel[indice].Correcta)
            {
                puntos++;
                respuestaUsuario[indice] = true;
            }
            else
                respuestaUsuario[indice] = false;

                indice++;

            if (indice < preguntasNivel.Count)
                MostrarPreguntas();
            else
                FinalizarQuiz();
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
                FinalizarQuiz();
            }
        }
            
            void FinalizarQuiz()
            {
            timer1.Stop();

            FormResultados fr = new FormResultados(
                preguntasNivel,
                respuestaUsuario,
                puntos
            );

            fr.Show();

            cerrandoPorCodigo = true;
            this.Close();

            }

        bool cerrandoPorCodigo = false;
        private void FormPreguntas_FormClosing(object sender, FormClosingEventArgs e)
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
