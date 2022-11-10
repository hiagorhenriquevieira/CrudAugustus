using System.Data;
using System.Data.SqlClient;
namespace CrudAugustusFashion.Dao
{
    public static class ConexaoDao
    {
        public static SqlConnection conectar()
        {
            var con = new SqlConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.ConnectionString = "Data Source=;Initial Catalog=;User ID=;";
                con.Open();
            }
            return con;
        }
    }
}
