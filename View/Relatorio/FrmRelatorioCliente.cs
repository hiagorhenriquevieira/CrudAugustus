using CrudAugustusFashion.Controller.RelatorioFiltroController;
using CrudAugustusFashion.Model.Cliente;
using CrudAugustusFashion.Model.RelatorioCliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudAugustusFashion.View.Relatorio
{
    public partial class FrmRelatorioCliente : Form
    {
        private RelatorioClienteController _relatorioClienteController;
        private FiltroRelatorioCliente _filtroRelatorioClienteModel;
        public FrmRelatorioCliente(RelatorioClienteController relatorioClienteController)
        {
            InitializeComponent();
            _relatorioClienteController = relatorioClienteController;
            _filtroRelatorioClienteModel = new FiltroRelatorioCliente();
        }

        private void FrmRelatorioCliente_Load(object sender, EventArgs e)
        {
            var data = DateTime.Now;

            dtpDataInicial.Value = new DateTime(data.Year, data.Month, 1);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = true;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = false;
        }

        internal void ReceberClienteSelecionado(ClienteModel clienteModel)
        {
            txtNomeCliente.Text = clienteModel.NomeCompleto.Nome;
            _filtroRelatorioClienteModel.IdCliente = clienteModel.IdCliente;
        }
        public void RetornarData()
        {
            _filtroRelatorioClienteModel.DataEmissao = dtpDataInicial.Value;
            _filtroRelatorioClienteModel.DataFinal = dtpDataFinal.Value;
        }

        public void ReceberDadosDoForm()
        {
            _filtroRelatorioClienteModel.LimiteClientes = Convert.ToInt32(nudLimiteClientes.Value);
            _filtroRelatorioClienteModel.OrdenarPor = cmbOrdemSelecao.Text;
            _filtroRelatorioClienteModel.Ordem = cmbOrdemParaFiltro.Text;
            if (txtValorParaFiltro.Text != "")
            {
                _filtroRelatorioClienteModel.ValorMinimo = Convert.ToDecimal(txtValorParaFiltro.Text);
            }
            else _filtroRelatorioClienteModel.ValorMinimo = 0;
        }

        private void btnFiltrarProdutosVendidos_Click(object sender, EventArgs e)
        {
            RetornarData();
            ReceberDadosDoForm();
            var lista = _relatorioClienteController.FiltrarProdutos(_filtroRelatorioClienteModel); ;
            dtgFiltragemDeClientes.DataSource = lista;
            AtualizarValor(lista);
        }

        private void AtualizarValor(IList<RelatorioClienteModel> lista)
        {
            lblTotalBruto.Text = lista.Sum(x => x.TotalBruto.Valor).ToString("c");
            lblTotalVendas.Text = lista.Sum(x => x.QuantidadeVendas).ToString();
            lblTotalDesconto.Text = lista.Sum(x => x.Desconto.Valor).ToString("c");
            lblTotalLiquido.Text = lista.Sum(x => x.TotalLiquido.Valor).ToString("c");
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
            _filtroRelatorioClienteModel.OrdenarPor = "";
            cmbOrdemSelecao.Text = "";
           
        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            _filtroRelatorioClienteModel.IdCliente = 0;
            txtNomeCliente.Text = "";
            _filtroRelatorioClienteModel.OrdenarPor = "";
            cmbOrdemSelecao.Text = "";
            _filtroRelatorioClienteModel.Ordem = "";
            cmbOrdemParaFiltro.Text = "";
        }

        private void btnLimparOrdem_Click(object sender, EventArgs e)
        {
            _filtroRelatorioClienteModel.Ordem = "";
            cmbOrdemParaFiltro.Text = "";
        }
    }
}
