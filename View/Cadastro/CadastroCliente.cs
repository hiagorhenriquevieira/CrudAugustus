using System;
using System.Windows.Forms;
using CrudAugustusFashion.Model;
using CrudAugustusFashion.Controller;
using CrudAugustusFashion.Validacoes;

namespace CrudAugustusFashion
{
    public partial class FrmCadastroCliente : Form
    {
        public FrmCadastroCliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmCadastroCliente_Load(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            
            if (ValidarCamposDeCadastroCliente())
            {
                var cliente = new ClienteModel();

            cliente.Nome = txtNome.Text;
            cliente.SobreNome = txtSobrenome.Text;
            cliente.Cpf = txtCpf.Text;
            cliente.Sexo = comboBoxSexo.Text;
            cliente.DataNascimento = dateTimeNascimento.Value;
            cliente.Email = txtEmail.Text;
            cliente.ValorLimite = decimal.Parse(txtLimiteCompraPrazo.Text);
            cliente.Observacao = txtObservacao.Text;

            cliente.Endereco.Cep = txtCep.Text;
            cliente.Endereco.Cidade = txtCidade.Text;
            cliente.Endereco.Bairro = txtBairro.Text;
            cliente.Endereco.Logradouro = txtLogradouro.Text;
            cliente.Endereco.NumeroResidencia = txtNumeroResidencia.Text;
            cliente.Endereco.Uf = comboBoxUf.Text;
            cliente.Endereco.Complemento = txtComplemento.Text;

            cliente.Telefone.Telefone = txtTelefone.Text;
            cliente.Telefone.Celular = txtCelular.Text;

                try
                {
                    new CadastroClienteController().CadastrarCliente(cliente);
                    MessageBox.Show("Cliente cadastrado com sucesso.");
                    this.Close();
                }catch(Exception ex)
                {
                    MessageBox.Show("Falha ao cadastrar cliente. Erro " + ex.Message);
                }

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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
            else if (!ValidacoesExtencion.ValidarCpf(txtCpf.Text))
            {
                MessageBox.Show("Campo - Cpf- Invalido");
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
            else if (!ValidacoesExtencion.ValidarCep(txtCep.Text))
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
    }
}
