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
        public MySqlConnection cn =new MySqlConnection();


        public MySqlConnection conectar() 
        {
            cn.ConnectionString = "Server =Localhost; User=root;Port =3306; Database =bd_exercicio_banco";
            if (cn.State== System.Data.ConnectionState.Closed)
            {
                cn.Open();
            }
            return cn;
        }
        public MySqlConnection desconectar() 
        {
            if (cn.State==System.Data.ConnectionState.Open)
            {
                cn.Close();

            }
            return cn;
        }

        public int ExecSql(string sql)
        {
            int nlinhas;
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = sql;
                comando.Connection = conectar();
                nlinhas = comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro:" + ex);
                nlinhas = 0;
            }
            return nlinhas;
        }

        public int ExecEscalar(string sql)
        {
            int conta = 0;
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand();
                mySqlCommand.CommandText = sql;
                mySqlCommand.Connection = conectar();
                conta = (int)mySqlCommand.ExecuteScalar();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex);
            }
            return conta;

        }

    }
}
