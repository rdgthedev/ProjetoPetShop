using MySql.Data.MySqlClient;
using PetShop_WINDOWSFORM.Conexao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop_WINDOWSFORM.Telas
{
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = "", email = "", senha = "", confirmSenha = "", cpf = "", telefone = "", rua = "", cep = "", num = "", estado = "";

            try
            {
                if (!string.IsNullOrEmpty(_txt_Nome.Text))
                {
                    nome = _txt_Nome.Text;
                }

                if (!string.IsNullOrEmpty(_txt_Email.Text))
                {
                    email = _txt_Email.Text;
                }

                if (!string.IsNullOrEmpty(_txt_Senha.Text))
                {
                    senha = _txt_Senha.Text;
                }

                if (!string.IsNullOrEmpty(_txt_ConfirmSenha.Text))
                {
                    confirmSenha = _txt_Nome.Text;
                }

                if (!string.IsNullOrEmpty(_txt_Cpf.Text))
                {
                    cpf = _txt_Cpf.Text;
                }

                if (!string.IsNullOrEmpty(_txt_Telefone.Text))
                {
                    telefone = _txt_Telefone.Text;
                }

                if (!string.IsNullOrEmpty(_txt_Rua.Text))
                {
                    rua = _txt_Rua.Text;
                }

                if (!string.IsNullOrEmpty(_txt_Cep.Text))
                {
                    cep = _txt_Cep.Text;
                }

                if (!string.IsNullOrEmpty(_txt_Num.Text))
                {
                    num = _txt_Num.Text;
                }

                if (!string.IsNullOrEmpty(_txt_Estado.Text))
                {
                    estado = _txt_Estado.Text;
                }


                string query = $"INSERT INTO cliente(nome, email, senha, cpf, telefone, rua, cep, numero, estado) VALUES ('{nome}', '{email}', '{senha}', '{cpf}', '{telefone}', '{rua}', '{cep}', '{num}', '{estado}')";

                ConexaoBD conexao = new ConexaoBD();
                //conexao.OpenBD();
                MySqlCommand command = new MySqlCommand(query, conexao.GetConnection());


                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Usuário cadastrado com sucesso!");
                }

                conexao.CloseBD();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao cadastrar!");
                Console.WriteLine(ex.InnerException);
            }

        }

        private void _btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaLogin telaLogin = new TelaLogin();
            telaLogin.Show();
        }

        private void TelaCadastro_Load(object sender, EventArgs e)
        {

        }

        private void _btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

