using CrudAugustusFashion.Dao;
using CrudAugustusFashion.Model;
using CrudAugustusFashion.Model.Cliente;
using CrudAugustusFashion.Model.Produto;
using CrudAugustusFashion.Model.RelatorioVendaProduto;
using CrudAugustusFashion.View.Relatorio;
using System;
using System.Collections.Generic;

namespace CrudAugustusFashion.Controller.RelatorioFiltroController
{
    public class RelatorioVendaController
    {
        private ClienteModel _clienteModel;
        private ProdutoModel _produtoModel;
        private FrmRelatorioDeVendaProduto _frmRelatorioVendaProduto;

        public RelatorioVendaController()
        {
            _clienteModel = new ClienteModel();
            _produtoModel = new ProdutoModel();
            
        }

        public void AbrirRelatorioVendaProduto()
        {
            _frmRelatorioVendaProduto = new FrmRelatorioDeVendaProduto(this);
            _frmRelatorioVendaProduto.MdiParent = MdiSingletonModel.InstanciarMDI();
            _frmRelatorioVendaProduto.Show();
        }
        public void AbrirListaDeClientes()
        {
            var frmListaDeClientes = new FrmListaClienteParaFiltro(this);
            frmListaDeClientes.MdiParent = MdiSingletonModel.InstanciarMDI();
            frmListaDeClientes.Show();
        }

        public void AbrirListaDeProdutos()
        {
            var frmListaDeProdutos = new FrmListaProdutoFiltro(this);
            frmListaDeProdutos.MdiParent = MdiSingletonModel.InstanciarMDI();
            frmListaDeProdutos.Show();
        }

        public void ReceberCliente(ClienteModel cliente)
        {
            _frmRelatorioVendaProduto.ReceberClienteSelecionado(cliente);
        }

        internal List<RelatorioVendaProdutoModel>FiltrarProdutos(FiltroRelatorioVendaProdutoModel filtros)
        {
            try
            {
                return  new RelatorioDeVendaProduto().ListarRelatorioPeloFiltro(filtros);
            }
            catch (Exception excecao)
            {
                throw new Exception(excecao.Message);
            }
        }

        public void ReceberProduto(ProdutoModel produto)
        {
            _frmRelatorioVendaProduto.ReceberProdutoSelecionado(produto);
        }
    }
}
