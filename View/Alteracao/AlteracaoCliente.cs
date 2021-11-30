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
        //variavel de instancia
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
           
            txtIdUsuario.Text = _cliente.IdUsuario.ToString();
            txtIdCliente.Text = _cliente.IdCliente.ToString();
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
        }

        private void FrmAlteracaoCliente_Load(object sender, EventArgs e)
        {
            try
            {
                new ClienteDao().ListarClientes();
            }catch(Exception ex)
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
                _excluircliente.ExcluirClientes(_cliente);
                MessageBox.Show("Cliente excluído com sucesso.");
                this.Close();
                _cadastroclientecontroller.AbrirListaCliente();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Falha ao excluir cliente. Erro: " + ex.Message);
            }
        }

        private void btnAlteracaoCliente_Click(object sender, EventArgs e)
        {
            var cliente = new ClienteModel
            {
                IdCliente = int.Parse(txtIdCliente.Text),
                IdUsuario = int.Parse(txtIdUsuario.Text),
                NomeCompleto = new NomeCompleto
                {
                    Nome = txtNome.Text,
                    SobreNome = txtSobrenome.Text
                },
                Cpf = txtCpf.Text,
                Sexo = comboBoxSexo.Text,
                DataNascimento = dateTimeNascimento.Value,
                Email = txtEmail.Text,
                ValorLimite = int.Parse(txtLimiteCompraPrazo.Text),
                Observacao = txtObservacao.Text.ToString(),
                Endereco = new EnderecoModel
                {
                    IdUsuario = int.Parse(txtIdUsuario.Text),
                    Cidade = txtCidade.Text,
                    Bairro = txtBairro.Text,
                    Cep = txtCep.Text,
                    Uf = comboBoxUf.Text,
                    Complemento = txtComplemento.Text,
                    Logradouro = txtLogradouro.Text,
                    NumeroResidencia = int.Parse(txtNumeroResidencia.Text),
                },
                Telefone = new TelefoneModel
                {
                    IdUsuario = int.Parse(txtIdUsuario.Text),
                    Celular = maskBoxCelular.Text,
                    Telefone = maskBoxTelefone.Text,
                }
            };
            
            try
            {
                var retorno = new AlteracaoClienteController().AlterarCliente(cliente);
                if(retorno == string.Empty)
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
            catch(Exception ex)
            {
                MessageBox.Show("Cliente não pode ser alterado. Erro " + ex.Message);
            }
        }
    }
}
