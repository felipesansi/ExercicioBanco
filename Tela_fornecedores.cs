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
      Banco Banco = new Banco();
        DataTable dt;
        Conexao conexao = new Conexao();
       
        private void Tela_fornecedores_Load(object sender, EventArgs e)
        {

            dt = Banco.Select_fornecedores();
            dataGrid_fornecdores.DataSource = dt;
        }

        private void btn_fechar_fornecedores_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       


        private void btn_salvar_fornecedores_Click(object sender, EventArgs e)
        {Banco banco = new Banco();
            if (txb_cnpj.Text == String.Empty || txb_email.Text == String.Empty || txb_razaoS.Text == String.Empty | mask_telefone.Text == String.Empty || txb_inscricao.Text == String.Empty || txb_fantasia.Text == String.Empty)
            {
                MessageBox.Show("Preencha todos os Campos por favor...", "Mensagem de aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                fornecedor.Cnpj = int.Parse(txb_cnpj.Text);
                fornecedor.Email = txb_email.Text;
                fornecedor.Telefone = mask_telefone.Text;
                fornecedor.Nome_fantasia = txb_fantasia.Text;
                fornecedor.Razao_social = txb_razaoS.Text;
                fornecedor.Inscricao_estadual = txb_inscricao.Text;
                banco .inserir(fornecedor);
                dt = Banco.Select_fornecedores();
                dataGrid_fornecdores.DataSource = dt;
            }
        }

        private void dataGrid_fornecdores_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int clicado = e.RowIndex;
          
            txb_cnpj.Text = dataGrid_fornecdores.Rows[clicado].Cells[0].Value.ToString();
          
            txb_email.Text = dataGrid_fornecdores.Rows[clicado].Cells[1].Value.ToString();
           
            mask_telefone.Text = dataGrid_fornecdores.Rows[clicado].Cells[2].Value.ToString();
            
            txb_fantasia.Text = dataGrid_fornecdores.Rows[clicado].Cells[3].Value.ToString();
           
            txb_inscricao.Text = dataGrid_fornecdores.Rows[clicado].Cells[4].Value.ToString();
           
            txb_razaoS.Text = dataGrid_fornecdores.Rows[clicado].Cells[5].Value.ToString();
           
            txb_id.Text = dataGrid_fornecdores.Rows[clicado].Cells[6].Value.ToString();

        }

        private void btn_atualizar_fornecedor_Click(object sender, EventArgs e)
        {
            if (dataGrid_fornecdores.SelectedRows.Count>0)
            {
                fornecedor.Cnpj = int.Parse(txb_cnpj.Text);
                fornecedor.Email = txb_email.Text;
                fornecedor.Telefone = mask_telefone.Text;
                fornecedor.Nome_fantasia = txb_inscricao.Text;
                fornecedor.Razao_social = txb_razaoS.Text;
                Banco.Atualizar_fornecedor(fornecedor);
                dt = Banco.Select_fornecedores();
                dataGrid_fornecdores.DataSource = dt;
            }
        }

        private void btn_deletar_fornecedor_Click(object sender, EventArgs e)
        {
            if (dataGrid_fornecdores.SelectedRows.Count>0)
            {
                fornecedor.Id = int.Parse(txb_id.Text);
                if (MessageBox.Show("Deseja reamente deletar este Fornecedor", "Perguta",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    Banco.Deletar_forncedor(fornecedor);
                  dt =  Banco.Select_fornecedores();
                    dataGrid_fornecdores.DataSource = dt;
                }
            }
        }
    }
}

