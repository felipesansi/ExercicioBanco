using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioBanco
{
    internal class Conexao
    { 
        public MySqlConnection conexao_bd = new MySqlConnection();
       

        public void conectar()
        {
            if (conexao_bd.State==System.Data.ConnectionState.Closed)
            {
                conexao_bd.ConnectionString = "server = Localhost; user = root; pwd ;database = bd_exercicio_banco";
            }
        
           
        }
        public void desconectar()
        {
            if (conexao_bd.State == System.Data.ConnectionState.Open)
            {
                conexao_bd.Close();
            }
        }
    }
}
