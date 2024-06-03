using Microsoft.Data.SqlClient;
using Models;

namespace Repositories
{
    public class InsureceRepository
    {
        string strConn = "Data Source=127.0.0.1; Initial Catalog=projAula2; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=Yes;";
        SqlConnection conn;

        public InsureceRepository()
        {
            conn = new SqlConnection(strConn);
            conn.Open();
        }
        public int Insert(Insurance insurece)
        {
            int result = 0;

            try
            {

                SqlCommand cmd = new SqlCommand(Insurance.INSERT, conn);
                cmd.Parameters.Add(new SqlParameter("@Description", insurece.description));
                result = (int) cmd.ExecuteScalar();

             }
            catch (Exception ex)
            {
                return result = 0;

            }
            finally { conn.Close(); }

            return result;
        }
    }
}
