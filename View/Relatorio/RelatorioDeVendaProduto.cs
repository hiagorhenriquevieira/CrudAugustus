using CrudAugustusFashion.Controller.RelatorioFiltroController;
using CrudAugustusFashion.Model.Cliente;
using CrudAugustusFashion.Model.Produto;
using System;
using System.Windows.Forms;

namespace CrudAugustusFashion.View.Relatorio
{
    public partial class FrmRelatorioDeVendaProduto : Form
    {
        private ClienteModel _clienteModel;
        private ProdutoModel _produtoModel;
        private RelatorioVendaController _relatorioVendaController;

        public FrmRelatorioDeVendaProduto(RelatorioVendaController relatorioVendaController)
        {
            InitializeComponent();
            _clienteModel = new ClienteModel();
            _relatorioVendaController = relatorioVendaController;
        }
        

        private void btnFiltrarCliente_Click(object sender, EventArgs e)
        {
            _relatorioVendaController.AbrirListaDeClientes();
        }

        private void btnFiltrarProduto_Click(object sender, EventArgs e)
        {
            _relatorioVendaController.AbrirListaDeProdutos();
        }

        public void ReceberClienteSelecionado(ClienteModel cliente)
        {
            txtNomeCliente.Text = cliente.NomeCompleto.Nome;
        }

        internal void ReceberProdutoSelecionado(ProdutoModel produto)
        {
            txtNomeProduto.Text = produto.Nome;
        }

        private void btnFiltrarProdutosVendidos_Click(object sender, EventArgs e)
        {
            _relatorioVendaController.FiltrarProdutos(_clienteModel, _produtoModel);
        }
    }
}
