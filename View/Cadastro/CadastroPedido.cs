using CrudAugustusFashion.Controller;
using CrudAugustusFashion.Controller.PedidoController;
using CrudAugustusFashion.Dao;
using CrudAugustusFashion.Validacoes;
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

        private void btnPesquisarProduto_Click(object sender, System.EventArgs e) => 
            dataGridViewProdutoPedido.DataSource = new CadastroPedidoController().ListarProdutosPedido(txtProcurarProduto.Text);
        private void btnPesquisarColaborador_Click(object sender, System.EventArgs e) => 
            dataGridViewColaboradorPedido.DataSource = new AlteracaoColaboradorController().BuscarListaColaborador(txtProcurarColaborador.Text);

        private void btnPesquisarCliente_Click(object sender, System.EventArgs e) => 
            dataGridViewClientePedido.DataSource = new AlteracaoClienteController().BuscarListaCliente(txtProcurarCliente.Text);

        private void dataGridViewProdutoPedido_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int codigoProduto = Convert.ToInt32(dataGridViewProdutoPedido.SelectedRows[0].Cells[0].Value);
            var produto = new ProdutoDao().RecuperarDadosProduto(codigoProduto);

            lblIdProduto.Text = produto.IdProduto.ToString();
            lblNomeProduto.Text = produto.Nome;
            txtPrecoVenda.Text = produto.PrecoVenda.ToString();
            AtualizarPrecos();
            
        }

        private void dataGridViewColaboradorPedido_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int idColaborador = Convert.ToInt32(dataGridViewColaboradorPedido.SelectedRows[0].Cells[0].Value);
            var colaborador = new ColaboradorDao().RecuperarDadosColaborador(idColaborador);

            lblIdColaborador.Text = colaborador.IdColaborador.ToString();
            lblNomeColaborador.Text = colaborador.NomeCompleto.ToString();
        }

        private void dataGridViewClientePedido_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int idCliente = Convert.ToInt32(dataGridViewClientePedido.SelectedRows[0].Cells[0].Value);
            var cliente = new ClienteDao().RecuperarDadosCliente(idCliente);

            lblIdCliente.Text = cliente.IdCliente.ToString();
            lblNomeCliente.Text = cliente.NomeCompleto.ToString();
        }


        public void AtualizarPrecos() 
        { 
            if (!ValidacoesExtencion.NuloOuVazio(txtPrecoVenda))
            {
                var precoVenda = Convert.ToDecimal(txtPrecoVenda.Text);
                var desconto = numericDesconto.Value;
                var precoLiquido = precoVenda - ((desconto / 100) * precoVenda);
                txtPrecoLiquido.Text = precoLiquido.ToString("c");

                var quantidade = numericQuantidade.Value;
                var total = precoLiquido * quantidade;
                txtTotal.Text = total.ToString("c");
            }
        }
        //Desconto
        private void numericDesconto_ValueChanged(object sender, EventArgs e) => AtualizarPrecos();
        private void numericDesconto_KeyPress(object sender, KeyPressEventArgs e) => AtualizarPrecos();

        //Quantidade
        private void numericQuantidade_ValueChanged(object sender, EventArgs e) => AtualizarPrecos();
        private void numericQuantidade_KeyPress(object sender, KeyPressEventArgs e) => AtualizarPrecos();

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {

        }
    }
}