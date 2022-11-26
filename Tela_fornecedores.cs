﻿using MySql.Data.MySqlClient;
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
            try
            {

                string sql = "SELECT (cnpj AS CNPJ,email AS EMAIL,telefone AS TELEFONE,nome_fatasia AS NOME_FANTASIA, inscricao_estadual AS INSCRIÇÃO_ESTADUAL,razao_social AS RAZÃO SOCIAL ";
                MySqlCommand CMD = new MySqlCommand(sql, conexao.conectar());
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_fechar_fornecedores_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       


        private void btn_salvar_fornecedores_Click(object sender, EventArgs e)
        {Banco banco = new Banco();
            if (txb_cnpj.Text == String.Empty || txb_email.Text == String.Empty || txb_razaoS.Text == String.Empty | mask_telefone.Text == String.Empty || txb_inscricao.Text == String.Empty || txb_fantasia.Text == String.Empty)
            {
                MessageBox.Show("Preencha todos os Campos por favor...", "Mensagem de aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                fornecedor.Cnpj = int.Parse(txb_cnpj.Text);
                fornecedor.Email = txb_email.Text;
                fornecedor.Telefone = mask_telefone.Text;
                fornecedor.Nome_fantasia = txb_fantasia.Text;
                fornecedor.Razao_social = txb_inscricao.Text;
                fornecedor.Inscricao_estadual = txb_inscricao.Text;
                banco .inserir(fornecedor);
            }
        }
    }
}

