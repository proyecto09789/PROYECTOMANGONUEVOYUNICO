using System;
using System.Drawing;
using System.Windows.Forms;

namespace PROYECTOMANGO
{
    public partial class CuidaALaMascota : Form
    {
        // Estadísticas
        private int vida = 100;
        private int comida = 80;
        private int energia = 70;
        private int felicidad = 90;
        private int experiencia = 0;
        private int nivel = 0; // 0=Semilla, 1=Brote, 2=Planta, 3=Árbol

        // Animación
        private Timer timerJuego;
        private Timer timerAnimacion;
        private int contadorAnimacion = 0;
        private bool moviendose = false;
        private int posicionX = 0;

        // Estados
        private string[] niveles = { "Semilla", "Brote", "Planta Joven", "Árbol Maduro" };
        private string estadoActual = "normal";

        public CuidaALaMascota()
        {
            InitializeComponent();
            InicializarJuego();
        }

        private void InicializarJuego()
        {
            // Conectar eventos
            btnRegar.Click += BtnRegar_Click;
            btnAlimentar.Click += BtnAlimentar_Click;
            btnJugar.Click += BtnJugar_Click;
            btnDormir.Click += BtnDormir_Click;

            // Timer principal (estadísticas)
            timerJuego = new Timer();
            timerJuego.Interval = 2000;
            timerJuego.Tick += TimerJuego_Tick;
            timerJuego.Start();

            // Timer de animación
            timerAnimacion = new Timer();
            timerAnimacion.Interval = 500;
            timerAnimacion.Tick += TimerAnimacion_Tick;
            timerAnimacion.Start();

            ActualizarInterfaz();
            ActualizarTamanioMascota();
        }

        private void TimerJuego_Tick(object sender, EventArgs e)
        {
            // Disminuir estadísticas con el tiempo
            comida = Math.Max(0, comida - 2);
            energia = Math.Max(0, energia - 1);

            // La felicidad baja si tiene hambre o está cansado
            if (comida < 30 || energia < 30)
                felicidad = Math.Max(0, felicidad - 2);

            // La vida baja si las estadísticas están críticas
            if (comida < 20 || energia < 20 || felicidad < 20)
                vida = Math.Max(0, vida - 1);

            ActualizarInterfaz();
            VerificarEstado();
        }

        private void TimerAnimacion_Tick(object sender, EventArgs e)
        {
            contadorAnimacion++;

            // Animación de respiración
            if (contadorAnimacion % 4 < 2)
            {
                panelMascota.Height = 80 + nivel * 20;
            }
            else
            {
                panelMascota.Height = 82 + nivel * 20;
            }

            // Parpadeo
            if (contadorAnimacion % 10 == 0)
            {
                lblOjos.Text = "- -";
            }
            else if (contadorAnimacion % 10 == 1)
            {
                ActualizarExpresion();
            }

            // Movimiento automático ocasional
            if (!moviendose && contadorAnimacion % 20 == 0 && felicidad > 50)
            {
                MoverMascota();
            }
        }

        private void BtnRegar_Click(object sender, EventArgs e)
        {
            vida = Math.Min(100, vida + 10);
            experiencia += 5;
            lblMensaje.Text = "¡Agua fresquita! 💧";
            estadoActual = "feliz";
            ActualizarExpresion();
            VerificarNivel();
            ActualizarInterfaz();
        }

        private void BtnAlimentar_Click(object sender, EventArgs e)
        {
            comida = Math.Min(100, comida + 35);
            felicidad = Math.Min(100, felicidad + 10);
            energia = Math.Max(0, energia - 3);
            experiencia += 20;

            lblMensaje.Text = "¡Ñam ñam! 🍎";
            estadoActual = "comiendo";
            ActualizarExpresion();
            VerificarNivel();
            ActualizarInterfaz();
        }

        private void BtnJugar_Click(object sender, EventArgs e)
        {
            if (energia < 15)
            {
                lblMensaje.Text = "Estoy muy cansado... 😴";
                estadoActual = "cansado";
                ActualizarExpresion();
                return;
            }

            felicidad = Math.Min(100, felicidad + 30);
            energia = Math.Max(0, energia - 18);
            comida = Math.Max(0, comida - 8);
            experiencia += 12;

            lblMensaje.Text = "¡Weee! ¡Qué divertido! 🎉";
            estadoActual = "jugando";
            ActualizarExpresion();
            MoverMascota();
            Saltar();
            VerificarNivel();
            ActualizarInterfaz();
        }

        private void BtnDormir_Click(object sender, EventArgs e)
        {
            energia = Math.Min(100, energia + 45);
            felicidad = Math.Min(100, felicidad + 8);
            experiencia += 5;

            lblMensaje.Text = "Zzz... 😴💤";
            estadoActual = "durmiendo";
            ActualizarExpresion();
            VerificarNivel();
            ActualizarInterfaz();
        }

        private void ActualizarExpresion()
        {
            // Ojos según estado
            switch (estadoActual)
            {
                case "feliz":
                case "jugando":
                    lblOjos.Text = "◉ ◉";
                    lblBoca.Text = "⌣";
                    break;
                case "cansado":
                case "durmiendo":
                    lblOjos.Text = "- -";
                    lblBoca.Text = "○";
                    break;
                case "comiendo":
                    lblOjos.Text = "◉ ◉";
                    lblBoca.Text = "◯";
                    break;
                case "triste":
                    lblOjos.Text = "◉ ◉";
                    lblBoca.Text = "︵";
                    break;
                default:
                    if (felicidad > 70)
                    {
                        lblOjos.Text = "◉ ◉";
                        lblBoca.Text = "‿";
                    }
                    else if (felicidad < 30)
                    {
                        lblOjos.Text = "◉ ◉";
                        lblBoca.Text = "﹏";
                    }
                    else
                    {
                        lblOjos.Text = "◉ ◉";
                        lblBoca.Text = "▬";
                    }
                    break;
            }

            // Brazos según estado
            if (estadoActual == "jugando")
                lblBrazos.Text = "╲ ╱";
            else if (estadoActual == "cansado")
                lblBrazos.Text = "╲ ╱";
            else
                lblBrazos.Text = "└ ┘";
        }

        private void MoverMascota()
        {
            moviendose = true;
            Timer timerMov = new Timer();
            timerMov.Interval = 100;
            int pasos = 0;
            int direccion = new Random().Next(2) == 0 ? 1 : -1;

            timerMov.Tick += (s, e) =>
            {
                pasos++;
                posicionX += direccion * 10;

                if (posicionX > 200) posicionX = 200;
                if (posicionX < -200) posicionX = -200;

                panelPlanta.Left = 210 + posicionX;

                // Animación de caminar
                lblPiernas.Text = pasos % 2 == 0 ? "/ \\" : "\\ /";

                if (pasos >= 6)
                {
                    timerMov.Stop();
                    timerMov.Dispose();
                    moviendose = false;
                    lblPiernas.Text = "| |";
                }
            };
            timerMov.Start();
        }

        private void Saltar()
        {
            Timer timerSalto = new Timer();
            timerSalto.Interval = 50;
            int frame = 0;
            int posY = panelPlanta.Top;

            timerSalto.Tick += (s, e) =>
            {
                frame++;
                if (frame <= 5)
                    panelPlanta.Top = posY - (frame * 8);
                else if (frame <= 10)
                    panelPlanta.Top = posY - ((10 - frame) * 8);
                else
                {
                    panelPlanta.Top = posY;
                    timerSalto.Stop();
                    timerSalto.Dispose();
                }
            };
            timerSalto.Start();
        }

        private void VerificarNivel()
        {
            int nivelAnterior = nivel;

            if (experiencia >= 100 && nivel == 0) nivel = 1;
            else if (experiencia >= 250 && nivel == 1) nivel = 2;
            else if (experiencia >= 500 && nivel == 2) nivel = 3;

            if (nivel > nivelAnterior)
            {
                lblMensaje.Text = $"¡Subí de nivel! Ahora soy {niveles[nivel]} 🎊";
                ActualizarTamanioMascota();
            }
        }

        private void ActualizarTamanioMascota()
        {
            // Crecer según nivel
            int tamano = 80 + (nivel * 25);
            panelMascota.Size = new Size(tamano, tamano);
            panelMascota.Left = (panelPlanta.Width - tamano) / 2;

            // Ajustar posición vertical
            panelMascota.Top = -(tamano - 20);

            // Cambiar altura de la tierra
            panelPlanta.Height = 100 + (nivel * 15);
            panelPlanta.Top = 400 - panelPlanta.Height;

            // Cambiar color según crecimiento
            Color[] colores = {
                Color.FromArgb(255, 220, 100),  // Semilla - amarillo
                Color.FromArgb(180, 230, 100),  // Brote - verde claro
                Color.FromArgb(100, 200, 50),   // Planta - verde
                Color.FromArgb(50, 150, 30)     // Árbol - verde oscuro
            };
            panelMascota.BackColor = colores[nivel];
        }

        private void ActualizarInterfaz()
        {
            pbVida.Value = vida;
            lblVidaValor.Text = vida.ToString();

            pbComida.Value = comida;
            lblComidaValor.Text = comida.ToString();

            pbEnergia.Value = energia;
            lblEnergiaValor.Text = energia.ToString();

            pbFelicidad.Value = felicidad;
            lblFelicidadValor.Text = felicidad.ToString();

            string expMax;
            if (nivel < 3)
            {
                if (nivel == 0)
                    expMax = "100";
                else if (nivel == 1)
                    expMax = "250";
                else
                    expMax = "500";
            }
            else
            {
                expMax = "MAX";
            }
            lblNivel.Text = $"Nivel: {niveles[nivel]}\nExp: {experiencia}/{expMax}";
        }

        private void VerificarEstado()
        {
            if (comida < 20)
            {
                lblEstado.Text = "¡Tengo hambre! 🍎";
                estadoActual = "triste";
            }
            else if (energia < 20)
            {
                lblEstado.Text = "Necesito dormir... 😴";
                estadoActual = "cansado";
            }
            else if (felicidad < 30)
            {
                lblEstado.Text = "Estoy aburrido... 😢";
                estadoActual = "triste";
            }
            else if (felicidad > 80 && comida > 60)
            {
                lblEstado.Text = "¡Me siento genial! 😊";
                estadoActual = "feliz";
            }

            ActualizarExpresion();

            if (vida <= 0)
            {
                timerJuego.Stop();
                timerAnimacion.Stop();
                MessageBox.Show("Oh no... Manguito necesitaba más cuidados 😢\n¡Inténtalo de nuevo!",
                    "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ReiniciarJuego();
            }
        }

        private void ReiniciarJuego()
        {
            vida = 100;
            comida = 80;
            energia = 70;
            felicidad = 90;
            experiencia = 0;
            nivel = 0;
            posicionX = 0;

            panelPlanta.Left = 210;
            lblEstado.Text = "🌱 Cuida a Manguito";
            lblMensaje.Text = "¡Hola! Soy Manguito 🥭";

            ActualizarTamanioMascota();
            ActualizarInterfaz();
            ActualizarExpresion();

            timerJuego.Start();
            timerAnimacion.Start();
        }

       
    }
}