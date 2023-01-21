using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using PetShop_WINDOWSFORM.Agendamentos;
using PetShop_WINDOWSFORM.Conexao;


namespace PetShop_WINDOWSFORM.ClasseBase
{
    public abstract class UsuarioLogin
    {
        public int Id { get; set; } = 0;
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Cep{ get; set; }
        public string Estado { get; set; }
        public string Senha { get; set; }


        //Obtém o ID do cliente e salva em uma variável.
        public virtual int ObterId(string login)
        {
            string verify = "Deslogado";
            var query = $"SELECT id FROM cliente WHERE nome = '{login}'";

            ConexaoBD conexao = new ConexaoBD();
            Agendamento usuario = new Agendamento();

            conexao.OpenBD();
            MySqlCommand comando = new MySqlCommand(query, conexao.GetConnection());

            var result = comando.ExecuteReader();

            var id = 0;
            if (result.Read())
            {
                id = usuario.Id = int.Parse(result["id"].ToString());
            }
            conexao.CloseBD();

            if (id != 0)
            {
                verify = "Logado";
            }
            AdicionarEstadoDoUsuario(verify, id);
            return id;
        }

        //public abstract int ObterId();

        public int GetID(int id)
        {
            return id;
        }

        //Adiciona a coluna "ESTADO CLIENTE" a situação em que o cliente se encontra "LOGADO/DESLOGADO."
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