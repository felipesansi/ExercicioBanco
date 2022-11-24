using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioBanco
{
    public partial class Tela_fornecedores : Form
    {
        public Tela_fornecedores()
        {
            InitializeComponent();
        }
        bool autencado =false;
        Conexao conexao = new Conexao();

        public bool inseir(Fornecedor f)
        {
            try
            {

                string sql = "insert to tb_fornecedores  values (@cnpj,@email,@telefone, @nomef, @inscricao)";
                SqlCommand comando = new SqlCommand();
                comando.CommandText = sql;
                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@cnpj", f.Cnpj);
                comando.Parameters.AddWithValue("@email", f.Email);
                comando.Parameters.AddWithValue("@telefone", f.Telefone);
                comando.Parameters.AddWithValue("@nomef", f.Nome_fantasia);
                comando.Parameters.AddWithValue("@inscricao", f.Inscricao_estadual);
             
                 comando.ExecuteNonQuery();

              
            }
            catch (Exception)
            {

                throw;
            }


            return autencado;
                
        }
        private void Tela_fornecedores_Load(object sender, EventArgs e)
        {

        }

        private void btn_fechar_fornecedores_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_salvar_fornecedores_Click(object sender, EventArgs e)
        {
          
        }
    }
}
