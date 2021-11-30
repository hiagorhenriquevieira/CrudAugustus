using CrudAugustusFashion.Dao;
using CrudAugustusFashion.Model;
using CrudAugustusFashion.View;
using System;

namespace CrudAugustusFashion.Controller
{
    class CadastroColaboradorController
    {
        public string CadastrarColaborador(ColaboradorModel colaboradorModel)
        {
            try
            {
                var retorno = colaboradorModel.ValidarColaborador();

                if (retorno == string.Empty)
                {
                    new ColaboradorDao().CadastrarColaborador(colaboradorModel);
                }
                return retorno;
            }
            catch (Exception excecao)
            {
                throw new Exception(excecao.Message);
            }
        }


        public void AbrirCadastroColaborador()
        {
            var frmCadastroColaborador = new FrmCadastroColaborador();
            frmCadastroColaborador.MdiParent = MdiSingletonModel.InstanciarMDI();
            frmCadastroColaborador.Show();
        }

        public void AbrirListaColaborador()
        {
            var frmListaColaborador = new FrmListaColaborador();
            frmListaColaborador.MdiParent = MdiSingletonModel.InstanciarMDI();
            frmListaColaborador.Show();
        }
    }
}
