using CrudAugustusFashion.Controller;
using CrudAugustusFashion.Controller.EmailController;
using CrudAugustusFashion.Controller.PedidoController;
using CrudAugustusFashion.Dao;
using CrudAugustusFashion.Enums;
using CrudAugustusFashion.Model;
using CrudAugustusFashion.Model.Carinho;
using CrudAugustusFashion.Model.Cliente;
using CrudAugustusFashion.Model.Pedido;
using CrudAugustusFashion.Model.Produto;
using CrudAugustusFashion.Validacoes;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CrudAugustusFashion.View.Cadastro
{
    public partial class FrmCadastroPedido : Form
    {

        private ProdutoModel _produtoModel;
        private VendaModel _pedidoModel;
        private CadastroPedidoController _cadastroPedido;
        private ClienteModel _clienteModel;
        private ColaboradorModel _colaboradorModel;


        public FrmCadastroPedido(VendaModel pedidoModel)
        {
            InitializeComponent();
            _pedidoModel = pedidoModel;
            _cadastroPedido = new CadastroPedidoController();
            _clienteModel = new ClienteModel();
            _colaboradorModel = new ColaboradorModel();
            _produtoModel = new ProdutoModel();

        }

        private void btnPesquisarProduto_Click(object sender, System.EventArgs e) =>
            dataGridViewProdutoPedido.DataSource = new CadastroPedidoController().ListarProdutosPedido(txtProcurarProduto.Text);
        private void btnPesquisarColaborador_Click(object sender, System.EventArgs e)
        {
            dataGridViewColaboradorPedido.DataSource = new AlteracaoColaboradorController().BuscarListaColaborador((txtProcurarColaborador.Text), (_colaboradorModel.Ativo = true));
        }

        private void btnPesquisarCliente_Click(object sender, System.EventArgs e)
        {
            dataGridViewClientePedido.DataSource = new AlteracaoClienteController().BuscarListaCliente((txtProcurarCliente.Text), (_clienteModel.Ativo = true));

        }

        private void dataGridViewProdutoPedido_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var lista = dataGridViewProdutoPedido.SelectedRows.Count;
            if(lista == 0)
            {
                MessageBox.Show("Nenhum produto foi selecionado");
                return;
            }

            int codigoProduto = Convert.ToInt32(dataGridViewProdutoPedido.SelectedRows[0].Cells[0].Value);
            var produto = new ProdutoDao().RecuperarDadosProduto(codigoProduto);

            _produtoModel.QuantidadeEstoque = produto.QuantidadeEstoque;
            _produtoModel.IdProduto = produto.IdProduto;
            lblIdProduto.Text = produto.IdProduto.ToString();
            lblNomeProduto.Text = produto.Nome;
            lblPrecoVenda.Text = produto.PrecoVenda.DinheiroFormatado;
            lblPrecoCusto.Text = produto.PrecoCusto.DinheiroFormatado;

            AtualizarPrecos();
        }

        private void dataGridViewColaboradorPedido_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var lista = dataGridViewColaboradorPedido.SelectedRows.Count;
            if(lista == 0)
            {
                MessageBox.Show("Nenhum colaborador foi selecionado");
                return;
            }
            int idColaborador = Convert.ToInt32(dataGridViewColaboradorPedido.SelectedRows[0].Cells[0].Value);
            var colaborador = new ColaboradorDao().RecuperarDadosColaborador(idColaborador);

            lblIdColaborador.Text = colaborador.IdColaborador.ToString();
            lblNomeColaborador.Text = colaborador.NomeCompleto.ToString();
        }

        public void RecuperarDadosDoCliente(int id)
        {
            var cliente = new AlteracaoClienteController().RecuperarDadosDoCliente(id);
            _clienteModel.IdCliente = cliente.IdCliente;
            _clienteModel.DataNascimento = cliente.DataNascimento;
            _clienteModel.ValorConsumido = cliente.ValorConsumido;
            _clienteModel.ValorLimite = cliente.ValorLimite;
            _clienteModel.NomeCompleto.Nome = cliente.NomeCompleto.Nome;
            _clienteModel.NomeCompleto.SobreNome = cliente.NomeCompleto.SobreNome;
            _clienteModel.Email = cliente.Email;
        }

        private void dataGridViewClientePedido_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var lista = dataGridViewClientePedido.SelectedRows.Count;
            if(lista == 0)
            {
                MessageBox.Show("Nenhum cliente foi selecionado");
                return;
            }
            int idCliente = Convert.ToInt32(dataGridViewClientePedido.SelectedRows[0].Cells[0].Value);
            RecuperarDadosDoCliente(idCliente);

            lblIdCliente.Text = _clienteModel.IdCliente.ToString();
            lblNomeCliente.Text = _clienteModel.NomeCompleto.ToString();

            var avisoDeAniversario = _clienteModel.VerificarSeEhAniversarioDoCliente();
            if (avisoDeAniversario != string.Empty)
                MessageBox.Show(avisoDeAniversario, "Aviso", MessageBoxButtons.OK);
        }


        public void AtualizarPrecos()
        {
            if (!ValidacoesExtencion.NuloOuVazio(lblPrecoVenda))
            {
                decimal precoVenda = RetornarPrecoVenda();
                decimal desconto = numericDesconto.Value;
                decimal precoLiquido = precoVenda - ((desconto / 100) * precoVenda);
                var quantidade = numericQuantidade.Value;
                decimal total = precoLiquido * quantidade;
                decimal descontoDecimal = precoVenda - precoLiquido;

                lblPrecoLiquido.Text = precoLiquido.ToString("c");
                lblTotal.Text = total.ToString("c");
                lblDescontoDecimal.Text = descontoDecimal.ToString("c");
                lblTotalBruto.Text = _pedidoModel.TotalBruto.DinheiroFormatado;
                lblTotalDesconto.Text = _pedidoModel.TotalDesconto.DinheiroFormatado;
                lblTotalLiquido.Text = _pedidoModel.TotalLiquido.DinheiroFormatado;
            }
        }

        private void numericDesconto_ValueChanged(object sender, EventArgs e) => AtualizarPrecos();

        private void numericDesconto_KeyPress(object sender, KeyPressEventArgs e) => AtualizarPrecos();

        private void numericQuantidade_ValueChanged(object sender, EventArgs e) => AtualizarPrecos();

        private void numericQuantidade_KeyPress(object sender, KeyPressEventArgs e) => AtualizarPrecos();


        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            if (numericQuantidade.Value > _produtoModel.QuantidadeEstoque)
            {
                MessageBox.Show("Quantidade de produtos é maior do que a quantidade em estoque");
                numericQuantidade.Value = _produtoModel.QuantidadeEstoque;
                return;
            }
            if (lblIdProduto.Text == "")
            {
                MessageBox.Show("Selecione um produto.");
                return;
            }
            else if (numericQuantidade.Value < 1)
            {
                MessageBox.Show("Quantidade não pode ser menor que 1.");
                return;
            }
            else
            {
                AdicionarProdutoCarrinho();
                AtualizarCarrinho();
            }
            LimparCamposAposAdicionarProdutoNoCarrinho();
        }

        private void AtualizarCarrinho()
        {
            dataGridViewCarrinhoPedido.DataSource = null;
            dataGridViewCarrinhoPedido.DataSource = _pedidoModel.Produtos;
            lblTotalBruto.Text = _pedidoModel.TotalBruto.DinheiroFormatado;
            lblTotalDesconto.Text = _pedidoModel.TotalDesconto.DinheiroFormatado;
            lblTotalLiquido.Text = _pedidoModel.TotalLiquido.DinheiroFormatado;

        }
        public void LimparCamposAposAdicionarProdutoNoCarrinho()
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
            if (VerificarSeCarrinhoEstaVazio())
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
        private void btnFinalizarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCamposDeCadastroPedido())
                    return;
                if (_pedidoModel.IdVenda != 0)
                {
                    SetarDadosDoPedido();

                    if (ValidacaoDeCampoVendaAhPrazo())

                    AlterarVenda();
                    return;
                }

                else
                {
                    if (RetornarSaldoDoCliente())
                    {
                        SetarDadosDoPedido();

                        CadastrarVenda();
                    }
                }
                LimparCamposAposCadastro();
            }
            catch (Exception excecao)
            {
                MessageBox.Show("Erro ao finalizar pedido. " + excecao.Message);
            }
        }

        private void CadastrarVenda()
        {
            _cadastroPedido.CadastrarPedido(_pedidoModel);
            MessageBox.Show("Venda realizada!"); 
            if(cbEnviarEmail.Checked == true)
            new EnvioDeEmail().EnviarEmail(_pedidoModel, _clienteModel);
        }


        private void SetarDadosDoPedido()
        {
            _pedidoModel.IdCliente = Convert.ToInt32(lblIdCliente.Text);
            _pedidoModel.IdColaborador = Convert.ToInt32(lblIdColaborador.Text);
            _pedidoModel.FormaDePagamento = (EFormaDePagamento)comboBoxFormaPagamento.SelectedIndex;
            _pedidoModel.DataEmissao = DateTime.Now;


            if (comboBoxFormaPagamento.SelectedIndex == 1)
            {

                _pedidoModel.Conta.ValorAPagar = _pedidoModel.TotalLiquido;
            }
        }

        private void AlterarVenda()
        {

            try
            {
                new AlteracaoPedidoController().AlterarPedido(_pedidoModel);
                MessageBox.Show("Alteração realizada com sucesso");
                LimparCamposAposCadastro();
            }
            catch (Exception excecao)
            {
                MessageBox.Show("Erro encontrado ao alterar pedido" + excecao.Message);
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
            if (dataGridViewCarrinhoPedido.RowCount == 0)
            {
                MessageBox.Show("Não há nenhum produto para ser efetuado o cadastro de pedido");
                return false;
            }
            else return true;
        }

        public void LimparCamposAposCadastro()
        {
            new CadastroPedidoController().AbrirCadastroPedido();
            this.Close();
        }

        public void RetornarDadosDaVenda()
        {
            lblIdCliente.Text = _pedidoModel.IdCliente.ToString();
            lblIdColaborador.Text = _pedidoModel.IdColaborador.ToString();

            dataGridViewCarrinhoPedido.DataSource = _pedidoModel.Produtos;

            comboBoxFormaPagamento.Text = _pedidoModel.FormaDePagamento.ToString();
            lblIdVenda.Text = _pedidoModel.IdVenda.ToString();
            int idCliente = Convert.ToInt32(lblIdCliente.Text);

            var cliente = new ClienteDao().RecuperarDadosCliente(idCliente);
            lblNomeCliente.Text = cliente.NomeCompleto.ToString();

            int idColaborador = Convert.ToInt32(lblIdColaborador.Text);
            var colaborador = new ColaboradorDao().RecuperarDadosColaborador(idColaborador);
            lblNomeColaborador.Text = colaborador.NomeCompleto.ToString();

        }

        private void FrmCadastroPedido_Load(object sender, EventArgs e)
        {
            if (_pedidoModel.IdVenda != 0)
            {
                RetornarDadosDaVenda();
                AtualizarCarrinho();
                _pedidoModel.LiquidoPreAlteracao = _pedidoModel.TotalLiquido;
                _pedidoModel.PagamentoPreAlteracao = _pedidoModel.FormaDePagamento;
            }
        }

        private bool ValidacaoDeCampoVendaAhPrazo()
        {
            if (comboBoxFormaPagamento.Text == "APRAZO")
            {
                var id = Convert.ToInt32(lblIdCliente.Text);
                RecuperarDadosDoCliente(id);
                var resultado = _pedidoModel.LiquidoPreAlteracao.Valor + _clienteModel.RetornarSaldoDoCliente();
                if (resultado >= Convert.ToDecimal(_pedidoModel.TotalLiquido.Valor))
                    return true;
                else
                {
                    MessageBox.Show($"Alteração não pode ser realizada, seu saldo está a baixo do valor da compra");
                    return false;
                }
            }
            return true; ;
        }

        private void AdicionarProdutoCarrinho()
        {
            var produto = new CarrinhoModel()
            {
                IdProduto = Convert.ToInt32(lblIdProduto.Text),
                Nome = lblNomeProduto.Text,
                IdVenda = _pedidoModel.IdVenda,
                Desconto = Convert.ToDecimal(ValidacoesExtencion.RetornarApenasNumeros(lblDescontoDecimal.Text)) / 100,
                PrecoVenda = RetornarPrecoVenda(),
                PrecoCusto = Convert.ToDecimal(ValidacoesExtencion.RetornarApenasNumeros(lblPrecoCusto.Text)) / 100,
                Quantidade = Convert.ToInt32(numericQuantidade.Value),
            };

            _pedidoModel.AdicionarProdutoCarrinho(produto);
            AtualizarCarrinho();
        }

        private decimal RetornarPrecoVenda() => Convert.ToDecimal(ValidacoesExtencion.RetornarApenasNumeros(lblPrecoVenda.Text)) / 100;

        public bool RetornarSaldoDoCliente()
        {
            if (comboBoxFormaPagamento.Text == "APRAZO" &&
                _clienteModel.RetornarSaldoDoCliente() < _pedidoModel.TotalLiquido.Valor)
            {
                MessageBox.Show("Valor limite atual é inferior ao valor da compra a prazo");
                return false;
            }
            return true;
        }

        public void RetornarProdutosDoCarrinho(CarrinhoModel produto)
        {
            _pedidoModel.RetornarProdutoCarrinho(produto);
            lblIdProduto.Text = produto.IdProduto.ToString();
            lblNomeProduto.Text = produto.Nome;
            lblPrecoCusto.Text = produto.PrecoCusto.ToString();
            lblPrecoLiquido.Text = produto.PrecoLiquido.ToString();
            lblTotal.Text = produto.Total.ToString();
            lblDescontoDecimal.Text = produto.Desconto.ToString();
            numericQuantidade.Value = produto.Quantidade;
            lblPrecoVenda.Text = produto.PrecoVenda.ToString();
        }

        private void dataGridViewCarrinhoPedido_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var produto = dataGridViewCarrinhoPedido.CurrentRow.DataBoundItem as CarrinhoModel;

            RetornarProdutosDoCarrinho(produto);
        }

        private void dataGridViewClientePedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}