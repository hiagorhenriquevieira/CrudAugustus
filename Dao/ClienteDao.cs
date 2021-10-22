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
        public void CadastrarCliente(ClienteModel cliente, EnderecoModel endereco, TelefoneModel telefone)
        {
            var strSqlUsuario = "insert into Usuarios output inserted.IdUsuario values (@nome, @sobreNome, @sexo, @dataNascimento, @cpf, @email)";
            var strSqlCliente = "insert into Clientes (IdUsuario, ValorLimite, Observacao) values (@IdUsuario, @limiteCompra, @observacao)";
            var strSqlEndereco = "insert into Endereco (IdUsuario, Cep, Cidade, Logradouro, Uf, Complemento, Bairro, NumeroResidencia) " +
               "values (@IdUsuario, @cep, @cidade, @logradouro, @uf, @complemento, @bairro, @numeroResidencia)";
            var strSqlTelefone = "insert into Telefone (IdUsuario, Telefone, Celular) values (@IdUsuario, @telefone, @celular)";

            try
            {
                using (var con = conexao.conectar())
                using (var transacao = con.BeginTransaction())
                {
                    int id = con.ExecuteScalar<int>(strSqlUsuario, cliente, transacao);
                    cliente.IdUsuario = id;

                    endereco.IdUsuario = id;

                    telefone.IdUsuario = id;

                    con.Execute(strSqlCliente, cliente, transacao);

                    con.Execute(strSqlEndereco, endereco, transacao);

                    con.Execute(strSqlTelefone, telefone, transacao);

                    transacao.Commit();
                }

                //MessageBox.Show(cliente.IdUsuario.ToString());
                MessageBox.Show("Cliente cadastrado com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<ClienteListaModel> ListarClientes()
        {
            var sqlSelect = @"select c.IdCliente, u.Nome, u.SobreNome, u.Sexo, u.DataNascimento, 
                            c.IdUsuario, t.Celular, t.Telefone, 
                            c.IdUsuario, e.Cidade, e.Bairro, e.Cep, e.Uf, e.Complemento, e.Logradouro, e.NumeroResidencia
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
                        (clienteListaModel, telefoneModel, enderecoModel) => MapearCliente(clienteListaModel, telefoneModel, enderecoModel),
                        splitOn: "IdUsuario"
                        ).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocorreu um erro ao listar clientes");
            }

            return new List<ClienteListaModel>();
        }

        private ClienteListaModel MapearCliente(ClienteListaModel clienteModel, TelefoneModel telefoneModel, EnderecoModel enderecoModel)
        {
            clienteModel.Telefone = telefoneModel;
            clienteModel.Endereco = enderecoModel;

            return clienteModel;
        }


        //public ClienteListaModel SelecionarCliente(IDbConnection conexao, id)
        //{
        //    return
        //}


    }

}
