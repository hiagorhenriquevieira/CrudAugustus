using CrudAugustusFashion.Controller.ProdutoController;
using CrudAugustusFashion.Dao;
using System;
using System.Windows.Forms;
using CrudAugustusFashion.Validacoes;


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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmListaProduto_Load(object sender, EventArgs e)
        {
            try
            {
                //dataGridViewListaProduto.DataSource = new ListaProdutoController().MostrarProdutosNaLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao listar clientes. Erro " + ex.Message);
            }
        }

        private void btnExibirCadastroProduto_Click(object sender, EventArgs e)
        {
            int codigoProduto = Convert.ToInt32(dataGridViewListaProduto.SelectedRows[0].Cells[0].Value);

            var produto = new ProdutoDao().RecuperarDadosProduto(codigoProduto);
            new AlteracaoProdutoController().AbrirAlteracaoProduto(produto);
            this.Close();
        }

        private void dataGridViewListaProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int codigoProduto = Convert.ToInt32(dataGridViewListaProduto.SelectedRows[0].Cells[0].Value);

            var produto = new ProdutoDao().RecuperarDadosProduto(codigoProduto);
            new AlteracaoProdutoController().AbrirAlteracaoProduto(produto);
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnFiltrarProduto_Click(object sender, EventArgs e)
        {
            if (txtFiltrarProduto.Text == string.Empty)
                MessageBox.Show("DIgita algo");
            else
                Filtrar();

            

        }
        private void Filtrar()
        {   
            dataGridViewListaProduto.DataSource = new ListaProdutoController().
                MostrarProdutosNaLista((txtFiltrarProduto.Text), checkBoxListaProdutoAtivo.Checked);
        }
        private void txtFiltrarProduto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
