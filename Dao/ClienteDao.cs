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
    public class ClienteDao
    {
        ConexaoDao conexao = new ConexaoDao();
        public void CadastrarCliente(ClienteModel cliente, EnderecoModel endereco, TelefoneModel telefone)
        {
            var strSqlUsuario = "insert into Usuarios output inserted.IdUsuario values (@nome, @sobreNome, @sexo, @dataNascimento, @cpf, @email)";
            var strSqlCliente = "insert into Clientes (IdUsuario, ValorLimite, Observacao) values (@IdUsuario, @limiteCompra, @observacao)";
            var strSqlEndereco = "insert into Endereco (IdUsuario, Cep, Cidade, Logradouro, Uf, Complemento, Bairro, NumeroResidencia) " +
               "values (@IdUsuario, @cep, @cidade, @logradouro, @uf, @complemento, @bairro, @numeroResidencia)";
            var strSqlTelefone = "insert into Telefone (IdUsuario, Telefone, DddTelefone, DddCelular, Celular) values (@IdUsuario, @telefone, @dddTelefone, @dddCelular, @celular)";

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

                    con.Execute(strSqlEndereco, endereco , transacao);

                    con.Execute(strSqlTelefone, telefone, transacao);

                    transacao.Commit();
                }

                MessageBox.Show(cliente.IdUsuario.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
