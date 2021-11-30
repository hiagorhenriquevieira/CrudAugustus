using CrudAugustusFashion.Dao;
using System;
using CrudAugustusFashion.Model;

namespace CrudAugustusFashion.Controller
{
   public class ExcluirColaboradorController
    {
        private ColaboradorDao _colaboradorDao;

        public ExcluirColaboradorController()
        {
            _colaboradorDao = new ColaboradorDao();
        }

        public void ExcluirColaboradores(ColaboradorModel colaboradorModel)
        {
            try
            {
                _colaboradorDao.ExcluirColaboradores(colaboradorModel);
            }
            catch (Exception excecao)
            {
                throw new Exception(excecao.Message);
            }
        }
    }
}

