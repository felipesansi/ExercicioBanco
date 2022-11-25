using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioBanco
{
    public partial class Tela_principal : Form
    {
        public Tela_principal()
        {
            InitializeComponent();
        }
        Form janela_filha = new Form();


        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir_janela(new Tela_fornecedores());
        }
        public void Abrir_janela(Form fh)
        {
            janela_filha = fh;
            fh.TopLevel=false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            Painel_principal.Controls.Add(fh);
            Painel_principal.Tag =  janela_filha;
            janela_filha.BringToFront();
            janela_filha.Show();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir_janela(new Tela_produto());
        }

        private void alimenticioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir_janela(new Tela_alimenticio());
        }

        private void Tela_principal_Load(object sender, EventArgs e)
        {
        }
    }
}
