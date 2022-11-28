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
            finally
            {
                conexao.desconectar();
            }
        }
      
        public DataTable Select_fornecedores()
        {
            DataTable dt = new  DataTable();
            Conexao conexao1 = new Conexao();
            try
            {
                string sql = "select cnpj as CNPJ,email as Email,telefone as Telefone ,nome_fatasia as Nome_fantasia, inscricao_estadual as Insceição_estadual,razao_social as Razão_social, id as ID from tb_fornecedor" ;
              
                MySqlCommand cmd = new MySqlCommand(sql, conexao1.conectar());
               
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
               
                da.Fill(dt);

            }
            catch (MySqlException erro)
            {

                MessageBox.Show(erro.Message);
            }
            finally
            {
                dt.Dispose();
                
                conexao1.desconectar();
            }
            return dt;
        }
        internal void Atualizar_fornecedor(Fornecedor f)
        {
            try
            {

                Conexao conexao = new Conexao();
                string update = "update tb_fornecedor set cnpj = @c, email = @e, telefone = @t, nome_fatasia =@n, inscricao_estadual = @i, razao_social = @r";
                MySqlCommand cmd = new MySqlCommand(update, conexao.conectar());
                cmd.Parameters.AddWithValue("@c", f.Cnpj);
                cmd.Parameters.AddWithValue("@e", f.Email);
                cmd.Parameters.AddWithValue("@t", f.Telefone);
                cmd.Parameters.AddWithValue("@n", f.Nome_fantasia);
                cmd.Parameters.AddWithValue("@i", f.Inscricao_estadual);
                cmd.Parameters.AddWithValue("@r", f.Razao_social);
                cmd.ExecuteNonQuery();
                    MessageBox.Show("Cadastro Atualizado com sucesso ", "Mensagem de Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException erro)
            {

                MessageBox.Show("erro de banco de dados "+erro);
            }
        }
        internal void Deletar_forncedor(Fornecedor f)
        {
            Conexao conexao = new Conexao();
            try
            {
               
                string delete = "delete from tb_fornecedor where id = @d";
                MySqlCommand cmd = new MySqlCommand(delete, conexao.conectar());
                cmd.Parameters.AddWithValue("@c", f.Cnpj);
                cmd.Parameters.AddWithValue("@e", f.Email);
                cmd.Parameters.AddWithValue("@t", f.Telefone);
                cmd.Parameters.AddWithValue("@n", f.Nome_fantasia);
                cmd.Parameters.AddWithValue("@i", f.Inscricao_estadual);
                cmd.Parameters.AddWithValue("@r", f.Razao_social);
                cmd.Parameters.AddWithValue("@d", f.Id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dados do Fornecedor Deletado  com Sucesso!", "Mensagem de sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("erro de banco de dados " + erro);

            }
            finally
            {
                conexao.desconectar();
            }
        }
        internal void inserir_produto(Produto p)
        {
            Conexao conexao = new Conexao();


            try
            {

                string sql = "insert into tb_produto (descricao, dt_validade, preco, quantidade)values(@d, @dt, @p, @q )";
                MySqlCommand cmd = new MySqlCommand(sql, conexao.conectar());
                cmd.Parameters.AddWithValue("@d", p.Descricao);
                cmd.Parameters.AddWithValue("@dt", p.Data_validade);
                cmd.Parameters.AddWithValue("@p", p.Preco);
                cmd.Parameters.AddWithValue("@q", p.Quantidade);
              
                cmd.ExecuteNonQuery();
                MessageBox.Show("Produto cadastrado com Sucesso!", "Mensagem de sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception erro)
            {

                MessageBox.Show("erro de banco " + erro);
            }
            finally
            {
                conexao.desconectar();
            }
        }
        public DataTable Select_produto()
        {
            DataTable dt = new DataTable();
            Conexao conexao1 = new Conexao();
            try
            {
                string sql = "select codigo as Código, descricao as Descrição, dt_validade as Validade, preco as preço, quantidade as Quanidade from tb_produto ";

                MySqlCommand cmd = new MySqlCommand(sql, conexao1.conectar());

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);

            }
            catch (MySqlException erro)
            {

                MessageBox.Show(erro.Message);
            }
            finally
            {
                dt.Dispose();

                conexao1.desconectar();
            }
            return dt;
        }
        internal void Atualizar_produto(Produto p)
        {
            try
            {

                Conexao conexao = new Conexao();
                string update = "update tb_produto set codigo = @c, descricao = @d,  dt_validade = @dt, preco = @p, quantidade=@q";
                MySqlCommand cmd = new MySqlCommand(update, conexao.conectar());
                cmd.Parameters.AddWithValue("@c", p.Codigo);
                cmd.Parameters.AddWithValue("@d", p.Descricao);
                cmd.Parameters.AddWithValue("@p", p.Preco);
                cmd.Parameters.AddWithValue("@dt", p.Data_validade);
                cmd.Parameters.AddWithValue("@q", p.Quantidade);
                
                cmd.ExecuteNonQuery();
                MessageBox.Show("Produto Atualizado com sucesso ", "Mensagem de Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException erro)
            {

                MessageBox.Show("erro de banco de dados " + erro);
            }
        }
        internal void Deletar_produto(Produto p)
        {
            Conexao conexao = new Conexao();
            try
            {

                string delete = "delete from tb_produto where codigo = @c";
                MySqlCommand cmd = new MySqlCommand(delete, conexao.conectar());
                cmd.Parameters.AddWithValue("@c", p.Codigo);
              
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dados do Produto Deletado  com Sucesso!", "Mensagem de sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("erro de banco de dados " + erro);

            }
            finally
            {
                conexao.desconectar();
            }
        }
        public DataTable Pequisar_forncedor(string pequisarPa)
        {
           Conexao classe_Conexao = new Conexao();
            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT * FROM tb_forncedor where id o LIKE '%" + pequisarPa + "%' or nome_fatasia LIKE '%" + pequisarPa + "%'";

                MySqlCommand cmd = new MySqlCommand(sql, classe_Conexao.conectar());
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                classe_Conexao.desconectar();

            }
            return dt;
        }



    }
}
