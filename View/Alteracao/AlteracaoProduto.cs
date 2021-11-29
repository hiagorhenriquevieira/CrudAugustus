using CrudAugustusFashion.Controller.ProdutoController;
using CrudAugustusFashion.Model.Produto;
using CrudAugustusFashion.Validacoes;
using System;
using System.Windows.Forms;

namespace CrudAugustusFashion.View.Alteracao
{
    public partial class FrmAlteracaoProduto : Form
    {
        private ProdutoModel _produto;
        private AlteracaoProdutoController _alteracaoProduto;

        public FrmAlteracaoProduto(ProdutoModel produto)
        {
            _produto = produto;
            InitializeComponent();
            PreencherCamposComDadosProduto();
            _alteracaoProduto = new AlteracaoProdutoController();
        }
        public void PreencherCamposComDadosProduto()
        {
            txtIdProduto.Text = _produto.IdProduto.ToString();
            txtCodigoBarras.Text = _produto.CodigoDeBarras;
            txtNomeProduto.Text = _produto.Nome;
            txtNomeFabricante.Text = _produto.Fabricante;
            numericEstoque.Text = _produto.QuantidadeEstoque.ToString();
            txtPrecoCusto.Text = _produto.PrecoCusto.ToString();
            txtPrecoVenda.Text = _produto.PrecoVenda.ToString();
            txtPorcentagemLucro.Text = _produto.Lucro.ToString();
        }

        private void buttonCalcularPrecoProduto_Click(object sender,EventArgs e)
        {
            if (!ValidacoesExtencion.NuloOuVazio(txtPorcentagemLucro) || !ValidacoesExtencion.NuloOuVazio(txtPrecoVenda))
            {
                var lucro = txtPorcentagemLucro.Text.ToFloat();
                var precoCusto = txtPrecoCusto.Text.ToFloat();
                var retorno = ((lucro / 100) + 1) * precoCusto;
                txtPrecoVenda.Text = retorno.ToString();
            }
            else
            {
                MessageBox.Show("Porcentagem de lucro invalida");
                return;
            }
        }
        private void buttonCadastrarProduto_Click(object sender, System.EventArgs e)
        {
            try
            {

                if (ValidarCamposDeAlteracaoProduto())
                {

                    _produto.IdProduto = Convert.ToInt32(txtIdProduto.Text);
                    _produto.Nome = txtNomeProduto.Text;
                    _produto.Fabricante = txtNomeFabricante.Text;
                    _produto.PrecoCusto = Convert.ToDecimal(txtPrecoCusto.Text);
                    _produto.PrecoVenda = Convert.ToDecimal(txtPrecoVenda.Text);
                    _produto.CodigoDeBarras = txtCodigoBarras.Text;
                    _produto.Lucro = Convert.ToInt32(txtPorcentagemLucro.Text);
                    _produto.QuantidadeEstoque = Convert.ToInt32(numericEstoque.Value);
                    
                    if (Convert.ToInt32(numericEstoque.Text) >= 0)
                    {
                    new AlteracaoProdutoController().AlterarProduto(_produto);
                    MessageBox.Show("Produto alterado com sucesso!");
                    this.Close();
                    }
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar Produto.  " + ex.Message);
            }
        }

        private bool ValidarCamposDeAlteracaoProduto()
        {
            if (ValidacoesCadastros.ValidarSeStringNaoPossuiNumeros(txtNomeProduto.Text))
            {
                MessageBox.Show("Campo -Nome do Produto- invalido ");
                return false;
            }
            if (ValidacoesCadastros.ValidarSeStringNaoPossuiNumeros(txtNomeFabricante.Text))
            {
                MessageBox.Show("Campo -Nome do Fabricante- invalido ");
                return false;
            }
             if (ValidacoesCadastros.ValidarSeIntNaoPossuiLetras(txtCodigoBarras.Text))
            {
                MessageBox.Show("Campo - Codigo de Barras- invalido");
                return false;
            }
             if (ValidacoesExtencion.NuloOuVazio(txtPrecoCusto))
            {
                MessageBox.Show("Campo -Preço de custo- não pdoe ser vazio");
                return false;
            }
            return true;
        }
        private void txtProdutosAdicionaisEstoque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
        private void txtPrecoCusto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }
        private void txtPorcentagemLucro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                _alteracaoProduto.AtivarProduto(_produto);
                MessageBox.Show("Produto ativo.");

            }
            catch (Exception excecao)
            {
                MessageBox.Show("Erro encontrado. " + excecao.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _alteracaoProduto.DesativarProduto(_produto);
                MessageBox.Show("Produto desativado.");
            }
            catch (Exception excecao)
            {
                MessageBox.Show("Erro encontrado. " + excecao.Message);
            }
        }
        private void btnAdicionarEstoque_Click(object sender, EventArgs e)
        {
            if (!ValidacoesExtencion.NuloOuVazio(txtPorcentagemLucro) || !ValidacoesExtencion.NuloOuVazio(txtPrecoVenda))
            {
                var estoque = numericEstoque.Value;
                var estoqueAdicional = numericEstoqueAdicional.Value;
                _produto.QuantidadeEstoque = Convert.ToInt32(estoque) + Convert.ToInt32(estoqueAdicional);
                numericEstoque.Value = _produto.QuantidadeEstoque;
            }
        }
        private void btnSubtrairEstoque_Click(object sender, EventArgs e)
        {

            if (ValidacoesExtencion.NuloOuVazio(txtPorcentagemLucro)) return;
            var estoque = numericEstoque.Value;
            var estoqueAdicional = numericEstoqueAdicional.Value;
            _produto.QuantidadeEstoque = (Convert.ToInt32(estoque) - Convert.ToInt32(estoqueAdicional));
            numericEstoque.Value = _produto.QuantidadeEstoque;       
        }
    }
}
