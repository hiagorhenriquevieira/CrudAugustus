using CrudAugustusFashion.Model;
using CrudAugustusFashion.Model.Usuario;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;


namespace CrudAugustusFashion.Dao
{
    public class ColaboradorDao
    {

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
                using (var con = ConexaoDao.conectar())
                using (var transacao = con.BeginTransaction())
                {
                    int id = con.ExecuteScalar<int>(insertUsuario, new
                    {
                        IdUsuario = colaborador.IdUsuario,
                        Nome = colaborador.NomeCompleto.Nome,
                        SobreNome = colaborador.NomeCompleto.SobreNome,
                        Cpf = colaborador.Cpf.RemoverFormatacao(),
                        Sexo = colaborador.Sexo,
                        DataNascimento = colaborador.DataNascimento,
                        Email = colaborador.Email,
                    }, transacao);

                    colaborador.IdUsuario = id;

                    colaborador.Endereco.IdUsuario = id;

                    colaborador.Telefone.IdUsuario = id;

                    int idColaborador = con.ExecuteScalar<int>(insertColaborador, colaborador, transacao);

                    colaborador.ContasBancarias.IdColaborador = idColaborador;

                    con.Execute(insertEndereco, new
                    {
                        IdUsuario = colaborador.Endereco.IdUsuario,
                        Cep = colaborador.Endereco.Cep.RemoverFormatacao(),
                        Cidade = colaborador.Endereco.Cidade,
                        Logradouro = colaborador.Endereco.Logradouro,
                        Uf = colaborador.Endereco.Uf,
                        Complemento = colaborador.Endereco.Complemento,
                        Bairro = colaborador.Endereco.Bairro,
                        NumeroResidencia = colaborador.Endereco.NumeroResidencia
                    }, transacao);

                    con.Execute(insertTelefone, colaborador.Telefone, transacao);

                    con.Execute(insertContaBancaria, colaborador.ContasBancarias, transacao);

                    transacao.Commit();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        internal void AlterarColaborador(ColaboradorModel colaborador)
        {
            var updateUsuario = "update Usuarios set Nome = @Nome, SobreNome = @SobreNome, Cpf = @Cpf, Sexo = @Sexo, DataNascimento = @DataNascimento, Email = @Email" +
                " where IdUsuario = @IdUsuario ";
            var updateColaborador = "update Colaboradores set Salario = @Salario, PorcentagemComissao = @PorcentagemComissao " +
                "where IdUsuario = @IdUsuario";
            var updateEndereco = "update Endereco set Cep = @Cep, Cidade = @Cidade, Logradouro = @Logradouro, Uf = @Uf, Complemento = @Complemento, Bairro = @Bairro, NumeroResidencia = @NumeroResidencia " +
                "where IdUsuario = @IdUsuario";
            var updateTelefone = "update Telefone set Telefone = @Telefone, Celular = @Celular" +
                " where IdUsuario = @IdUsuario";
            var updateContasBancarias = "update ContasBancarias set Conta = @Conta, Agencia = @Agencia, TipoConta = @TipoConta, Banco = @Banco" +
                " where IdColaborador = @IdColaborador ";

            try
            {
                using (var con = ConexaoDao.conectar())
                using (var transacao = con.BeginTransaction())
                {
                    con.Execute(updateUsuario, new
                    {
                        IdUsuario = colaborador.IdUsuario,
                        Nome = colaborador.NomeCompleto.Nome,
                        SobreNome = colaborador.NomeCompleto.SobreNome,
                        Cpf = colaborador.Cpf.RemoverFormatacao(),
                        Sexo = colaborador.Sexo,
                        DataNascimento = colaborador.DataNascimento,
                        Email = colaborador.Email,
                    }, transacao);

                    con.Execute(updateColaborador, colaborador, transacao);

                    con.Execute(updateEndereco, new
                    {
                        IdUsuario = colaborador.Endereco.IdUsuario,
                        Cep = colaborador.Endereco.Cep.RemoverFormatacao(),
                        Cidade = colaborador.Endereco.Cidade,
                        Logradouro = colaborador.Endereco.Logradouro,
                        Uf = colaborador.Endereco.Uf,
                        Complemento = colaborador.Endereco.Complemento,
                        Bairro = colaborador.Endereco.Bairro,
                        NumeroResidencia = colaborador.Endereco.NumeroResidencia
                    }, transacao);

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
                        co.IdUsuario, u.IdUsuario, u.Sexo, u.DataNascimento, u.Cpf, u.Email,
                        co.IdUsuario, u.Nome, u.SobreNome,
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
                using (var con = ConexaoDao.conectar())
                {
                    return con.Query<ColaboradorListaModel, NomeCompleto, TelefoneModel, EnderecoModel, ContaBancariaModel, ColaboradorListaModel>(
                        sqlSelect,
                        (colaboradorListaModel, nomeCompleto, telefoneModel, enderecoModel, contaBancariaModel) => MapearListaColaborador(colaboradorListaModel, nomeCompleto, telefoneModel, enderecoModel, contaBancariaModel),
                        splitOn: "IdUsuario"
                        ).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private ColaboradorListaModel MapearListaColaborador(ColaboradorListaModel colaboradorModel, NomeCompleto nomeCompleto, TelefoneModel telefoneModel, EnderecoModel enderecoModel, ContaBancariaModel contaBancariaModel)
        {
            colaboradorModel.NomeCompleto = nomeCompleto;
            colaboradorModel.Telefone = telefoneModel;
            colaboradorModel.Endereco = enderecoModel;
            return colaboradorModel;
        }
        private ColaboradorModel MapearColaborador(ColaboradorModel colaboradorModel, NomeCompleto nomeCompleto, TelefoneModel telefoneModel, EnderecoModel enderecoModel, ContaBancariaModel contaBancariaModel)
        {
            colaboradorModel.NomeCompleto = nomeCompleto;
            colaboradorModel.ContasBancarias = contaBancariaModel;
            colaboradorModel.Telefone = telefoneModel;
            colaboradorModel.Endereco = enderecoModel;
            return colaboradorModel;
        }

        public List<ColaboradorListaModel> BuscarListaColaborador(string nome, bool ativo)
        {
            var selectNomeColaborador = @"select co.IdColaborador, co.Salario, co.PorcentagemComissao,
                        co.IdUsuario, u.Sexo, u.DataNascimento, u.Cpf, u.Email,
                        co.IdUsuario, u.Nome, u.SobreNome,
                        co.IdUsuario, t.IdTelefone, t.Celular, t.Telefone, 
                        co.IdUsuario, e.IdEndereco, e.Cidade, e.Bairro, e.Cep, e.Uf, e.Complemento, e.Logradouro, e.NumeroResidencia,
                        co.IdUsuario, cb.IdContaBancaria, cb.Conta, cb.Agencia, cb.Banco, cb.Tipoconta
                        from
                        Usuarios u inner join Colaboradores co on u.IdUsuario = co.IdUsuario
                        inner join Endereco e on co.IdUsuario = e.IdUsuario
                        inner join ContasBancarias cb on co.IdColaborador = cb.IdColaborador
                        inner join Telefone t on co.IdUsuario = t.IdUsuario
                        where u.Nome like @Nome + '%' and co.Status = @Ativo";
            try
            {
                using (var con = ConexaoDao.conectar())
                {
                    return con.Query<ColaboradorListaModel, NomeCompleto, TelefoneModel, EnderecoModel, ContaBancariaModel, ColaboradorListaModel>(
                        selectNomeColaborador,
                        (colaboradorListaModel, nomeCompleto, telefoneModel, enderecoModel, contaBancariaModel)
                        => MapearListaColaborador(colaboradorListaModel, nomeCompleto, telefoneModel, enderecoModel, contaBancariaModel),
                        new { Nome = nome, Ativo = ativo },
                        splitOn: "IdUsuario"
                        ).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        internal void ExcluirColaboradores(ColaboradorModel colaboradorModel)
        {
            const string updateColaborador = @"update Colaboradores set Status = 0
                                               where IdUsuario = @IdUsuario";
            try
            {
                using (var conexao = ConexaoDao.conectar())
                using (var transacao = conexao.BeginTransaction())
                {
                    conexao.Execute(updateColaborador, new { IdUsuario = colaboradorModel.IdUsuario }, transacao);
                    transacao.Commit();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public int RecuperarIdColaborador(int idColaborador)
        {
            var SelectIdColaborador = @"select IdUsuario from Colaboradores 
                                    where IdColaborador = @IdColaborador;";
            try
            {
                using (var conexao = ConexaoDao.conectar())
                {
                    return conexao.QuerySingle<int>(SelectIdColaborador, new { IdColaborador = idColaborador });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        internal ColaboradorModel RecuperarDadosColaborador(int idColaborador)
        {
            int idUsuario = RecuperarIdColaborador(idColaborador);

            var selectColaborador = @"select co.IdColaborador, co.Salario, co.PorcentagemComissao,
                        co.IdUsuario, u.Sexo, u.DataNascimento, u.Cpf, u.Email,
                        co.IdUsuario, u.Nome, u.SobreNome,
                        co.IdUsuario, t.IdTelefone, t.Celular, t.Telefone, 
                        co.IdUsuario, e.IdEndereco, e.Cidade, e.Bairro, e.Cep, e.Uf, e.Complemento, e.Logradouro, e.NumeroResidencia,
                        co.IdUsuario, cb.IdContaBancaria, cb.Conta, cb.Agencia, cb.Banco, cb.Tipoconta
                        from
                        Colaboradores co inner join Usuarios u on u.IdUsuario = co.IdUsuario
                        inner join Endereco e on co.IdUsuario = e.IdUsuario
                        inner join ContasBancarias cb on co.IdColaborador = cb.IdColaborador
                        inner join Telefone t on co.IdUsuario = t.IdUsuario
                        where co.IdColaborador = @IdColaborador;";
            try
            {
                using (var con = ConexaoDao.conectar())
                {
                    return con.Query<ColaboradorModel, NomeCompleto, TelefoneModel, EnderecoModel, ContaBancariaModel, ColaboradorModel>(
                        selectColaborador,
                        (colaboradorModel, nomeCompleto, telefoneModel, enderecoModel, contaBancariaModel)
                        => MapearColaborador(colaboradorModel, nomeCompleto, telefoneModel, enderecoModel, contaBancariaModel),
                        new { IdColaborador = idColaborador },
                        splitOn: "IdUsuario"
                        ).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
