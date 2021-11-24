using CrudAugustusFashion.Dao;
using CrudAugustusFashion.Model.Pedido;
using System;

namespace CrudAugustusFashion.Controller.PedidoController
{
    public class AlteracaoPedidoController
    {
        internal void AlterarPedido(VendaModel pedidoModel)
        {
            new VendaDao().AlterarPedido(pedidoModel);
        }
    }
}
