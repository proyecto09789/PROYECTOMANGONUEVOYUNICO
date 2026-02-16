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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace PROYECTOMANGO
{
    public partial class CosechaForm : Form
    {
        public CosechaForm()
        {
            InitializeComponent();
        }

        private void btnVolverCosecha_Click(object sender, EventArgs e)
        {
            ProcProductivo procProductivo = new ProcProductivo();
            procProductivo.Show();
            this.Hide();
        }

        private void CargarFromulario(object formHijo)
        {

            if (this.AbrirFormPnlCosecha.Controls.Count > 0)
                this.AbrirFormPnlCosecha.Controls.RemoveAt(0);

            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            fh.FormBorderStyle = FormBorderStyle.None;

            this.AbrirFormPnlCosecha.Controls.Add(fh);
            this.AbrirFormPnlCosecha.Tag = fh;
            fh.Show();
        }

        private void cmbTemasCosecha_SelectedIndexChanged(object sender, EventArgs e)
        {
//Técnica de Corte
//El Desleche
//Lavado y Tratamiento
//Clasificación y Empaque
            string temaSeleccionado = cmbTemasCosecha.SelectedItem.ToString();
            switch (temaSeleccionado)
            {
                case "Índices de Madurez":
                    CargarFromulario(new IndicesDeMadurez());
                    break;
                case "Técnica de Corte":
                    CargarFromulario(new TecnicaDeCorte());
                    break;
                case "El Desleche":
                    CargarFromulario(new ElDesleche());
                    break;
                case "Lavado y Tratamiento":
                    CargarFromulario(new LavadoYTratamiento());
                    break;
                case "Clasificación y Empaque":
                    CargarFromulario(new ClasificacionYEmpaque());
                    break;
            }
        }

        private void btnRefCosecha_Click(object sender, EventArgs e)
        {
            pnlRefCosecha.Visible = true;
            pnlRefCosecha.BringToFront();
        }

        private void btnRefPnlCosech_Click(object sender, EventArgs e)
        {
            pnlRefCosecha.Visible = false;
        }

        private void btnCerrarCose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
