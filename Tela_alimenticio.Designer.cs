namespace ExercicioBanco
{
    partial class Tela_alimenticio
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_tipo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_medida = new System.Windows.Forms.TextBox();
            this.btn_salvar_alimenticio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(405, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Alimenticio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(206, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tipo:";
            // 
            // txb_tipo
            // 
            this.txb_tipo.Location = new System.Drawing.Point(258, 95);
            this.txb_tipo.Name = "txb_tipo";
            this.txb_tipo.Size = new System.Drawing.Size(151, 20);
            this.txb_tipo.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(455, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Medida:";
            // 
            // txb_medida
            // 
            this.txb_medida.Location = new System.Drawing.Point(528, 92);
            this.txb_medida.Name = "txb_medida";
            this.txb_medida.Size = new System.Drawing.Size(151, 20);
            this.txb_medida.TabIndex = 20;
            // 
            // btn_salvar_alimenticio
            // 
            this.btn_salvar_alimenticio.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_salvar_alimenticio.FlatAppearance.BorderSize = 0;
            this.btn_salvar_alimenticio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar_alimenticio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar_alimenticio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_salvar_alimenticio.Location = new System.Drawing.Point(366, 224);
            this.btn_salvar_alimenticio.Name = "btn_salvar_alimenticio";
            this.btn_salvar_alimenticio.Size = new System.Drawing.Size(183, 43);
            this.btn_salvar_alimenticio.TabIndex = 22;
            this.btn_salvar_alimenticio.Text = "Salvar dados";
            this.btn_salvar_alimenticio.UseVisualStyleBackColor = false;
            // 
            // Tela_alimenticio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 350);
            this.Controls.Add(this.btn_salvar_alimenticio);
            this.Controls.Add(this.txb_medida);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txb_tipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Tela_alimenticio";
            this.Text = "Tela_alimenticio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_salvar_alimenticio;
        public System.Windows.Forms.TextBox txb_tipo;
        public System.Windows.Forms.TextBox txb_medida;
    }
}