namespace DonaMaria
{
    partial class FormDetalhesReceita
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
            label1 = new Label();
            txtID = new TextBox();
            label2 = new Label();
            txtNome = new TextBox();
            label3 = new Label();
            txtModoPreparo = new TextBox();
            Dtg = new DataGridView();
            NomeIngrediente = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            Descricao = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)Dtg).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Código";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(12, 28);
            txtID.Name = "txtID";
            txtID.Size = new Size(119, 23);
            txtID.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(137, 9);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Enabled = false;
            txtNome.Location = new Point(137, 27);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(651, 23);
            txtNome.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 62);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 4;
            label3.Text = "Modo de preparo";
            // 
            // txtModoPreparo
            // 
            txtModoPreparo.Enabled = false;
            txtModoPreparo.Location = new Point(12, 80);
            txtModoPreparo.Multiline = true;
            txtModoPreparo.Name = "txtModoPreparo";
            txtModoPreparo.ScrollBars = ScrollBars.Vertical;
            txtModoPreparo.Size = new Size(776, 205);
            txtModoPreparo.TabIndex = 5;
            // 
            // Dtg
            // 
            Dtg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dtg.Columns.AddRange(new DataGridViewColumn[] { NomeIngrediente, Quantidade, Descricao });
            Dtg.Location = new Point(13, 291);
            Dtg.Name = "Dtg";
            Dtg.Size = new Size(775, 160);
            Dtg.TabIndex = 6;
            // 
            // NomeIngrediente
            // 
            NomeIngrediente.DataPropertyName = "NomeIngrediente";
            NomeIngrediente.HeaderText = "Ingrediente";
            NomeIngrediente.Name = "NomeIngrediente";
            NomeIngrediente.Width = 200;
            // 
            // Quantidade
            // 
            Quantidade.DataPropertyName = "Quantidade";
            Quantidade.HeaderText = "Qtd";
            Quantidade.Name = "Quantidade";
            Quantidade.Width = 50;
            // 
            // Descricao
            // 
            Descricao.DataPropertyName = "Descricao";
            Descricao.HeaderText = "Descrição";
            Descricao.Name = "Descricao";
            Descricao.Width = 450;
            // 
            // FormDetalhesReceita
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Dtg);
            Controls.Add(txtModoPreparo);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(txtID);
            Controls.Add(label1);
            Name = "FormDetalhesReceita";
            Text = "FormDetalhesReceita";
            Load += FormDetalhesReceita_Load;
            ((System.ComponentModel.ISupportInitialize)Dtg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtID;
        private Label label2;
        private TextBox txtNome;
        private Label label3;
        private TextBox txtModoPreparo;
        private DataGridView Dtg;
        private DataGridViewTextBoxColumn NomeIngrediente;
        private DataGridViewTextBoxColumn Quantidade;
        private DataGridViewTextBoxColumn Descricao;
    }
}