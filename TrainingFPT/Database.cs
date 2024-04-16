using Microsoft.Data.SqlClient;

namespace TrainingFPT
{
    public class Database
    {
        public static string GetStringConnection()
        {
            string strConnection = @"Data Source=NGUYENTHAISON\SQLEXPRESS;Initial Catalog=TrainingPhat;Integrated Security=True;Trust Server Certificate=True";
            return strConnection;
        }

        public static SqlConnection GetSqlConnection()
        {
            string strConnection = GetStringConnection();
            SqlConnection connection = new SqlConnection(strConnection);
            return connection;
        }
    }
}
