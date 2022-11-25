using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioBanco
{
    public class Conexao
    {
        MySqlConnection cn = new MySqlConnection();
        internal bool passa;
        public MySqlConnection conectar()
        {
            cn.ConnectionString = "server = Localhost; database = bd_exercicio_banco; port =3306; user = root";
            if (cn.State==System.Data.ConnectionState.Closed)
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

        public bool inseir(Fornecedor f)
        {
            string sql = "insert into tb_fornecedor values(@cnpj,@razaos, @email, @telefone, @nomef, @inscricao)";
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                cmd.Connection = conectar();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@cnpj", f.Cnpj);
                cmd.Parameters.AddWithValue("@email", f.Email);
                cmd.Parameters.AddWithValue("@telefone", f.Telefone);
                cmd.Parameters.AddWithValue("@nomef", f.Nome_fantasia);
                cmd.Parameters.AddWithValue("@inscricao", f.Inscricao_estadual);
                cmd.Parameters.AddWithValue("@razaos", f.Razao_social);
                cmd.ExecuteNonQuery();
                passa = true;
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("problemas com mysql"+erro);

            }
            return passa;


        }
        DataTable dt  = new DataTable();
        internal DataTable selectforncedor()
        {
            try
            {
                string sql = "select cnpj as CNPJ from b_fornecedor  ";

                 MySqlCommand cmd = new MySqlCommand(sql,conectar());

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);



                adapter.Fill(dt);

            }
            catch (MySqlException erro)
            {

                MessageBox.Show("erro de banco de dados"+erro);
            }
            return dt;
        }
    }
}
