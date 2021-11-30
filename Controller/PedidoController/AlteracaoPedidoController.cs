using CrudAugustusFashion.Dao;
using CrudAugustusFashion.Model.Pedido;
using System;

namespace CrudAugustusFashion.Controller.PedidoController
{
    public class AlteracaoPedidoController
    {
        internal void AlterarPedido(VendaModel pedidoModel)
        {
            try
            {
            new VendaDao().AlterarPedido(pedidoModel);
            }
            catch (Exception excecao)
            {
                throw new Exception(excecao.Message);
            }
        }

        internal void EliminarPedido(VendaModel vendaModel)
        {
            try{
            new VendaDao().EliminarPedido(vendaModel);
            }
            catch(Exception excecao)
            {
                throw new Exception(excecao.Message);
            }
        }
    }
}
