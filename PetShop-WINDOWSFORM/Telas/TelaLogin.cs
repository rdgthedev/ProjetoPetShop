using PetShop_WINDOWSFORM.AutenticacaoLogin;
using PetShop_WINDOWSFORM.Telas;

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
            var login = _txt_Login.Text;
            var senha = _txt_Senha.Text;


                Autenticador autenticador = new Autenticador();

            if(autenticador.AutenticarLogin(login, senha) == true)
            {
                MessageBox.Show("Sucesso!");
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
            this.Close();
        }

        private void _label_Titutlo_Click(object sender, EventArgs e)
        {

        }
    }
}