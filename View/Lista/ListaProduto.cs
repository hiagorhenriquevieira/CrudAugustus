using CrudAugustusFashion.Controller.ProdutoController;
using CrudAugustusFashion.Dao;
using System;
using System.Windows.Forms;


namespace CrudAugustusFashion.View.Lista
{
    public partial class FrmListaProduto : Form
    {
        private ListaProdutoController _listaProduto;

        public FrmListaProduto()
        {
            InitializeComponent();
            _listaProduto = new ListaProdutoController();
        }
        private void FrmListaProduto_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao listar clientes. Erro " + ex.Message);
            }
        }

        private void btnExibirCadastroProduto_Click(object sender, EventArgs e)
        {
            try
            {

                var produtos = dataGridViewListaProduto.SelectedRows.Count;
                if (produtos == 0)
                    return;
                int codigoProduto = Convert.ToInt32(dataGridViewListaProduto.SelectedRows[0].Cells[0].Value);
                var produto = new ProdutoDao().RecuperarDadosProduto(codigoProduto);
                new AlteracaoProdutoController().AbrirAlteracaoProduto(produto);
                this.Close();

            }
            catch (Exception excecao)
            {
                MessageBox.Show("Produto Não Selecionado" + excecao.Message);
            }
        }

        private void dataGridViewListaProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int codigoProduto = Convert.ToInt32(dataGridViewListaProduto.SelectedRows[0].Cells[0].Value);

            var produto = new ProdutoDao().RecuperarDadosProduto(codigoProduto);
            new AlteracaoProdutoController().AbrirAlteracaoProduto(produto);
            this.Close();
        }
        private void btnFiltrarProduto_Click(object sender, EventArgs e)
        {

            FiltrarProduto();
        }
        private void FiltrarProduto()
        {
            dataGridViewListaProduto.DataSource = new ListaProdutoController().
                MostrarProdutosNaLista((txtFiltrarProduto.Text), checkBoxListaProdutoAtivo.Checked);
        }
    }
}
