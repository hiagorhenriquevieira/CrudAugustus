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
        private ExcluirClienteController _excluircliente;

        public FrmAlteracaoCliente(ClienteModel cliente)
        {
            InitializeComponent();
            _cliente = cliente;
            _excluircliente = new ExcluirClienteController();
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
            try
            {
                new ClienteDao().ListarClientes();
            }catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao listar clientes. Erro " + ex.Message);
            }
           

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                _excluircliente.ExcluirClientes(_cliente);
                MessageBox.Show("Cliente excluído com sucesso.");
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Falha ao excluir cliente. Erro: " + ex.Message);
            }
            
            
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

            cliente.Endereco.IdUsuario = int.Parse(txtIdUsuario.Text);
            cliente.Endereco.Cidade = txtCidade.Text;
            cliente.Endereco.Bairro = txtBairro.Text;
            cliente.Endereco.Cep = txtCep.Text;
            cliente.Endereco.Uf = comboBoxUf.Text;
            cliente.Endereco.Complemento = txtComplemento.Text;
            cliente.Endereco.Logradouro = txtLogradouro.Text;
            cliente.Endereco.NumeroResidencia = txtNumeroResidencia.Text;

            cliente.Telefone.IdUsuario = int.Parse(txtIdUsuario.Text);
            cliente.Telefone.Celular = maskBoxCelular.Text;
            cliente.Telefone.Telefone = maskBoxTelefone.Text;

            try
            {
                new AlteracaoClienteController().AlterarCliente(cliente);
                MessageBox.Show("Cliente alterado com sucesso.");
                this.Close();
            }catch(Exception ex)
            {
                MessageBox.Show("Cliente não pode ser alterado. Erro " + ex.Message);
            }
        }
    }
}
