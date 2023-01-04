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

        /*public MySqlConnection OpenBD()
        {
            string connection = "server = localhost; uid = root; password= Ro15704123456; port = 3306; database = teste";

            MySqlConnection conexao = new MySqlConnection(connection);

            conexao.Open();

            return conexao;

        }

        public void CloseBD(MySqlConnection conexao)
        {
            conexao.Close();
        }*/

        /*public MySqlConnection ConnectionBD()
        {

        }*/

        MySqlConnection conn = null;
        string connection = "server = localhost; database = teste; user = root; password = Ro15704123456; port = 3306";

        public ConexaoBD()
        {
            conn = new MySqlConnection(connection);
            conn.Open();
        }
        

         
        

        /*public void OpenBD()
        {
            

            conn.Open();

            return conn;
        }*/

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
