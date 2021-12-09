using CrudAugustusFashion.Controller.RelatorioFiltroController;
using CrudAugustusFashion.Model.Cliente;
using CrudAugustusFashion.Model.RelatorioCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CrudAugustusFashion.View.Relatorio
{
    public partial class FrmRelatorioCliente : Form
    {
        private RelatorioClienteController _relatorioClienteController;
        private FiltroRelatorioCliente _filtroRelatorioClienteModel;
        private RelatorioClienteViewModel _relatorioClienteViewModel;

        public FrmRelatorioCliente(RelatorioClienteController relatorioClienteController)
        {
            InitializeComponent();
            _relatorioClienteController = relatorioClienteController;
            _filtroRelatorioClienteModel = new FiltroRelatorioCliente();
            _relatorioClienteViewModel = new RelatorioClienteViewModel();
        }

        private void FrmRelatorioCliente_Load(object sender, EventArgs e)
        {
            AtribuirDataAoPrimeiroDiaDoMes();
            AtribuirOrdemCrescente();
        }
        private void AtribuirOrdemCrescente() => cmbOrdemParaFiltro.SelectedIndex = 0;

        private void AtribuirDataAoPrimeiroDiaDoMes()
        {
            var data = DateTime.Now;
            dtpDataInicial.Value = new DateTime(data.Year, data.Month, 1);
        }
        private void btnMenu_Click(object sender, EventArgs e) => panelMenu.Visible = true;

        private void btnFechar_Click(object sender, EventArgs e) => panelMenu.Visible = false;

        internal void ReceberClienteSelecionado(ClienteModel clienteModel)
        {
            txtNomeCliente.Text = clienteModel.NomeCompleto.Nome;
            _filtroRelatorioClienteModel.IdCliente = clienteModel.IdCliente;
        } 

        public bool ReceberDadosDoForm()
        {
            if(ValidarDatas() == true)
            {
            _filtroRelatorioClienteModel.DataEmissao = dtpDataInicial.Value;
            _filtroRelatorioClienteModel.DataFinal = dtpDataFinal.Value;
            _filtroRelatorioClienteModel.LimiteClientes = Convert.ToInt32(nudLimiteClientes.Value);
            _filtroRelatorioClienteModel.OrdenarPor = cmbOrdemSelecao.SelectedIndex;
            _filtroRelatorioClienteModel.Ordem = cmbOrdemParaFiltro.SelectedIndex;
            if (txtValorParaFiltro.Text != "")
            {
                _filtroRelatorioClienteModel.ValorMinimo = Convert.ToDecimal(txtValorParaFiltro.Text);
            }
            else _filtroRelatorioClienteModel.ValorMinimo = 0;
            }
            return false;
        }

        private bool ValidarDatas()
        {
            if (dtpDataInicial.Value > DateTime.Now || dtpDataInicial.Value > dtpDataFinal.Value)
            {
                MessageBox.Show("Data inicial não pode ser superior ao dia atual");
                return false;
            }
            return true;
        }

        private void btnFiltrarProdutosVendidos_Click(object sender, EventArgs e)
        {
            ReceberDadosDoForm();
            _relatorioClienteViewModel.Relatorio = _relatorioClienteController.FiltrarProdutos(_filtroRelatorioClienteModel); 
            dtgFiltragemDeClientes.DataSource = _relatorioClienteViewModel.Relatorio;
            
            AtualizarValor();
        }

        public  void AtualizarValor()
        {
            lblTotalBruto.Text = _relatorioClienteViewModel.TotalBruto.ToString();
            lblTotalVendas.Text = _relatorioClienteViewModel.QuantidadeVendas.ToString();
            lblTotalDesconto.Text = _relatorioClienteViewModel.TotalDesconto.ToString();
            lblTotalLiquido.Text = _relatorioClienteViewModel.TotalLiquido.ToString();
        }

        private void txtValorParaFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void btnFiltrarCliente_Click(object sender, EventArgs e)
        {
            _relatorioClienteController.AbrirListaDeClientes();
        }

        private void btnLimparCliente_Click(object sender, EventArgs e)
        {
            _filtroRelatorioClienteModel.IdCliente = 0;
            txtNomeCliente.Text = "";
        }

        private void btnLimparOrdenarPor_Click(object sender, EventArgs e)
        {
            _filtroRelatorioClienteModel.OrdenarPor = -1;
            cmbOrdemSelecao.Text = "";  
        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            _filtroRelatorioClienteModel.IdCliente = 0;
            txtNomeCliente.Text = "";
            _filtroRelatorioClienteModel.OrdenarPor = -1;
            cmbOrdemSelecao.SelectedIndex = -1;
            _filtroRelatorioClienteModel.Ordem = 0;
            cmbOrdemParaFiltro.SelectedIndex = 0;
        }
    }
}
