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
        public void CadastrarColaborador(ColaboradorModel colaborador)
        {

            var insertUsuario = "insert into Usuarios (Nome, SobreNome, Sexo, DataNascimento, Cpf, Email) output inserted.IdUsuario values (@nome, @sobreNome, @sexo, @dataNascimento, @cpf, @email)";
            var insertColaborador = "insert into Colaboradores (IdUsuario, Salario, PorcentagemComissao) output inserted.IdColaborador values (@IdUsuario, @salario, @porcentagemComissao)";
            var insertEndereco = "insert into Endereco (IdUsuario, Cep, Cidade, Logradouro, Uf, Complemento, Bairro, NumeroResidencia) " +
               "values (@IdUsuario, @cep, @cidade, @logradouro, @uf, @complemento, @bairro, @numeroResidencia)";
            var insertTelefone = "insert into Telefone (IdUsuario, Telefone, Celular) values (@IdUsuario, @telefone, @celular)";
            var insertContaBancaria = "insert into ContasBancarias (IdColaborador, Conta, Agencia, TipoConta, Banco) values (@IdColaborador, @conta, @agencia, @tipoConta, @banco)";

            try
            {
                using (var con = conexao.conectar())
                using (var transacao = con.BeginTransaction())
                {
                    int id = con.ExecuteScalar<int>(insertUsuario, colaborador, transacao);

                    colaborador.IdUsuario = id;

                    colaborador.Endereco.IdUsuario = id;

                    colaborador.Telefone.IdUsuario = id;

                    int idColaborador = con.ExecuteScalar<int>(insertColaborador, colaborador, transacao);

                    colaborador.ContasBancarias.IdColaborador = idColaborador;

                    con.Execute(insertEndereco, colaborador.Endereco, transacao);

                    con.Execute(insertTelefone, colaborador.Telefone, transacao);

                    con.Execute(insertContaBancaria, colaborador.ContasBancarias, transacao);

                    transacao.Commit();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                ;
            }
        }
        internal void AlterarColaborador(ColaboradorModel colaborador)
        {
            var updateUsuario = "update Usuarios set Nome = @Nome, SobreNome = @SobreNome, Cpf = @Cpf, Sexo = @Sexo, DataNascimento = @DataNascimento, Email = @Email" +
                " where IdUsuario = @IdUsuario ";
            var updateColaborador = "update Colaboradores set Salario = @Salario, PorcentagemComissao = @PorcentagemComissao " +
                "where IdColaborador = @IdUsuario";
            var updateEndereco = "update Endereco set Cep = @Cep, Cidade = @Cidade, Logradouro = @Logradouro, Uf = @Uf, Complemento = @Complemento, Bairro = @Bairro, NumeroResidencia = @NumeroResidencia " +
                "where IdEndereco = @IdUsuario";
            var updateTelefone = "update Telefone set Telefone = @Telefone, Celular = @Celular" +
                " where IdTelefone = @IdUsuario";
            var updateContasBancarias = "update ContasBancarias set Conta = @Conta, Agencia = @Agencia, TipoConta = @TipoConta, Banco = @Banco where IdContaBancaria = @IdColaborador ";

            try
            {
                using (var con = conexao.conectar())
                using (var transacao = con.BeginTransaction())
                {
                    int id = con.ExecuteScalar<int>(updateUsuario, colaborador, transacao);

                    colaborador.IdUsuario = id;

                    colaborador.Endereco.IdUsuario = id;

                    colaborador.Telefone.IdUsuario = id;

                    int idColaborador = con.ExecuteScalar<int>(updateColaborador, colaborador, transacao);

                    colaborador.ContasBancarias.IdColaborador = idColaborador;

                    con.Execute(updateEndereco, colaborador.Endereco, transacao);

                    con.Execute(updateTelefone, colaborador.Telefone, transacao);

                    con.Execute(updateContasBancarias, colaborador.ContasBancarias, transacao);

                    transacao.Commit();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
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
                throw new Exception(ex.Message);
            }

            //return new List<ColaboradorListaModel>();
        }

        private ColaboradorListaModel MapearColaborador(ColaboradorListaModel colaboradorModel, TelefoneModel telefoneModel, EnderecoModel enderecoModel, ContaBancariaModel contaBancariaModel)
        {
            
            colaboradorModel.Endereco = enderecoModel;
            

            return colaboradorModel;
        }

        internal void ExcluirColaboradores(ColaboradorModel colaboradorModel)
        {
            var deleteTelefone = @"Delete from Telefone
                where IdUsuario = @IdUsuario";
            var deleteEndereco = "Delete from Endereco " +
                "where IdUsuario = @IdUsuario";
            var deleteContaBancaria = @"Delete from ContasBancarias
                where IdColaborador = @IdColaborador";
            var deleteColaborador = "Delete from Colaboradores " +
                "where IdUsuario = @IdUsuario";
            var deleteUsuario = "Delete from Usuarios " +
                "where IdUsuario = @IdUsuario";

            try
            {
                using (var conexao = this.conexao.conectar())
                using (var transacao = conexao.BeginTransaction())
                {
                    conexao.Execute(deleteTelefone, new { IdUsuario = colaboradorModel.IdUsuario }, transacao);

                    conexao.Execute(deleteEndereco, new { IdUsuario = colaboradorModel.IdUsuario }, transacao);

                    conexao.Execute(deleteContaBancaria, new { IdColaborador = colaboradorModel.IdColaborador }, transacao);

                    conexao.Execute(deleteColaborador, new { IdUsuario = colaboradorModel.IdUsuario }, transacao);

                    conexao.Execute(deleteUsuario, new { IdUsuario = colaboradorModel.IdUsuario }, transacao);
                    transacao.Commit();
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
