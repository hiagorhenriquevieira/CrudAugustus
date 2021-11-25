using CrudAugustusFashion.Dao;
using CrudAugustusFashion.Model;
using CrudAugustusFashion.View.Alteracao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        internal void AlterarColaborador(ColaboradorModel colaboradorModel)
        {
            try
            {
                _colaboradorDao.AlterarColaborador(colaboradorModel);
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
            catch(Exception excecao)
            {
                throw new Exception(excecao.Message);
            }
        }
    }
    
}
