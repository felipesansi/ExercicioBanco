using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioBanco
{
    internal class Conexao
    { 
        public MySqlConnection conexao_bd = new MySqlConnection();

        string mensagem;
        public MySqlConnection classe_conxao()
        {
            conexao_bd.ConnectionString = "server = Localhost; user = root; pwd ;database = bd_exercicio_banco";
            return conexao_bd;
        }
        public MySqlConnection conectar()
        {
            if (conexao_bd.State==System.Data.ConnectionState.Closed)
            {
               conexao_bd.Open();
            }
           return conexao_bd;
           
        }
        public MySqlConnection desconectar()
        {
            if (conexao_bd.State == System.Data.ConnectionState.Open)
            {
                conexao_bd.Close();
            }
            return conexao_bd;
        }
        //public string executeSql(string sql)
        //{
        //    try
        //    {
        //        MySqlCommand comando = new MySqlCommand();
        //        comando.Connection = conectar();
        //        comando.CommandText = sql;
        //        comando.ExecuteNonQuery();
                
        //    }
        //    catch (SqlException erro )
        //    {
        //        this.mensagem = "Prblema com sql " +erro;

        //    }
        //    return mensagem;
        //}
    }
}
