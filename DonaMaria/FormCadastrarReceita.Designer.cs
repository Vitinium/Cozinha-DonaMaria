namespace DonaMaria
{
    partial class FormCadastrarReceita
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
            NomeIngrediente = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            Descricao = new DataGridViewTextBoxColumn();
            Alterar = new DataGridViewButtonColumn();
            Excluir = new DataGridViewButtonColumn();
            BtnSalvar = new Button();
            txtModoPreparo = new TextBox();
            LblDescricao = new Label();
            TxtNome = new TextBox();
            TxtCod = new TextBox();
            LblNome = new Label();
            LblCod = new Label();
            cmbTipoCozinha = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            cmbIngredientes = new ComboBox();
            BtnAddIngrediente = new Button();
            label3 = new Label();
            numQuantidade = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)DtG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantidade).BeginInit();
            SuspendLayout();
            // 
            // DtG
            // 
            DtG.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DtG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtG.Columns.AddRange(new DataGridViewColumn[] { NomeIngrediente, Quantidade, Descricao, Alterar, Excluir });
            DtG.Location = new Point(0, 317);
            DtG.Name = "DtG";
            DtG.ReadOnly = true;
            DtG.Size = new Size(800, 124);
            DtG.TabIndex = 8;
            DtG.CellClick += DtG_CellClick;
            // 
            // NomeIngrediente
            // 
            NomeIngrediente.DataPropertyName = "NomeIngrediente";
            NomeIngrediente.HeaderText = "Ingrediente";
            NomeIngrediente.Name = "NomeIngrediente";
            NomeIngrediente.ReadOnly = true;
            // 
            // Quantidade
            // 
            Quantidade.DataPropertyName = "Quantidade";
            Quantidade.HeaderText = "Quantidade";
            Quantidade.Name = "Quantidade";
            Quantidade.ReadOnly = true;
            Quantidade.Width = 150;
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
            BtnSalvar.Location = new Point(370, 256);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(119, 37);
            BtnSalvar.TabIndex = 9;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // txtModoPreparo
            // 
            txtModoPreparo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtModoPreparo.Location = new Point(38, 82);
            txtModoPreparo.Multiline = true;
            txtModoPreparo.Name = "txtModoPreparo";
            txtModoPreparo.ScrollBars = ScrollBars.Vertical;
            txtModoPreparo.Size = new Size(730, 103);
            txtModoPreparo.TabIndex = 10;
            // 
            // LblDescricao
            // 
            LblDescricao.AutoSize = true;
            LblDescricao.Location = new Point(38, 64);
            LblDescricao.Name = "LblDescricao";
            LblDescricao.Size = new Size(99, 15);
            LblDescricao.TabIndex = 11;
            LblDescricao.Text = "Modo de preparo";
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
            // cmbTipoCozinha
            // 
            cmbTipoCozinha.FormattingEnabled = true;
            cmbTipoCozinha.Location = new Point(370, 216);
            cmbTipoCozinha.Name = "cmbTipoCozinha";
            cmbTipoCozinha.Size = new Size(398, 23);
            cmbTipoCozinha.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(370, 198);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 11;
            label1.Text = "Tipo de cozinha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 198);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 11;
            label2.Text = "Ingrediente";
            // 
            // cmbIngredientes
            // 
            cmbIngredientes.FormattingEnabled = true;
            cmbIngredientes.Location = new Point(38, 216);
            cmbIngredientes.Name = "cmbIngredientes";
            cmbIngredientes.Size = new Size(121, 23);
            cmbIngredientes.TabIndex = 16;
            // 
            // BtnAddIngrediente
            // 
            BtnAddIngrediente.Location = new Point(107, 256);
            BtnAddIngrediente.Name = "BtnAddIngrediente";
            BtnAddIngrediente.Size = new Size(134, 37);
            BtnAddIngrediente.TabIndex = 9;
            BtnAddIngrediente.Text = "Adicionar ingrediente";
            BtnAddIngrediente.Click += BtnAddIngrediente_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(185, 198);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 11;
            label3.Text = "Quantidade";
            // 
            // numQuantidade
            // 
            numQuantidade.Location = new Point(185, 216);
            numQuantidade.Name = "numQuantidade";
            numQuantidade.Size = new Size(120, 23);
            numQuantidade.TabIndex = 17;
            // 
            // FormCadastrarReceita
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numQuantidade);
            Controls.Add(cmbIngredientes);
            Controls.Add(cmbTipoCozinha);
            Controls.Add(DtG);
            Controls.Add(BtnAddIngrediente);
            Controls.Add(BtnSalvar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtModoPreparo);
            Controls.Add(label1);
            Controls.Add(LblDescricao);
            Controls.Add(TxtNome);
            Controls.Add(TxtCod);
            Controls.Add(LblNome);
            Controls.Add(LblCod);
            Name = "FormCadastrarReceita";
            Text = "FormCadastrarReceita";
            FormClosed += FormCadastrarReceita_FormClosed;
            Load += FormCadastrarReceita_Load;
            ((System.ComponentModel.ISupportInitialize)DtG).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DtG;
        private Button BtnSalvar;
        private TextBox txtModoPreparo;
        private Label LblDescricao;
        private TextBox TxtNome;
        private TextBox TxtCod;
        private Label LblNome;
        private Label LblCod;
        private ComboBox cmbTipoCozinha;
        private Label label1;
        private Label label2;
        private ComboBox cmbIngredientes;
        private Button BtnAddIngrediente;
        private Label label3;
        private NumericUpDown numQuantidade;
        private DataGridViewTextBoxColumn NomeIngrediente;
        private DataGridViewTextBoxColumn Quantidade;
        private DataGridViewTextBoxColumn Descricao;
        private DataGridViewButtonColumn Alterar;
        private DataGridViewButtonColumn Excluir;
    }
}