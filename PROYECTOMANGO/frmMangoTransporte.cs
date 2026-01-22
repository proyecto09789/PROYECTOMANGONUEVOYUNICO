using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PROYECTOMANGO
{
    public partial class frmMangoTransporte : Form
    {
        private readonly Dictionary<Panel, Control> origenEtapa = new Dictionary<Panel, Control>();

        private readonly Dictionary<Panel, int> indiceOriginal = new Dictionary<Panel, int>();

        private int intentos = 3;

        public frmMangoTransporte()
        {
            InitializeComponent();
        }

        private void frmMangoTransporte_Load(object sender, EventArgs e)
        {
            CargarEtapas();
            PrepararSlots();

            RegistrarOrigenEtapas();
            ActualizarIntentosUI();
        }
        private void ActualizarIntentosUI()
        {
            if (intentos <= 0) return;

            lblIntentos.Text = $"Intentos: {intentos}/3";

            if (intentos == 3)
                lblIntentos.ForeColor = Color.Green;
            else if (intentos == 2)
                lblIntentos.ForeColor = Color.Orange;
            else
                lblIntentos.ForeColor = Color.Red;
        }

        private void MostrarJuegoCompletado()
        {
            lblIntentos.Text = "Has ganado";
            lblIntentos.ForeColor = Color.DarkGreen;
            lblIntentos.Font = new Font(lblIntentos.Font, FontStyle.Bold);

            btnVerificar.Enabled = false;
            BloquearMovimiento(); 
        }
        private void MostrarHasPerdido()
        {
            lblIntentos.Text = "Has perdido";
            lblIntentos.ForeColor = Color.DarkRed;
            lblIntentos.Font = new Font(lblIntentos.Font, FontStyle.Bold);

            btnVerificar.Enabled = false;
            BloquearMovimiento();
        }



        private void RegistrarOrigenEtapas()
        {
            RegistrarOrigen(panelEtapa1);
            RegistrarOrigen(panelEtapa2);
            RegistrarOrigen(panelEtapa3);
            RegistrarOrigen(panelEtapa4);
            RegistrarOrigen(panelEtapa5);
        }

        private void RegistrarOrigen(Panel etapa)
        {
            if (etapa?.Parent == null) return;

            origenEtapa[etapa] = etapa.Parent;

            indiceOriginal[etapa] = etapa.Parent.Controls.GetChildIndex(etapa);
        }

        private void CargarEtapas()
        {
            AsignarEtapa(panelEtapa1, Properties.Resources.cosecha, 1);
            AsignarEtapa(panelEtapa2, Properties.Resources.lavado, 2);
            AsignarEtapa(panelEtapa3, Properties.Resources.empaque, 3);
            AsignarEtapa(panelEtapa4, Properties.Resources.transporte, 4);
            AsignarEtapa(panelEtapa5, Properties.Resources.entrega, 5);
        }

        private void AsignarEtapa(Panel panel, Image imagen, int ordenCorrecto)
        {
            panel.Controls.Clear();
            panel.Tag = ordenCorrecto;
            panel.AllowDrop = true;

            PictureBox pb = new PictureBox();
            pb.Dock = DockStyle.Fill;
            pb.Image = imagen;
            pb.SizeMode = PictureBoxSizeMode.Zoom;

            pb.MouseDown += Etapa_MouseDown;
            panel.MouseDown += Etapa_MouseDown;

            panel.Controls.Add(pb);
        }

        private void Etapa_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            Control c = sender as Control;
            Panel etapa = c as Panel ?? c.Parent as Panel;

            if (etapa != null)
                etapa.DoDragDrop(etapa, DragDropEffects.Move);
        }

        private void PrepararSlots()
        {
            PrepararSlot(panelLlegada1);
            PrepararSlot(panelLlegada2);
            PrepararSlot(panelLlegada3);
            PrepararSlot(panelLlegada4);
            PrepararSlot(panelLlegada5);
        }

        private void PrepararSlot(Panel slot)
        {
            slot.AllowDrop = true;
            slot.DragEnter += Slot_DragEnter;
            slot.DragDrop += Slot_DragDrop;
        }

        private void Slot_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Panel)))
                e.Effect = DragDropEffects.Move;
        }

        private void Slot_DragDrop(object sender, DragEventArgs e)
        {
            Panel slot = sender as Panel;
            Panel etapa = (Panel)e.Data.GetData(typeof(Panel));

            if (slot == null || etapa == null) return;

            if (slot.Controls.OfType<Panel>().Any())
            {
                MessageBox.Show("Este lugar ya está ocupado");
                return;
            }

            etapa.Parent.Controls.Remove(etapa);
            etapa.Dock = DockStyle.Fill;
            slot.Controls.Add(etapa);
        }

        private void RestaurarEtapasAlOrigen()
        {
            Panel[] etapas = { panelEtapa1, panelEtapa2, panelEtapa3, panelEtapa4, panelEtapa5 };

            foreach (Panel etapa in etapas)
            {
                if (etapa == null) continue;
                if (!origenEtapa.ContainsKey(etapa)) continue;

                Control contenedorOriginal = origenEtapa[etapa];

                etapa.Parent?.Controls.Remove(etapa);

                etapa.Dock = DockStyle.None;

                contenedorOriginal.Controls.Add(etapa);

                if (indiceOriginal.TryGetValue(etapa, out int idx))
                    contenedorOriginal.Controls.SetChildIndex(etapa, idx);
            }
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            Panel[] slots =
            {
                panelLlegada1,
                panelLlegada2,
                panelLlegada3,
                panelLlegada4,
                panelLlegada5
            };

            for (int i = 0; i < slots.Length; i++)
            {
                Panel etapa = slots[i].Controls.OfType<Panel>().FirstOrDefault();

                if (etapa == null)
                {
                    MessageBox.Show("Completa todas las etapas");
                    return;
                }

                if ((int)etapa.Tag != i + 1)
                {
                    intentos--;
                    ActualizarIntentosUI();

                    MessageBox.Show($"Orden incorrecto,\nte quedan {intentos} intento(s).");

                    RestaurarEtapasAlOrigen();

                    if (intentos <= 0)
                    {
                        MessageBox.Show("Se acabaron los intentos,\nJuego terminado.");

                        MostrarHasPerdido();
                    }
                    return;
                }
            }

            MessageBox.Show("Proceso de transporte del mango correcto!");
            MostrarJuegoCompletado();
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void BloquearMovimiento()
        {
          Panel[] etapas =
            {
                panelEtapa1,
                panelEtapa2,
                panelEtapa3,
                panelEtapa4,
                panelEtapa5
            };

          foreach (var etapa in etapas)
            {
                etapa.AllowDrop = false;
                etapa.MouseDown -= Etapa_MouseDown;
            }

          Panel[] slots =
            {
                panelLlegada1,
                panelLlegada2,
                panelLlegada3,
                panelLlegada4,
                panelLlegada5
            };

           foreach (var slot in slots)
              slot.AllowDrop = false;
        }
    }
}
