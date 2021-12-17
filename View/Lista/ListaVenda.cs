using CrudAugustusFashion.Controller.PedidoController;
using CrudAugustusFashion.Enums;
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
            DesativarInteracoesSeStatusEhInativo();
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
            lblFormaDePagamento.Text =_vendaModel.GetEnumDescription(_venda.FormaDePagamento);
            

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
            this.Close();
        }
        private VendaModel ConverterModels()
        {
            _vendaModel.IdVenda = _venda.IdVenda;
            _vendaModel.IdCliente = _venda.IdCliente;
            _vendaModel.IdColaborador = _venda.IdColaborador;
            _vendaModel.FormaDePagamento = _venda.FormaDePagamento;
            _vendaModel.Produtos = _venda.Produtos;
            _vendaModel.IdVenda = _venda.IdVenda;
            _vendaModel.Ativo = _venda.Ativo;

            return _vendaModel;
        }

        private void BtnDesativarPedido_Click(object sender, EventArgs e)
        {
            
            new AlteracaoPedidoController().EliminarPedido(ConverterModels());
            MessageBox.Show("Venda Eliminada");
            this.Close();
            new ListagemPedidoController().AbrirListaPedido();
        }
        private void DesativarInteracoesSeStatusEhInativo()
        {
            if (!_venda.Ativo)
            {
                btnAlterarPedido.Visible = false;
                BtnDesativarPedido.Visible = false;
            }
        }
    }
}
