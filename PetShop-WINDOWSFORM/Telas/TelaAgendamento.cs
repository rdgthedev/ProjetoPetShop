using MySql.Data.MySqlClient;
using PetShop_WINDOWSFORM.Agendamentos;
using PetShop_WINDOWSFORM.ClasseBase;
using PetShop_WINDOWSFORM.Conexao;
using PetShop_WINDOWSFORM.Serviços;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop_WINDOWSFORM.Telas
{
    public partial class TelaAgendamento : Form
    {
        public TelaAgendamento()
        {
            InitializeComponent();
            Servicos listarServicos = new Servicos();
            listarServicos.ListarServicos(cl_Servicos);
            /*if(listarServicos.ListarServicos(cl_Servicos).Count == 4)
            {
                throw new Exception("Você pode marcar no máximo 4 servicos por agendamento!");
            }*/
            dateTimePicker1.MinDate = DateTime.Now;
            dateTimePicker1.MaxDate = DateTime.Today.AddMonths(2);
            cl_Servicos.Enabled = false;
            btn_Confirmar.Enabled = false;
        }

        private void _btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaMenu telaMenu = new TelaMenu();
            telaMenu.Show();
        }

        private void _btn_agendamento_Click_1(object sender, EventArgs e)
        {



        }

        private void _btn_Voltar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            TelaMenu telaMenu = new TelaMenu();
            telaMenu.Show();
        }

        private void _btn_Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        /*private void TelaAgendamento_Load(object sender, EventArgs e)
        {
            comboBoxMeses.DataSource= new List<string>()
            {
                "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"
            };
        }*/

        private void comboBoxDias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxMeses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Agendamento agendamento = new Agendamento();
                //agendamento.Dia = dateTimePicker1.Value;
                agendamento.Hora = _masked_hora.Text;
                if (agendamento.Hora == "  :")
                {
                    MessageBox.Show("Você deve preencher a data para verificar!", "Pet Shop", MessageBoxButtons.OK);
                }
                else
                {
                    agendamento.Selecionar(dateTimePicker1, agendamento.Hora, cl_Servicos, btn_Confirmar);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.InnerException);
            }
        }
        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
             Agendamento agendamento = new Agendamento();
             agendamento.InserirDadosAgendamento(dateTimePicker1, _masked_hora.Text, cl_Servicos);
             MessageBox.Show("Agendamento feito com sucesso!", "Pet Shop");
        }

        private void cl_Servicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cl_Servicos.CheckedItems.Count >= 4)
            {
                MessageBox.Show("Você pode selecionar no máximo 4 serviços!", "Pet Shop", MessageBoxButtons.OK);
            }
        }
    }
}
