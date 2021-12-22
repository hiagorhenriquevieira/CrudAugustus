using CrudAugustusFashion.Controller;
using CrudAugustusFashion.Controller.PedidoController;
using CrudAugustusFashion.Controller.ProdutoController;
using CrudAugustusFashion.Controller.RelatorioFiltroController;
using CrudAugustusFashion.Model.Produto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudAugustusFashion.View.MdiParent
{
    public partial class FrmHome : Form
    {
        private CadastroColaboradorController _cadastroColaboradorController;
        private  CadastroClienteController _cadastroClienteController;
        private CadastroProdutoController _cadastroProdutoController;
        private ListaProdutoController _listaProdutoController;
        private CadastroPedidoController _cadastroPedidoController;
        private ProdutoModel _produto;
        private ListagemPedidoController _listaPedidoController;
        private RelatorioVendaController _relatorioVendaController;
        private RelatorioClienteController _relatorioClienteController;
        public FrmHome()
        {
            InitializeComponent();
            _cadastroColaboradorController = new CadastroColaboradorController();
            _cadastroClienteController = new CadastroClienteController();
            _cadastroProdutoController = new CadastroProdutoController();
            _listaProdutoController = new ListaProdutoController();
            _cadastroPedidoController = new CadastroPedidoController();
            _produto = new ProdutoModel();
            _listaPedidoController = new ListagemPedidoController();
            _relatorioVendaController = new RelatorioVendaController();
            _relatorioClienteController = new RelatorioClienteController();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void BtnCadastrarCliente_Click(object sender, EventArgs e) => _cadastroClienteController.AbrirCadastroCliente();

        private void BtnListarClientes_Click(object sender, EventArgs e) => _cadastroClienteController.AbrirListaCliente();

        private void BtnCadastrarColaborador_Click(object sender, EventArgs e) => _cadastroColaboradorController.AbrirCadastroColaborador();

        private void BtnListarColaborador_Click(object sender, EventArgs e) => _cadastroColaboradorController.AbrirListaColaborador();

        private void BtnCadastrarProduto_Click(object sender, EventArgs e) => _cadastroProdutoController.AbrirCadastroProduto();

        private void BtnListarProdutos_Click(object sender, EventArgs e) => _listaProdutoController.AbrirListaProduto();

        private void btnAbirirCadastroVenda_Click(object sender, EventArgs e) => _cadastroPedidoController.AbrirCadastroPedido();

        private void btnAbrirListaVendas_Click(object sender, EventArgs e) => _listaPedidoController.AbrirListaPedido();

        private void btnAbrirRelatorioClientes_Click(object sender, EventArgs e) => _relatorioClienteController.AbrirRelatorioCliente();

        private void btnAbrirRelatorioProdutos_Click(object sender, EventArgs e) => _relatorioVendaController.AbrirRelatorioVendaProduto();

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
