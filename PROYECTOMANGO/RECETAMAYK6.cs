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

namespace RECETAMAYK34
{
    public partial class RECETAMAYK21 : Form
    {
        public RECETAMAYK21()
        {
            InitializeComponent();
        }

        private void btnReceta1siguiente_Click(object sender, EventArgs e)
        {
            pnlfonReceta02.Visible = true;
            pnlfonReceta02.Location = new Point(1, 0);
            pnlfonReceta01.Visible = false;
            pnlfonReceta01.Location = new Point(1000, 1000);    
        }

        private void btnReceta2siguiente_Click(object sender, EventArgs e)
        {
            pnlfonReceta03.Visible = true;
            pnlfonReceta03.Location = new Point(1, 0);
            pnlfonReceta02.Location = new Point(1000, 1000);
            pnlfonReceta02.Visible = false;
        }

        private void btnregresar3_Click(object sender, EventArgs e)
        {
            panelrecetastotal.Visible = true;
            pnlfonReceta03.Visible = false;
                pnlfonReceta03.Location = new Point(1000, 1000);
        }

        private void btnregresar2_Click(object sender, EventArgs e)
        {
            
            panelrecetastotal.Visible = true;
            pnlfonReceta02.Visible = false;
            pnlfonReceta02.Location = new Point(1000, 1000);
        }

        private void btnReceta1M_Click(object sender, EventArgs e)
        {
          panelrecetastotal.Visible = true;
            pnlfonReceta01.Visible = false;
            pnlfonReceta01.Location = new Point(1000, 1000);
        }

        private void label64_Click(object sender, EventArgs e)
        {

        }

        private void RECETAMAYK21_Load(object sender, EventArgs e)
        {

        }

        private void label89_Click(object sender, EventArgs e)
        {

        }

        private void label87_Click(object sender, EventArgs e)
        {

        }

        private void label99_Click(object sender, EventArgs e)
        {

        }

        private void label77_Click(object sender, EventArgs e)
        {

        }

        private void label84_Click(object sender, EventArgs e)
        {

        }

        private void panelrecetastotal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGlaseadp_Click(object sender, EventArgs e)
        {
            pnlfonReceta03.Location = new Point(1, 2);
            pnlfonReceta03.Visible = true;
            panelrecetastotal.Visible = false;  
        }

        private void Ensaladapican_Click(object sender, EventArgs e)
        {
            pnlfonReceta02.Location = new Point(1, 2);
            pnlfonReceta02.Visible = true;
            panelrecetastotal.Visible = false;
        }

        private void BtnArrozpega_Click(object sender, EventArgs e)
        {
            pnlfonReceta01.Location = new Point(1, 2);
            pnlfonReceta01.Visible = true;
            panelrecetastotal.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelrecetastotal.Visible = true;
            pnlfonReceta05.Visible = false;
            pnlfonReceta05.Location = new Point(1000, 1000);
        }

        private void picanrelleno_Click(object sender, EventArgs e)
        {
            pnlfonReceta05.Location = new Point(1, 2);
            pnlfonReceta05.Visible = true;
            panelrecetastotal.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelrecetastotal.Visible = true;
            pnlfonReceta04.Visible = false;
            pnlfonReceta04.Location = new Point(1000, 1000);
        }

        private void btnencuenmang_Click(object sender, EventArgs e)
        {
            pnlfonReceta04.Location = new Point(1, 2);
            pnlfonReceta04.Visible = true;
            panelrecetastotal.Visible = false;
        }

        private void Mango7laye_Click(object sender, EventArgs e)
        {
            pnlfonReceta06.Location = new Point(1, 2);
            pnlfonReceta06.Visible = true;
            panelrecetastotal.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panelrecetastotal.Visible = true;
            pnlfonReceta06.Visible = false;
            pnlfonReceta06.Location = new Point(1000, 1000);
        }

        private void btnvomerec_Click(object sender, EventArgs e)
        {
            mangomayinterf desgve = new mangomayinterf();
            desgve.Show();
                this.Close();
        }
    }
}
