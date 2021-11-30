using CrudAugustusFashion.Controller;
using CrudAugustusFashion.Model;
using CrudAugustusFashion.Validacoes;
using System;
using System.Windows.Forms;


namespace CrudAugustusFashion.View
{
    public partial class FrmCadastroColaborador : Form
    {
        public FrmCadastroColaborador()
        {
            InitializeComponent();
        }

        private void CadastroColaborador_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrarColaborador_Click(object sender, EventArgs e)
        {
            if (ValidarCamposDeCadastroColaborador())
            {
                var colaborador = new ColaboradorModel()
                {
                    NomeCompleto = new Model.Usuario.NomeCompleto
                    {
                        Nome = txtNome.Text,
                        SobreNome = txtSobrenome.Text,

                    },
                    Cpf = txtCpf.Text,
                    Sexo = comboBoxSexo.Text,
                    Email = txtEmail.Text,
                    DataNascimento = dateTimeNascimento.Value,
                    Salario = int.Parse(txtSalario.Text),
                    PorcentagemComissao = int.Parse(txtPorcentagemComissao.Text),

                    Endereco = new EnderecoModel
                    {
                        Cep = txtCep.Text,
                        Cidade = txtCidade.Text,
                        Bairro = txtComplemento.Text,
                        Logradouro = txtLogradouro.Text,
                        NumeroResidencia = int.Parse(txtNumeroResidencia.Text),
                        Uf = comboBoxUf.Text,
                        Complemento = txtComplemento.Text,
                    },

                    Telefone = new TelefoneModel
                    {
                        Telefone = txtTelefone.Text,
                        Celular = txtCelular.Text,
                    },

                    ContasBancarias = new ContaBancariaModel
                    {
                        Agencia = int.Parse(txtAgencia.Text),
                        Banco = txtBanco.Text,
                        TipoConta = txtBanco.Text,
                        Conta = int.Parse(txtConta.Text),
                    },
                };
                try
                {
                    var retorno = new CadastroColaboradorController().CadastrarColaborador(colaborador);
                    if (retorno == string.Empty)
                    {
                        MessageBox.Show("Colaborador cadastrado com sucesso!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(retorno);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao cadastrar colaborador. Erro: " + ex.Message);
                }
            }
            return;

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtBanco_TextChanged(object sender, EventArgs e)
        {

        }
        private bool ValidarCamposDeCadastroColaborador()
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
                MessageBox.Show("Campo -Cpf- Invalido");
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
            else if (ValidacoesCadastros.ValidarSeStringNaoPossuiNumeros(txtBanco.Text))
            {
                MessageBox.Show("Campo -Banco- invalido");
                return false;
            }
            else if (ValidacoesCadastros.ValidarSeIntNaoPossuiLetras(txtAgencia.Text))
            {
                MessageBox.Show("Campo -Agencia- invalido");
                return false;
            }
            else if (ValidacoesCadastros.ValidarSeStringNaoPossuiNumeros(txtTipoConta.Text))
            {
                MessageBox.Show("Campo -Tipo conta- invalido");
                return false;
            }
            else if (ValidacoesCadastros.ValidarSeIntNaoPossuiLetras(txtConta.Text))
            {
                MessageBox.Show("Campo -Conta- invalido");
                return false;
            }
            else if (ValidacoesCadastros.ValidarSeIntNaoPossuiLetras(txtPorcentagemComissao.Text))
            {
                MessageBox.Show("Campo -Porcentagem de Comissão- invalido");
                return false;
            }
            else if (ValidacoesCadastros.ValidarSeIntNaoPossuiLetras(txtSalario.Text))
            {
                MessageBox.Show("Campo -Salário- invalido");
                return false;
            }
            return true;
        }
    }
}
