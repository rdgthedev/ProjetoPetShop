using MySql.Data.MySqlClient;
using PetShop_WINDOWSFORM.ClasseBase;
using PetShop_WINDOWSFORM.Conexao;
using PetShop_WINDOWSFORM.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop_WINDOWSFORM.AutenticacaoLogin
{
    public class Autenticador : IObterID
    {
        public bool AutenticarLogin(string login, string senha)
        {
                var query = $"SELECT COUNT(*) FROM cliente WHERE nome = '{login}' AND senha = '{senha}'";
                var verify = false;
                ConexaoBD conexao = new ConexaoBD();
                conexao.OpenBD();
                MySqlCommand command = new MySqlCommand(query, conexao.GetConnection());
                string result = Convert.ToString(command.ExecuteScalar());
                if (result == "1")
                {
                    verify = true;
                }
                else
                {
                    MessageBox.Show("Usuário não cadastrado.", "PetShop");
                }
                return verify;
        }
        public int ObterID(string primeiro)
        {
            var verify = "Deslogado";
            int id=0;
            var query = $"SELECT id FROM cliente WHERE nome = '{primeiro}'";
            ConexaoBD conexao = new ConexaoBD();
            conexao.OpenBD();
            MySqlCommand comando = new MySqlCommand(query, conexao.GetConnection());
            var result = comando.ExecuteReader();
            while (result.Read())
            {
                id = Convert.ToInt32(result.GetString(0));
            }
            if(id > 0)
            {
                verify = "Logado";
            }
            AdicionarEstadoDoUsuario(verify, id);
            return id;
        }

        public void AdicionarEstadoDoUsuario(string verify, int id)
        {
            var queryDeslogaTodos = "UPDATE cliente SET estado_usuario = 'Deslogado'";

            ConexaoBD conexao = new ConexaoBD();
            conexao.OpenBD();
            MySqlCommand novoComando = new MySqlCommand(queryDeslogaTodos, conexao.GetConnection());
            novoComando.ExecuteNonQuery();

            var newQuery = $"UPDATE cliente SET estado_usuario = '{verify}' WHERE id = '{id}'";
            novoComando.CommandText = newQuery;
            novoComando.ExecuteNonQuery();
            //MessageBox.Show(verify.ToString());
            conexao.CloseBD();
        }
    }
        
}

