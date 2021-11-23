using CrudAugustusFashion.Controller.PedidoController;
using CrudAugustusFashion.Model.Pedido;
using CrudAugustusFashion.Model.Venda;
using System;
using System.Windows.Forms;

namespace CrudAugustusFashion.View.Lista
{
    public partial class FrmListaVenda : Form
    {
        private VendaConsulta _venda;
        private VendaModel _vendaModel;

        public FrmListaVenda(VendaConsulta venda)
        {
            InitializeComponent();
            _venda = venda;
            _vendaModel = new VendaModel();
            PreencherCamposComDadosDaVenda();
            
        }

        private void ListaVenda_Load(object sender, EventArgs e)
        {
            PreencherCamposComDadosDaVenda();
        }

        public void PreencherCamposComDadosDaVenda()
        {
            lblIdVenda.Text = _venda.IdVenda.ToString();
            lblNomeCliente.Text = _venda.NomeCliente.ToString();
            lblNomeColaborador.Text = _venda.NomeColaborador.ToString();
            lblIdCliente.Text = _venda.IdCliente.ToString();
            lblIdColaborador.Text = _venda.IdColaborador.ToString();
            lblTotalBruto.Text = _venda.TotalBruto.ToString();
            lblTotalDesconto.Text = _venda.TotalDesconto.ToString();
            lblTotalLiquido.Text = _venda.TotalLiquido.ToString();
            lblLucroTotal.Text = _venda.Lucro.ToString();
            lblFormaDePagamento.Text = _venda.FormaDePagamento;

            dataGridViewConsulta.DataSource = _venda.Produtos;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            new ListagemPedidoController().AbrirListaPedido();
            this.Close();
        }

        private void btnAlterarPedido_Click(object sender, EventArgs e)
        {
            
            new CadastroPedidoController().AbrirAlteracaoDePedido(ConverterModels());
        }
        private VendaModel ConverterModels()
        {
            var venda = new VendaModel();
            venda.IdVenda = _venda.IdVenda;
            venda.IdCliente = _venda.IdCliente;
            venda.IdColaborador = _venda.IdColaborador;
            venda.FormaDePagamento = _venda.FormaDePagamento;
            venda.Produtos = _venda.Produtos;

            return venda;
            
            
        }
    }
}
