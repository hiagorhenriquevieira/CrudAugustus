using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace CrudAugustusFashion.Dao
{
    class ConexaoDao
    {
        SqlConnection con = new SqlConnection();

        public ConexaoDao()
        {
            con.ConnectionString = "Data Source=DESKTOP-IETNHSD;Initial Catalog=BDAUGUSTO;User ID=sa;Password=123";
        }

        public SqlConnection conectar()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.ConnectionString = "Data Source=DESKTOP-IETNHSD;Initial Catalog=BDAUGUSTO;User ID=sa;Password=123";
                con.Open();
            }
            return con;
        }

        public void desconectar()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
