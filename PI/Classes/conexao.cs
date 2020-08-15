using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PI
{
    public class conexao
    {
        
        MySqlConnection conex = new MySqlConnection();
        //Construtor 
        public conexao()
        {
            conex.ConnectionString = "server = localhost; database = bd_VestATM; user id = root; Password =";

        }

        //Metodo conectar
        public MySqlConnection conectar()
        {
            if (conex.State == System.Data.ConnectionState.Closed) 
            {
                conex.Open();
            }
            return conex;
        }

        //Metodo Desconectar
        public void desconectar()
        {
            if (conex.State == System.Data.ConnectionState.Open) 
            {
                conex.Close();
            }

        }
        
    }
}
