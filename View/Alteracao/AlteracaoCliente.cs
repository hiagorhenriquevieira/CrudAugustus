using CrudAugustusFashion.Controller;
using CrudAugustusFashion.Dao;
using CrudAugustusFashion.Model;
using CrudAugustusFashion.Model.Cliente;
using CrudAugustusFashion.Model.Usuario;
using System;
using System.Windows.Forms;

namespace CrudAugustusFashion.View.Alteracao
{
    public partial class FrmAlteracaoCliente : Form
    {
        private ClienteModel _cliente;
        private ExcluirClienteController _excluircliente;
        private CadastroClienteController _cadastroclientecontroller;

        public FrmAlteracaoCliente(ClienteModel cliente)
        {
            InitializeComponent();
            _cliente = cliente;

            _excluircliente = new ExcluirClienteController();
            PreencherCamposComCliente();
            _cadastroclientecontroller = new CadastroClienteController();
        }


        private void PreencherCamposComCliente()
        {
            txtNome.Text = _cliente.NomeCompleto.Nome;
            txtSobrenome.Text = _cliente.NomeCompleto.SobreNome;
            txtLogradouro.Text = _cliente.Endereco.Logradouro;
            txtBairro.Text = _cliente.Endereco.Bairro;
            txtCep.Text = _cliente.Endereco.Cep.ToString();
            txtCidade.Text = _cliente.Endereco.Cidade;
            txtComplemento.Text = _cliente.Endereco.Complemento;
            comboBoxUf.Text = _cliente.Endereco.Uf;
            txtNumeroResidencia.Text = _cliente.Endereco.NumeroResidencia.ToString();
            comboBoxSexo.Text = _cliente.Sexo;
            txtLimiteCompraPrazo.Text = _cliente.ValorLimite.ToString();
            txtObservacao.Text = _cliente.Observacao;
            txtEmail.Text = _cliente.Email;
            maskBoxTelefone.Text = _cliente.Telefone.Telefone;
            maskBoxCelular.Text = _cliente.Telefone.Celular;
            txtCpf.Text = _cliente.Cpf.ToString();
            dateTimeNascimento.Value = _cliente.DataNascimento;
            lblSaldoDisponivel.Text = RetornarValorLimiteAtual().ToString("c");
        }

        private void FrmAlteracaoCliente_Load(object sender, EventArgs e)
        {
            try
            {
                new ClienteDao().ListarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao listar clientes. Erro " + ex.Message);
            }
            var avisoDeAniversario = _cliente.VerificarSeEhAniversarioDoCliente();
            if (avisoDeAniversario != string.Empty)
                MessageBox.Show(avisoDeAniversario, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult OpcaoDoUsuario = new DialogResult();

                OpcaoDoUsuario = MessageBox.Show("Você está prestes a Excluir um cliente, deseja continuar? ", 
                    "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(OpcaoDoUsuario == DialogResult.Yes)
                {
                _excluircliente.ExcluirClientes(_cliente);
                MessageBox.Show("Cliente excluído com sucesso.");
                this.Close();
                _cadastroclientecontroller.AbrirListaCliente();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao excluir cliente. Erro: " + ex.Message);
            }
        }



        private void btnAlteracaoCliente_Click(object sender, EventArgs e)
        {
            _cliente.ValorLimite = txtLimiteCompraPrazo.Text;
            var cliente = new ClienteModel
            {
                IdCliente = _cliente.IdCliente,
                IdUsuario = _cliente.IdUsuario,
                NomeCompleto = new NomeCompleto
                {
                    Nome = txtNome.Text,
                    SobreNome = txtSobrenome.Text
                },
                Cpf = txtCpf.Text,
                Sexo = comboBoxSexo.Text,
                DataNascimento = dateTimeNascimento.Value,
                Email = txtEmail.Text,
                ValorLimite = _cliente.ValorLimite.Valor,
                Observacao = txtObservacao.Text.ToString(),
                Endereco = new EnderecoModel
                {
                    IdUsuario = _cliente.IdUsuario,
                    Cidade = txtCidade.Text,
                    Bairro = txtBairro.Text,
                    Cep = txtCep.Text,
                    Uf = comboBoxUf.Text,
                    Complemento = txtComplemento.Text,
                    Logradouro = txtLogradouro.Text,
                    NumeroResidencia = txtNumeroResidencia.Text,
                },
                Telefone = new TelefoneModel
                {
                    IdUsuario = _cliente.IdUsuario,
                    Celular = maskBoxCelular.Text,
                    Telefone = maskBoxTelefone.Text,
                }
            };
            try
            {
                var retorno = new AlteracaoClienteController().AlterarCliente(cliente);
                if (retorno == string.Empty)
                {
                    MessageBox.Show("Cliente alterado com sucesso.");
                    this.Close();
                    _cadastroclientecontroller.AbrirListaCliente();
                }
                else
                {
                    MessageBox.Show(retorno);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cliente não pode ser alterado. Erro " + ex.Message);
            }
        }

        public string RetornarValorDeLimiteDoCliente(ClienteModel cliente)
        {

            string str = txtLimiteCompraPrazo.Text;
            string[] charsToRemove = new string[] { "R", "$", };
            foreach (var c in charsToRemove)
            {
                str = str.Replace(c, string.Empty);
            }

           cliente.ValorLimite = Convert.ToDecimal(str);
            return cliente.ValorLimite.ToString();

        }


        private decimal RetornarValorLimiteAtual()
        {
            return _cliente.ValorLimite.Valor - _cliente.ValorConsumido.Valor;
        }

        private void txtLimiteCompraPrazo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void txtSobrenome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
