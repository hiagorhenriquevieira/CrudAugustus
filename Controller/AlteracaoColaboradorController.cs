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
        public void AbrirAlteracaoColaboradores(ColaboradorModel colaboradores)
        {
        var frmAlteracaoColaboradores = new FrmAlteracaoColaboradores(colaboradores);
        frmAlteracaoColaboradores.MdiParent = MdiSingletonModel.InstanciarMDI();
            frmAlteracaoColaboradores.Show();
        }

        internal void AlterarColaborador(ColaboradorModel colaborador)
        {
            try
            {
                _colaboradorDao.AlterarColaborador(colaborador);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<ColaboradorListaModel> BuscarListaColaborador(string nome)
        {
            try
            {
                var lista = _colaboradorDao.BuscarListaColaborador(nome);
                return lista;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
    
}
