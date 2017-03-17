using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace techtake
{
    static class Program
    {
        public static string Msg;

        public static void Erro()
        {
            frmErro Erro = new frmErro();
            Erro.ShowDialog();
        }        
        public static void Sucesso()
        {
            frmSucesso Sucesso = new frmSucesso();
            Sucesso.ShowDialog();
        }

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FadeInicial());
            
        }
    }
}
