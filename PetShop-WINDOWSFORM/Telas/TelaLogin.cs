using MySql.Data.MySqlClient;
using PetShop_WINDOWSFORM.Agendamentos;
using PetShop_WINDOWSFORM.AutenticacaoLogin;
using PetShop_WINDOWSFORM.ClasseBase;
using PetShop_WINDOWSFORM.Conexao;
using PetShop_WINDOWSFORM.Telas;
using System.Security.Cryptography.X509Certificates;

namespace PetShop_WINDOWSFORM
{
    public partial class TelaLogin : Form
    {
        
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string login = _txt_Login.Text;
            string senha = _txt_Senha.Text;

            Autenticador autenticador = new Autenticador();

                if (autenticador.AutenticarLogin(login, senha) == true)
                {
                    Agendamento obtendoID = new Agendamento();
                    obtendoID.ObterId(login);
                    TelaMenu telaMenu = new TelaMenu();
                    this.Hide();
                    telaMenu.Show();
                    MessageBox.Show("Bem vindo!", "Pet Shop");
                }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaCadastro telaCadastro = new TelaCadastro();
            telaCadastro.Show();
        }

        private void _btn_Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void _label_Titutlo_Click(object sender, EventArgs e)
        {

        }
    }
}