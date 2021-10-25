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

        }

        private void PreencherCamposComConsultores()
        {
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
