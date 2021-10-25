using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace CrudAugustusFashion.Dao
{
    class ConexaoDao
    {
        SqlConnection con = new SqlConnection();

        public ConexaoDao()
        {
            con.ConnectionString = "Data Source=DESKTOP-NBSNSV6;Initial Catalog=BDAUGUSTO;User ID=sa;Password=123";
        }

        public SqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
