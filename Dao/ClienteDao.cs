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

                    endereco.IdUsuario = id;

                    telefone.IdUsuario = id;

                    conexao.Execute(insertCliente, cliente, transacao);

                    conexao.Execute(insertEndereco, endereco, transacao);

                    conexao.Execute(insertTelefone, telefone, transacao);

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

        internal void AlterarCliente(ClienteModel cliente, EnderecoModel endereco, TelefoneModel telefone)
        {
            const string updateUsuario = "update Usuarios (Nome, SobreNome, Cpf, Sexo Email) output updated.IdUsuario values (@nome, @sobreNome, @cpf, @sexo, @email)";
            const string updateCliente = "update Clientes (IdUsuario, ValorLimite, Observacao) values (@IdUsuario, @valorLimite, @observacao)";
            const string updateEndereco = "update Endereco (IdUsuario, Cep, Cidade, Logradouro, Uf, Complemento, Bairro, NumeroResidencia) values (@IdUsuario, @cep, @cidade, @logradouro, @uf, @complemento, @bairro, @numeroResidencia)";
            const string updateTelefone = "update Telefone (IdUsuario, Telefone, Celular) values (@IdUsuario, @telefone, @celular)";
            //var id = cliente;
            //var sqlUpdate = @"";

            //try
            //{
            //    using (var con = new ConexaoDao().conectar())
            //    {
            //        con.Query<ClienteListaModel>(sqlUpdate, cliente);
            //        AlterarCliente(cliente);
            //         MessageBox.Show("Cliente alterado!");

            //    }
            //}
            //catch (Exception excecao)
            //{
            //    MessageBox.Show(excecao.Message);
            //}
            try
            {
                using (var conexao = this.conexao.conectar())
                using (var transacao = conexao.BeginTransaction())
                {
                    int id = conexao.ExecuteScalar<int>(updateUsuario, cliente, transacao);
                    cliente.IdUsuario = id;

                    endereco.IdUsuario = id;

                    telefone.IdUsuario = id;

                    conexao.Execute(updateCliente, cliente, transacao);

                    conexao.Execute(updateEndereco, endereco, transacao);

                    conexao.Execute(updateTelefone, telefone, transacao);

                    transacao.Commit();
                }

                //MessageBox.Show(cliente.IdUsuario.ToString());
                MessageBox.Show("Cliente alterado com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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


        //public void AlterarCliente(ClienteModel cliente, EnderecoModel endereco, TelefoneModel telefone)
        //{
        //    const string updateUsuario = "update Usuarios output updated.IdUsuario values (@nome, @sobreNome, @cpf, @sexo, @dataNascimento, @email)";
        //    const string updateCliente = "update Clientes (IdUsuario, ValorLimite, Observacao) values (@IdUsuario, @valorLimite, @observacao)";
        //    const string updateEndereco = "update Endereco (IdUsuario, Cep, Cidade, Logradouro, Uf, Complemento, Bairro, NumeroResidencia) values (@IdUsuario, @cep, @cidade, @logradouro, @uf, @complemento, @bairro, @numeroResidencia)";
        //    const string updateTelefone = "update Telefone (IdUsuario, Telefone, Celular) values (@IdUsuario, @telefone, @celular)";
        //    //var id = cliente;
        //    //var sqlUpdate = @"";

        //    //try
        //    //{
        //    //    using (var con = new ConexaoDao().conectar())
        //    //    {
        //    //        con.Query<ClienteListaModel>(sqlUpdate, cliente);
        //    //        AlterarCliente(cliente);
        //    //         MessageBox.Show("Cliente alterado!");

        //    //    }
        //    //}
        //    //catch (Exception excecao)
        //    //{
        //    //    MessageBox.Show(excecao.Message);
        //    //}
        //    try
        //    {
        //        using (var conexao = this.conexao.conectar())
        //        using (var transacao = conexao.BeginTransaction())
        //        {
        //            int id = conexao.ExecuteScalar<int>(updateUsuario, cliente, transacao);
        //            cliente.IdUsuario = id;

        //            endereco.IdUsuario = id;

        //            telefone.IdUsuario = id;

        //            conexao.Execute(updateCliente, cliente, transacao);

        //            conexao.Execute(updateEndereco, endereco, transacao);

        //            conexao.Execute(updateTelefone, telefone, transacao);

        //            transacao.Commit();
        //        }

        //        //MessageBox.Show(cliente.IdUsuario.ToString());
        //        MessageBox.Show("Cliente alterado com sucesso");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }

        //}



        public void ExcluirClientes()
        {

        }



    }

}
