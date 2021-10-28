using CrudAugustusFashion.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrudAugustusFashion.Controller;
using CrudAugustusFashion.Model;
using CrudAugustusFashion.Validacoes;

namespace CrudAugustusFashion.View.Alteracao
{
    public partial class FrmAlteracaoCliente : Form
    {
        //variavel de instancia
        private ClienteModel _cliente;

        public FrmAlteracaoCliente(ClienteModel cliente)
        {
            InitializeComponent();
            _cliente = cliente; 
            PreencherCamposComCliente();
        }

        private void PreencherCamposComCliente()
        {
            txtIdUsuario.Text = _cliente.IdUsuario.ToString();
            txtIdCliente.Text = _cliente.IdCliente.ToString();
            txtNome.Text = _cliente.Nome;
            txtLogradouro.Text = _cliente.Endereco.Logradouro;
            txtBairro.Text = _cliente.Endereco.Bairro;
            txtCep.Text = _cliente.Endereco.Cep;
            txtCidade.Text = _cliente.Endereco.Cidade;
            txtComplemento.Text = _cliente.Endereco.Complemento;
            comboBoxUf.Text = _cliente.Endereco.Uf;
            txtNumeroResidencia.Text = _cliente.Endereco.NumeroResidencia;
            comboBoxSexo.Text = _cliente.Sexo;
            txtCpf.Text = _cliente.Cpf;
            txtSobrenome.Text = _cliente.SobreNome;
            txtLimiteCompraPrazo.Text = _cliente.ValorLimite.ToString();
            txtObservacao.Text = _cliente.Observacao;
            dateTimeNascimento.Value = _cliente.DataNascimento;
            txtEmail.Text = _cliente.Email;
            maskBoxTelefone.Text = _cliente.Telefone.Telefone;
            maskBoxCelular.Text = _cliente.Telefone.Celular;
        }

        private void FrmAlteracaoCliente_Load(object sender, EventArgs e)
        {
            new ClienteDao().ListarClientes();
           

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
           
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnAlteracaoCliente_Click(object sender, EventArgs e)
        {
            var cliente = new ClienteModel();
            cliente.IdCliente = int.Parse(txtIdCliente.Text);
            cliente.IdUsuario = int.Parse(txtIdUsuario.Text);
            cliente.Nome = txtNome.Text;
            cliente.SobreNome = txtSobrenome.Text;
            cliente.Cpf = txtCpf.Text;
            cliente.Sexo = comboBoxSexo.Text;
            cliente.DataNascimento = dateTimeNascimento.Value;
            cliente.Email = txtEmail.Text;
            cliente.ValorLimite = int.Parse(txtLimiteCompraPrazo.Text);

            var endereco = new EnderecoModel();
            endereco.IdUsuario = int.Parse(txtIdUsuario.Text);
            endereco.Cidade = txtCidade.Text;
            endereco.Bairro = txtBairro.Text;
            endereco.Cep = txtCep.Text;
            endereco.Uf = comboBoxUf.Text;
            endereco.Complemento = txtComplemento.Text;
            endereco.Logradouro = txtLogradouro.Text;
            endereco.NumeroResidencia = txtNumeroResidencia.Text;

            var telefone = new TelefoneModel();
            telefone.IdUsuario = int.Parse(txtIdUsuario.Text);
            telefone.Celular = maskBoxCelular.Text;
            telefone.Telefone = maskBoxTelefone.Text;

            new AlteracaoClienteController().AlterarCliente(cliente, endereco, telefone);
        }
    }
}
