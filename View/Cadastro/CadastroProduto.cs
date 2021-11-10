using CrudAugustusFashion.Controller.ProdutoController;
using CrudAugustusFashion.Model.Produto;
using CrudAugustusFashion.Validacoes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudAugustusFashion.View.Cadastro
{
    public partial class FrmCadastroProduto : Form
    {
        public FrmCadastroProduto()
        {
            InitializeComponent();
        }

        private void CadastroProduto_Load(object sender, EventArgs e)
        {

        }

        private void buttonCadastrarProduto_Click(object sender, EventArgs e)
        {
            var produto = new ProdutoModel();
            produto.NomeProduto = txtNomeProduto.Text;
            produto.NomeFabricante = txtNomeFabricante.Text;
            produto.PrecoCusto = Convert.ToDecimal(txtPrecoCusto.Text);
            produto.PrecoVenda = Convert.ToDecimal(txtPrecoVenda.Text);
            produto.CodigoDeBarras = txtCodigoBarras.Text;
            produto.QuantidadeEstoque = Convert.ToInt32(txtEstoque.Text);
            produto.Lucro = Convert.ToInt32(txtPorcentagemLucro.Text);

            new CadastroProdutoController().CadastrarProduto(produto);
            MessageBox.Show("Produto cadastrado com sucesso!");
        }

        private void buttonCalcularPrecoProduto_Click(object sender, EventArgs e)
        {
            var lucro = txtPorcentagemLucro.Text.ToFloat();
            var precoCusto = txtPrecoCusto.Text.ToFloat();
            var retorno = ((lucro / 100) + 1) * precoCusto;
            txtPrecoVenda.Text = retorno.ToString();
            
        }
    }
}
