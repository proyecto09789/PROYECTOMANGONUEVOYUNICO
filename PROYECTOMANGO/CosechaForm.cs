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
    }
}
