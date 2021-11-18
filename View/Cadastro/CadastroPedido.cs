using CrudAugustusFashion.Controller;
using CrudAugustusFashion.Controller.PedidoController;
using CrudAugustusFashion.Dao;
using CrudAugustusFashion.Model.Carinho;
using CrudAugustusFashion.Model.Produto.Pedido;
using CrudAugustusFashion.Validacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CrudAugustusFashion.View.Cadastro
{
    public partial class FrmCadastroPedido : Form
    {
        private PedidoLista _pedidoLista;
        public FrmCadastroPedido()
        {
            InitializeComponent();
            _pedidoLista = new PedidoLista();    
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
            lblPrecoVenda.Text = produto.PrecoVenda.ToString();
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
            if (!ValidacoesExtencion.NuloOuVazio(lblPrecoVenda))
            {
                var precoVenda = Convert.ToDecimal(lblPrecoVenda.Text);
                var desconto = numericDesconto.Value;
                var precoLiquido = precoVenda - ((desconto / 100) * precoVenda);
                lblPrecoLiquido.Text = precoLiquido.ToString("c");

                var quantidade = numericQuantidade.Value;
                var total = precoLiquido * quantidade;
                lblTotal.Text = total.ToString("c");

                var descontoDecimal = precoVenda - precoLiquido;
                lblDescontoDecimal.Text = descontoDecimal.ToString("c");
            }
        }
        //Desconto
        private void numericDesconto_ValueChanged(object sender, EventArgs e)
        {
            AtualizarPrecos();
            //CalcularDescontoEmDecimal();
        }

        private void numericDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            AtualizarPrecos();
            //CalcularDescontoEmDecimal();
        }

        //Quantidade
        private void numericQuantidade_ValueChanged(object sender, EventArgs e) => AtualizarPrecos();

        private void numericQuantidade_KeyPress(object sender, KeyPressEventArgs e) => AtualizarPrecos();

        List<CarrinhoModel> _carrinhoLista = new List<CarrinhoModel>();
        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            if(lblIdProduto.Text == "")
            {
                MessageBox.Show("Selecione um produto.");
                return;
            }else if (numericQuantidade.Value < 1)
            {
                MessageBox.Show("Quantidade não pode ser menor que 1.");
                return;
            }
            else
            {
                _carrinhoLista.Add(new CarrinhoModel()
                {
                    IdProduto = Convert.ToInt32(lblIdProduto.Text),
                    Nome = lblNomeProduto.Text,
                    DescontoDecimal = Convert.ToDecimal(ValidacaoDePreco.RemoverFormatacaoDoPreco(lblDescontoDecimal.Text)),
                    PrecoLiquido = Convert.ToDecimal(ValidacaoDePreco.RemoverFormatacaoDoPreco(lblPrecoLiquido.Text)),
                    PrecoVenda = Convert.ToDecimal(ValidacaoDePreco.RemoverFormatacaoDoPreco(lblPrecoVenda.Text)),
                    Quantidade = Convert.ToInt32(numericQuantidade.Value),
                    Total = Convert.ToDecimal(ValidacaoDePreco.RemoverFormatacaoDoPreco(lblTotal.Text))
                }) ;

                AtualizarCarrinho();
            }
            LimparCampos();

        }

        private void AtualizarCarrinho()
        {
            dataGridViewCarrinhoPedido.DataSource = null;
            dataGridViewCarrinhoPedido.DataSource = _carrinhoLista;
            CalcularTotalBruto();
            CalcularTotalDesconto();
            CalcularTotalLiquido();
        }
        public void LimparCampos()
        {
            lblIdProduto.Text = "";
            lblNomeProduto.Text = "";
            lblPrecoVenda.Text = "";
            lblPrecoLiquido.Text = "";
            lblTotal.Text = "";
            lblDescontoDecimal.Text = "";
            numericDesconto.Value = 0;
            numericQuantidade.Value = 1;
            lblDescontoDecimal.Text = "";
        }

        private void btnRetirarProdutoCarrinho_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridViewCarrinhoPedido.SelectedRows[0].Cells[0].Value);
            _carrinhoLista.Remove((from x in _carrinhoLista
                                  where x.IdProduto == id
                                  select x).FirstOrDefault()
                                  );
            AtualizarCarrinho();
        } 
        private void CalcularTotalBruto()
        {
            var soma = _carrinhoLista.Sum(x => x.PrecoVenda * x.Quantidade);
            lblTotalBruto.Text = soma.ToString("c"); 
        }
        private void CalcularTotalDesconto()
        {
            var soma = _carrinhoLista.Sum(x => x.DescontoDecimal + x.DescontoDecimal);
            lblTotalDesconto.Text = soma.ToString("c");
        }
        private void CalcularTotalLiquido()
        {
            var soma = _carrinhoLista.Sum(x => x.PrecoLiquido + x.PrecoLiquido);
            lblTotalLiquido.Text = soma.ToString("c");
        }
        private void FrmCadastroPedido_Load(object sender, EventArgs e)
        {

        }
    }
}