namespace DonaMaria
{
    partial class FormCadastrarIngrediente
    {
        private System.ComponentModel.IContainer components = null;
        private Label LblCod;
        private Label LblNome;
        private TextBox TxtCod;
        private TextBox TxtNome;
        private Label LblDescricao;
        private TextBox TxtDescricao;
        private Button BtnSalvar;
        private DataGridView DtG;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            LblCod = new Label();
            LblNome = new Label();
            TxtCod = new TextBox();
            TxtNome = new TextBox();
            LblDescricao = new Label();
            TxtDescricao = new TextBox();
            BtnSalvar = new Button();
            DtG = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Descricao = new DataGridViewTextBoxColumn();
            Alterar = new DataGridViewButtonColumn();
            Excluir = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)DtG).BeginInit();
            SuspendLayout();
            // 
            // LblCod
            // 
            LblCod.AutoSize = true;
            LblCod.Location = new Point(38, 19);
            LblCod.Name = "LblCod";
            LblCod.Size = new Size(18, 15);
            LblCod.TabIndex = 7;
            LblCod.Text = "ID";
            // 
            // LblNome
            // 
            LblNome.AutoSize = true;
            LblNome.Location = new Point(185, 19);
            LblNome.Name = "LblNome";
            LblNome.Size = new Size(40, 15);
            LblNome.TabIndex = 6;
            LblNome.Text = "Nome";
            // 
            // TxtCod
            // 
            TxtCod.Enabled = false;
            TxtCod.Location = new Point(38, 37);
            TxtCod.Name = "TxtCod";
            TxtCod.Size = new Size(100, 23);
            TxtCod.TabIndex = 5;
            // 
            // TxtNome
            // 
            TxtNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtNome.Location = new Point(185, 37);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(583, 23);
            TxtNome.TabIndex = 4;
            // 
            // LblDescricao
            // 
            LblDescricao.AutoSize = true;
            LblDescricao.Location = new Point(38, 77);
            LblDescricao.Name = "LblDescricao";
            LblDescricao.Size = new Size(58, 15);
            LblDescricao.TabIndex = 3;
            LblDescricao.Text = "Descrição";
            // 
            // TxtDescricao
            // 
            TxtDescricao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtDescricao.Location = new Point(38, 95);
            TxtDescricao.Multiline = true;
            TxtDescricao.Name = "TxtDescricao";
            TxtDescricao.ScrollBars = ScrollBars.Vertical;
            TxtDescricao.Size = new Size(730, 103);
            TxtDescricao.TabIndex = 2;
            // 
            // BtnSalvar
            // 
            BtnSalvar.Location = new Point(38, 204);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(119, 37);
            BtnSalvar.TabIndex = 1;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // DtG
            // 
            DtG.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DtG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtG.Columns.AddRange(new DataGridViewColumn[] { ID, Nome, Descricao, Alterar, Excluir });
            DtG.Location = new Point(0, 247);
            DtG.Name = "DtG";
            DtG.ReadOnly = true;
            DtG.Size = new Size(800, 203);
            DtG.TabIndex = 0;
            DtG.CellClick += DtG_CellClick;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Nome
            // 
            Nome.DataPropertyName = "Nome";
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            Nome.Width = 150;
            // 
            // Descricao
            // 
            Descricao.DataPropertyName = "Descricao";
            Descricao.HeaderText = "Descrição";
            Descricao.Name = "Descricao";
            Descricao.ReadOnly = true;
            Descricao.Width = 200;
            // 
            // Alterar
            // 
            Alterar.HeaderText = "Alterar";
            Alterar.Name = "Alterar";
            Alterar.ReadOnly = true;
            Alterar.Text = "Alterar";
            Alterar.UseColumnTextForButtonValue = true;
            // 
            // Excluir
            // 
            Excluir.HeaderText = "Excluir";
            Excluir.Name = "Excluir";
            Excluir.ReadOnly = true;
            Excluir.Text = "Excluir";
            Excluir.UseColumnTextForButtonValue = true;
            // 
            // FormCadastrarIngrediente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DtG);
            Controls.Add(BtnSalvar);
            Controls.Add(TxtDescricao);
            Controls.Add(LblDescricao);
            Controls.Add(TxtNome);
            Controls.Add(TxtCod);
            Controls.Add(LblNome);
            Controls.Add(LblCod);
            Name = "FormCadastrarIngrediente";
            Text = "Cadastrar ingrediente";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DtG).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Descricao;
        private DataGridViewButtonColumn Alterar;
        private DataGridViewButtonColumn Excluir;
    }
}
