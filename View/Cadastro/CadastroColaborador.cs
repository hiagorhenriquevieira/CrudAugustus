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
            var colaborador = new ColaboradorModel();

            colaborador.Nome = txtNome.Text;
            colaborador.SobreNome = txtSobrenome.Text;
            colaborador.Cpf = txtCpf.Text;
            colaborador.Sexo = comboBoxSexo.Text;
            colaborador.Email = txtEmail.Text;
            colaborador.DataNascimento = dateTimeNascimento.Value;
            colaborador.Salario = int.Parse(txtSalario.Text);
            colaborador.PorcentagemComissao = int.Parse(txtPorcentagemComissao.Text);

            colaborador.Endereco.Cep = txtCep.Text;
            colaborador.Endereco.Cidade = txtCidade.Text;
            colaborador.Endereco.Bairro = txtComplemento.Text;
            colaborador.Endereco.Logradouro = txtLogradouro.Text;
            colaborador.Endereco.NumeroResidencia = int.Parse(txtNumeroResidencia.Text);
            colaborador.Endereco.Uf = comboBoxUf.Text;
            colaborador.Endereco.Complemento = txtComplemento.Text;

            colaborador.Telefone.Telefone = txtTelefone.Text;
            colaborador.Telefone.Celular = txtCelular.Text;

            colaborador.ContasBancarias.Agencia = int.Parse(txtAgencia.Text);
            colaborador.ContasBancarias.Banco = txtBanco.Text;
            colaborador.ContasBancarias.TipoConta = txtBanco.Text;
            colaborador.ContasBancarias.Conta = int.Parse(txtConta.Text);

                try
                {
                    new CadastroColaboradorController().CadastrarColaborador(colaborador);
                    MessageBox.Show("Colaborador cadastrado com sucesso!");
                    this.Close();
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
            else if (!ValidacoesExtencion.ValidarCpf(txtCpf.Text))
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
            else if (ValidacoesExtencion.ValidarEmail(txtEmail.Text))
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
            }else if (ValidacoesCadastros.ValidarSeIntNaoPossuiLetras(txtSalario.Text))
            {
                MessageBox.Show("Campo -Salário- invalido");
                return false;
            }
            return true;
        }
    }
}
