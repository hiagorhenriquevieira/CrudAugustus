using CrudAugustusFashion.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public void ExcluirColaboradores(ColaboradorModel colaborador)
        {
            try
            {
                _colaboradorDao.ExcluirColaboradores(colaborador);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

