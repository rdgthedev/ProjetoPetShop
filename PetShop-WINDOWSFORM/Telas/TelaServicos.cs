using PetShop_WINDOWSFORM.Serviços;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop_WINDOWSFORM.Telas
{
    
    public partial class TelaServicos : Form
    {
        public TelaServicos()
        {
            InitializeComponent();
            Servicos servicos = new Servicos();
            servicos.ListarServicos(this._lv_servicos);
        }

        private void _label_Servicos_Click(object sender, EventArgs e)
        {

        }

        private void _btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaMenu telaMenu = new TelaMenu();

            telaMenu.Show();
        }
    }
}
