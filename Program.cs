using CrudAugustusFashion.Model;
using System;
using System.Windows.Forms;

namespace CrudAugustusFashion
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(MdiSingletonModel.InstanciarMDI());
        }
    }
}
