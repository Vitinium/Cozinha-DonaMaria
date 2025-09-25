namespace DonaMaria
{
    partial class FormCadastrarTpCozinha
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
            DtG = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Descricao = new DataGridViewTextBoxColumn();
            Alterar = new DataGridViewButtonColumn();
            Excluir = new DataGridViewButtonColumn();
            BtnSalvar = new Button();
            TxtDescricao = new TextBox();
            LblDescricao = new Label();
            TxtNome = new TextBox();
            TxtCod = new TextBox();
            LblNome = new Label();
            LblCod = new Label();
            ((System.ComponentModel.ISupportInitialize)DtG).BeginInit();
            SuspendLayout();
            // 
            // DtG
            // 
            DtG.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DtG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtG.Columns.AddRange(new DataGridViewColumn[] { ID, Nome, Descricao, Alterar, Excluir });
            DtG.Location = new Point(0, 238);
            DtG.Name = "DtG";
            DtG.ReadOnly = true;
            DtG.Size = new Size(800, 203);
            DtG.TabIndex = 8;
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
            // BtnSalvar
            // 
            BtnSalvar.Location = new Point(38, 195);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(119, 37);
            BtnSalvar.TabIndex = 9;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // TxtDescricao
            // 
            TxtDescricao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtDescricao.Location = new Point(38, 86);
            TxtDescricao.Multiline = true;
            TxtDescricao.Name = "TxtDescricao";
            TxtDescricao.ScrollBars = ScrollBars.Vertical;
            TxtDescricao.Size = new Size(730, 103);
            TxtDescricao.TabIndex = 10;
            // 
            // LblDescricao
            // 
            LblDescricao.AutoSize = true;
            LblDescricao.Location = new Point(38, 68);
            LblDescricao.Name = "LblDescricao";
            LblDescricao.Size = new Size(58, 15);
            LblDescricao.TabIndex = 11;
            LblDescricao.Text = "Descrição";
            // 
            // TxtNome
            // 
            TxtNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtNome.Location = new Point(185, 28);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(583, 23);
            TxtNome.TabIndex = 12;
            // 
            // TxtCod
            // 
            TxtCod.Enabled = false;
            TxtCod.Location = new Point(38, 28);
            TxtCod.Name = "TxtCod";
            TxtCod.Size = new Size(100, 23);
            TxtCod.TabIndex = 13;
            // 
            // LblNome
            // 
            LblNome.AutoSize = true;
            LblNome.Location = new Point(185, 10);
            LblNome.Name = "LblNome";
            LblNome.Size = new Size(40, 15);
            LblNome.TabIndex = 14;
            LblNome.Text = "Nome";
            // 
            // LblCod
            // 
            LblCod.AutoSize = true;
            LblCod.Location = new Point(38, 10);
            LblCod.Name = "LblCod";
            LblCod.Size = new Size(18, 15);
            LblCod.TabIndex = 15;
            LblCod.Text = "ID";
            // 
            // FormCadastrarTpCozinha
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
            Name = "FormCadastrarTpCozinha";
            Text = "FormCadastrarTpCozinha";
            Load += FormCadastrarTpCozinha_Load;
            ((System.ComponentModel.ISupportInitialize)DtG).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DtG;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Descricao;
        private DataGridViewButtonColumn Alterar;
        private DataGridViewButtonColumn Excluir;
        private Button BtnSalvar;
        private TextBox TxtDescricao;
        private Label LblDescricao;
        private TextBox TxtNome;
        private TextBox TxtCod;
        private Label LblNome;
        private Label LblCod;
    }
}