using CrudAugustusFashion.Controller.RelatorioFiltroController;
using CrudAugustusFashion.Model.Cliente;
using CrudAugustusFashion.Model.Produto;
using CrudAugustusFashion.Model.RelatorioVendaProduto;
using System;
using System.Windows.Forms;

namespace CrudAugustusFashion.View.Relatorio
{
    public partial class FrmRelatorioDeVendaProduto : Form
    {
        private ClienteModel _clienteModel;
        private ProdutoModel _produtoModel;
        private RelatorioVendaController _relatorioVendaController;
        private FiltroRelatorioVendaProdutoModel _filtroRelatorioVendaProdutoModel;

        public FrmRelatorioDeVendaProduto(RelatorioVendaController relatorioVendaController)
        {
            InitializeComponent();
            _clienteModel = new ClienteModel();
            _filtroRelatorioVendaProdutoModel = new FiltroRelatorioVendaProdutoModel();
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
            _filtroRelatorioVendaProdutoModel.IdCliente = cliente.IdCliente;

        }

        internal void ReceberProdutoSelecionado(ProdutoModel produto)
        {
            txtNomeProduto.Text = produto.Nome;
            _filtroRelatorioVendaProdutoModel.IdProduto = produto.IdProduto;
            _filtroRelatorioVendaProdutoModel.Nome = produto.Nome;
        }
        internal void ReceberDatas()
        {
            _filtroRelatorioVendaProdutoModel.DataEmissao = dtpDataInicial.Value;
            _filtroRelatorioVendaProdutoModel.DataFinal = dtpDataFinal.Value;
        }


        private void btnFiltrarProdutosVendidos_Click(object sender, EventArgs e)
        {
            ReceberDatas();
           dtgFiltragemDeVendas.DataSource = _relatorioVendaController.FiltrarProdutos(_filtroRelatorioVendaProdutoModel);

        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            LimparCliente();
            LimparProduto();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = true;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = false;
        }

        private void btnLimparCliente_Click(object sender, EventArgs e)
        {
            LimparCliente();
        }

        private void btnLimparProduto_Click(object sender, EventArgs e)
        {
            LimparProduto();
        }

        private void LimparCliente()
        {
            txtNomeCliente.Text = "";
            _filtroRelatorioVendaProdutoModel.IdCliente = 0;
        }
        public void LimparProduto()
        {
            txtNomeProduto.Text = "";
            _filtroRelatorioVendaProdutoModel.IdProduto = 0;
            _filtroRelatorioVendaProdutoModel.Nome = "";
        }

        private void FrmRelatorioDeVendaProduto_Load(object sender, EventArgs e)
        {

        }
    }
}
