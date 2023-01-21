using PetShop_WINDOWSFORM.ClasseBase;
using PetShop_WINDOWSFORM.Serviços;
using PetShop_WINDOWSFORM.Telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop_WINDOWSFORM
{
    public partial class TelaMenu : Form
    {
        public TelaMenu()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //this.Close();
            TelaAgendamento telaAgendamento = new TelaAgendamento();
            telaAgendamento.TopLevel = false;
            telaAgendamento.Dock = DockStyle.Fill;
            pn_central.Controls.Clear();
            pn_central.Controls.Add(telaAgendamento);
            telaAgendamento.Show();
        }

        private void _btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaLogin telaLogin= new TelaLogin();
            telaLogin.Show();
        }

        private void _btn_fecharMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void _btn_servicos_Click(object sender, EventArgs e)
        {
            TelaServicos telaServico = new TelaServicos();
            telaServico.TopLevel = false;
            telaServico.Dock = DockStyle.Fill;
            pn_central.Controls.Clear();
            pn_central.Controls.Add(telaServico);
            telaServico.Show();
        }
    }
}
