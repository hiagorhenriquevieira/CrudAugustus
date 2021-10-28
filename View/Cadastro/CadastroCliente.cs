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
            if (txtNome.NuloOuVazio() || txtNome.Text.ValidarApenasLetras() || txtSobrenome.NuloOuVazio() ||
                txtCpf.NuloOuVazio() || comboBoxSexo.NuloOuVazio() ||
                txtCidade.NuloOuVazio() || txtBairro.NuloOuVazio() ||
                txtCep.NuloOuVazio() || comboBoxUf.NuloOuVazio() || txtLogradouro.NuloOuVazio() ||
                txtNumeroResidencia.NuloOuVazio() ||
                txtCelular.NuloOuVazio() || txtEmail.NuloOuVazio() ||
                txtLimiteCompraPrazo.NuloOuVazio())
            {
                MessageBox.Show("Preencha os campos obrigatórios!");
                return;
            }
            else if (txtNome.Text.ValidarApenasLetras() || txtSobrenome.Text.ValidarApenasLetras() ||
                txtCidade.Text.ValidarApenasLetras())
            {
                MessageBox.Show("Um dos campos contem caracteres não permitidos" +
                    " (Nome, Sobrenome, Cidade) " +
                    " Verifique os campos");
                return;
            }
            else if (txtLimiteCompraPrazo.Text.ValidarApenasNumeros()|| 
                    txtNumeroResidencia.Text.ValidarApenasNumeros())
            {
                MessageBox.Show("Um dos campos contem caracteres não permitidos\n9+" +
                    "(Limite de compra a prazo, Numero\n" +
                    "Verifique os campos");
                return;
            };


            var cliente = new ClienteModel();

            cliente.Nome = txtNome.Text;
            cliente.SobreNome = txtSobrenome.Text;
            cliente.Cpf = txtCpf.Text;
            cliente.Sexo = comboBoxSexo.Text;
            cliente.DataNascimento = dateTimeNascimento.Value;
            cliente.Email = txtEmail.Text;
            cliente.ValorLimite = decimal.Parse(txtLimiteCompraPrazo.Text);
            cliente.Observacao = txtObservacao.Text;

            var endereco = new EnderecoModel();
            endereco.Cep = txtCep.Text;
            endereco.Cidade = txtCidade.Text;
            endereco.Bairro = txtBairro.Text;
            endereco.Logradouro = txtLogradouro.Text;
            endereco.NumeroResidencia = txtNumeroResidencia.Text;
            endereco.Uf = comboBoxUf.Text;
            endereco.Complemento = txtComplemento.Text;

            var telefone = new TelefoneModel();
            telefone.Telefone = txtTelefone.Text;
            telefone.Celular = txtCelular.Text;

            new CadastroClienteController().CadastrarCliente(cliente, endereco, telefone);
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ValidarCamposDeCadastro()
        {
            if (ValidacoesCadastros.ValidarSeStringNaoPossuiNumeros(txtNome.Text))
            {
                MessageBox.Show("Campo -Nome- invalido ");
                return;
            }else if(ValidacoesCadastros.ValidarSeStringNaoPossuiNumeros(txtSobrenome.Text))
            {
                MessageBox.Show("Campo -Sobrenome- invalido ");
                return;
            }else if (ValidacoesExtencion.ValidarCpf(txtCpf.Text))
            {
                MessageBox.Show("Campo - Cpf- Invalido");
                return;
            }else if ()
            
            
            
            
            
            else if (ValidacoesCadastros.ValidarSeStringNaoPossuiNumeros(txtCidade.Text))
            {
                MessageBox.Show("Campo -Cidade- invalido ");
                return;
            }
        
        }
    }
}
