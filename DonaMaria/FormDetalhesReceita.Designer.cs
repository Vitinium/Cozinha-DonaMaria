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
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            dataGridView1 = new DataGridView();
            Ingrediente = new DataGridViewTextBoxColumn();
            Qtd = new DataGridViewTextBoxColumn();
            Descricao = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // textBox1
            // 
            textBox1.Location = new Point(12, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(119, 23);
            textBox1.TabIndex = 1;
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
            // textBox2
            // 
            textBox2.Location = new Point(137, 27);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(651, 23);
            textBox2.TabIndex = 3;
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
            // textBox3
            // 
            textBox3.Location = new Point(12, 80);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ScrollBars = ScrollBars.Vertical;
            textBox3.Size = new Size(776, 205);
            textBox3.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Ingrediente, Qtd, Descricao });
            dataGridView1.Location = new Point(13, 291);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(775, 160);
            dataGridView1.TabIndex = 6;
            // 
            // Ingrediente
            // 
            Ingrediente.HeaderText = "Ingrediente";
            Ingrediente.Name = "Ingrediente";
            Ingrediente.Width = 200;
            // 
            // Qtd
            // 
            Qtd.HeaderText = "Qtd";
            Qtd.Name = "Qtd";
            Qtd.Width = 50;
            // 
            // Descricao
            // 
            Descricao.HeaderText = "Descrição";
            Descricao.Name = "Descricao";
            Descricao.Width = 450;
            // 
            // FormDetalhesReceita
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "FormDetalhesReceita";
            Text = "FormDetalhesReceita";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Ingrediente;
        private DataGridViewTextBoxColumn Qtd;
        private DataGridViewTextBoxColumn Descricao;
    }
}