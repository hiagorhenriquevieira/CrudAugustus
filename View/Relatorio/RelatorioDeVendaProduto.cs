using CrudAugustusFashion.Controller.RelatorioFiltroController;
using CrudAugustusFashion.Model.Cliente;
using CrudAugustusFashion.Model.Produto;
using CrudAugustusFashion.Model.RelatorioVendaProduto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CrudAugustusFashion.View.Relatorio
{
    public partial class FrmRelatorioDeVendaProduto : Form
    {
        
        private RelatorioVendaController _relatorioVendaController;      
        private FiltroRelatorioVendaProdutoModel _filtroRelatorioVendaProdutoModel;
        private RelatorioVendaProdutoViewModel _relatorioVendaProdutoViewModel;

        public FrmRelatorioDeVendaProduto(RelatorioVendaController relatorioVendaController)
        {
            InitializeComponent();
           
            _filtroRelatorioVendaProdutoModel = new FiltroRelatorioVendaProdutoModel();
            _relatorioVendaController = relatorioVendaController;
            _relatorioVendaProdutoViewModel = new RelatorioVendaProdutoViewModel();
           
        }

        private void btnFiltrarCliente_Click(object sender, EventArgs e) => _relatorioVendaController.AbrirListaDeClientes();

        private void btnFiltrarProduto_Click(object sender, EventArgs e) => _relatorioVendaController.AbrirListaDeProdutos();

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
        internal bool ReceberDatas()
        {
            if(ValidarDatas() == true)
            {
            _filtroRelatorioVendaProdutoModel.DataEmissao = dtpDataInicial.Value;
            _filtroRelatorioVendaProdutoModel.DataFinal = dtpDataFinal.Value;
            }
            return false;
        }

        public void ReceberStatusDaVenda()
        {
            _filtroRelatorioVendaProdutoModel.Ativo = cbVendaAtivas.Checked;
        }

        private bool ValidarDatas()
        {
            if(dtpDataInicial.Value > DateTime.Now)
            {
                MessageBox.Show("Data inicial não pode ser maior do que a data atual");
                return false;
            }
            if(dtpDataInicial.Value > dtpDataFinal.Value)
            {
                MessageBox.Show("Data inicial não pode ser maior do que a data final");
            }
            return true;
        }

        private void btnFiltrarProdutosVendidos_Click(object sender, EventArgs e)
        {
            ReceberStatusDaVenda();
            ReceberDatas();
            _relatorioVendaProdutoViewModel.Relatorio = _relatorioVendaController.FiltrarProdutos(_filtroRelatorioVendaProdutoModel); ;
            dtgFiltragemDeVendas.DataSource = _relatorioVendaProdutoViewModel.Relatorio;
            AtualizarTotais();
        }
        public void AtualizarTotais()
        {
            lblTotalBruto.Text = _relatorioVendaProdutoViewModel.TotalBruto.ToString();
            lblTotalCusto.Text = _relatorioVendaProdutoViewModel.TotalCusto.ToString();
            lblTotalDesconto.Text = _relatorioVendaProdutoViewModel.TotalDesconto.ToString();
            lblTotalLiquido.Text = _relatorioVendaProdutoViewModel.TotalLiquido.ToString();
            lblLucroReais.Text = _relatorioVendaProdutoViewModel.LucroReais.ToString();
        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            LimparCliente();
            LimparProduto();
        }

        private void btnMenu_Click(object sender, EventArgs e) => panelMenu.Visible = true;

        private void btnFechar_Click(object sender, EventArgs e) => panelMenu.Visible = false;

        private void btnLimparCliente_Click(object sender, EventArgs e) => LimparCliente();

        private void btnLimparProduto_Click(object sender, EventArgs e) => LimparProduto();

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
            var data = DateTime.Now;
            dtpDataInicial.Value = new DateTime(data.Year, data.Month, 1);
        }
    }
}
