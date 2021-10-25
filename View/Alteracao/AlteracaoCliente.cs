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
using CrudAugustusFashion.Extencion;

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
            txtLimiteCompraPrazo.Text = _cliente.LimiteCompra;
            txtObservacao.Text = _cliente.Observacao;
            dateTimeNascimento.Value = _cliente.DataNascimento;
            txtEmail.Text = _cliente.Email;
            txtTelefone = _cliente.Telefone;
            txtCelular = _cliente.Celular;
        }

        private void FrmAlteracaoCliente_Load(object sender, EventArgs e)
        {
            new ClienteDao().ListarClientes();
           

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
           
        }
    }
}
