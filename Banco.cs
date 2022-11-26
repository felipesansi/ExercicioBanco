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
    public class Banco
    {
        internal void inserir(Fornecedor f)
        {
            Conexao conexao = new Conexao();
            DataTable dt;

            try
            {

                string sql = "insert into tb_fornecedor (cnpj,email,telefone,nome_fatasia, inscricao_estadual,razao_social)values(@c, @e, @t, @n, @i, @r)";
                MySqlCommand cmd = new MySqlCommand(sql, conexao.conectar());
                cmd.Parameters.AddWithValue("@c", f.Cnpj);
                cmd.Parameters.AddWithValue("@e", f.Email);
                cmd.Parameters.AddWithValue("@t", f.Telefone);
                cmd.Parameters.AddWithValue("@n", f.Nome_fantasia);
                cmd.Parameters.AddWithValue("@i", f.Inscricao_estadual);
                cmd.Parameters.AddWithValue("@r", f.Razao_social);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Fornecedor cadastrado com Sucesso!", "Mensagem de sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception erro)
            {

                MessageBox.Show("erro de banco " + erro);
            }

        }
      
        public DataTable Select_fornecedores()
        {
            DataTable dt = new  DataTable();
            Conexao conexao1 = new Conexao();
            try
            {
                string sql = "select cnpj as CNPJ,email as Email,telefone as Telefone ,nome_fatasia as Nome_fantasia, inscricao_estadual as Insceição_estadual,razao_social as Razão_social from tb_fornecedor" ;
                MySqlCommand cmd = new MySqlCommand(sql, conexao1.conectar());
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
               
                da.Fill(dt);

            }
            catch (MySqlException erro)
            {

                MessageBox.Show(erro.Message);
            }
            return dt;
        }
    }
}
