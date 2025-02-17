using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Proyecto_1.BackEnd
{
    public class Conexion
    {
        private MySqlConnection connection;
        private readonly string connectionString;
        public Conexion()
        {
            connectionString = "server=40.90.195.148; user id = nope; password =Centagrui123;database=proyecto1; port=3306;";
            connection = new MySqlConnection(connectionString);
        }
        public void OpenConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void CloseConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                    // connection.Dispose(); si le dejo esto, hay problemas al borrar, jeje
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
