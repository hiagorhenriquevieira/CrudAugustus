using CrudAugustusFashion.View;

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
