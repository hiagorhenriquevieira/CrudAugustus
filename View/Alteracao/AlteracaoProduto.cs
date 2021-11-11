﻿using CrudAugustusFashion.Controller.ProdutoController;
using CrudAugustusFashion.Model.Produto;
using CrudAugustusFashion.Validacoes;
using System;
using System.Windows.Forms;

namespace CrudAugustusFashion.View.Alteracao
{
    public partial class FrmAlteracaoProduto : Form
    {
        private ProdutoModel _produto;

        public FrmAlteracaoProduto(ProdutoModel produto)
        {
            _produto = produto;
            InitializeComponent();
            PreencherCamposComDadosProduto();
        }

        public void PreencherCamposComDadosProduto()
        {
            txtIdProduto.Text = _produto.IdProduto.ToString();
            txtCodigoBarras.Text = _produto.CodigoDeBarras;
            txtNomeProduto.Text = _produto.Nome;
            txtNomeFabricante.Text = _produto.Fabricante;
            txtEstoque.Text = _produto.QuantidadeEstoque.ToString();
            txtPrecoCusto.Text = _produto.PrecoCusto.ToString();
            txtPrecoVenda.Text = _produto.PrecoVenda.ToString();
            txtPorcentagemLucro.Text = _produto.Lucro.ToString();
        }

        private void buttonCalcularPrecoProduto_Click(object sender, System.EventArgs e)
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
            if (ValidarCamposDeAlteracaoProduto())
            {
                var produto = new ProdutoModel();
                produto.IdProduto = Convert.ToInt32(txtIdProduto.Text);
                produto.Nome = txtNomeProduto.Text;
                produto.Fabricante = txtNomeFabricante.Text;
                produto.PrecoCusto = Convert.ToDecimal(txtPrecoCusto.Text);
                produto.PrecoVenda = Convert.ToDecimal(txtPrecoVenda.Text);
                produto.CodigoDeBarras = txtCodigoBarras.Text;
                produto.QuantidadeEstoque = Convert.ToInt32(txtEstoque.Text);
                produto.Lucro = Convert.ToInt32(txtPorcentagemLucro.Text);

                new AlteracaoProdutoController().AlterarProduto(produto);
                MessageBox.Show("Produto alteradocom sucesso!");
                this.Close();
            }
            else
            {
                return;
            }
        }




        private bool ValidarCamposDeAlteracaoProduto()
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
            }
            else if (ValidacoesExtencion.NuloOuVazio(txtPrecoCusto))
            {
                MessageBox.Show("Campo -Preço de custo- não pdoe ser vazio");
                return false;
            }
            else if (ValidacoesCadastros.ValidarSeIntNaoPossuiLetras(txtEstoque.Text))
            {
                MessageBox.Show("Campo -Estoque- invalido");
                return false;
            }

            return true;
        }

        private void FrmAlteracaoProduto_Load(object sender, EventArgs e)
        {

        }
    }
}
