using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AgendaContatos
{
    class Conexao
    {
        public MySqlConnection con = new MySqlConnection(@"Server=localhost;Port=3307;Database=agenda;User=root;Pwd=root");

        public string conectar()
        {
            try
            {
                con.Open();
                return ("Conexão realizada com sucesso.");
            }
            catch(MySqlException e)
            {
                return (e.ToString());
            }
        }
    }
}
