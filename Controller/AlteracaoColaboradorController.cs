using CrudAugustusFashion.Model;
using CrudAugustusFashion.View.Alteracao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAugustusFashion.Controller
{
    class AlteracaoColaboradorController
    {
        
        public void AbrirAlteracaoColaboradores(ColaboradorModel colaboradores)
        {
        var frmAlteracaoColaboradores = new FrmAlteracaoColaboradores(colaboradores);
        frmAlteracaoColaboradores.MdiParent = MdiSingletonModel.InstanciarMDI();
            frmAlteracaoColaboradores.Show();
        }
    }
}
