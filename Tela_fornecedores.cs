using MySql.Data.MySqlClient;
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
      
        Fornecedor fornecedor = new Fornecedor();
        bool passou = false;
        DataTable dt;
        Conexao conexao = new Conexao();

        private void Tela_fornecedores_Load(object sender, EventArgs e)
        {
            dt=conexao.selectforncedor();
            dataGrid_fornecdores.DataSource= dt;
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
}
