using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using PetShop_WINDOWSFORM.ClasseBase;
using PetShop_WINDOWSFORM.Conexao;
using PetShop_WINDOWSFORM.Interface;
using PetShop_WINDOWSFORM.Serviços;
using PetShop_WINDOWSFORM.Telas;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PetShop_WINDOWSFORM.Agendamentos
{
    public class Agendamento : UsuarioLogin
    {
        public string Pet { get; set; }
        public string Dia { get; set; }
        //private string hora;

        public string Hora { get; set; }
        public Servicos Servicos { get; set; }
        string DiaFormatado { get; set; }



        public void ObterDados()
        {
            var query = $"SELECT id, nome, cpf, email, telefone, rua, numero, cep FROM cliente WHERE estado_usuario = 'logado'";
            ConexaoBD conexao = new ConexaoBD();
            conexao.OpenBD();
            MySqlCommand comando = new MySqlCommand(query, conexao.GetConnection());
            var result = comando.ExecuteReader();
            if (result.Read())
            {
                Id = int.Parse(result["id"].ToString());
                Nome = result.GetString(1);
                Cpf = result.GetString(2);
                Email = result.GetString(3);
                Telefone = result.GetString(4);
                Rua = result.GetString(5);
                Numero = result.GetInt32(6);
                Cep = result.GetString(7);
            }
            conexao.CloseBD();
        }
        public int Verificar(DateTimePicker date)
        {
            var finaisDeSemana = 0;
            if (date.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                MessageBox.Show("Não fazemos agendamentos aos Domingos!");
                finaisDeSemana++;
            }
            return finaisDeSemana;
        }

        public DialogResult Selecionar(DateTimePicker diaa, string horaa, CheckedListBox l, Button b)
        {
            DateTime recebeDia;
            string horaFormatada;
            DialogResult dialog = DialogResult.No;
            var finaisDeSemana = Verificar(diaa);
            recebeDia = DateTime.Parse(diaa.Value.ToString());
            DiaFormatado = recebeDia.ToString("yyyy-MM-dd");
            if(finaisDeSemana == 0)
            {
                horaFormatada = String.Format("{0:HH:mm:ss}", horaa);
                var query = $"SELECT DATE_FORMAT(dia, '%d-%m-%Y') FROM agendamento " +
                $"WHERE dia = '{DiaFormatado}' AND hora = '{horaFormatada}'";
                ConexaoBD conexao = new ConexaoBD();
                conexao.OpenBD();
                MySqlCommand comando = new MySqlCommand(query, conexao.GetConnection());
                var result = comando.ExecuteReader();
                Hora = horaFormatada;
                Dia = DiaFormatado;
                var inserir = 0;

                if (result.Read())
                {
                    MessageBox.Show("Essa data já existe!", "Pet Shop", MessageBoxButtons.OK);
                    inserir++;
                }
                if(inserir == 0)
                {
                    dialog = MessageBox.Show("Esta data está disponível, deseja agendar?",
                    "Pet Shop", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }
                if(dialog == DialogResult.Yes)
                {
                    l.Enabled = true;
                    b.Enabled = true;
                }
                conexao.CloseBD();
            }
            return dialog;
        }

        public void InserirDadosAgendamento(DateTimePicker dia, string hora, CheckedListBox clBox)
        {
            ObterDados();
            Servicos checkServicos = new Servicos();
            var servicos = checkServicos.ServicosEscolhidos(clBox);
            StringBuilder stringBuilder = new StringBuilder();
            //string selectedItems = string.Concat(servicos);
            foreach (var item in servicos)
            {
                stringBuilder.Append(item + ", ");
            }
            var diaRecibido = DateTime.Parse(dia.Value.ToString());
            string diaFormatado = diaRecibido.ToString("yyyy-MM-dd");
            var query = $"INSERT INTO agendamento (usuario_id, nome, telefone, rua, numero, cep, dia, hora, servicos) " +
            $"VALUES ('{Id}', '{Nome}', '{Telefone}', '{Rua}', '{Numero}','{Cep}', '{diaFormatado}', '{hora}', '{stringBuilder}')";
            ConexaoBD conexao = new ConexaoBD();
            conexao.OpenBD();
            MySqlCommand comando = new MySqlCommand(query, conexao.GetConnection());
            comando.ExecuteNonQuery();
            conexao.CloseBD();
        }
    }
}



