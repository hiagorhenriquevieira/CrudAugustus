using CrudAugustusFashion.Controller.PedidoController;
using CrudAugustusFashion.Dao;
using CrudAugustusFashion.Model.Venda;
using System;
using System.Windows.Forms;

namespace CrudAugustusFashion.View.Lista
{
    public partial class FrmPedidoLista : Form
    {
        private ListagemPedidoController _listagemPedido;

        public FrmPedidoLista()
        {
            InitializeComponent();
            _listagemPedido = new ListagemPedidoController();

        }
        private void PedidoLista_Load(object sender, EventArgs e)
        {

        }

        private void btnSelecionarItemListaPedido_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerificarSeUmaVendaFoiSelecionada())
                {
                    var idVenda = Convert.ToInt32(dataGridViewPedidoLista.CurrentRow.Cells[0].Value);

                    var cliente = _listagemPedido.ExibirListaDeVenda(idVenda);
                    _listagemPedido.AbrirConsultaDeVenda(cliente);
                    this.Close();
                }

            }
            catch (Exception excecao)
            {
                MessageBox.Show("Erro encontrado. " + excecao.Message);
            }
        }

        private void btnFiltrarPedidoProduto_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewPedidoLista.DataSource = new ListagemPedidoController().
                    MostrarProdutosNaLista((txtFiltrarPedido.Text),(CbProdutosAtivos.Checked));
                
            }
            catch (Exception excecao)
            {
                MessageBox.Show("Erro ao listar pedidos." + excecao.Message);
            }
        }
        private bool VerificarSeUmaVendaFoiSelecionada()
        {
            if (dataGridViewPedidoLista.RowCount == 0)
            {
                MessageBox.Show("Uma venda deve ser selecionada para exibir.");
                return false;
            }
            return true;
        }
        private void dataGridViewPedidoLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
