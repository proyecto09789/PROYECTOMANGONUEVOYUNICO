using PROYECTOBETA001;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace MangoApp
{
    public partial class Benefimango01 : Form
    {
        // Colores temáticos del mango
        private Color mangoYellow = Color.FromArgb(255, 187, 51);
        private Color mangoOrange = Color.FromArgb(255, 142, 28);
        private Color mangoRed = Color.FromArgb(229, 57, 53);
        private Color mangoGreen = Color.FromArgb(67, 160, 71);
        private Color lightCream = Color.FromArgb(255, 248, 225);

        // Sistema de gamificación
        private HashSet<Panel> tarjetasExploradas = new HashSet<Panel>();
        private HashSet<Panel> tarjetasFavoritas = new HashSet<Panel>();
        private int puntos = 0;
        private Random random = new Random();

        // Datos curiosos sobre el mango
        private string[] datosCuriosos = new string[]
        {
            "🥭 Los mangos pertenecen a la misma familia que los anacardos y pistachos.",
            "🌍 Existen más de 1,000 variedades diferentes de mango en el mundo.",
            "📜 El mango ha sido cultivado por más de 4,000 años en India.",
            "🎨 Los mangos contienen más de 20 vitaminas y minerales diferentes.",
            "⚖️ Un mango promedio contiene solo 99 calorías por taza.",
            "🌳 Un árbol de mango puede producir frutos durante más de 100 años.",
            "👑 En India, el mango es conocido como 'El Rey de las Frutas'.",
            "💪 Los mangos fueron la fruta favorita de Gandhi durante su juventud."
        };

        // Preguntas del quiz
        private List<QuizQuestion> preguntasQuiz = new List<QuizQuestion>
        {
            new QuizQuestion
            {
                Pregunta = "¿Qué porcentaje del requerimiento diario de vitamina C cubre una taza de mango?",
                Respuestas = new[] { "67%", "45%", "30%", "90%" },
                RespuestaCorrecta = 0
            },
            new QuizQuestion
            {
                Pregunta = "¿Cuál de estos NO es un beneficio del mango?",
                Respuestas = new[] { "Mejora la digestión", "Fortalece el sistema inmune", "Reduce el apetito drásticamente", "Protege la vista" },
                RespuestaCorrecta = 2
            },
            new QuizQuestion
            {
                Pregunta = "¿Qué mineral del mango ayuda a regular la presión arterial?",
                Respuestas = new[] { "Calcio", "Potasio", "Hierro", "Zinc" },
                RespuestaCorrecta = 1
            },
            new QuizQuestion
            {
                Pregunta = "¿Cuántas calorías tiene aproximadamente una taza de mango?",
                Respuestas = new[] { "150", "99", "200", "50" },
                RespuestaCorrecta = 1
            }
        };

        public Benefimango01()
        {
            InitializeComponent();
            InicializarInteractividad();
        }

        private void InicializarInteractividad()
        {
            // Agregar clic a cada tarjeta para marcarla como explorada
            foreach (Control control in benefitsPanel.Controls)
            {
                if (control is Panel card && card.Name.StartsWith("card"))
                {
                    card.Click += Card_Click;
                    // Agregar evento a todos los controles hijos también
                    foreach (Control child in card.Controls)
                    {
                        child.Click += (s, e) => Card_Click(card, e);
                    }
                }
            }

            // Agregar panel de progreso
            AgregarPanelProgreso();
        }

        private void AgregarPanelProgreso()
        {
            Panel progresoPanel = new Panel
            {
                Size = new Size(250, 60),
                Location = new Point(991, 688),
                BackColor = mangoYellow
            };

            Label lblProgreso = new Label
            {
                Text = "🎯 Exploradas: 0/8",
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(10, 10),
                Size = new Size(230, 25),
                Name = "lblProgreso"
            };

            Label lblPuntos = new Label
            {
                Text = "⭐ Puntos: 0",
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(10, 35),
                Size = new Size(230, 20),
                Name = "lblPuntos"
            };

            progresoPanel.Controls.Add(lblProgreso);
            progresoPanel.Controls.Add(lblPuntos);
            this.Controls.Add(progresoPanel);
            progresoPanel.BringToFront();
        }

        private void Card_Click(object sender, EventArgs e)
        {
            Panel card = sender as Panel;
            if (card != null && !tarjetasExploradas.Contains(card))
            {
                tarjetasExploradas.Add(card);
                puntos += 10;
                ActualizarProgreso();

                // Efecto visual de "descubierto"
                AnimarTarjetaDescubierta(card);

                // Mostrar dato curioso aleatorio
                if (random.Next(0, 2) == 0)
                {
                    MostrarDatoCurioso();
                }

                // Si completó todas las tarjetas
                if (tarjetasExploradas.Count == 8)
                {
                    MostrarFelicitacion();
                }
            }
        }

        private void AnimarTarjetaDescubierta(Panel card)
        {
            Timer timer = new Timer { Interval = 50 };
            int contador = 0;
            Color colorOriginal = card.BackColor;

            timer.Tick += (s, e) =>
            {
                contador++;
                if (contador % 2 == 0)
                    card.BackColor = mangoYellow;
                else
                    card.BackColor = colorOriginal;

                if (contador >= 6)
                {
                    card.BackColor = colorOriginal;
                    timer.Stop();
                    timer.Dispose();
                }
            };
            timer.Start();
        }

        private void ActualizarProgreso()
        {
            Label lblProgreso = this.Controls.Find("lblProgreso", true).FirstOrDefault() as Label;
            Label lblPuntos = this.Controls.Find("lblPuntos", true).FirstOrDefault() as Label;

            if (lblProgreso != null)
                lblProgreso.Text = $"🎯 Exploradas: {tarjetasExploradas.Count}/8";

            if (lblPuntos != null)
                lblPuntos.Text = $"⭐ Puntos: {puntos}";
        }

        private void MostrarDatoCurioso()
        {
            string dato = datosCuriosos[random.Next(datosCuriosos.Length)];

            Form datoForm = new Form
            {
                Text = "💡 Dato Curioso del Mango",
                Size = new Size(500, 200),
                StartPosition = FormStartPosition.CenterParent,
                BackColor = lightCream,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false
            };

            Label lblDato = new Label
            {
                Text = dato,
                Font = new Font("Segoe UI", 12, FontStyle.Regular),
                ForeColor = Color.FromArgb(80, 80, 80),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                Padding = new Padding(30)
            };

            Button btnOk = new Button
            {
                Text = "¡Interesante! 👍",
                Size = new Size(150, 40),
                Location = new Point(175, 110),
                BackColor = mangoOrange,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };
            btnOk.FlatAppearance.BorderSize = 0;
            btnOk.Click += (s, e) => { puntos += 5; ActualizarProgreso(); datoForm.Close(); };

            datoForm.Controls.Add(lblDato);
            datoForm.Controls.Add(btnOk);
            datoForm.ShowDialog();
        }

        private void MostrarFelicitacion()
        {
            DialogResult result = MessageBox.Show(
                "🎉 ¡FELICITACIONES! 🎉\n\n" +
                "¡Has explorado todos los beneficios del mango!\n\n" +
                $"Puntos totales: {puntos}\n\n" +
                "¿Quieres probar el quiz sobre el mango?",
                "¡Exploración Completa!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                IniciarQuiz();
            }
        }

        private void HeaderPanel_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            using (LinearGradientBrush brush = new LinearGradientBrush(
                panel.ClientRectangle,
                mangoYellow,
                mangoOrange,
                LinearGradientMode.Horizontal))
            {
                e.Graphics.FillRectangle(brush, panel.ClientRectangle);
            }
        }

        private void Card_Paint(object sender, PaintEventArgs e)
        {
            Panel card = sender as Panel;
            Color accentColor = (Color)card.Tag;

            using (Pen pen = new Pen(accentColor, 3))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, card.Width - 1, card.Height - 1);
            }

            using (Brush brush = new SolidBrush(accentColor))
            {
                e.Graphics.FillRectangle(brush, 0, 0, card.Width, 5);
            }

            // Dibujar estrella si está en favoritos
            if (tarjetasFavoritas.Contains(card))
            {
                e.Graphics.DrawString("⭐", new Font("Segoe UI", 16),
                    Brushes.Gold, card.Width - 40, 10);
            }

            // Dibujar checkmark si fue explorada
            if (tarjetasExploradas.Contains(card))
            {
                e.Graphics.DrawString("✓", new Font("Segoe UI", 20, FontStyle.Bold),
                    Brushes.LimeGreen, card.Width - 40, card.Height - 40);
            }
        }

        private void Card_MouseEnter(object sender, EventArgs e)
        {
            Panel card = sender as Panel;
            card.BackColor = lightCream;
            card.Cursor = Cursors.Hand;

            // Efecto de elevación
            card.Location = new Point(card.Location.X, card.Location.Y - 5);
        }

        private void Card_MouseLeave(object sender, EventArgs e)
        {
            Panel card = sender as Panel;
            card.BackColor = Color.White;
            card.Cursor = Cursors.Default;

            // Restaurar posición
            card.Location = new Point(card.Location.X, card.Location.Y + 5);
        }

        private void BtnShowReferences_Click(object sender, EventArgs e)
        {
            MostrarReferenciasModerna();
        }

        private void BtnShowQuiz_Click(object sender, EventArgs e)
        {
            IniciarQuiz();
        }

        private void BtnCalculator_Click(object sender, EventArgs e)
        {
            MostrarCalculadoraMango();
        }

        private void MostrarCalculadoraMango()
        {
            Form calcForm = new Form
            {
                Text = "🧮 Calculadora Nutricional del Mango",
                Size = new Size(600, 500),
                StartPosition = FormStartPosition.CenterParent,
                BackColor = lightCream,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false
            };

            // Header
            Panel headerPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 80,
                BackColor = mangoGreen
            };

            Label titulo = new Label
            {
                Text = "🧮 CALCULADORA DE NUTRIENTES",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                ForeColor = Color.White,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            };
            headerPanel.Controls.Add(titulo);

            // Input de porciones
            Label lblPregunta = new Label
            {
                Text = "¿Cuántas tazas de mango vas a consumir?",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                Location = new Point(50, 110),
                Size = new Size(500, 30),
                ForeColor = Color.FromArgb(80, 80, 80)
            };

            NumericUpDown numPorciones = new NumericUpDown
            {
                Location = new Point(220, 150),
                Size = new Size(150, 30),
                Font = new Font("Segoe UI", 14),
                Minimum = 0.5m,
                Maximum = 10,
                DecimalPlaces = 1,
                Value = 1,
                Increment = 0.5m
            };

            Label lblResultado = new Label
            {
                Location = new Point(50, 220),
                Size = new Size(500, 200),
                Font = new Font("Segoe UI", 11),
                ForeColor = Color.FromArgb(60, 60, 60),
                Text = ""
            };

            Button btnCalcular = new Button
            {
                Text = "Calcular Nutrientes",
                Size = new Size(200, 45),
                Location = new Point(200, 400),
                BackColor = mangoOrange,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnCalcular.FlatAppearance.BorderSize = 0;

            btnCalcular.Click += (s, ev) =>
            {
                decimal porciones = numPorciones.Value;
                int calorias = (int)(99 * porciones);
                decimal fibra = 2.6m * porciones;
                int potasio = (int)(277 * porciones);
                int vitaminaC = (int)(60 * porciones);
                int vitaminaA = (int)(90 * porciones);

                lblResultado.Text = $"📊 RESULTADOS PARA {porciones} TAZA(S):\n\n" +
                    $"🔥 Calorías: {calorias} kcal\n" +
                    $"🌾 Fibra: {fibra:F1}g\n" +
                    $"⚡ Potasio: {potasio}mg\n" +
                    $"🍊 Vitamina C: {vitaminaC}mg ({(int)(vitaminaC / 0.6)}% VD*)\n" +
                    $"🥕 Vitamina A: {vitaminaA}µg\n\n" +
                    $"*VD = Valor Diario recomendado";

                puntos += 5;
                ActualizarProgreso();
            };

            calcForm.Controls.Add(headerPanel);
            calcForm.Controls.Add(lblPregunta);
            calcForm.Controls.Add(numPorciones);
            calcForm.Controls.Add(lblResultado);
            calcForm.Controls.Add(btnCalcular);

            calcForm.ShowDialog();
        }

        private void MostrarReferenciasModerna()
        {
            Form referencesForm = new Form
            {
                Text = "📚 Referencias Científicas - Beneficios del Mango",
                Size = new Size(1000, 700),
                StartPosition = FormStartPosition.CenterParent,
                BackColor = lightCream,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false
            };

            // Panel header
            Panel headerPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 100,
                BackColor = mangoOrange
            };

            Label titleLabel = new Label
            {
                Text = "📚 REFERENCIAS CIENTÍFICAS",
                Font = new Font("Segoe UI", 20, FontStyle.Bold),
                ForeColor = Color.White,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Top,
                Height = 50,
                Padding = new Padding(0, 10, 0, 0)
            };

            Label subtitleLabel = new Label
            {
                Text = "Investigaciones verificadas sobre los beneficios del mango",
                Font = new Font("Segoe UI", 11, FontStyle.Italic),
                ForeColor = lightCream,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Bottom,
                Height = 40
            };

            headerPanel.Controls.Add(titleLabel);
            headerPanel.Controls.Add(subtitleLabel);

            // Panel de referencias con scroll
            Panel referencesPanel = new Panel
            {
                Location = new Point(20, 120),
                Size = new Size(940, 470),
                BackColor = Color.White,
                AutoScroll = true,
                BorderStyle = BorderStyle.FixedSingle
            };

            int yPos = 20;
            var referencias = ObtenerReferencias();

            foreach (var referencia in referencias)
            {
                Panel refCard = CrearTarjetaReferencia(referencia, yPos);
                referencesPanel.Controls.Add(refCard);
                yPos += 140;
            }

            // Panel de botones
            Panel buttonPanel = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 80,
                BackColor = lightCream
            };

            Button btnQuiz = new Button
            {
                Text = "🎮 Jugar Quiz",
                Size = new Size(180, 50),
                Location = new Point(220, 15),
                BackColor = mangoGreen,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnQuiz.FlatAppearance.BorderSize = 0;
            btnQuiz.Click += (s, ev) => { referencesForm.Close(); IniciarQuiz(); };

            Button btnDato = new Button
            {
                Text = "💡 Dato Curioso",
                Size = new Size(180, 50),
                Location = new Point(420, 15),
                BackColor = mangoYellow,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnDato.FlatAppearance.BorderSize = 0;
            btnDato.Click += (s, ev) => MostrarDatoCurioso();

            Button btnCerrar = new Button
            {
                Text = "✓ Cerrar",
                Size = new Size(180, 50),
                Location = new Point(620, 15),
                BackColor = mangoRed,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.Click += (s, ev) => referencesForm.Close();

            buttonPanel.Controls.Add(btnQuiz);
            buttonPanel.Controls.Add(btnDato);
            buttonPanel.Controls.Add(btnCerrar);

            referencesForm.Controls.Add(headerPanel);
            referencesForm.Controls.Add(referencesPanel);
            referencesForm.Controls.Add(buttonPanel);

            referencesForm.ShowDialog();
        }

        private Panel CrearTarjetaReferencia(ReferenciaInfo referencia, int yPos)
        {
            Panel card = new Panel
            {
                Location = new Point(20, yPos),
                Size = new Size(880, 120),
                BackColor = lightCream,
                BorderStyle = BorderStyle.None
            };

            // Borde izquierdo colorido
            Panel border = new Panel
            {
                Location = new Point(0, 0),
                Size = new Size(5, 120),
                BackColor = referencia.Color
            };

            Label lblNumero = new Label
            {
                Text = referencia.Numero,
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                ForeColor = referencia.Color,
                Location = new Point(15, 10),
                Size = new Size(50, 30)
            };

            Label lblTitulo = new Label
            {
                Text = referencia.Titulo,
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                ForeColor = Color.FromArgb(40, 40, 40),
                Location = new Point(70, 10),
                Size = new Size(790, 25)
            };

            Label lblAutor = new Label
            {
                Text = referencia.Autor,
                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                ForeColor = Color.FromArgb(100, 100, 100),
                Location = new Point(70, 35),
                Size = new Size(790, 20)
            };

            LinkLabel lblUrl = new LinkLabel
            {
                Text = "🔗 Ver fuente completa",
                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                LinkColor = mangoOrange,
                Location = new Point(70, 60),
                Size = new Size(200, 20),
                Cursor = Cursors.Hand
            };
            lblUrl.LinkClicked += (s, e) =>
            {
                try
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = referencia.Url,
                        UseShellExecute = true
                    });
                }
                catch { }
            };

            Label lblDesc = new Label
            {
                Text = referencia.Descripcion,
                Font = new Font("Segoe UI", 8, FontStyle.Italic),
                ForeColor = Color.FromArgb(120, 120, 120),
                Location = new Point(70, 85),
                Size = new Size(790, 30)
            };

            card.Controls.Add(border);
            card.Controls.Add(lblNumero);
            card.Controls.Add(lblTitulo);
            card.Controls.Add(lblAutor);
            card.Controls.Add(lblUrl);
            card.Controls.Add(lblDesc);

            return card;
        }

        private List<ReferenciaInfo> ObtenerReferencias()
        {
            return new List<ReferenciaInfo>
            {
                new ReferenciaInfo
                {
                    Numero = "1",
                    Titulo = "Mango: Nutrition, Health Benefits, and How to Eat It",
                    Autor = "Healthline (2025)",
                    Url = "https://www.healthline.com/nutrition/mango",
                    Descripcion = "Revisión nutricional completa y actualizada sobre los beneficios del mango.",
                    Color = mangoRed
                },
                new ReferenciaInfo
                {
                    Numero = "2",
                    Titulo = "Mango Consumption is Associated with Improved Nutrient Intakes",
                    Autor = "Papanikolaou Y, Fulgoni VL - Nutrients (2022)",
                    Url = "https://pmc.ncbi.nlm.nih.gov/articles/PMC8746860/",
                    Descripcion = "Estudio basado en NHANES 2001-2018 sobre calidad dietética y control de peso.",
                    Color = mangoOrange
                },
                new ReferenciaInfo
                {
                    Numero = "3",
                    Titulo = "Multifaceted Health Benefits of Mangifera indica L. (Mango)",
                    Autor = "Lauricella M, Emanuele S, et al. - Nutrients (2017)",
                    Url = "https://pmc.ncbi.nlm.nih.gov/articles/PMC5452255/",
                    Descripcion = "Investigación sobre propiedades antioxidantes y anticancerígenas del mango.",
                    Color = mangoYellow
                },
                new ReferenciaInfo
                {
                    Numero = "4",
                    Titulo = "Is mango the luscious superhero of fruit?",
                    Autor = "American Heart Association (2021)",
                    Url = "https://www.heart.org/en/news/2021/06/02/is-mango-the-luscious-superhero-of-fruit",
                    Descripcion = "Análisis científico de los beneficios cardiovasculares del mango.",
                    Color = mangoRed
                },
                new ReferenciaInfo
                {
                    Numero = "5",
                    Titulo = "Health benefits of the mango fruit - Recent review",
                    Autor = "PubMed (2025) - PMID: 41114828",
                    Url = "https://pubmed.ncbi.nlm.nih.gov/41114828/",
                    Descripcion = "Revisión reciente de literatura científica sobre beneficios del mango.",
                    Color = mangoGreen
                },
                new ReferenciaInfo
                {
                    Numero = "6",
                    Titulo = "The Top 6 Health Benefits of Mango",
                    Autor = "Cleveland Clinic (2023)",
                    Url = "https://health.clevelandclinic.org/mango-benefits",
                    Descripcion = "Información médica verificada sobre beneficios digestivos y nutricionales.",
                    Color = mangoOrange
                },
                new ReferenciaInfo
                {
                    Numero = "7",
                    Titulo = "The contribution of mango to human nutrition and health",
                    Autor = "ScienceDirect (2023)",
                    Url = "https://www.sciencedirect.com/science/article/pii/S1878535223003222",
                    Descripcion = "Investigación sobre la contribución nutricional del mango a la salud humana.",
                    Color = mangoYellow
                },
                new ReferenciaInfo
                {
                    Numero = "8",
                    Titulo = "Two New Studies Find Positive Health Outcomes",
                    Autor = "National Mango Board (2024)",
                    Url = "https://www.mango.org/blog/two-new-studies-find-positive-health-outcomes-of-mango-consumption/",
                    Descripcion = "Estudios recientes sobre resultados positivos del consumo de mango.",
                    Color = mangoRed
                }
            };
        }

        private void IniciarQuiz()
        {
            QuizForm quizForm = new QuizForm(preguntasQuiz, mangoOrange, mangoYellow, lightCream);
            if (quizForm.ShowDialog() == DialogResult.OK)
            {
                int puntosQuiz = quizForm.PuntosObtenidos;
                puntos += puntosQuiz;
                ActualizarProgreso();

                MessageBox.Show(
                    $"🎉 ¡Quiz Completado! 🎉\n\n" +
                    $"Respuestas correctas: {puntosQuiz / 25}/{preguntasQuiz.Count}\n" +
                    $"Puntos ganados: {puntosQuiz}\n\n" +
                    $"¡Sigue aprendiendo sobre el mango!",
                    "Resultado del Quiz",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mangomayinterf vent0001 = new mangomayinterf();
            vent0001.Show();
            this.Hide();
        }
    }

    // Clases auxiliares
    public class QuizQuestion
    {
        public string Pregunta { get; set; }
        public string[] Respuestas { get; set; }
        public int RespuestaCorrecta { get; set; }
    }

    public class ReferenciaInfo
    {
        public string Numero { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Url { get; set; }
        public string Descripcion { get; set; }
        public Color Color { get; set; }
    }

    // Formulario del Quiz
    public class QuizForm : Form
    {
        private List<QuizQuestion> preguntas;
        private int preguntaActual = 0;
        private int respuestasCorrectas = 0;
        private Color colorPrimario;
        private Color colorSecundario;
        private Color colorFondo;
        public int PuntosObtenidos { get; private set; }

        private Label lblPregunta;
        private RadioButton[] opciones;
        private Button btnSiguiente;
        private Label lblProgreso;

        public QuizForm(List<QuizQuestion> preguntas, Color primario, Color secundario, Color fondo)
        {
            this.preguntas = preguntas;
            this.colorPrimario = primario;
            this.colorSecundario = secundario;
            this.colorFondo = fondo;

            InitializeQuiz();
        }

        private void InitializeQuiz()
        {
            this.Text = "🎮 Quiz del Mango";
            this.Size = new Size(700, 500);
            this.StartPosition = FormStartPosition.CenterParent;
            this.BackColor = colorFondo;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            // Header
            Panel headerPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 80,
                BackColor = colorPrimario
            };

            Label titulo = new Label
            {
                Text = "🎮 QUIZ SOBRE EL MANGO",
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                ForeColor = Color.White,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            };

            headerPanel.Controls.Add(titulo);

            // Progreso
            lblProgreso = new Label
            {
                Text = "Pregunta 1 de " + preguntas.Count,
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                ForeColor = Color.FromArgb(80, 80, 80),
                Location = new Point(30, 100),
                Size = new Size(640, 25)
            };

            // Pregunta
            lblPregunta = new Label
            {
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = Color.FromArgb(40, 40, 40),
                Location = new Point(30, 140),
                Size = new Size(640, 60),
                AutoSize = false
            };

            // Opciones
            opciones = new RadioButton[4];
            for (int i = 0; i < 4; i++)
            {
                opciones[i] = new RadioButton
                {
                    Font = new Font("Segoe UI", 12),
                    Location = new Point(50, 220 + (i * 50)),
                    Size = new Size(600, 40),
                    Cursor = Cursors.Hand
                };
            }

            // Botón siguiente
            btnSiguiente = new Button
            {
                Text = "Siguiente ➜",
                Size = new Size(200, 50),
                Location = new Point(250, 400),
                BackColor = colorPrimario,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnSiguiente.FlatAppearance.BorderSize = 0;
            btnSiguiente.Click += BtnSiguiente_Click;

            this.Controls.Add(headerPanel);
            this.Controls.Add(lblProgreso);
            this.Controls.Add(lblPregunta);
            foreach (var opcion in opciones)
                this.Controls.Add(opcion);
            this.Controls.Add(btnSiguiente);

            CargarPregunta();
        }

        private void CargarPregunta()
        {
            var pregunta = preguntas[preguntaActual];
            lblProgreso.Text = $"Pregunta {preguntaActual + 1} de {preguntas.Count}";
            lblPregunta.Text = pregunta.Pregunta;

            for (int i = 0; i < 4; i++)
            {
                opciones[i].Text = pregunta.Respuestas[i];
                opciones[i].Checked = false;
            }

            if (preguntaActual == preguntas.Count - 1)
                btnSiguiente.Text = "Finalizar ✓";
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            int respuestaSeleccionada = -1;
            for (int i = 0; i < opciones.Length; i++)
            {
                if (opciones[i].Checked)
                {
                    respuestaSeleccionada = i;
                    break;
                }
            }

            if (respuestaSeleccionada == -1)
            {
                MessageBox.Show("Por favor selecciona una respuesta", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (respuestaSeleccionada == preguntas[preguntaActual].RespuestaCorrecta)
            {
                respuestasCorrectas++;
            }

            preguntaActual++;

            if (preguntaActual < preguntas.Count)
            {
                CargarPregunta();
            }
            else
            {
                PuntosObtenidos = respuestasCorrectas * 25;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}