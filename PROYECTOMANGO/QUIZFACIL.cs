using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media; // Para reproducir sonidos WAV
using System.IO;
using System.Windows.Forms.VisualStyles;
using PROYECTOBETA001;

namespace PROYECTOMANGO
{
    public partial class QUIZFACIL : Form
    {
        private int puntuacion = 0;
        private int preguntaActual = 0;
        private int respuestasCorrectas = 0;

        // Timer para el contador regresivo
        private Timer temporizador;
        private int tiempoRestante = 7;
        private const int TIEMPO_INICIAL = 20;

        // SoundPlayers para los sonidos
        private SoundPlayer sonidoTicTac;
        private SoundPlayer sonidoCorrecto;
        private SoundPlayer sonidoIncorrecto;

        public QUIZFACIL()
        {
            InitializeComponent();
            InicializarTemporizador();
            InicializarSonidos();
        }

        private void InicializarTemporizador()
        {
            temporizador = new Timer();
            temporizador.Interval = 1000; // 1 segundo
            temporizador.Tick += Temporizador_Tick;
        }

        private void InicializarSonidos()
        {
            try
            {
                // Cargar sonidos desde Resources
                // Asegúrate de agregar los archivos .wav en Properties -> Resources

                // Para el sonido de tic-tac (cuando quedan 10 segundos)
                if (Properties.Resources.tictac != null)
                {
                    sonidoTicTac = new SoundPlayer(Properties.Resources.tictac);
                }

                // Para el sonido de respuesta correcta
                if (Properties.Resources.correcto != null)
                {
                    sonidoCorrecto = new SoundPlayer(Properties.Resources.correcto);
                }

                // Para el sonido de respuesta incorrecta
                if (Properties.Resources.incorrecto != null)
                {
                    sonidoIncorrecto = new SoundPlayer(Properties.Resources.incorrecto);
                }
            }
            catch (Exception ex)
            {
                // Si hay error al cargar sonidos, continuar sin ellos
                MessageBox.Show("Error al cargar sonidos: " + ex.Message, "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Juegomayre1_Load(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                panelmay1.Dock = DockStyle.Fill;
            }

            panelmay1.Visible = false;
            panelmay2.Visible = false;
            panelmay3.Visible = false;
            panelmay4.Visible = false;
            panelmay5.Visible = false;


            panelmay09.Visible = false;
            panelcomenzar1.Visible = true;

            lblnumpre.Text = $"{preguntaActual + 1}";
        }

        private void IniciarQuiz()
        {
            puntuacion = 0;
            preguntaActual = 0;
            respuestasCorrectas = 0;

            labelpuntuación.Text = "Puntuación: 0";
            lblnumpre.Text = "1";
            labelcorrect2.Text = "";

            panelcomenzar1.Visible = false;
            panelmay09.Visible = false;

            panelmay1.Location = new Point(38, 98);
            panelmay1.Visible = true;
            panelmay2.Visible = false;
            panelmay3.Visible = false;
            panelmay4.Visible = false;
            panelmay5.Visible = false;


            ResetearColoresBotones();
            IniciarTemporizador();
        }

        private void IniciarTemporizador()
        {
            tiempoRestante = TIEMPO_INICIAL;
            ActualizarDisplayTiempo();
            temporizador.Start();
        }

        private void Temporizador_Tick(object sender, EventArgs e)
        {
            tiempoRestante--;
            ActualizarDisplayTiempo();

            // Reproducir sonido de tic tac cuando quedan 10 segundos
            if (tiempoRestante <= 10 && tiempoRestante > 0)
            {
                ReproducirSonidoTicTac();
            }

            // Cambiar color del tiempo cuando queda poco
            if (tiempoRestante <= 4)
            {
                labelmay3.ForeColor = Color.Red;
            }
            else
            {
                labelmay3.ForeColor = Color.Black;
            }

            // Si se acaba el tiempo
            if (tiempoRestante <= 0)
            {
                temporizador.Stop();
                sonidoTicTac?.Stop();
                _ = TiempoAgotado();
            }
        }

        private void ActualizarDisplayTiempo()
        {
            labelmay3.Text = $"Tiempo: {tiempoRestante}s";
        }

        private void ReproducirSonidoTicTac()
        {
            try
            {
                if (sonidoTicTac != null)
                {
                    sonidoTicTac.Play(); // Reproduce de forma asíncrona
                }
                else
                {
                    // Si no hay archivo de sonido, usar beep del sistema
                    Console.Beep(800, 100);
                }
            }
            catch (Exception)
            {
                // Ignorar errores de reproducción
            }
        }

        private void ReproducirSonidoCorrecto()
        {
            try
            {
                if (sonidoCorrecto != null)
                {
                    sonidoCorrecto.Play(); // Reproduce de forma asíncrona
                }
                else
                {
                    // Si no hay archivo de sonido, usar beeps del sistema
                    Console.Beep(523, 100);  // Do
                    Console.Beep(659, 100);  // Mi
                    Console.Beep(784, 200);  // Sol
                }
            }
            catch (Exception)
            {
                // Ignorar errores de reproducción
            }
        }

        private void ReproducirSonidoIncorrecto()
        {
            try
            {
                if (sonidoIncorrecto != null)
                {
                    sonidoIncorrecto.Play(); // Reproduce de forma asíncrona
                }
                else
                {
                    // Si no hay archivo de sonido, usar beeps del sistema
                    Console.Beep(400, 200);
                    Console.Beep(300, 300);
                }
            }
            catch (Exception)
            {
                // Ignorar errores de reproducción
            }
        }

        private async Task TiempoAgotado()
        {
            DesactivarBotonesPreguntaActual();

            labelcorrect2.Text = "¡Tiempo agotado! ⏰";
            labelcorrect2.ForeColor = Color.Orange;

            MostrarRespuestaCorrectaPreguntaActual();

            await Task.Delay(2000);
            labelcorrect2.Text = "";

            preguntaActual++;

            if (preguntaActual < 5)
            {
                MostrarSiguientePregunta();
            }
            else
            {
                MostrarResultadoFinal();
            }
        }

        private void DesactivarBotonesPreguntaActual()
        {
            switch (preguntaActual)
            {
                case 0:
                    btnopm1.Enabled = false;
                    btnopm2.Enabled = false;
                    btnopm3.Enabled = false;
                    btnopm4.Enabled = false;
                    break;
                case 1:
                    btnopm5.Enabled = false;
                    btnopm6.Enabled = false;
                    btnopm7.Enabled = false;
                    btnopm8.Enabled = false;
                    break;
                case 2:
                    btnopm9.Enabled = false;
                    btnopm10.Enabled = false;
                    btnopm11.Enabled = false;
                    btnopm12.Enabled = false;
                    break;
                case 3:
                    btnopm13.Enabled = false;
                    btnopm14.Enabled = false;
                    btnopm15.Enabled = false;
                    btnopm16.Enabled = false;
                    break;
                case 4:
                    btnopm17.Enabled = false;
                    btnopm18.Enabled = false;
                    btnopm19.Enabled = false;
                    btnopm20.Enabled = false;
                    break;


            }
        }

        private void MostrarRespuestaCorrectaPreguntaActual()
        {
            /*Pongo esto para saber que botón es el correcto de cada pregunta, ya que
             el código se basa en el índice de la pregunta actual:*/

            // Pregunta 0: btnopm1 (índice 2 - Envolverlas en harina de arroz)
            // Pregunta 1: btnopm6 (índice 1 - 2 semanas)
            // Pregunta 2: btnopm10 (índice 1 - En tiras de aproximadamente 2" x 1/4")
            // Pregunta 3: btnopm14 (índice 2 - La salsa se cocina y se licúa...)
            // Pregunta 4: btnopm17 (índice 3 - 350°F)
            // Pregunta 5: btnopm24 (índice 4 - 4)
            // Pregunta 6: btnopm27 (índice 3 - Cuatro frascos de una pinta junto con sus tapas correspondientes)
            // Pregunta 7: btnopm29 (índice 1 - Con agua jabonosa caliente y dejándolos secar al aire)
            // Pregunta 8: brnopm34 (índice 2 - Vinagre, sal kosher y azúcar mezclados a fuego lento)
            // Pregunta 9: (me olvide dee poner aquí :) 
            // Pregunta 10: btnopm39 (índice 3 - Lograr que la sal y el azúcar se disuelvan completamente)



            switch (preguntaActual)
            {
                case 0:
                    btnopm1.BackColor = Color.LightGreen;
                    break;
                case 1:
                    btnopm7.BackColor = Color.LightGreen;
                    break;
                case 2:
                    btnopm10.BackColor = Color.LightGreen;
                    break;
                case 3:
                    btnopm14.BackColor = Color.LightGreen;
                    break;
                case 4:
                    btnopm18.BackColor = Color.LightGreen;
                    break;

            }
        }

        private void ResetearColoresBotones()
        {
            // Resetear todos los botones a su color original
            btnopm1.BackColor = Color.PeachPuff;
            btnopm2.BackColor = Color.PeachPuff;
            btnopm3.BackColor = Color.PeachPuff;
            btnopm4.BackColor = Color.PeachPuff;
            btnopm5.BackColor = Color.PeachPuff;
            btnopm6.BackColor = Color.PeachPuff;
            btnopm7.BackColor = Color.PeachPuff;
            btnopm8.BackColor = Color.PeachPuff;
            btnopm9.BackColor = Color.PeachPuff;
            btnopm10.BackColor = Color.PeachPuff;
            btnopm11.BackColor = Color.PeachPuff;
            btnopm12.BackColor = Color.PeachPuff;
            btnopm13.BackColor = Color.PeachPuff;
            btnopm14.BackColor = Color.PeachPuff;
            btnopm15.BackColor = Color.PeachPuff;
            btnopm16.BackColor = Color.PeachPuff;
            btnopm17.BackColor = Color.PeachPuff;
            btnopm18.BackColor = Color.PeachPuff;
            btnopm19.BackColor = Color.PeachPuff;
            btnopm20.BackColor = Color.PeachPuff;


            // Habilitar todos los botones
            btnopm1.Enabled = true;
            btnopm2.Enabled = true;
            btnopm3.Enabled = true;
            btnopm4.Enabled = true;
            btnopm5.Enabled = true;
            btnopm6.Enabled = true;
            btnopm7.Enabled = true;
            btnopm8.Enabled = true;
            btnopm9.Enabled = true;
            btnopm10.Enabled = true;
            btnopm11.Enabled = true;
            btnopm12.Enabled = true;
            btnopm13.Enabled = true;
            btnopm14.Enabled = true;
            btnopm15.Enabled = true;
            btnopm16.Enabled = true;
            btnopm17.Enabled = true;
            btnopm18.Enabled = true;
            btnopm19.Enabled = true;
            btnopm20.Enabled = true;


        }

        private void MostrarSiguientePregunta()
        {
            panelmay1.Visible = false;
            panelmay2.Visible = false;
            panelmay3.Visible = false;
            panelmay4.Visible = false;
            panelmay5.Visible = false;


            switch (preguntaActual)
            {
                case 1:
                    panelmay2.Location = new Point(38, 98);
                    panelmay2.Visible = true;
                    break;
                case 2:
                    panelmay3.Location = new Point(38, 98);
                    panelmay3.Visible = true;
                    break;
                case 3:
                    panelmay4.Location = new Point(38, 98);
                    panelmay4.Visible = true;
                    break;
                case 4:
                    panelmay5.Location = new Point(38, 98);
                    panelmay5.Visible = true;
                    break;

            }

            lblnumpre.Text = $"{preguntaActual + 1}";
            IniciarTemporizador();
        }

        private void MostrarResultadoFinal()
        {
            temporizador.Stop();

            panelmay1.Visible = false;
            panelmay2.Visible = false;
            panelmay3.Visible = false;
            panelmay4.Visible = false;
            panelmay5.Visible = false;


            panelmay09.Location = new Point(38, 98);
            panelmay09.Visible = true;
        }

        private async Task ProcesarRespuesta(bool esCorrecto, Button botonPresionado, Button botonCorrecto)
        {
            temporizador.Stop();
            DesactivarBotonesPreguntaActual();

            if (esCorrecto)
            {
                puntuacion += 20;
                respuestasCorrectas++;
                labelcorrect2.Text = "¡Correcto! 🥭";
                labelcorrect2.ForeColor = Color.Green;
                botonPresionado.BackColor = Color.LightGreen;
                ReproducirSonidoCorrecto();
            }
            else
            {
                labelcorrect2.Text = "¡Incorrecto! 🥭";
                labelcorrect2.ForeColor = Color.Red;
                botonPresionado.BackColor = Color.LightCoral;
                botonCorrecto.BackColor = Color.LightGreen;
                ReproducirSonidoIncorrecto();
            }

            labelpuntuación.Text = $"Puntuación: {puntuacion}";
            preguntaActual++;

            await Task.Delay(2000);
            labelcorrect2.Text = "";

            if (preguntaActual < 5)
            {
                MostrarSiguientePregunta();
            }
            else
            {
                MostrarResultadoFinal();
            }
        }

        // ============ PREGUNTA 1 ============
        private async void btnopm1_Click(object sender, EventArgs e)
        {
            await ProcesarRespuesta(true, btnopm1, btnopm1);
        }

        private async void btnopm2_Click(object sender, EventArgs e)
        {
            await ProcesarRespuesta(false, btnopm2, btnopm1);
        }

        private async void btnopm3_Click(object sender, EventArgs e)
        {
            await ProcesarRespuesta(false, btnopm3, btnopm1);
        }

        private async void btnopm4_Click(object sender, EventArgs e)
        {
            await ProcesarRespuesta(false, btnopm4, btnopm1);
        }

        // ============ PREGUNTA 2 ============
        private async void btnopm5_Click(object sender, EventArgs e)
        {
            await ProcesarRespuesta(false, btnopm5, btnopm7);
        }

        private async void btnopm6_Click(object sender, EventArgs e)
        {
            await ProcesarRespuesta(false, btnopm6, btnopm7);
        }

        private async void btnopm7_Click(object sender, EventArgs e)
        {
            await ProcesarRespuesta(true, btnopm7, btnopm7);
        }

        private async void btnopm8_Click(object sender, EventArgs e)
        {
            await ProcesarRespuesta(false, btnopm8, btnopm7);
        }

        // ============ PREGUNTA 3 ============
        private async void btnopm9_Click(object sender, EventArgs e)
        {
            await ProcesarRespuesta(false, btnopm9, btnopm10);
        }

        private async void btnopm10_Click(object sender, EventArgs e)
        {
            await ProcesarRespuesta(true, btnopm10, btnopm10);
        }

        private async void btnopm11_Click(object sender, EventArgs e)
        {
            await ProcesarRespuesta(false, btnopm11, btnopm10);
        }

        private async void btnopm12_Click(object sender, EventArgs e)
        {
            await ProcesarRespuesta(false, btnopm12, btnopm10);
        }

        // ============ PREGUNTA 4 ============
        private async void btnopm13_Click(object sender, EventArgs e)
        {
            await ProcesarRespuesta(false, btnopm13, btnopm14);
        }

        private async void btnopm14_Click(object sender, EventArgs e)
        {
            await ProcesarRespuesta(true, btnopm14, btnopm14);
        }

        private async void btnopm15_Click(object sender, EventArgs e)
        {
            await ProcesarRespuesta(false, btnopm15, btnopm14);
        }

        private async void btnopm16_Click(object sender, EventArgs e)
        {
            await ProcesarRespuesta(false, btnopm16, btnopm14);
        }

        // ============ PREGUNTA 5 ============
        private async void btnopm17_Click(object sender, EventArgs e)
        {
            await ProcesarRespuesta(false, btnopm17, btnopm18);
        }

        private async void btnopm18_Click(object sender, EventArgs e)
        {
            await ProcesarRespuesta(true, btnopm18, btnopm18);
        }

        private async void btnopm19_Click(object sender, EventArgs e)
        {
            await ProcesarRespuesta(false, btnopm19, btnopm18);
        }

        private async void btnopm20_Click(object sender, EventArgs e)
        {
            await ProcesarRespuesta(false, btnopm20, btnopm18);
        }




        private void panelmay09_Paint(object sender, PaintEventArgs e)
        {
            lblResultadoFinal1.Text = $"¡Juego Terminado!\n\nTu puntuación: {puntuacion}/100";
            repuestacorrctmay1.Text = $"{respuestasCorrectas}";

            if (puntuacion >= 80)
                lblNivel.Text = "¡Eres un Experto en Mangos! 🏆";
            else if (puntuacion >= 60)
                lblNivel.Text = "¡Buen Conocimiento! 👍";
            else
                lblNivel.Text = "Sigue aprendiendo sobre mangos 📚";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IniciarQuiz();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            temporizador?.Stop();
            mangomayinterf ve54f = new mangomayinterf();
            ve54f.Show();
            this.Hide();
             
        }


        private void JUGARDNUEV0_Click(object sender, EventArgs e)
        {
            ResetearColoresBotones();
            IniciarQuiz();
        }

        private void REGRESARME23_Click(object sender, EventArgs e)
        {
            temporizador?.Stop();
            mangomayinterf ventm2 = new mangomayinterf();
            ventm2.Show();
            this.Hide();
                        
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            temporizador?.Stop();
            temporizador?.Dispose();

            // Liberar recursos de sonidos
            sonidoTicTac?.Dispose();
            sonidoCorrecto?.Dispose();
            sonidoIncorrecto?.Dispose();

            base.OnFormClosing(e);
        }

        private void panelfinalmay1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}