using MySql.Data.MySqlClient;
using PetShop_WINDOWSFORM.Conexao;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop_WINDOWSFORM.AutenticacaoLogin
{
    public class Autenticador
    {

        public bool AutenticarLogin(string login, string senha)
        {

            var query = $"SELECT COUNT(*) FROM cliente WHERE nome = '{login}' AND senha = '{senha}'";

            var verify = false;

            ConexaoBD conexao = new ConexaoBD();

            //conexao.OpenBD();
            MySqlCommand command = new MySqlCommand(query, conexao.GetConnection());

            /*command.Parameters.AddWithValue("@login", login);
            command.Parameters.AddWithValue("@senha", senha);*/

            string result = Convert.ToString(command.ExecuteScalar());

            conexao.CloseBD();

            if (result == "1")
            {
                verify = true;
            }
            else
            {
                MessageBox.Show("Usuário não cadastrado.", "PetShop");
            }

            return verify;


            /*var verify = false;
            ConexaoBD conn = new ConexaoBD();

            try
            {
                string query = $"SELECT COUNT(*) FROM cliente WHERE nome = '{login}' AND senha = '{senha}'";
                MySqlCommand command = new MySqlCommand(query, conn.ConnectionBD());
                conn.OpenBD();

                string result = Convert.ToString(command.ExecuteScalar());


                if(result == "1")
                {
                    verify= true;
                    MessageBox.Show("Logado com sucesso!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve algum erro no programa!");
                Console.WriteLine(ex.InnerException);
            }
            finally
            {
                conn.CloseBD(); 
            }

            return verify;*/

        }
        
    }
}
