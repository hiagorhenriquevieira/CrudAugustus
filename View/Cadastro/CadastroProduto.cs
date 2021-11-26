﻿using CrudAugustusFashion.Controller.ProdutoController;
using CrudAugustusFashion.Model.Produto;
using CrudAugustusFashion.Validacoes;
using System;
using System.Windows.Forms;

namespace CrudAugustusFashion.View.Cadastro
{
    public partial class FrmCadastroProduto : Form
    {
        private ProdutoModel _produto;

        public FrmCadastroProduto()
        {
            InitializeComponent();
            _produto = new ProdutoModel();
        }

        private void CadastroProduto_Load(object sender, EventArgs e)
        {

        }

        private void buttonCadastrarProduto_Click(object sender, EventArgs e)
        {
            if (ValidarCamposDeCadastroProduto()) {
                
                _produto.Nome = txtNomeProduto.Text;
                _produto.Fabricante = txtNomeFabricante.Text;
                _produto.PrecoCusto = Convert.ToDecimal(txtPrecoCusto.Text);
                _produto.PrecoVenda = Convert.ToDecimal(txtPrecoVenda.Text);
                _produto.CodigoDeBarras = txtCodigoBarras.Text;
                _produto.QuantidadeEstoque = Convert.ToInt32(txtEstoque.Text);
                _produto.Lucro = Convert.ToInt32(txtPorcentagemLucro.Text);
            }
            if (ValidarPrecoCustoVenda()) {
            new CadastroProdutoController().CadastrarProduto(_produto);
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
                var retorno = ((lucro / 100) +1) * precoCusto;

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
             if (ValidacoesCadastros.ValidarSeStringNaoPossuiNumeros(txtNomeFabricante.Text))
            {
                MessageBox.Show("Campo -Nome do Fabricante- invalido ");
                return false;
            }
            if (ValidacoesCadastros.ValidarSeIntNaoPossuiLetras(txtCodigoBarras.Text))
            {
                MessageBox.Show("Campo - Codigo de Barras- obrigatorio");
                return false;
            }
            if (ValidacoesExtencion.NuloOuVazio(txtPrecoCusto))
            {
                MessageBox.Show("Campo -Preço de custo- não pdoe ser vazio");
                return false;
            }
            if (ValidacoesCadastros.ValidarSeIntNaoPossuiLetras(txtEstoque.Text))
            {
                MessageBox.Show("Campo -Estoque- invalido");
                return false;
            }

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
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void txtEstoque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
        private bool ValidarPrecoCustoVenda()
        {
            if (Convert.ToDecimal(txtPrecoVenda.Text) >= Convert.ToDecimal(txtPrecoCusto.Text))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Preço de venda deve ser igual ou maior que o preço de custo do produto.");
                return false;
            }
        }

        private void txtCodigoBarras_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtEstoque_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
