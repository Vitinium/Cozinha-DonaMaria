namespace DonaMaria
{
    partial class FormConsultarReceita
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
            TxtFiltro = new TextBox();
            BtnFiltro = new Button();
            dataGridView1 = new DataGridView();
            Nome = new DataGridViewTextBoxColumn();
            Descricao = new DataGridViewTextBoxColumn();
            BtnAbrir = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(195, 15);
            label1.TabIndex = 0;
            label1.Text = "Critérios para localização da receita:";
            // 
            // TxtFiltro
            // 
            TxtFiltro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtFiltro.Location = new Point(12, 29);
            TxtFiltro.Name = "TxtFiltro";
            TxtFiltro.Size = new Size(776, 23);
            TxtFiltro.TabIndex = 1;
            // 
            // BtnFiltro
            // 
            BtnFiltro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnFiltro.Location = new Point(12, 58);
            BtnFiltro.Name = "BtnFiltro";
            BtnFiltro.Size = new Size(776, 35);
            BtnFiltro.TabIndex = 2;
            BtnFiltro.Text = "Localizar receita";
            BtnFiltro.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nome, Descricao, BtnAbrir });
            dataGridView1.Location = new Point(12, 111);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(778, 338);
            dataGridView1.TabIndex = 3;
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome da receita";
            Nome.Name = "Nome";
            // 
            // Descricao
            // 
            Descricao.HeaderText = "Descrição da receita";
            Descricao.Name = "Descricao";
            Descricao.Width = 350;
            // 
            // BtnAbrir
            // 
            BtnAbrir.HeaderText = "Abrir";
            BtnAbrir.Name = "BtnAbrir";
            // 
            // FormConsultarReceita
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(BtnFiltro);
            Controls.Add(TxtFiltro);
            Controls.Add(label1);
            Name = "FormConsultarReceita";
            Text = "FormConsultarReceita";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtFiltro;
        private Button BtnFiltro;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Descricao;
        private DataGridViewButtonColumn BtnAbrir;
    }
}