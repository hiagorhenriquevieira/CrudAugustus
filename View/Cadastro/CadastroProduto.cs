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
            if (ValidarCamposDeCadastroProduto()) { 
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
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void buttonCalcularPrecoProduto_Click(object sender, EventArgs e)
        {
            if (!ValidacoesExtencion.NuloOuVazio(txtPorcentagemLucro) || !ValidacoesExtencion.NuloOuVazio(txtPrecoVenda)){ 
                var lucro = txtPorcentagemLucro.Text.ToFloat();
                var precoCusto = txtPrecoCusto.Text.ToFloat();
                var retorno = ((lucro / 100) + 1) * precoCusto;
                txtPrecoVenda.Text = retorno.ToString();
            }else
            {
                MessageBox.Show("Porcentagem de lucro invalida");
                return;
            }

        }
        private bool ValidarCamposDeCadastroProduto()
        {
            if (ValidacoesCadastros.ValidarSeStringNaoPossuiNumeros(txtNomeProduto.Text))
            {
                MessageBox.Show("Campo -Nome do Produto- invalido ");
                return false;
            }
            else if (ValidacoesCadastros.ValidarSeStringNaoPossuiNumeros(txtNomeFabricante.Text))
            {
                MessageBox.Show("Campo -Nome do Fabricante- invalido ");
                return false;
            }
            else if (ValidacoesExtencion.NuloOuVazio(txtCodigoBarras))
            {
                MessageBox.Show("Campo - Codigo de Barras- obrigatorio");
                return false;
            }else if (ValidacoesExtencion.NuloOuVazio(txtPrecoCusto))
            {
                MessageBox.Show("Campo -Preço de custo- não pdoe ser vazio");
                return false;
            }
            //else if (ValidacoesCadastros.ValidarSeStringNaoPossuiNumeros(txtBairro.Text))
            //{
            //    MessageBox.Show("Campo -Bairro- invalido");
            //    return false;
            //}
            //else if (ValidacoesCadastros.ValidarSeIntNaoPossuiLetras(txtNumeroResidencia.Text))
            //{
            //    MessageBox.Show("Campo -Numero- invalido");
            //    return false;
            //}

            return true;
        }

        private void txtPorcentagemLucro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtPrecoCusto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
