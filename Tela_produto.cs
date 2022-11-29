using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioBanco
{
    public partial class Tela_produto : Form
    {
        public Tela_produto()
        {
            InitializeComponent();
        }
        Banco banco = new Banco();
        Produto produto = new Produto();
        DataTable dt;
        
        private void Limpa_campos()
        {
            txb_codigo.Clear();
            txb_descricao.Clear();
            txb_preco.Clear();
            txb_quantidade.Clear();
            txb_pesquisar_produto.Clear();
        }
        private void btn_fechar_produto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_salvar_produtos_Click(object sender, EventArgs e)
        {
            if (txb_codigo.Text== String.Empty|| txb_descricao.Text == String.Empty||  txb_preco.Text == String.Empty ||txb_quantidade.Text == String.Empty )
            {

            }
            produto.Descricao = txb_descricao.Text;
            produto.Data_validade = DateTime.Parse(mask_data_v.Text);
            produto.Preco = double.Parse(txb_preco.Text);
            produto.Quantidade = int.Parse(txb_quantidade.Text);
            banco.inserir_produto(produto);
            dt = banco.Select_produto();
            dataGrid_produto.DataSource = dt;
        }

        private void Tela_produto_Load(object sender, EventArgs e)
        {
            dt = banco.Select_produto();
            dataGrid_produto.DataSource = dt;
        }

        private void dataGrid_produto_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int clicado = e.RowIndex;
            txb_codigo.Text = dataGrid_produto.Rows[clicado].Cells[0].Value.ToString();
            txb_descricao.Text = dataGrid_produto.Rows[clicado].Cells[1].Value.ToString();
            txb_preco.Text = dataGrid_produto.Rows[clicado].Cells[3].Value.ToString();
            txb_quantidade.Text = dataGrid_produto.Rows[clicado].Cells[4].Value.ToString();
            mask_data_v.Text = dataGrid_produto.Rows[clicado].Cells[2].Value.ToString();

        }

        private void btn_atualizar_produto_Click(object sender, EventArgs e)
        {
            if (dataGrid_produto.SelectedRows.Count > 0)
            {
                produto.Codigo = int.Parse(txb_codigo.Text);
                produto.Descricao = txb_descricao.Text;
                produto.Preco = double.Parse(txb_preco.Text);
                produto.Quantidade = int.Parse(txb_quantidade.Text);
                produto.Data_validade = DateTime.Parse(mask_data_v.Text);

              
                if (MessageBox.Show("Deseja reamente deletar este Fornecedor", "Perguta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                else
                {
                  banco.Deletar_produto(produto);
                    dt = banco.Select_produto();
                    dataGrid_produto.DataSource = dt;
                    Limpa_campos();
                   
                }
            }
            else
            {
                MessageBox.Show("Selecione a linha que deseja atualizar", "Mensagem de aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        
        }

        private void btn_deletar_produto_Click(object sender, EventArgs e)
        {

            if (dataGrid_produto.SelectedRows.Count > 0)
            {
                produto.Codigo = int.Parse(txb_codigo.Text);
                produto.Descricao = txb_descricao.Text;
                produto.Preco = double.Parse(txb_preco.Text);
                produto.Quantidade = int.Parse(txb_quantidade.Text);
                produto.Data_validade = DateTime.Parse(mask_data_v.Text);
                banco.Deletar_produto(produto);
                dt = banco.Select_produto();
                dataGrid_produto.DataSource = dt;
                Limpa_campos();


            }
            else
            {
                MessageBox.Show("Selecione a linha que deseja deletar", "Mensagem de aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txb_pesquisar_produto_TextChanged(object sender, EventArgs e)
        {
            string pesquisar_produto = txb_pesquisar_produto.Text;
            
            if (pesquisar_produto!= null)
            {
                dt =banco.Pequisar_produto(pesquisar_produto);
                dataGrid_produto.DataSource = dt;
            }
        }

        private void check_nao_alimenticio_CheckedChanged(object sender, EventArgs e)
        {
            if (check_nao_alimenticio.Checked) 
            { 
                btn_salvar_produtos.Enabled = true;
            }
            else
            {
                btn_salvar_produtos.Enabled = false;
            }
        }

        private void check_alimenticio_CheckedChanged(object sender, EventArgs e)
        {
            if (check_alimenticio.Checked)
            {
                btn_terminar_cadastro.Enabled = true;
            }
            else
            {
                    btn_terminar_cadastro.Enabled= false;   
            }
        }

        private void btn_terminar_cadastro_Click(object sender, EventArgs e)
        {

            Tela_alimenticio tela = new Tela_alimenticio();
            tela.ShowDialog();
            
        }
    }
}
