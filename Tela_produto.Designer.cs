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
            this.btn_deletar_produto = new System.Windows.Forms.Button();
            this.btn_atualizar_produto = new System.Windows.Forms.Button();
            this.txb_pesquisar_produto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGrid_produto = new System.Windows.Forms.DataGridView();
            this.mask_data_v = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.check_nao_alimenticio = new System.Windows.Forms.CheckBox();
            this.check_alimenticio = new System.Windows.Forms.CheckBox();
            this.btn_terminar_cadastro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_produto)).BeginInit();
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
            this.btn_salvar_produtos.Enabled = false;
            this.btn_salvar_produtos.FlatAppearance.BorderSize = 0;
            this.btn_salvar_produtos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar_produtos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar_produtos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_salvar_produtos.Location = new System.Drawing.Point(691, 329);
            this.btn_salvar_produtos.Name = "btn_salvar_produtos";
            this.btn_salvar_produtos.Size = new System.Drawing.Size(132, 30);
            this.btn_salvar_produtos.TabIndex = 26;
            this.btn_salvar_produtos.Text = "Salvar dados";
            this.btn_salvar_produtos.UseVisualStyleBackColor = false;
            this.btn_salvar_produtos.Click += new System.EventHandler(this.btn_salvar_produtos_Click);
            // 
            // txb_quantidade
            // 
            this.txb_quantidade.Location = new System.Drawing.Point(314, 162);
            this.txb_quantidade.Name = "txb_quantidade";
            this.txb_quantidade.Size = new System.Drawing.Size(151, 20);
            this.txb_quantidade.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(218, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "Quantidade:";
            // 
            // txb_descricao
            // 
            this.txb_descricao.Location = new System.Drawing.Point(586, 141);
            this.txb_descricao.Multiline = true;
            this.txb_descricao.Name = "txb_descricao";
            this.txb_descricao.Size = new System.Drawing.Size(232, 41);
            this.txb_descricao.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(490, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Descrição:";
            // 
            // txb_codigo
            // 
            this.txb_codigo.Enabled = false;
            this.txb_codigo.Location = new System.Drawing.Point(102, 154);
            this.txb_codigo.Multiline = true;
            this.txb_codigo.Name = "txb_codigo";
            this.txb_codigo.Size = new System.Drawing.Size(67, 28);
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
            this.label2.Location = new System.Drawing.Point(29, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "Código:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 18);
            this.label7.TabIndex = 28;
            this.label7.Text = "Preço:";
            // 
            // txb_preco
            // 
            this.txb_preco.Location = new System.Drawing.Point(95, 254);
            this.txb_preco.Name = "txb_preco";
            this.txb_preco.Size = new System.Drawing.Size(151, 20);
            this.txb_preco.TabIndex = 29;
            // 
            // btn_deletar_produto
            // 
            this.btn_deletar_produto.BackColor = System.Drawing.Color.Red;
            this.btn_deletar_produto.FlatAppearance.BorderSize = 0;
            this.btn_deletar_produto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletar_produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletar_produto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_deletar_produto.Location = new System.Drawing.Point(564, 330);
            this.btn_deletar_produto.Name = "btn_deletar_produto";
            this.btn_deletar_produto.Size = new System.Drawing.Size(121, 30);
            this.btn_deletar_produto.TabIndex = 35;
            this.btn_deletar_produto.Text = "Deletar";
            this.btn_deletar_produto.UseVisualStyleBackColor = false;
            this.btn_deletar_produto.Click += new System.EventHandler(this.btn_deletar_produto_Click);
            // 
            // btn_atualizar_produto
            // 
            this.btn_atualizar_produto.BackColor = System.Drawing.Color.Blue;
            this.btn_atualizar_produto.FlatAppearance.BorderSize = 0;
            this.btn_atualizar_produto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_atualizar_produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atualizar_produto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_atualizar_produto.Location = new System.Drawing.Point(431, 330);
            this.btn_atualizar_produto.Name = "btn_atualizar_produto";
            this.btn_atualizar_produto.Size = new System.Drawing.Size(121, 30);
            this.btn_atualizar_produto.TabIndex = 34;
            this.btn_atualizar_produto.Text = "Atualizar dados";
            this.btn_atualizar_produto.UseVisualStyleBackColor = false;
            this.btn_atualizar_produto.Click += new System.EventHandler(this.btn_atualizar_produto_Click);
            // 
            // txb_pesquisar_produto
            // 
            this.txb_pesquisar_produto.Location = new System.Drawing.Point(99, 340);
            this.txb_pesquisar_produto.Name = "txb_pesquisar_produto";
            this.txb_pesquisar_produto.Size = new System.Drawing.Size(151, 20);
            this.txb_pesquisar_produto.TabIndex = 33;
            this.txb_pesquisar_produto.TextChanged += new System.EventHandler(this.txb_pesquisar_produto_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 342);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 15);
            this.label9.TabIndex = 32;
            this.label9.Text = "Pesquisar:";
            // 
            // dataGrid_produto
            // 
            this.dataGrid_produto.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGrid_produto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_produto.Location = new System.Drawing.Point(32, 376);
            this.dataGrid_produto.Name = "dataGrid_produto";
            this.dataGrid_produto.Size = new System.Drawing.Size(838, 176);
            this.dataGrid_produto.TabIndex = 31;
            this.dataGrid_produto.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGrid_produto_RowHeaderMouseClick);
            // 
            // mask_data_v
            // 
            this.mask_data_v.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mask_data_v.Location = new System.Drawing.Point(429, 252);
            this.mask_data_v.Mask = "00/00/0000";
            this.mask_data_v.Name = "mask_data_v";
            this.mask_data_v.Size = new System.Drawing.Size(116, 22);
            this.mask_data_v.TabIndex = 37;
            this.mask_data_v.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(286, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 18);
            this.label4.TabIndex = 36;
            this.label4.Text = "Data de validade:";
            // 
            // check_nao_alimenticio
            // 
            this.check_nao_alimenticio.AutoSize = true;
            this.check_nao_alimenticio.Location = new System.Drawing.Point(316, 76);
            this.check_nao_alimenticio.Name = "check_nao_alimenticio";
            this.check_nao_alimenticio.Size = new System.Drawing.Size(138, 17);
            this.check_nao_alimenticio.TabIndex = 38;
            this.check_nao_alimenticio.Text = "Produto Não alimenticio";
            this.check_nao_alimenticio.UseVisualStyleBackColor = true;
            this.check_nao_alimenticio.CheckedChanged += new System.EventHandler(this.check_nao_alimenticio_CheckedChanged);
            // 
            // check_alimenticio
            // 
            this.check_alimenticio.AutoSize = true;
            this.check_alimenticio.Location = new System.Drawing.Point(500, 76);
            this.check_alimenticio.Name = "check_alimenticio";
            this.check_alimenticio.Size = new System.Drawing.Size(76, 17);
            this.check_alimenticio.TabIndex = 39;
            this.check_alimenticio.Text = "Alimenticio";
            this.check_alimenticio.UseVisualStyleBackColor = true;
            this.check_alimenticio.CheckedChanged += new System.EventHandler(this.check_alimenticio_CheckedChanged);
            // 
            // btn_terminar_cadastro
            // 
            this.btn_terminar_cadastro.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_terminar_cadastro.Enabled = false;
            this.btn_terminar_cadastro.FlatAppearance.BorderSize = 0;
            this.btn_terminar_cadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_terminar_cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_terminar_cadastro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_terminar_cadastro.Location = new System.Drawing.Point(293, 329);
            this.btn_terminar_cadastro.Name = "btn_terminar_cadastro";
            this.btn_terminar_cadastro.Size = new System.Drawing.Size(132, 41);
            this.btn_terminar_cadastro.TabIndex = 40;
            this.btn_terminar_cadastro.Text = "Terminar Cadastro";
            this.btn_terminar_cadastro.UseVisualStyleBackColor = false;
            this.btn_terminar_cadastro.Click += new System.EventHandler(this.btn_terminar_cadastro_Click);
            // 
            // Tela_produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 650);
            this.Controls.Add(this.btn_terminar_cadastro);
            this.Controls.Add(this.check_alimenticio);
            this.Controls.Add(this.check_nao_alimenticio);
            this.Controls.Add(this.mask_data_v);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_deletar_produto);
            this.Controls.Add(this.btn_atualizar_produto);
            this.Controls.Add(this.txb_pesquisar_produto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGrid_produto);
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
            this.Load += new System.EventHandler(this.Tela_produto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_produto)).EndInit();
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
        private System.Windows.Forms.Button btn_deletar_produto;
        private System.Windows.Forms.Button btn_atualizar_produto;
        private System.Windows.Forms.TextBox txb_pesquisar_produto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGrid_produto;
        private System.Windows.Forms.MaskedTextBox mask_data_v;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox check_nao_alimenticio;
        private System.Windows.Forms.CheckBox check_alimenticio;
        private System.Windows.Forms.Button btn_terminar_cadastro;
    }
}