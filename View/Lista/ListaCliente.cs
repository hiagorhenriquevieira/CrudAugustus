using CrudAugustusFashion.Controller;
using CrudAugustusFashion.Dao;
using CrudAugustusFashion.Model;
using CrudAugustusFashion.View.Alteracao;
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
    public partial class FrmListaCliente : Form
    {
        public FrmListaCliente()
        {
            InitializeComponent();
        }

        private void frmListaCliente_Load(object sender, EventArgs e)
        {
            dataGridViewListaClientes.DataSource = new ClienteDao().ListarClientes();
        }

        private void dataGridViewListaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExibirCadastroCliente_Click(object sender, EventArgs e)
        {

            /* 
             * passar pro alteracaoClienteController new AlteracaoClienteController().AbrirAlteracaoCliente(cliente);
             */

            var cliente = RetornarClienteDaGrid();


            new AlteracaoClienteController().AbrirAlteracaoCliente(cliente);



        }

        private ClienteModel RetornarClienteDaGrid()
        {
            return new ClienteModel
            {
                IdUsuario = (int)dataGridViewListaClientes.SelectedRows[0].Cells["IdUsuario"].Value,
                IdCliente = (int)dataGridViewListaClientes.SelectedRows[0].Cells["IdCliente"].Value,
                Nome = dataGridViewListaClientes.SelectedRows[0].Cells["Nome"].Value.ToString(),
                SobreNome = dataGridViewListaClientes.SelectedRows[0].Cells["SobreNome"].Value.ToString(),
                Sexo = dataGridViewListaClientes.SelectedRows[0].Cells["Sexo"].Value.ToString(),
                Cpf = dataGridViewListaClientes.SelectedRows[0].Cells["Cpf"].Value.ToString(),
                DataNascimento = (DateTime)dataGridViewListaClientes.SelectedRows[0].Cells["DataNascimento"].Value,
                Email = dataGridViewListaClientes.SelectedRows[0].Cells["Email"].Value.ToString(),
                Endereco = new EnderecoModel
                {
                    Cep = dataGridViewListaClientes.SelectedRows[0].Cells["EnderecoCep"].Value.ToString(),
                    Cidade = dataGridViewListaClientes.SelectedRows[0].Cells["EnderecoCidade"].Value.ToString(),
                    Bairro = dataGridViewListaClientes.SelectedRows[0].Cells["EnderecoBairro"].Value.ToString(),
                    Complemento = dataGridViewListaClientes.SelectedRows[0].Cells["EnderecoComplemento"].Value.ToString(),
                    NumeroResidencia = dataGridViewListaClientes.SelectedRows[0].Cells["EnderecoNumero"].Value.ToString(),
                    Logradouro = dataGridViewListaClientes.SelectedRows[0].Cells["EnderecoLogradouro"].Value.ToString(),
                    Uf = dataGridViewListaClientes.SelectedRows[0].Cells["EnderecoUf"].Value.ToString(),
                    IdEndereco = (int)dataGridViewListaClientes.SelectedRows[0].Cells["IdEndereco"].Value,
                    IdUsuario = (int)dataGridViewListaClientes.SelectedRows[0].Cells["IdUsuario"].Value,
                },
                ValorLimite = (decimal)dataGridViewListaClientes.SelectedRows[0].Cells["ValorLimite"].Value,
                Observacao = dataGridViewListaClientes.SelectedRows[0].Cells["Observacao"].Value.ToString(),
                Telefone = new TelefoneModel
                {
                    IdTelefone = (int)dataGridViewListaClientes.SelectedRows[0].Cells["IdTelefone"].Value,
                    IdUsuario = (int)dataGridViewListaClientes.SelectedRows[0].Cells["IdUsuario"].Value,
                    Telefone = dataGridViewListaClientes.SelectedRows[0].Cells["TelefoneTelefone"].Value.ToString(),
                    Celular = dataGridViewListaClientes.SelectedRows[0].Cells["TelefoneCelular"].Value.ToString(),
                }
            }; 
        }
    }
}
