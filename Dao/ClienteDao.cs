using CrudAugustusFashion.Model;
using CrudAugustusFashion.Model.Cliente;
using CrudAugustusFashion.Model.Produto;
using CrudAugustusFashion.Model.Usuario;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CrudAugustusFashion.Dao
{
    public class ClienteDao
    {

        public void CadastrarCliente(ClienteModel cliente)
        {
            const string insertUsuario = "insert into Usuarios output inserted.IdUsuario values (@nome, @sobreNome, @cpf, @sexo, @dataNascimento, @email)";
            const string insertCliente = "insert into Clientes (IdUsuario, ValorLimite, Observacao) values (@IdUsuario, @valorLimite, @observacao)";
            const string insertEndereco = "insert into Endereco (IdUsuario, Cep, Cidade, Logradouro, Uf, Complemento, Bairro, NumeroResidencia) " +
                "values (@IdUsuario, @cep, @cidade, @logradouro, @uf, @complemento, @bairro, @numeroResidencia)";
            const string insertTelefone = "insert into Telefone (IdUsuario, Telefone, Celular) values (@IdUsuario, @telefone, @celular)";

            try
            {
                using (var conexao = ConexaoDao.conectar())
                using (var transacao = conexao.BeginTransaction())
                {
                    int idUsuario = conexao.ExecuteScalar<int>(insertUsuario, new
                    {
                        cliente.IdUsuario,
                        cliente.NomeCompleto.Nome,
                        cliente.NomeCompleto.SobreNome,
                        Cpf = cliente.Cpf.RemoverFormatacao(),
                        cliente.Sexo,
                        cliente.DataNascimento,
                        cliente.Email,
                    }
                            , transacao);
                    cliente.IdUsuario = idUsuario;

                    cliente.Endereco.IdUsuario = idUsuario;

                    cliente.Telefone.IdUsuario = idUsuario;

                    conexao.Execute(insertCliente, new
                    {
                        cliente.IdUsuario,
                        ValorLimite = cliente.ValorLimite.Valor,
                        cliente.Observacao,
                    }, transacao);

                    conexao.Execute(insertEndereco, new
                    {
                        IdUsuario = cliente.Endereco.IdUsuario,
                        Cep = cliente.Endereco.Cep.RemoverFormatacao(),
                        Cidade = cliente.Endereco.Cidade,
                        Logradouro = cliente.Endereco.Logradouro,
                        Uf = cliente.Endereco.Uf,
                        Complemento = cliente.Endereco.Complemento,
                        Bairro = cliente.Endereco.Bairro,
                        NumeroResidencia = cliente.Endereco.NumeroResidencia
                    }, transacao);

                    conexao.Execute(insertTelefone, cliente.Telefone, transacao);

                    transacao.Commit();
                }
            }
            catch (Exception excecao)
            {
                throw new Exception(excecao.Message);
            }
        }

        internal void AlterarCliente(ClienteModel cliente)
        {
            const string updateUsuario = "update Usuarios set Nome = @Nome, SobreNome = @SobreNome, Cpf = @Cpf, Sexo = @Sexo, DataNascimento = @DataNascimento, Email = @Email" +
                " where IdUsuario = @IdUsuario ";
            const string updateCliente = "update Clientes set ValorLimite = @ValorLimite, Observacao = @Observacao" +
                " where IdUsuario = @IdUsuario";
            const string updateEndereco = "update Endereco set Cep = @Cep, Cidade = @Cidade, Logradouro = @Logradouro, Uf = @Uf, Complemento = @Complemento, Bairro = @Bairro, NumeroResidencia = @NumeroResidencia " +
                "where IdUsuario = @IdUsuario";
            const string updateTelefone = "update Telefone set Telefone = @Telefone, Celular = @Celular" +
                " where IdUsuario = @IdUsuario";

            try
            {
                using (var conexao = ConexaoDao.conectar())
                using (var transacao = conexao.BeginTransaction())
                {
                    conexao.Execute(updateUsuario, new
                    {
                        cliente.IdUsuario,
                        cliente.NomeCompleto.Nome,
                        cliente.NomeCompleto.SobreNome,
                        Cpf = cliente.Cpf.RemoverFormatacao(),
                        cliente.Sexo,
                        cliente.DataNascimento,
                        cliente.Email,
                    }
                            , transacao);

                    conexao.Execute(updateCliente, new
                    {
                        cliente.IdUsuario,
                        ValorLimite = cliente.ValorLimite.Valor,
                        cliente.Observacao,
                    }, transacao);

                    conexao.Execute(updateEndereco, new
                    {
                        cliente.Endereco.IdUsuario,
                        Cep = cliente.Endereco.Cep.RemoverFormatacao(),
                        cliente.Endereco.Cidade,
                        cliente.Endereco.Logradouro,
                        cliente.Endereco.Uf,
                        cliente.Endereco.Complemento,
                        cliente.Endereco.Bairro,
                        cliente.Endereco.NumeroResidencia
                    }, transacao);

                    conexao.Execute(updateTelefone, cliente.Telefone, transacao);

                    transacao.Commit();
                }
            }
            catch (Exception excecao)
            {
                throw new Exception(excecao.Message);
            }
        }

        public List<ClienteListaModel> ListarClientes()
        {
            var sqlSelect = @"select c.IdCliente, c.IdUsuario, c.Observacao, c.ValorLimite,
                            u.IdUsuario, u.Sexo, u.DataNascimento, u.Cpf, u.Email,
                            c.IdUsuario, u.Nome, u.SobreNome, 
                            c.IdUsuario, t.IdTelefone, t.Telefone, t.Celular, 
                            c.IdUsuario, e.IdEndereco, e.Cidade, e.Bairro, e.Cep, e.Uf, e.Complemento, e.Logradouro, e.NumeroResidencia
                            from
                            Usuarios u inner join Clientes c on u.IdUsuario = c.IdUsuario
                            inner join Endereco e on c.IdUsuario = e.IdUsuario
                            inner join Telefone t on c.IdUsuario = t.IdUsuario;";

            try
            {
                using (var conexao = ConexaoDao.conectar())
                {
                    return conexao.Query(
                        sqlSelect,
                        (ClienteListaModel clienteListaModel, NomeCompleto nomeCompleto, TelefoneModel telefoneModel, EnderecoModel enderecoModel)
                        => MapearListaCliente(clienteListaModel,
                                              nomeCompleto,
                                              telefoneModel,
                                              enderecoModel),
                        splitOn: "IdUsuario"
                        ).ToList();
                }
            }
            catch (Exception excecao)
            {
                throw new Exception(excecao.Message);
            }
        }

        private ClienteListaModel MapearListaCliente(ClienteListaModel clienteModel, NomeCompleto nomeCompleto, TelefoneModel telefoneModel, EnderecoModel enderecoModel)
        {
            clienteModel.NomeCompleto = nomeCompleto;
            clienteModel.Telefone = telefoneModel;
            clienteModel.Endereco = enderecoModel;
            return clienteModel;
        }

        private ClienteModel MapearCliente(ClienteModel clienteModel, NomeCompleto nomeCompleto, TelefoneModel telefoneModel, EnderecoModel enderecoModel)
        {
            clienteModel.NomeCompleto = nomeCompleto;
            clienteModel.Telefone = telefoneModel;
            clienteModel.Endereco = enderecoModel;
            return clienteModel;
        }

        public List<ClienteListaModel> BuscarListaCliente(string nome, bool ativo)
        {

            var selectNomeCliente = @"select c.IdCliente, c.Observacao, c.ValorLimite,
                            c.IdUsuario, u.IdUsuario, u.Sexo, u.DataNascimento, u.Cpf, u.Email,
                            c.IdUsuario, u.Nome, u.SobreNome,
                            c.IdUsuario, t.IdTelefone, t.Telefone, t.Celular, 
                            c.IdUsuario, e.IdEndereco, e.Cidade, e.Bairro, e.Cep, e.Uf, e.Complemento, e.Logradouro, e.NumeroResidencia
                            from
                            Usuarios u inner join Clientes c on u.IdUsuario = c.IdUsuario
                            inner join Endereco e on c.IdUsuario = e.IdUsuario
                            inner join Telefone t on c.IdUsuario = t.IdUsuario
                            where u.Nome like @Nome + '%' and c.Status = @Ativo;";
            try
            {

                using (var conexao = ConexaoDao.conectar())
                {
                    return conexao.Query(
                        selectNomeCliente,
                        (ClienteListaModel clienteListaModel, NomeCompleto nomeCompleto, TelefoneModel telefoneModel, EnderecoModel enderecoModel)
                        => MapearListaCliente(clienteListaModel, nomeCompleto, telefoneModel, enderecoModel), new { Nome = nome, Ativo = ativo },
                        splitOn: "IdUsuario"
                        ).ToList();
                }
            }
            catch (Exception excecao)
            {
                throw new Exception(excecao.Message);
            }
        }

        internal void ExcluirClientes(ClienteModel clienteModel)
        {

            const string updateCliente = @"Update Clientes set Status = 0
                                           where IdUsuario = @IdUsuario";

            try
            {
                using (var conexao = ConexaoDao.conectar())
                using (var transacao = conexao.BeginTransaction())
                {
                    conexao.Execute(updateCliente, new { IdUsuario = clienteModel.IdUsuario }, transacao);

                    transacao.Commit();
                }
            }
            catch (Exception excecao)
            {
                throw new Exception(excecao.Message);
            }
        }

        public int RecuperarIdUsuario(int IdCliente)
        {
            var SelectIdUsuario = @"select IdUsuario from Clientes 
                                    where IdCliente = @IdCliente;";

            try
            {
                using (var conexao = ConexaoDao.conectar())
                {
                    return conexao.QuerySingle<int>(SelectIdUsuario, new { IdCliente });
                }
            }
            catch (Exception excecao)
            {
                throw new Exception(excecao.Message);
            }
        }

        internal ClienteModel RecuperarDadosCliente(int idCliente)
        {
            int IdUsuario = RecuperarIdUsuario(idCliente);

            var selectUsuario = @"select c.IdCliente, c.Observacao, c.ValorLimite,
                            c.IdUsuario, u.IdUsuario, u.Sexo, u.DataNascimento, u.Cpf, u.Email,
                            c.IdUsuario, u.Nome, u.SobreNome,
                            c.IdUsuario, t.IdTelefone, t.Telefone, t.Celular, 
                            c.IdUsuario, e.IdEndereco, e.Cidade, e.Bairro, e.Cep, e.Uf, e.Complemento, e.Logradouro, e.NumeroResidencia
                            from
                            Usuarios u inner join Clientes c on u.IdUsuario = c.IdUsuario
                            inner join Endereco e on u.IdUsuario = e.IdUsuario
                            inner join Telefone t on u.IdUsuario = t.IdUsuario
                            where c.IdUsuario = @IdUsuario;";


            try
            {
                using (var conexao = ConexaoDao.conectar())
                {
                    return conexao.Query(
                        selectUsuario,
                        (ClienteModel clienteModel, NomeCompleto nomeCompleto, TelefoneModel telefoneModel, EnderecoModel enderecoModel)
                        => MapearCliente(clienteModel, nomeCompleto, telefoneModel, enderecoModel),
                        new { IdUsuario },
                        splitOn: "IdUsuario"
                        ).FirstOrDefault();
                }
            }
            catch (Exception excecao)
            {
                throw new Exception(excecao.Message);
            }
        }
        public decimal RecuperarValorGastoAPrazo(int cliente)
        {
            const string selectValorGastoAPrazo = @"Select sum(v.TotalLiquido) as ValorConsumido
                                                    from ContasAReceber cr
                                                    inner join Venda v on v.IdVenda = cr.IdVenda
                                                    inner join Clientes c on c.IdCliente = v.IdCliente
                                                    where c.IdCliente = @IdCliente and Ativo = 1
                                                    and v.FormaDePagamento = 1
													group by c.ValorLimite";


            try
            {
                using (var conexao = ConexaoDao.conectar())
                {
                    return conexao.Query<decimal>(selectValorGastoAPrazo, new { IdCliente = cliente }).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
