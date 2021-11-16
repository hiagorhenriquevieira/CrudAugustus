using CrudAugustusFashion.Controller;
using CrudAugustusFashion.Controller.PedidoController;
using CrudAugustusFashion.Dao;
using System;
using System.Windows.Forms;

namespace CrudAugustusFashion.View.Cadastro
{
    public partial class FrmCadastroPedido : Form
    {
        public FrmCadastroPedido()
        {
            InitializeComponent();
        }

        private void btnPesquisarProduto_Click(object sender, System.EventArgs e)
        {
            dataGridViewProdutoPedido.DataSource = new CadastroPedidoController().ListarProdutosPedido(txtProcurarProduto.Text);

        }

        private void FrmCadastroPedido_Load(object sender, System.EventArgs e)
        {

        }

        private void btnPesquisarColaborador_Click(object sender, System.EventArgs e)
        {
            dataGridViewColaboradorPedido.DataSource = new AlteracaoColaboradorController().BuscarListaColaborador(txtProcurarColaborador.Text);
        }

        private void btnPesquisarCliente_Click(object sender, System.EventArgs e)
        {
            dataGridViewClientePedido.DataSource = new AlteracaoClienteController().BuscarListaCliente(txtProcurarCliente.Text);

        }

        private void dataGridViewProdutoPedido_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lblIdCliente.Text = dataGridViewClientePedido.SelectedRows[0].Cells[0].Value.ToString();
        }

        public int SelecionarClienteModel() => Convert.ToInt32(dataGridViewClientePedido.SelectedRows[0].Cells[0].Value);
        public int SelecionarColaboradorModel() => Convert.ToInt32(dataGridViewColaboradorPedido.SelectedRows[0].Cells[0].Value);
        public int SelecionarProdutoModel() => Convert.ToInt32(dataGridViewProdutoPedido.SelectedRows[0].Cells[0].Value);
        public int SelecionarCarrinhoModel() => dataGridViewCarrinhoPedido.Rows.GetRowCount(DataGridViewElementStates.Selected);
    }
}