using Npgsql;
using System.Data;
using System.Windows.Forms;

namespace Apex_
{
    class DataBase
    {
        public static NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; User Id=postgres; Password=postgres; Database=apex;");

        public static DataSet ds = new DataSet();
        public static void dsTable_Fill(string name, string sql)
        {
            connection.Open();
            if (ds.Tables[name] != null) ds.Tables[name].Clear();
            NpgsqlDataAdapter dat;
            dat = new NpgsqlDataAdapter(sql, connection);
            dat.Fill(ds, name);
            connection.Close();
        }

        public static bool SqlRequest(string sql)
        {
            NpgsqlCommand com;
            com = new NpgsqlCommand(sql, connection);
            connection.Open();
            try
            {
                com.ExecuteNonQuery();
            }
            catch (NpgsqlException)
            {
                MessageBox.Show("Обновление базы данных не было выполнено из-за не указания обновляемых данных" +
                    " или не соответствия их типов", "Ошибка!");
                connection.Close(); return false;
            }
            connection.Close();
            return true;
        }
    }
}
