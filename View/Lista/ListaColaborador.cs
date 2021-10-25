using CrudAugustusFashion.Dao;
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
using System.Data.SqlClient;

namespace CrudAugustusFashion.View
{
    public partial class FrmListaColaborador : Form
    {
        public FrmListaColaborador()
        {
            InitializeComponent();
        }

        private void FrmListaColaborador_Load(object sender, EventArgs e)
        {
            dataGrideViewColaboradores.DataSource = new ColaboradorDao().ListarColaboradores();
        }

        private void btnExibirCadastroColaborador_Click(object sender, EventArgs e)
        {
            var colaboradores = RetornarClienteDaGrid();

            new AlteracaoColaboradorController().AbrirAlteracaoColaboradores(colaboradores);
        }

        private ColaboradorModel RetornarClienteDaGrid()
        {
            return new ColaboradorModel
            {
                IdUsuario = (int)dataGrideViewColaboradores.SelectedRows[0].Cells["IdUsuario"].Value,
                IdColaborador = (int)dataGrideViewColaboradores.SelectedRows[0].Cells["IdColaborador"].Value,
                Nome = dataGrideViewColaboradores.SelectedRows[0].Cells["Nome"].Value.ToString(),
                SobreNome = dataGrideViewColaboradores.SelectedRows[0].Cells["SobreNome"].Value.ToString(),
                Sexo = dataGrideViewColaboradores.SelectedRows[0].Cells["Sexo"].Value.ToString(),
                Cpf = dataGrideViewColaboradores.SelectedRows[0].Cells["Cpf"].Value.ToString(),
                DataNascimento = (DateTime)dataGrideViewColaboradores.SelectedRows[0].Cells["DataNascimento"].Value,
                Email = dataGrideViewColaboradores.SelectedRows[0].Cells["Email"].Value.ToString(),
                Salario = (int)dataGrideViewColaboradores.SelectedRows[0].Cells["Salario"].Value,
                PorcentagemComissao = (int)dataGrideViewColaboradores.SelectedRows[0].Cells["PorcentagemComissao"].Value,

                Endereco = new EnderecoModel
                {
                    Cep = dataGrideViewColaboradores.SelectedRows[0].Cells["EnderecoCep"].Value.ToString(),
                    Cidade = dataGrideViewColaboradores.SelectedRows[0].Cells["EnderecoCidade"].Value.ToString(),
                    Bairro = dataGrideViewColaboradores.SelectedRows[0].Cells["EnderecoBairro"].Value.ToString(),
                    Complemento = dataGrideViewColaboradores.SelectedRows[0].Cells["EnderecoComplemento"].Value.ToString(),
                    NumeroResidencia = dataGrideViewColaboradores.SelectedRows[0].Cells["EnderecoNumero"].Value.ToString(),
                    Logradouro = dataGrideViewColaboradores.SelectedRows[0].Cells["EnderecoLogradouro"].Value.ToString(),
                    Uf = dataGrideViewColaboradores.SelectedRows[0].Cells["EnderecoUf"].Value.ToString(),
                    IdEndereco = (int)dataGrideViewColaboradores.SelectedRows[0].Cells["IdEndereco"].Value,
                    IdUsuario = (int)dataGrideViewColaboradores.SelectedRows[0].Cells["IdUsuario"].Value,
                },
                Telefone = new TelefoneModel
                {
                    IdTelefone = (int)dataGrideViewColaboradores.SelectedRows[0].Cells["IdTelefone"].Value,
                    IdUsuario = (int)dataGrideViewColaboradores.SelectedRows[0].Cells["IdUsuario"].Value,
                    Telefone = dataGrideViewColaboradores.SelectedRows[0].Cells["TelefoneTelefone"].Value.ToString(),
                    Celular = dataGrideViewColaboradores.SelectedRows[0].Cells["TelefoneCelular"].Value.ToString(),
                },
                ContasBancarias = new ContaBancariaModel
                {
                    IdContaBancaria = (int)dataGrideViewColaboradores.SelectedRows[0].Cells["IdContaBancaria"].Value,
                    IdColaborador = (int)dataGrideViewColaboradores.SelectedRows[0].Cells["IdColaborador"].Value,
                    Conta = (int)dataGrideViewColaboradores.SelectedRows[0].Cells["ContaBancariaConta"].Value,
                    Agencia = (int)dataGrideViewColaboradores.SelectedRows[0].Cells["ContaBancariaAgencia"].Value,
                    TipoConta = dataGrideViewColaboradores.SelectedRows[0].Cells["ContaBancariaTipoConta"].Value.ToString(),
                    Banco = dataGrideViewColaboradores.SelectedRows[0].Cells["ContaBancariaBanco"].Value.ToString(),
                }
            };
        }
    }
}
