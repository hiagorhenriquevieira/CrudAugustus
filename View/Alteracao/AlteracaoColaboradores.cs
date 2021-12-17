using CrudAugustusFashion.Controller;
using CrudAugustusFashion.Dao;
using CrudAugustusFashion.Model;
using CrudAugustusFashion.Model.Usuario;
using System;
using System.Windows.Forms;
namespace CrudAugustusFashion.View.Alteracao
{
    public partial class FrmAlteracaoColaboradores : Form
    {
        private ColaboradorModel _colaboradorModel;
        private ExcluirColaboradorController _excluirColaborador;
        private CadastroColaboradorController _cadastroColaboradorController;

        public FrmAlteracaoColaboradores(ColaboradorModel colaboradores)
        {
            InitializeComponent();
            _colaboradorModel = colaboradores;
            _excluirColaborador = new ExcluirColaboradorController();
            _cadastroColaboradorController = new CadastroColaboradorController();
            PreencherCamposComConsultores();
        }

        private void AlteracaoColaboradores_Load(object sender, EventArgs e)
        {
            new ColaboradorDao().ListarColaboradores();
            var avisoDeAniversario = _colaboradorModel.VerificarSeEhAniversarioDoCliente();
            if (avisoDeAniversario != string.Empty)
                MessageBox.Show(avisoDeAniversario, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAlteracaoCliente_Click(object sender, EventArgs e)
        {
            var colaborador = new ColaboradorModel()
            {
                IdColaborador = int.Parse(txtIdColaborador.Text),
                IdUsuario = int.Parse(txtIdUsuario.Text),

                NomeCompleto = new NomeCompleto
                {
                    Nome = txtNome.Text,
                    SobreNome = txtSobrenome.Text,
                },
                Cpf = txtCpf.Text,
                Sexo = comboBoxSexo.Text,
                Email = txtEmail.Text,
                DataNascimento = dateTimeNascimento.Value,
                Salario = int.Parse(txtSalario.Text),
                PorcentagemComissao = int.Parse(txtPorcentagemComissao.Text),

                Endereco = new EnderecoModel
                {
                    IdUsuario = int.Parse(txtIdUsuario.Text),
                    Cep = txtCep.Text,
                    Cidade = txtCidade.Text,
                    Bairro = txtComplemento.Text,
                    Logradouro = txtLogradouro.Text,
                    NumeroResidencia = txtNumeroResidencia.Text,
                    Uf = comboBoxUf.Text,
                    Complemento = txtComplemento.Text,
                },

                Telefone = new TelefoneModel
                {
                    IdUsuario = int.Parse(txtIdUsuario.Text),
                    Telefone = maskBoxTelefone.Text,
                    Celular = maskBoxCelular.Text,
                },
                ContasBancarias = new ContaBancariaModel
                {
                    IdColaborador = int.Parse(txtIdColaborador.Text),
                    Agencia = int.Parse(txtAgencia.Text),
                    Banco = txtBanco.Text,
                    TipoConta = txtTipoConta.Text,
                    Conta = int.Parse(txtConta.Text),
                },
            };

            try
            {
                var retorno = new AlteracaoColaboradorController().AlterarColaborador(colaborador);
                if (retorno == string.Empty)
                {
                    MessageBox.Show("Colaborador alterado com sucesso!");
                    this.Close();
                _cadastroColaboradorController.AbrirListaColaborador();
                }
                else
                {
                    MessageBox.Show(retorno);
                }
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
            txtNome.Text = _colaboradorModel.NomeCompleto.Nome;
            txtLogradouro.Text = _colaboradorModel.Endereco.Logradouro;
            txtBairro.Text = _colaboradorModel.Endereco.Bairro;
            txtCep.Text = _colaboradorModel.Endereco.Cep.ToString();
            txtCidade.Text = _colaboradorModel.Endereco.Cidade;
            txtComplemento.Text = _colaboradorModel.Endereco.Complemento;
            comboBoxUf.Text = _colaboradorModel.Endereco.Uf;
            txtNumeroResidencia.Text = _colaboradorModel.Endereco.NumeroResidencia.ToString();
            comboBoxSexo.Text = _colaboradorModel.Sexo;
            txtCpf.Text = _colaboradorModel.Cpf.ToString();
            txtSobrenome.Text = _colaboradorModel.NomeCompleto.SobreNome;
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
                _cadastroColaboradorController.AbrirListaColaborador();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao excluir colaborador. Erro: " + ex.Message);
            }
        }

        private void txtAgencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtConta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtPorcentagemComissao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
