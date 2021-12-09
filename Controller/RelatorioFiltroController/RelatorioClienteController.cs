using CrudAugustusFashion.Dao;
using CrudAugustusFashion.Model;
using CrudAugustusFashion.Model.Cliente;
using CrudAugustusFashion.Model.RelatorioCliente;
using CrudAugustusFashion.View.Relatorio;
using System;
using System.Collections.Generic;

namespace CrudAugustusFashion.Controller.RelatorioFiltroController
{
    public class RelatorioClienteController
    {
        private FrmRelatorioCliente _frmRelatorioCliente;
        public void AbrirRelatorioCliente()
        {
            _frmRelatorioCliente = new FrmRelatorioCliente(this);
            _frmRelatorioCliente.MdiParent = MdiSingletonModel.InstanciarMDI();
            _frmRelatorioCliente.Show();
            _frmRelatorioCliente.BringToFront();
            
        }

        public void AbrirListaDeClientes()
        {
            var frmListaDeClientes = new FrmListaClientesFiltro(this);
            frmListaDeClientes.MdiParent = MdiSingletonModel.InstanciarMDI();
            frmListaDeClientes.Show();
        }

        internal void ReceberCliente(ClienteModel clienteModel)
        {
            _frmRelatorioCliente.ReceberClienteSelecionado(clienteModel);
        }

        internal List<RelatorioClienteModel> FiltrarProdutos(FiltroRelatorioCliente filtros)
        {
            try
            {
                return new RelatorioDeClienteDao().ListarRelatorioPeloFiltro(filtros);
            }
            catch (Exception excecao)
            {
                throw new Exception(excecao.Message);
            }
        }
    }
}
