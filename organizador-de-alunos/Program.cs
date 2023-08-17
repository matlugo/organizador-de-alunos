using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace organizador_de_alunos
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new Login());
            Login telaDeLogin= new Login();

            if (telaDeLogin.ShowDialog() == DialogResult.OK) 
            { 
                Application.Run(new Formspricipal ());
            }
        }
    }
}
