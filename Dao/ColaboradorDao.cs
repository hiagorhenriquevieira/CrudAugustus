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

            var strSqlUsuario = "insert into Usuarios output inserted.IdUsuario values (@nome, @sobreNome, @sexo, @dataNascimento, @cpf, @email)";
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
    }
}
