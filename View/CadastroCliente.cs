using System;
using System.Windows.Forms;
using CrudAugustusFashion.Model;
using CrudAugustusFashion.Controller;


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

        private void button1_Click(object sender, EventArgs e)
        {
            var cliente = new ClienteModel();

            cliente.Nome = txtNome.Text;
            cliente.SobreNome = txtSobrenome.Text;
            cliente.Cpf = txtCpf.Text;
            cliente.Sexo = txtSexo.Text;
            cliente.DataNascimento = dateTimeNascimento.Value;
            cliente.Email = txtEmail.Text;
            cliente.LimiteCompra = decimal.Parse(txtLimiteCompraPrazo.Text);
            cliente.Observacao = txtObservacao.Text;

            var endereco = new EnderecoModel();
            endereco.Cep = txtCep.Text;
            endereco.Cidade = txtCidade.Text;
            endereco.Bairro = txtComplemento.Text;
            endereco.Logradouro = txtLogradouro.Text;
            endereco.NumeroResidencia = txtNumeroResidencia.Text;
            endereco.Uf = txtUf.Text;
            endereco.Complemento = txtComplemento.Text;

            var telefone = new TelefoneModel();
            telefone.Telefone = int.Parse(txtTelefone.Text);
            telefone.Celular = int.Parse(txtCelular.Text);
            telefone.DddCelular = int.Parse(txtDddCelular.Text);
            telefone.DddTelefone = int.Parse(txtDddTelefone.Text);

            new CadastroClienteController().CadastrarCliente(cliente, endereco, telefone);
        }
    }
}
