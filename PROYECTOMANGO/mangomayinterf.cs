using PROYECTOMANGO;
using RECETAMAYK34;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PROYECTOBETA001
{
    public partial class mangomayinterf : Form
    {
        Point panelOculto;
        Point panelVisible;

        public mangomayinterf()
        {
            InitializeComponent();
        }
        private void btnRecetaman_Click(object sender, EventArgs e)
        {
            pnlnivelquiezmay.Location = new Point(1280, 48);
            RECETAMAYK21 ventramang = new RECETAMAYK21();
            ventramang.Show();
            this.Hide();

        }
        private void mangomayinterf_Load(object sender, EventArgs e)

        {

            panelOculto = new Point(-panelrecetaGlaseadoMangJengibre.Width,
                                    panelrecetaGlaseadoMangJengibre.Location.Y);

            panelVisible = new Point(1, 1); 
            panelrecetaGlaseadoMangJengibre.Location = panelOculto;

        }
        private void verresetGlaseMan_Click(object sender, EventArgs e)
        {
            panelrecetaGlaseadoMangJengibre.Location = panelVisible;
            paneldelusoculinario.Visible = false;
        }
        private void CerrarbtnResetGlaseadoMango_Click(object sender, EventArgs e)
        {
            panelrecetaGlaseadoMangJengibre.Location = panelOculto;
            paneldelusoculinario.Visible = true;
        }
        private void menuinterzaprin01_Click(object sender, EventArgs e)
        {
            Interfazprinc vent0001 = new Interfazprinc();
            vent0001.Show();
            this.Hide();
        }
        private void btnbenefsal_Click(object sender, EventArgs e)
        {
            
            panelBeneficios.Visible = true;
            pnlnivelquiezmay.Location = new Point(1280, 48);

        }
        private void btnjuegococi_Click(object sender, EventArgs e)
        {
           pnlGuia.Location = new Point(128, 48);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Juegomayre1 ventjueg12omayre1 = new Juegomayre1();
            ventjueg12omayre1.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            QUIZ2MEDIO cjbud = new QUIZ2MEDIO();
            cjbud.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Quizdificil1 quizdifi2cil1 = new Quizdificil1();
            quizdifi2cil1.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Comenzarquiz1_Click(object sender, EventArgs e)
        {
            pnlGuia.Location = new Point(1280, 48);
            pnlnivelquiezmay.Location = new Point(128, 48);
        }
    }
    
}

