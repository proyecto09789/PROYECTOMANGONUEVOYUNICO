using System;
using System.Timers;

/*EL GAMESTATE ES LA CLASE QUE CONTROLA EL ESTADO DEL JUEGO, 
 COMO LA VIDA, COMIDA, ENERGIA, EXPERIENCIA Y NIVEL DEL JUGADOR.
Y QUE ESTA DISEÑADA COMO UN SINGLETON PARA ASEGURAR QUE SOLO HAYA
UNA INSTANCIA DE ESTA CLASE EN TODO EL JUEGO. TAMBIÉN INCLUYE UN 
TEMPORIZADOR QUE ACTUALIZA EL ESTADO DEL JUEGO CADA SEGUNDO Y
NOTIFICA A LOS SUSCRIPTORES CUANDO HAY CAMBIOS EN EL ESTADO.
*/
namespace PROYECTOMANGO
{
    public sealed class GameState
    {
        //Aquí se implementa el patrón Singleton, asegurando que solo haya una instancia de GameState.
        //Que  es singleton? Un singleton es un patrón de diseño que restringe la instanciación de una clase a un solo objeto.
        private static readonly Lazy<GameState> lazy = new Lazy<GameState>(() => new GameState());

        // Propiedad pública para acceder a la instancia única
        public static GameState Instance => lazy.Value;

        private readonly Timer timer;
        private int tick;

        private readonly object sync = new object();

        // Estado público (lectura)
        public int Vida { get; private set; } = 100;
        public int Comida { get; private set; } = 100;
        public int Energia { get; private set; } = 100; // agua
        public int Experiencia { get; private set; } = 0;
        public int Nivel { get; private set; } = 0;

        // Intervalos (ticks de 1s)
        private readonly int vidaDecayInterval = 5;
        private readonly int comidaDecayInterval = 4;
        private readonly int energiaDecayInterval = 3;

        public event EventHandler StateChanged;

        private GameState()
        {
            timer = new Timer(1000);
            timer.Elapsed += Timer_Elapsed;
            timer.AutoReset = true;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            lock (sync)
            {
                // el tick representa segundos transcurridos
                tick++;


                if (tick % vidaDecayInterval == 0)
                {
                    Vida = Math.Max(0, Vida - 1);
                }
                if (tick % comidaDecayInterval == 0)
                {
                    Comida = Math.Max(0, Comida - 1);
                }
                if (tick % energiaDecayInterval == 0)
                {
                    Energia = Math.Max(0, Energia - 1);
                }
                // opcional: agregar pérdida de vida si comida/agua == 0
                if (Comida == 0 || Energia == 0)
                {
                    Vida = Math.Max(0, Vida - 1);
                }
            }

            StateChanged?.Invoke(this, EventArgs.Empty);
        }

        // Métodos para modificar estado (aseguran límites y notifican)
        public void AddComida(int amount)
        {
            lock (sync)
            {
                Comida = Math.Min(100, Comida + amount);
            }
            StateChanged?.Invoke(this, EventArgs.Empty);
        }

        // Esto sirve para agregar energia (agua), pilas muchachos si le quieren agregar mas agua se le cambia aquí.
        public void AddEnergia(int amount)
        {
            lock (sync)
            {
                Energia = Math.Min(100, Energia + amount);
            }
            StateChanged?.Invoke(this, EventArgs.Empty);
        }

        public void AddVida(int amount)
        {
            lock (sync)
            {
                Vida = Math.Min(100, Vida + amount);
            }
            StateChanged?.Invoke(this, EventArgs.Empty);
        }

        public void AddExperiencia(int amount)
        {
            lock (sync)
            {
                Experiencia += amount;
                if (Experiencia >= 100)
                {
                    Experiencia = 0;
                    Nivel++;
                }
            }
            StateChanged?.Invoke(this, EventArgs.Empty);
        }

        // Para detener el temporizador si lo necesitas
        public void Stop()
        {
            timer.Stop();
        }

        public void Start()
        {
            timer.Start();
        }
    }
}