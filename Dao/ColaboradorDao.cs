using CrudAugustusFashion.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudAugustusFashion.Dao
{
    public class ColaboradorDao
    {
        ConexaoDao conexao = new ConexaoDao();
        public void CadastrarColaborador(ColaboradorModel colaborador, EnderecoModel endereco, TelefoneModel telefone, ContaBancariaModel contaBancaria)
        {

            var strSqlUsuario = "insert into Usuarios (Nome, SobreNome, Sexo, DataNascimento, Cpf, Email) output inserted.IdUsuario values (@nome, @sobreNome, @sexo, @dataNascimento, @cpf, @email)";
            var strSqlColaborador = "insert into Colaboradores (IdUsuario, Salario, PorcentagemComissao) output inserted.IdColaborador values (@IdUsuario, @salario, @porcentagemComissao)";
            var strSqlEndereco = "insert into Endereco (IdUsuario, Cep, Cidade, Logradouro, Uf, Complemento, Bairro, NumeroResidencia) " +
               "values (@IdUsuario, @cep, @cidade, @logradouro, @uf, @complemento, @bairro, @numeroResidencia)";
            var strSqlTelefone = "insert into Telefone (IdUsuario, Telefone, Celular) values (@IdUsuario, @telefone, @celular)";
            var strSqlContaBancaria = "insert into ContasBancarias (IdColaborador, Conta, Agencia, TipoConta, Banco) values (@IdColaborador, @conta, @agencia, @tipoConta, @banco)";

            try
            {
                using (var con = conexao.conectar())
                using (var transacao = con.BeginTransaction())
                {
                    int id = con.ExecuteScalar<int>(strSqlUsuario, colaborador, transacao);

                    colaborador.IdUsuario = id;

                    endereco.IdUsuario = id;

                    telefone.IdUsuario = id;

                    int idColaborador = con.ExecuteScalar<int>(strSqlColaborador, colaborador, transacao);

                    contaBancaria.IdColaborador = idColaborador;

                    con.Execute(strSqlEndereco, endereco, transacao);

                    con.Execute(strSqlTelefone, telefone, transacao);

                    con.Execute(strSqlContaBancaria, contaBancaria, transacao);

                    transacao.Commit();
                }

                //MessageBox.Show(colaborador.IdUsuario.ToString());
                MessageBox.Show("Colaborador cadastrado com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public List<ColaboradorListaModel> ListarColaboradores()
        {
            var sqlSelect = @"select co.IdColaborador, co.Salario, co.PorcentagemComissao,
                        co.IdUsuario, u.IdUsuario,  u.Nome, u.SobreNome, u.Sexo, u.DataNascimento, u.Cpf, u.Email,
                        co.IdUsuario, t.IdTelefone, t.Celular, t.Telefone, 
                        co.IdUsuario, e.IdEndereco, e.Cidade, e.Bairro, e.Cep, e.Uf, e.Complemento, e.Logradouro, e.NumeroResidencia,
                        co.IdUsuario, cb.IdContaBancaria, cb.Conta, cb.Agencia, cb.Banco, cb.Tipoconta
                        from
                        Usuarios u inner join Colaboradores co on u.IdUsuario = co.IdUsuario
                        inner join Endereco e on co.IdUsuario = e.IdUsuario
                        inner join ContasBancarias cb on co.IdColaborador = cb.IdColaborador
                        inner join Telefone t on co.IdUsuario = t.IdUsuario;";

            try
            {
                using (var con = conexao.conectar())
                {
                    return con.Query<ColaboradorListaModel, TelefoneModel, EnderecoModel, ContaBancariaModel, ColaboradorListaModel>(
                        sqlSelect,
                        (colaboradorListaModel, telefoneModel, enderecoModel, contaBancariaModel) => MapearColaborador(colaboradorListaModel, telefoneModel, enderecoModel, contaBancariaModel),
                        splitOn: "IdUsuario"
                        ).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocorreu um erro ao listar clientes");
            }

            return new List<ColaboradorListaModel>();
        }

        private ColaboradorListaModel MapearColaborador(ColaboradorListaModel colaboradorModel, TelefoneModel telefoneModel, EnderecoModel enderecoModel, ContaBancariaModel contaBancariaModel)
        {
            colaboradorModel.Telefone = telefoneModel;
            colaboradorModel.Endereco = enderecoModel;
            colaboradorModel.ContasBancarias = contaBancariaModel;

            return colaboradorModel;
        }
    }
}
