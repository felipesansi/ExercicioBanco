using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
    }
}
