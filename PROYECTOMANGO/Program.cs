using PROYECTOBETA001;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTOMANGO
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Esta linea sirve para mostrar el primero formulario al momento de ejecutar, en este caso el formulario de logi
            Application.Run(new Interfazprinc());

        }
    }
}
