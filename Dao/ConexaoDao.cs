using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace CrudAugustusFashion.Dao
{
   public static class ConexaoDao
    {
        

        //public static ConexaoDao()
        //{
        //    var con = new SqlConnection();
        //    con.ConnectionString = "Data Source=DESKTOP-IETNHSD;Initial Catalog=BDAUGUSTO;User ID=sa;Password=123";
        //}

        public static SqlConnection conectar()
        {
            var con = new SqlConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.ConnectionString = "Data Source=DESKTOP-IETNHSD;Initial Catalog=BDAUGUSTO;User ID=sa;Password=123";
                con.Open();
            }
            return con;
        }

        public static void desconectar()
        {
            var con = new SqlConnection();
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
