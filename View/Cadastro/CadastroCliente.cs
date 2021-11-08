using System;
using System.Windows.Forms;
using CrudAugustusFashion.Model.Cliente;
using CrudAugustusFashion.Model.Usuario;
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
        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            
            if (ValidarCamposDeCadastroCliente())
            {
                var cliente = new ClienteModel();
            cliente.NomeCompleto.Nome = txtNome.Text;
            cliente.NomeCompleto.SobreNome = txtSobrenome.Text;
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
            cliente.Endereco.NumeroResidencia = int.Parse(txtNumeroResidencia.Text);
            cliente.Endereco.Uf = comboBoxUf.Text;
            cliente.Endereco.Complemento = txtComplemento.Text;

            cliente.Telefone.Telefone = txtTelefone.Text;
            cliente.Telefone.Celular = txtCelular.Text;

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
                }catch(Exception ex)
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
    }
}
