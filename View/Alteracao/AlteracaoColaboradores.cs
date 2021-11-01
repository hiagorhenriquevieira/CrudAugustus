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
        private ColaboradorDao _excluirColaborador;

        public FrmAlteracaoColaboradores(ColaboradorModel colaboradores)
        {
            InitializeComponent();
            _colaboradorModel = colaboradores;
            _excluirColaborador = new ColaboradorDao();
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
            colaborador.Email = txtEmail.Text;
            colaborador.DataNascimento = dateTimeNascimento.Value;
            colaborador.Salario = int.Parse(txtSalario.Text);
            colaborador.PorcentagemComissao = int.Parse(txtPorcentagemComissao.Text);

            colaborador.Endereco.IdUsuario = int.Parse(txtIdUsuario.Text);
            colaborador.Endereco.Cep = txtCep.Text;
            colaborador.Endereco.Cidade = txtCidade.Text;
            colaborador.Endereco.Bairro = txtComplemento.Text;
            colaborador.Endereco.Logradouro = txtLogradouro.Text;
            colaborador.Endereco.NumeroResidencia = txtNumeroResidencia.Text;
            colaborador.Endereco.Uf = comboBoxUf.Text;
            colaborador.Endereco.Complemento = txtComplemento.Text;

            colaborador.Telefone.IdUsuario = int.Parse(txtIdUsuario.Text);
            colaborador.Telefone.Telefone = maskBoxTelefone.Text;
            colaborador.Telefone.Celular = maskBoxCelular.Text;

            colaborador.ContasBancarias.IdColaborador = int.Parse(txtIdColaborador.Text);
            colaborador.ContasBancarias.Agencia = int.Parse(txtAgencia.Text);
            colaborador.ContasBancarias.Banco = txtBanco.Text;
            colaborador.ContasBancarias.TipoConta = txtBanco.Text;
            colaborador.ContasBancarias.Conta = int.Parse(txtConta.Text);


            try
            {
                new AlteracaoColaboradorController().AlterarColaborador(colaborador);
                MessageBox.Show("Colaborador alterado com sucesso.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao alterar colaborador. Erro" + ex.Message);
            }
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                _excluirColaborador.ExcluirColaboradores(_colaboradorModel);
                MessageBox.Show("Colaborador excluido com sucesso.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao excluir colaborador. Erro: " + ex.Message);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
