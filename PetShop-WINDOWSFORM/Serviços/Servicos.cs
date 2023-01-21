using MySql.Data.MySqlClient;
using PetShop_WINDOWSFORM.ClasseBase;
using PetShop_WINDOWSFORM.Conexao;
using PetShop_WINDOWSFORM.Interface;
using PetShop_WINDOWSFORM.Telas;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop_WINDOWSFORM.Serviços
{
    public class Servicos : CaracteristicasServico, IServicos<ListView>
    {
        public string Banho { get; set; }
        public string Tosa { get; set; }
        public string TaxiPet { get; set; }
        public string Hospedagem { get; set; }
        public string Delivery { get; set; }
        public string Spa { get; set; }

        public void ListarServicos(ListView lvservicos)
        {
            var query = $"SELECT id, nome, valor FROM servicos";
            ConexaoBD conexao = new ConexaoBD();
            conexao.OpenBD();
            MySqlCommand comando = new MySqlCommand(query, conexao.GetConnection());
            var reader = comando.ExecuteReader();
            List<Servicos> listServicos = new List<Servicos>();
            while (reader.Read())
            {
                listServicos.Add(new Servicos()
                {
                    Id = reader["id"].ToString(),
                    Nome = reader["nome"].ToString(),
                    Preco = reader["valor"].ToString()
                });
            }
            foreach (var item in listServicos)
            {
                ListViewItem l = new ListViewItem(item.Id);
                for (int i = 1; i < listServicos.Count; i++)
                {
                    l.SubItems.Add(item.Nome);
                    l.SubItems.Add("R$       " + item.Preco);
                }
                lvservicos.Items.Add(l);
            }
            conexao.CloseBD();
        }

        public void ListarServicos(CheckedListBox parametro)
        {
            var query = $"SELECT id, nome, valor FROM servicos";
            ConexaoBD conexao = new ConexaoBD();
            conexao.OpenBD();
            MySqlCommand comando = new MySqlCommand(query, conexao.GetConnection());
            var reader = comando.ExecuteReader();
            List<string> list = new List<string>();
            while (reader.Read())
            {
                //list.Add(Nome = reader["nome"].ToString());
                parametro.Items.Add(reader["nome"].ToString());
            }
            //parametro.Items.Add(list);
            conexao.CloseBD();
        }

        public List<string> ServicosEscolhidos(CheckedListBox parametro)
        {
            List<string> servicos = new List<string>();
            foreach(string item in parametro.CheckedItems)
            {
                servicos.Add(item.ToString());
            }
            return servicos;
        }
    }
    }

