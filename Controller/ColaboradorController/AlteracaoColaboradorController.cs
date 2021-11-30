using CrudAugustusFashion.Dao;
using CrudAugustusFashion.Model;
using CrudAugustusFashion.View.Alteracao;
using System;
using System.Collections.Generic;

namespace CrudAugustusFashion.Controller
{
    public class AlteracaoColaboradorController
    {
        private ColaboradorDao _colaboradorDao;

        public AlteracaoColaboradorController()
        {
            _colaboradorDao = new ColaboradorDao();
        }

        public void AbrirAlteracaoColaboradores(ColaboradorModel colaboradoreModel)
        {
            var frmAlteracaoColaboradores = new FrmAlteracaoColaboradores(colaboradoreModel);
            frmAlteracaoColaboradores.MdiParent = MdiSingletonModel.InstanciarMDI();
            frmAlteracaoColaboradores.Show();
        }

        internal string AlterarColaborador(ColaboradorModel colaboradorModel)
        {
            try
            {
                var retorno = colaboradorModel.ValidarColaborador();

                if (retorno == string.Empty)
                {
                    _colaboradorDao.AlterarColaborador(colaboradorModel);
                }
                return retorno;
            }
            catch (Exception excecao)
            {
                throw new Exception(excecao.Message);
            }
        }

        public List<ColaboradorListaModel> BuscarListaColaborador(string nome, bool ativo)
        {
            try
            {
                var lista = _colaboradorDao.BuscarListaColaborador(nome, ativo);
                return lista;
            }
            catch (Exception excecao)
            {
                throw new Exception(excecao.Message);
            }
        }
    }
}
