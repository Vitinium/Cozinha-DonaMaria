namespace DonaMaria
{
    partial class Form1
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
        private DataGridViewTextBoxColumn Reference;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewButtonColumn Alterar;
        private DataGridViewButtonColumn Excluir;

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
            Reference = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Alterar = new DataGridViewButtonColumn();
            Excluir = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)DtG).BeginInit();
            SuspendLayout();
            // 
            // LblCod
            // 
            LblCod.AutoSize = true;
            LblCod.Location = new Point(60, 40);
            LblCod.Name = "LblCod";
            LblCod.Size = new Size(59, 15);
            LblCod.TabIndex = 7;
            LblCod.Text = "Reference";
            // 
            // LblNome
            // 
            LblNome.AutoSize = true;
            LblNome.Location = new Point(207, 40);
            LblNome.Name = "LblNome";
            LblNome.Size = new Size(39, 15);
            LblNome.TabIndex = 6;
            LblNome.Text = "Name";
            // 
            // TxtCod
            // 
            TxtCod.Location = new Point(60, 58);
            TxtCod.Name = "TxtCod";
            TxtCod.Size = new Size(100, 23);
            TxtCod.TabIndex = 5;
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(207, 58);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(523, 23);
            TxtNome.TabIndex = 4;
            // 
            // LblDescricao
            // 
            LblDescricao.AutoSize = true;
            LblDescricao.Location = new Point(60, 98);
            LblDescricao.Name = "LblDescricao";
            LblDescricao.Size = new Size(67, 15);
            LblDescricao.TabIndex = 3;
            LblDescricao.Text = "Description";
            // 
            // TxtDescricao
            // 
            TxtDescricao.Location = new Point(60, 116);
            TxtDescricao.Multiline = true;
            TxtDescricao.Name = "TxtDescricao";
            TxtDescricao.ScrollBars = ScrollBars.Vertical;
            TxtDescricao.Size = new Size(670, 103);
            TxtDescricao.TabIndex = 2;
            // 
            // BtnSalvar
            // 
            BtnSalvar.Location = new Point(60, 225);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(119, 37);
            BtnSalvar.TabIndex = 1;
            BtnSalvar.Text = "Save";
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // DtG
            // 
            DtG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtG.Columns.AddRange(new DataGridViewColumn[] { Reference, Name, Description, Alterar, Excluir });
            DtG.Dock = DockStyle.Bottom;
            DtG.Location = new Point(0, 300);
            DtG.Name = "DtG";
            DtG.ReadOnly = true;
            DtG.Size = new Size(800, 150);
            DtG.TabIndex = 0;
            DtG.CellContentClick += DtG_CellContentClick;
            // 
            // Reference
            // 
            Reference.HeaderText = "Reference";
            Reference.Name = "Reference";
            Reference.ReadOnly = true;
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.Name = "Name";
            Name.ReadOnly = true;
            // 
            // Description
            // 
            Description.HeaderText = "Description";
            Description.Name = "Description";
            Description.ReadOnly = true;
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
            // Form1
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
            Text = "Cadastrar tipo de Cozinha";
            ((System.ComponentModel.ISupportInitialize)DtG).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
