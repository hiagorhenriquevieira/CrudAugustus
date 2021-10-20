using CrudAugustusFashion.Controller;
using CrudAugustusFashion.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void txtBairro_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrarColaborador_Click(object sender, EventArgs e)
        {
            var colaborador = new ColaboradorModel();

            colaborador.Nome = txtNome.Text;
            colaborador.SobreNome = txtSobrenome.Text;
            colaborador.Cpf = txtCpf.Text;
            colaborador.Sexo = txtSexo.Text;
            colaborador.Email = txtEmail.Text;
            colaborador.DataNascimento = dateTimeNascimento.Value;

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

            var contaBancaria = new ContaBancariaModel();
            contaBancaria.Agencia = int.Parse(txtAgencia.Text);
            contaBancaria.Banco = txtBanco.Text;
            contaBancaria.TipoConta = txtBanco.Text;
            contaBancaria.Conta = int.Parse(txtConta.Text);



            new CadastroColaboradorController().CadastrarColaborador(colaborador, endereco, telefone, contaBancaria);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
