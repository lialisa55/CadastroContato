using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AgendaContatos
{
    class Controle
    {
        Conexao c = new Conexao();
        public string Cadastrar(Contato cont)
        {
            try
            {
                string sql  = "INSERT INTO tbcontato (nome, telefone, celular, email) " + 
                    "VALUES ('" + cont.Nome + "', '" + cont.Telefone + 
                    "', '" + cont.Celular + "', '" + cont.Email + "')";

                MySqlCommand cmd = new MySqlCommand(sql, c.con);

                c.conectar();
                cmd.ExecuteNonQuery();
                c.desconectar();
                return ("Cadastro realizado com sucesso.");
            }
            catch (MySqlException e)
            {
                return (e.ToString());
            }

            
        }
        public string Alterar(Contato cont)
        {
            try
            {
                string sql = "UPDATE tbcontato set nome = '" + cont.Nome + "', telefone = '" + cont.Telefone + "', celular = '" + cont.Celular + "', email = '" + cont.Email + "' where codContato = " + cont.CodContato;

                MySqlCommand cmd = new MySqlCommand(sql, c.con);

                c.conectar();
                cmd.ExecuteNonQuery();
                c.desconectar();
                return ("Alteração realizada com sucesso.");
            }
            catch (MySqlException e)
            {
                return (e.ToString());
            }
            
        }
        public string Deletar (Contato cont)
        {
            try
            {
                string sql = "DELETE FROM tbcontato where codcontato = " + cont.CodContato + ";";

                MySqlCommand cmd = new MySqlCommand(sql, c.con);

                c.conectar();
                cmd.ExecuteNonQuery();
                c.desconectar();
                return ("Contato excluído com sucesso");
            }
            catch (MySqlException e)
            {
                return (e.ToString());
            }


        }
        
        public Contato buscar (int codigo)
        {
            Contato contato = new Contato();

            try
            {
                string sql = "select * from tbcontato where codcontato =" + codigo + ";";

                MySqlCommand cmd = new MySqlCommand(sql, c.con);

                c.conectar();

                MySqlDataReader Dados = cmd.ExecuteReader();

                if (Dados.HasRows)
                {
                    Dados.Read();

                    contato.CodContato = Convert.ToInt32(Dados["codcontato"]);
                    contato.Nome = Dados["nome"].ToString();
                    contato.Telefone = Dados["telefone"].ToString();
                    contato.Celular = Dados["celular"].ToString();
                    contato.Email = Dados["email"].ToString();

                    Dados.Close();

                    return contato;
                }
                else
                {
                    return null;
                }
            }
            catch (MySqlException e)
            {
                throw (e);
            }
            finally
            {
                c.desconectar();
            }
        }

    }
}
