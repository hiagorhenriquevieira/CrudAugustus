using CrudAugustusFashion.Controller;
using CrudAugustusFashion.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudAugustusFashion.Dao
{
    public class ClienteDao
    {
        ConexaoDao conexao = new ConexaoDao();
        public void CadastrarCliente(ClienteModel cliente)
        {
            const string insertUsuario = "insert into Usuarios output inserted.IdUsuario values (@nome, @sobreNome, @cpf, @sexo, @dataNascimento, @email)";
            const string insertCliente = "insert into Clientes (IdUsuario, ValorLimite, Observacao) values (@IdUsuario, @valorLimite, @observacao)";
            const string insertEndereco = "insert into Endereco (IdUsuario, Cep, Cidade, Logradouro, Uf, Complemento, Bairro, NumeroResidencia) values (@IdUsuario, @cep, @cidade, @logradouro, @uf, @complemento, @bairro, @numeroResidencia)";
            const string insertTelefone = "insert into Telefone (IdUsuario, Telefone, Celular) values (@IdUsuario, @telefone, @celular)";

            try
            {
                using (var conexao = this.conexao.conectar())
                using (var transacao = conexao.BeginTransaction())
                {
                    int id = conexao.ExecuteScalar<int>(insertUsuario, cliente, transacao);
                    cliente.IdUsuario = id;

                    cliente.Endereco.IdUsuario = id;

                    cliente.Telefone.IdUsuario = id;

                    conexao.Execute(insertCliente, cliente, transacao);

                    conexao.Execute(insertEndereco, cliente.Endereco, transacao);

                    conexao.Execute(insertTelefone, cliente.Telefone, transacao);

                    transacao.Commit();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        internal void AlterarCliente(ClienteModel cliente)
        {
            const string updateUsuario = "update Usuarios set Nome = @Nome, SobreNome = @SobreNome, Cpf = @Cpf, Sexo = @Sexo, DataNascimento = @DataNascimento, Email = @Email" +
                " where IdUsuario = @IdUsuario ";
            const string updateCliente = "update Clientes set ValorLimite = @ValorLimite, Observacao = @Observacao " +
                "where IdUsuario = @IdUsuario";
            const string updateEndereco = "update Endereco set Cep = @Cep, Cidade = @Cidade, Logradouro = @Logradouro, Uf = @Uf, Complemento = @Complemento, Bairro = @Bairro, NumeroResidencia = @NumeroResidencia " +
                "where IdUsuario = @IdUsuario";
            const string updateTelefone = "update Telefone set Telefone = @Telefone, Celular = @Celular" +
                " where IdUsuario = @IdUsuario";

            try
            {
                using (var conexao = this.conexao.conectar())
                using (var transacao = conexao.BeginTransaction())
                {
                    conexao.Execute(updateUsuario, cliente, transacao);

                    conexao.Execute(updateCliente, cliente, transacao);

                    conexao.Execute(updateEndereco, cliente.Endereco, transacao);

                    conexao.Execute(updateTelefone, cliente.Telefone, transacao);

                    transacao.Commit();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<ClienteListaModel> ListarClientes()
        {
            var sqlSelect = @"select c.IdCliente, c.Observacao, c.ValorLimite,
                            c.IdUsuario, u.IdUsuario,  u.Nome, u.SobreNome, u.Sexo, u.DataNascimento, u.Cpf, u.Email,
                            c.IdUsuario, t.IdTelefone, t.Celular, t.Telefone, 
                            c.IdUsuario, e.IdEndereco, e.Cidade, e.Bairro, e.Cep, e.Uf, e.Complemento, e.Logradouro, e.NumeroResidencia
                            from
                            Usuarios u inner join Clientes c on u.IdUsuario = c.IdUsuario
                            inner join Endereco e on c.IdUsuario = e.IdUsuario
                            inner join Telefone t on c.IdUsuario = t.IdUsuario;";

            try
            {
                using (var con = conexao.conectar())
                {
                    return con.Query<ClienteListaModel, TelefoneModel, EnderecoModel, ClienteListaModel>(
                        sqlSelect,
                        (clienteListaModel, telefoneModel, enderecoModel) => MapearListaCliente(clienteListaModel, telefoneModel, enderecoModel),
                        splitOn: "IdUsuario"
                        ).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }

        private ClienteListaModel MapearListaCliente(ClienteListaModel clienteModel, TelefoneModel telefoneModel, EnderecoModel enderecoModel)
        {
            clienteModel.Endereco = enderecoModel;
            return clienteModel;
        }

        private ClienteModel MapearCliente(ClienteModel clienteModel, TelefoneModel telefoneModel, EnderecoModel enderecoModel)
        {
            clienteModel.Endereco = enderecoModel;
            return clienteModel;
        }




        internal void ExcluirClientes(ClienteModel clienteModel)
        {
            var deleteTelefone = @"Delete from Telefone
                where IdUsuario = @IdUsuario";
            var deleteEndereco = "Delete from Endereco " +
                "where IdUsuario = @IdUsuario";
            var deleteCliente = "Delete from Clientes " +
                "where IdUsuario = @IdUsuario";
            var deleteUsuario = "Delete from Usuarios " +
                "where IdUsuario = @IdUsuario";

            try
            {
                using (var conexao = this.conexao.conectar())
                using (var transacao = conexao.BeginTransaction())
                {
                    conexao.Execute(deleteTelefone, new { IdUsuario = clienteModel.IdUsuario }, transacao);

                    conexao.Execute(deleteEndereco, new { IdUsuario = clienteModel.IdUsuario }, transacao);

                    conexao.Execute(deleteCliente, new { IdUsuario = clienteModel.IdUsuario }, transacao);

                    conexao.Execute(deleteUsuario, new { IdUsuario = clienteModel.IdUsuario }, transacao);
                    transacao.Commit();
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int RecuperarIdUsuario(int idCliente)
        {
            var SelectIdUsuario = @"select IdUsuario from Clientes 
                                    where IdCliente = @IdCliente;";

            try
            {
                using (var conexao = this.conexao.conectar())
                {
                    return conexao.QuerySingle<int>(SelectIdUsuario, new { IdCliente = idCliente });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        internal ClienteModel RecuperarDadosCliente(int idCliente)
        {
            int idUsuario = RecuperarIdUsuario(idCliente);

            var selectUsuario = @"select c.IdCliente, c.Observacao, c.ValorLimite,
                            c.IdUsuario, u.IdUsuario,  u.Nome, u.SobreNome, u.Sexo, u.DataNascimento, u.Cpf, u.Email,
                            c.IdUsuario, t.IdTelefone, t.Celular, t.Telefone, 
                            c.IdUsuario, e.IdEndereco, e.Cidade, e.Bairro, e.Cep, e.Uf, e.Complemento, e.Logradouro, e.NumeroResidencia
                            from
                            Usuarios u inner join Clientes c on u.IdUsuario = c.IdUsuario
                            inner join Endereco e on c.IdUsuario = e.IdUsuario
                            inner join Telefone t on c.IdUsuario = t.IdUsuario
                            where c.IdUsuario = @IdUsuario;";
            try
            {
                using (var con = conexao.conectar())
                {
                    return con.Query<ClienteModel, TelefoneModel, EnderecoModel, ClienteModel>(
                        selectUsuario,
                        (clienteModel, telefoneModel, enderecoModel) => MapearCliente(clienteModel, telefoneModel, enderecoModel),
                        new { IdUsuario = idUsuario },
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
