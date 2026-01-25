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
            pnlfonReceta03.Visible = false;
            pnlfonReceta03.Location = new Point(1000, 1000);
            pnlfonReceta02.Visible = true;
            pnlfonReceta02.Location = new Point(1,0);
        }

        private void btnregresar2_Click(object sender, EventArgs e)
        {
            pnlfonReceta02.Visible = false;
            pnlfonReceta02.Location = new Point(1000, 1000);   
            pnlfonReceta01.Visible = true;
            pnlfonReceta01.Location = new Point(1, 0);


        }

        private void btnReceta1M_Click(object sender, EventArgs e)
        {
            mangomayinterf gdfs = new mangomayinterf();
            gdfs.Show();
            this.Hide();
        }
    }
}
