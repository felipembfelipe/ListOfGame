using ListOfGame.View;
using System;
using System.Windows.Forms;
using Unity;

namespace ListOfGame
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main(string[] args)
        {
            // Inicia a aplicação
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Configura o Unity Container e resolve as dependências
            var container = UnityConfig.RegisterComponents();

            // Resolve a dependência de frmLogin com todas as dependências injetadas
            var frmLogin = container.Resolve<frmLogin>();  // Aqui o Unity vai injetar ILoginServices automaticamente

            // Inicia o formulário com todas as dependências resolvidas
            Application.Run(frmLogin);
        }
    }
}
