using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop_WINDOWSFORM.Conexao
{
    public class ConexaoBD
    {
        MySqlConnection conn;
        string connection = "server = localhost; database = teste; user = root; password = Ro15704123456; port = 3306";

        public ConexaoBD()
        {
            conn = new MySqlConnection(connection);
        }
        public void OpenBD()
        {
            conn.Open();
        }
        public void CloseBD()
        {
            conn.Close();
        }
        public MySqlConnection GetConnection() 
        {   
            return conn;
        }   
    }


}
