using CrudAugustusFashion.Controller;
using CrudAugustusFashion.Controller.PedidoController;
using CrudAugustusFashion.Dao;
using CrudAugustusFashion.Model.Carinho;
using CrudAugustusFashion.Validacoes;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CrudAugustusFashion.View.Cadastro
{
    public partial class FrmCadastroPedido : Form
    {
        
        private Model.Pedido.VendaModel _pedidoModel;
        private CadastroPedidoController _cadastroPedido;

        public FrmCadastroPedido()
        {
            InitializeComponent();
            _pedidoModel = new Model.Pedido.VendaModel();
            _cadastroPedido = new CadastroPedidoController();
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
            lblPrecoCusto.Text = produto.PrecoCusto.ToString();
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
                lblLucro.Text = _pedidoModel.LucroTotal.ToString();
                lblTotalBruto.Text = _pedidoModel.TotalBruto.ToString();
                lblTotalDesconto.Text = _pedidoModel.TotalDesconto.ToString();
                lblTotalLiquido.Text = _pedidoModel.TotalLiquido.ToString();
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
               _pedidoModel.Produtos.Add(new CarrinhoModel()
                {
                    IdProduto = Convert.ToInt32(lblIdProduto.Text),
                    Nome = lblNomeProduto.Text,
                    DescontoDecimal = Convert.ToDecimal(lblDescontoDecimal.Text.RemoverFormatacaoDoPreco()),
                    PrecoLiquido = Convert.ToDecimal(lblPrecoLiquido.Text.RemoverFormatacaoDoPreco()),
                    PrecoVenda = Convert.ToDecimal(lblPrecoVenda.Text.RemoverFormatacaoDoPreco()),
                    PrecoCusto =Convert.ToDecimal(lblPrecoCusto.Text.RemoverFormatacaoDoPreco()),
                    Quantidade = Convert.ToInt32(numericQuantidade.Value),
                    Total = Convert.ToDecimal(lblTotal.Text.RemoverFormatacaoDoPreco())
                }) ;

                AtualizarCarrinho();
                
            }
            LimparCampos();

        }

        private void AtualizarCarrinho()
        {
            dataGridViewCarrinhoPedido.DataSource = null;
            dataGridViewCarrinhoPedido.DataSource = _pedidoModel.Produtos;
            lblLucro.Text = _pedidoModel.LucroTotal.ToString();
            lblTotalBruto.Text = _pedidoModel.TotalBruto.ToString();
            lblTotalDesconto.Text = _pedidoModel.TotalDesconto.ToString();
            lblTotalLiquido.Text = _pedidoModel.TotalLiquido.ToString();

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
            if(VerificarSeCarrinhoEstaVazio())
            {
            int id = Convert.ToInt32(dataGridViewCarrinhoPedido.SelectedRows[0].Cells[1].Value);
            _pedidoModel.Produtos.Remove((from x in _pedidoModel.Produtos
                                   where x.IdProduto == id
                                  select x).FirstOrDefault()
                                  );
                AtualizarCarrinho();
            };
        } 
        
        public bool VerificarSeCarrinhoEstaVazio() 
        {
            if (dataGridViewCarrinhoPedido.RowCount == 0)
            {
                MessageBox.Show("Erro! Carrinho vazio");
                return false;
            }
            btnRetirarProdutoCarrinho.Enabled = true;
           
            return true;
        }

        private void FrmCadastroPedido_Load(object sender, EventArgs e)
        {
        }

        private void btnFinalizarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCamposDeCadastroPedido())
                {
                    _pedidoModel.IdCliente = Convert.ToInt32(lblIdCliente.Text);
                    _pedidoModel.IdColaborador = Convert.ToInt32(lblIdColaborador.Text);
                    _pedidoModel.FormaDePagamento = comboBoxFormaPagamento.Text;
                   
                    _cadastroPedido.CadastrarPedido(_pedidoModel);
                   
                    MessageBox.Show("Sucesso");
                }
            }
            catch (Exception excecao)
            {
                MessageBox.Show("Erro ao finalizar pedido. " + excecao.Message);
            }
        }

        private bool ValidarCamposDeCadastroPedido()
        {
            if (lblIdCliente.NuloOuVazio())
            {
                MessageBox.Show("Selecione um cliente.");
                return false;
            }
            if (lblIdColaborador.NuloOuVazio())
            {
                MessageBox.Show("Selecione um colaborador.");
                return false;
            }
            if (lblTotalLiquido.NuloOuVazio())
            {
                MessageBox.Show("Não há nenhum produto na lista para ser efetuado o cadastro do pedido.");
                return false;
            }
            if (comboBoxFormaPagamento.NuloOuVazio())
            {
                MessageBox.Show("Selecione um meio de pagamento.");
                return false;
            }
            if(dataGridViewCarrinhoPedido.RowCount == 0)
            {
                MessageBox.Show("Não há nenhum produto para ser efetuado o cadastro de pedido");
                return false;
            }
            else return true;
        }
    }
}