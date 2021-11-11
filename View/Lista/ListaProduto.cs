using CrudAugustusFashion.Controller.ProdutoController;
using CrudAugustusFashion.Dao;
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

namespace CrudAugustusFashion.View.Lista
{
    public partial class FrmListaProduto : Form
    {
        public FrmListaProduto()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmListaProduto_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridViewListaProduto.DataSource = new ProdutoDao().ListarPruduto();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao listar clientes. Erro " + ex.Message);
            }
        }

        private void btnExibirCadastroCliente_Click(object sender, EventArgs e)
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
    }
}
