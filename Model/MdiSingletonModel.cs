using CrudAugustusFashion.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAugustusFashion.Model
{
    class MdiSingletonModel
    {
        private MdiSingletonModel() { }

        private static MdiParentPrincipal instanciaMdiParentPrincipal;
        public static MdiParentPrincipal InstanciarMDI()
        {
            if (instanciaMdiParentPrincipal == null)
            {
                instanciaMdiParentPrincipal = new MdiParentPrincipal();
                return instanciaMdiParentPrincipal;
            }
            return instanciaMdiParentPrincipal;
        }
    }
}
