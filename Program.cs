using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrudAugustusFashion.View;
using CrudAugustusFashion.Model;

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
