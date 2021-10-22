using CrudAugustusFashion.Controller;
using CrudAugustusFashion.Extencion;
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
            if (txtNome.NuloOuVazio() || txtSobrenome.NuloOuVazio() ||
                txtCpf.NuloOuVazio() || comboBoxSexo.NuloOuVazio() ||
                txtCidade.NuloOuVazio() || txtBairro.NuloOuVazio() ||
                txtCep.NuloOuVazio() || comboBoxUf.NuloOuVazio() ||
                txtComplemento.NuloOuVazio() || txtLogradouro.NuloOuVazio() ||
                txtNumeroResidencia.NuloOuVazio() ||
                txtCelular.NuloOuVazio() || txtEmail.NuloOuVazio() ||
                txtConta.NuloOuVazio() || txtAgencia.NuloOuVazio() ||
                txtTipoConta.NuloOuVazio() || txtBanco.NuloOuVazio() ||
                txtSalario.NuloOuVazio() || txtPorcentagemComissao.NuloOuVazio())
            {
                MessageBox.Show("Preencha os campos obrigatórios!");
                return;
            }
            

            var colaborador = new ColaboradorModel();

            colaborador.Nome = txtNome.Text;
            colaborador.SobreNome = txtSobrenome.Text;
            colaborador.Cpf = txtCpf.Text;
            colaborador.Sexo = comboBoxSexo.Text;
            colaborador.Email = txtEmail.Text;
            colaborador.DataNascimento = dateTimeNascimento.Value;
            colaborador.Salario = int.Parse(txtSalario.Text);
            colaborador.PorcentagemComissao = int.Parse(txtPorcentagemComissao.Text);

            var endereco = new EnderecoModel();
            endereco.Cep = txtCep.Text;
            endereco.Cidade = txtCidade.Text;
            endereco.Bairro = txtComplemento.Text;
            endereco.Logradouro = txtLogradouro.Text;
            endereco.NumeroResidencia = txtNumeroResidencia.Text;
            endereco.Uf = comboBoxUf.Text;
            endereco.Complemento = txtComplemento.Text;

            var telefone = new TelefoneModel();
            telefone.Telefone = txtTelefone.Text;
            telefone.Celular = txtCelular.Text;

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

        private void txtBanco_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
