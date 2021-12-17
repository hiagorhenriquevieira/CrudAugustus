using System;
using System.Windows.Forms;
using CrudAugustusFashion.Model.Cliente;
using CrudAugustusFashion.Model.Usuario;
using CrudAugustusFashion.Controller;
using CrudAugustusFashion.Validacoes;
using CrudAugustusFashion.Model;

namespace CrudAugustusFashion
{
    public partial class FrmCadastroCliente : Form
    {
        public FrmCadastroCliente()
        {
            InitializeComponent();
        }
        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {

            if (ValidarCamposDeCadastroCliente())
            {
                var cliente = new ClienteModel()
                {
                    NomeCompleto = new NomeCompleto
                    {
                        Nome = txtNome.Text,
                        SobreNome = txtSobrenome.Text,

                    },
                    Cpf = txtCpf.Text,
                    Sexo = comboBoxSexo.Text,
                    DataNascimento = dateTimeNascimento.Value,
                    Email = txtEmail.Text,
                    ValorLimite = decimal.Parse(txtLimiteCompraPrazo.Text),
                    Observacao = txtObservacao.Text,

                    Endereco = new EnderecoModel
                    {
                        Cep = txtCep.Text,
                        Cidade = txtCidade.Text,
                        Bairro = txtBairro.Text,
                        Logradouro = txtLogradouro.Text,
                        NumeroResidencia = txtNumeroResidencia.Text,
                        Uf = comboBoxUf.Text,
                        Complemento = txtComplemento.Text,
                    },

                    Telefone = new TelefoneModel
                    {
                        Telefone = txtTelefone.Text,
                        Celular = txtCelular.Text,
                    },
                };
                try
                {
                    var retorno = new CadastroClienteController().CadastrarCliente(cliente);
                    if (retorno == string.Empty)
                    {
                        MessageBox.Show("Cliente cadastrado com sucesso.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(retorno);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao cadastrar cliente. Erro " + ex.Message);
                }
            }
        }
        private bool ValidarCamposDeCadastroCliente()
        {
            if (ValidacoesCadastros.ValidarSeStringNaoPossuiNumeros(txtNome.Text))
            {
                MessageBox.Show("Campo -Nome- invalido ");
                return false;
            }
            else if (ValidacoesCadastros.ValidarSeStringNaoPossuiNumeros(txtSobrenome.Text))
            {
                MessageBox.Show("Campo -Sobrenome- invalido ");
                return false;
            }
            else if (ValidacoesExtencion.NuloOuVazio(txtCpf))
            {
                MessageBox.Show("Campo - Cpf- obrigatorio");
                return false;
            }
            else if (ValidacoesExtencion.NuloOuVazio(comboBoxSexo))
            {
                MessageBox.Show("Campo -Sexo- invalido");
                return false;
            }
            else if (ValidacoesCadastros.ValidarSeStringNaoPossuiNumeros(txtCidade.Text))
            {
                MessageBox.Show("Campo -Cidade- invalido");
                return false;
            }
            else if (ValidacoesCadastros.ValidarSeStringNaoPossuiNumeros(txtBairro.Text))
            {
                MessageBox.Show("Campo -Bairro- invalido");
                return false;
            }
            else if (ValidacoesExtencion.NuloOuVazio(txtCep))
            {
                MessageBox.Show("Campo -Cep- invalido");
                return false;
            }
            else if (ValidacoesExtencion.NuloOuVazio(comboBoxUf))
            {
                MessageBox.Show("Campo -Uf- invalido");
                return false;
            }
            else if (ValidacoesExtencion.NuloOuVazio(txtLogradouro))
            {
                MessageBox.Show("Campo -Logradouro- invalido");
                return false;
            }
            else if (ValidacoesCadastros.ValidarSeIntNaoPossuiLetras(txtNumeroResidencia.Text))
            {
                MessageBox.Show("Campo -Numero- invalido");
                return false;
            }
            else if (!ValidacoesExtencion.ValidarTelefone(txtTelefone.Text))
            {
                MessageBox.Show("Campo -Telefone- invalido");
                return false;
            }
            else if (!ValidacoesExtencion.ValidarCelular(txtCelular.Text))
            {
                MessageBox.Show("Campo -Celular- invalido");
                return false;
            }
            else if (!ValidacoesExtencion.ValidarEmail(txtEmail.Text))
            {
                MessageBox.Show("Campo -Email- invalido");
                return false;
            }
            else if (ValidacoesCadastros.ValidarSeIntNaoPossuiLetras(txtLimiteCompraPrazo.Text))
            {
                MessageBox.Show("Campo -Limite de compra a prazo- invalido");
                return false;
            }
            return true;
        }

        private void txtLimiteCompraPrazo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
