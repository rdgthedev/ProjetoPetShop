using MySql.Data.MySqlClient;
using PetShop_WINDOWSFORM.Conexao;
using PetShop_WINDOWSFORM.Serviços;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop_WINDOWSFORM.Interface
{
    public interface IServicos<T>
    {
        public void ListarServicos(T parametro);

    }
}
