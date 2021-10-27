using CrudAugustusFashion.Controller;
using CrudAugustusFashion.Dao;
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

namespace CrudAugustusFashion.View.Alteracao
{
    public partial class FrmAlteracaoColaboradores : Form
    {
        private ColaboradorModel _colaboradorModel;
        public FrmAlteracaoColaboradores(ColaboradorModel colaboradores)
        {
            InitializeComponent();
            _colaboradorModel = colaboradores;
            PreencherCamposComConsultores();
        }

        private void AlteracaoColaboradores_Load(object sender, EventArgs e)
        {
            new ColaboradorDao().ListarColaboradores();
        }

        private void btnAlteracaoCliente_Click(object sender, EventArgs e)
        {
            var colaborador = new ColaboradorModel();
            colaborador.IdColaborador = int.Parse(txtIdColaborador.Text);
            colaborador.IdUsuario = int.Parse(txtIdUsuario.Text);
            colaborador.Nome = txtNome.Text;
            colaborador.SobreNome = txtSobrenome.Text;
            colaborador.Cpf = txtCpf.Text;
            colaborador.Sexo = comboBoxSexo.Text;
            colaborador.DataNascimento = dateTimeNascimento.Value;
            colaborador.Email = txtEmail.Text;
            colaborador.Salario = int.Parse(txtSalario.Text);
            colaborador.PorcentagemComissao = int.Parse(txtPorcentagemComissao.Text);

            

            var endereco = new EnderecoModel();
            endereco.Cidade = txtCidade.Text;
            endereco.Bairro = txtBairro.Text;
            endereco.Cep = txtCep.Text;
            endereco.Complemento = txtComplemento.Text;
            endereco.Logradouro = txtLogradouro.Text;
            endereco.NumeroResidencia = txtNumeroResidencia.Text;

            var telefone = new TelefoneModel();
            telefone.Celular = maskBoxCelular.Text;
            telefone.Telefone = maskBoxTelefone.Text;

            var contaBancaria = new ContaBancariaModel();
            contaBancaria.Conta = int.Parse(txtConta.Text);
            contaBancaria.Agencia = int.Parse(txtAgencia.Text);
            contaBancaria.TipoConta = txtTipoConta.Text;
            contaBancaria.Banco = txtBanco.Text;


            new AlteracaoColaboradorController().AlterarColaborador(colaborador, endereco, telefone, contaBancaria);
        }

        private void PreencherCamposComConsultores()
        {
            txtIdColaborador.Text = _colaboradorModel.IdColaborador.ToString();
            txtIdUsuario.Text = _colaboradorModel.IdUsuario.ToString();
            txtNome.Text = _colaboradorModel.Nome;
            txtLogradouro.Text = _colaboradorModel.Endereco.Logradouro;
            txtBairro.Text = _colaboradorModel.Endereco.Bairro;
            txtCep.Text = _colaboradorModel.Endereco.Cep;
            txtCidade.Text = _colaboradorModel.Endereco.Cidade;
            txtComplemento.Text = _colaboradorModel.Endereco.Complemento;
            comboBoxUf.Text = _colaboradorModel.Endereco.Uf;
            txtNumeroResidencia.Text = _colaboradorModel.Endereco.NumeroResidencia;
            comboBoxSexo.Text = _colaboradorModel.Sexo;
            txtCpf.Text = _colaboradorModel.Cpf;
            txtSobrenome.Text = _colaboradorModel.SobreNome;
            dateTimeNascimento.Value = _colaboradorModel.DataNascimento;
            txtEmail.Text = _colaboradorModel.Email;
            maskBoxTelefone.Text = _colaboradorModel.Telefone.Telefone;
            maskBoxCelular.Text = _colaboradorModel.Telefone.Celular;
            txtBanco.Text = _colaboradorModel.ContasBancarias.Banco;
            txtAgencia.Text = _colaboradorModel.ContasBancarias.Agencia.ToString();
            txtConta.Text = _colaboradorModel.ContasBancarias.Conta.ToString();
            txtTipoConta.Text = _colaboradorModel.ContasBancarias.TipoConta;
            txtPorcentagemComissao.Text = _colaboradorModel.PorcentagemComissao.ToString();
            txtSalario.Text = _colaboradorModel.Salario.ToString();

        }
    }
}
