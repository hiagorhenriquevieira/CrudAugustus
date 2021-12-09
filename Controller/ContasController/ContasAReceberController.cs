using CrudAugustusFashion.Dao;
using CrudAugustusFashion.Model;
using CrudAugustusFashion.Model.ContasAReceberModel;
using CrudAugustusFashion.View.ContasAReceber;
using System;
using System.Collections.Generic;

namespace CrudAugustusFashion.Controller.ContasController
{
    public class ContasAReceberController
    {
        
        public void AbrirListaDeContasAReceber()
        {
            var frmListaDeContasAReceber = new FrmListaDeContasAReceber();
            frmListaDeContasAReceber.MdiParent = MdiSingletonModel.InstanciarMDI();
            frmListaDeContasAReceber.Show();
        }

        public List<ListaDeContasAReceberModel> ListarComprasAPrazo(string text, bool ativo)
        {
            try
            {
               return new PedidoDao().ListarComprasAPrazo(text, ativo);
            }
            catch (Exception excecao)
            {
                throw new Exception(excecao.Message);
            }
        }

        internal void PagarContaAPrazo(int idVenda)
        {
            try
            {
                 new PedidoDao().PagarContaAPrazo(idVenda);
            }
            catch(Exception excecao)
            {
                throw new Exception(excecao.Message);
            }
        }
    }
}
