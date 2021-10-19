using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using CrudAugustusFashion.Model;
namespace CrudAugustusFashion.Dao
{
    class UsuarioDao
    {
        ConexaoDao conexao = new ConexaoDao();
        SqlCommand comand = new SqlCommand();

        public void CadastrarUsuario(UsuarioDao usuario)
        {
            comand.CommandText = "insert into Usuarios (nome, senha, email) values (@nome, @senha, @email)";

            //comand.Parameters.AddWithValue("@nome", usuario.Nome);
            //comand.Parameters.AddWithValue("@senha", usuario.Senha);
            //comand.Parameters.AddWithValue("@email", usuario.Email);


            try
            {
                comand.Connection = conexao.conectar();
                comand.ExecuteNonQuery();
                conexao.desconectar();

                MessageBox.Show("Deu");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
