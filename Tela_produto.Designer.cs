namespace ExercicioBanco
{
    partial class Tela_produto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_fechar_produto = new System.Windows.Forms.Button();
            this.btn_salvar_produtos = new System.Windows.Forms.Button();
            this.txb_quantidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_descricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_codigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txb_preco = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_fechar_produto
            // 
            this.btn_fechar_produto.BackColor = System.Drawing.SystemColors.Control;
            this.btn_fechar_produto.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn_fechar_produto.FlatAppearance.BorderSize = 2;
            this.btn_fechar_produto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_fechar_produto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fechar_produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fechar_produto.ForeColor = System.Drawing.Color.Red;
            this.btn_fechar_produto.Location = new System.Drawing.Point(839, 1);
            this.btn_fechar_produto.Name = "btn_fechar_produto";
            this.btn_fechar_produto.Size = new System.Drawing.Size(54, 43);
            this.btn_fechar_produto.TabIndex = 15;
            this.btn_fechar_produto.Text = "x";
            this.btn_fechar_produto.UseVisualStyleBackColor = false;
            this.btn_fechar_produto.Click += new System.EventHandler(this.btn_fechar_produto_Click);
            // 
            // btn_salvar_produtos
            // 
            this.btn_salvar_produtos.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_salvar_produtos.FlatAppearance.BorderSize = 0;
            this.btn_salvar_produtos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar_produtos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar_produtos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_salvar_produtos.Location = new System.Drawing.Point(356, 278);
            this.btn_salvar_produtos.Name = "btn_salvar_produtos";
            this.btn_salvar_produtos.Size = new System.Drawing.Size(199, 43);
            this.btn_salvar_produtos.TabIndex = 26;
            this.btn_salvar_produtos.Text = "Salvar dados";
            this.btn_salvar_produtos.UseVisualStyleBackColor = false;
            // 
            // txb_quantidade
            // 
            this.txb_quantidade.Location = new System.Drawing.Point(356, 118);
            this.txb_quantidade.Name = "txb_quantidade";
            this.txb_quantidade.Size = new System.Drawing.Size(151, 20);
            this.txb_quantidade.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(260, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "Quantidade:";
            // 
            // txb_descricao
            // 
            this.txb_descricao.Location = new System.Drawing.Point(661, 97);
            this.txb_descricao.Multiline = true;
            this.txb_descricao.Name = "txb_descricao";
            this.txb_descricao.Size = new System.Drawing.Size(232, 41);
            this.txb_descricao.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(550, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Descrição:";
            // 
            // txb_codigo
            // 
            this.txb_codigo.Location = new System.Drawing.Point(91, 118);
            this.txb_codigo.Name = "txb_codigo";
            this.txb_codigo.Size = new System.Drawing.Size(151, 20);
            this.txb_codigo.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(426, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Produtos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "Código:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 18);
            this.label7.TabIndex = 28;
            this.label7.Text = "Preço:";
            // 
            // txb_preco
            // 
            this.txb_preco.Location = new System.Drawing.Point(91, 210);
            this.txb_preco.Name = "txb_preco";
            this.txb_preco.Size = new System.Drawing.Size(151, 20);
            this.txb_preco.TabIndex = 29;
            // 
            // Tela_produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 372);
            this.Controls.Add(this.txb_preco);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_salvar_produtos);
            this.Controls.Add(this.txb_quantidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txb_descricao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txb_codigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_fechar_produto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tela_produto";
            this.Text = "Tela_produto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_fechar_produto;
        private System.Windows.Forms.Button btn_salvar_produtos;
        private System.Windows.Forms.TextBox txb_quantidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_descricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_codigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txb_preco;
    }
}