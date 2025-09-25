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
            DtG = new DataGridView();
            Nome = new DataGridViewTextBoxColumn();
            Descricao = new DataGridViewTextBoxColumn();
            Abrir = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)DtG).BeginInit();
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
            BtnFiltro.Click += BtnFiltro_Click;
            // 
            // DtG
            // 
            DtG.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DtG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtG.Columns.AddRange(new DataGridViewColumn[] { Nome, Descricao, Abrir });
            DtG.Location = new Point(12, 111);
            DtG.Name = "DtG";
            DtG.Size = new Size(778, 338);
            DtG.TabIndex = 3;
            DtG.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Nome
            // 
            Nome.DataPropertyName = "Nome";
            Nome.HeaderText = "Nome da receita";
            Nome.Name = "Nome";
            // 
            // Descricao
            // 
            Descricao.DataPropertyName = "ModoPreparo";
            Descricao.HeaderText = "Descrição da receita";
            Descricao.Name = "Descricao";
            Descricao.Width = 350;
            // 
            // Abrir
            // 
            Abrir.HeaderText = "Abrir";
            Abrir.Name = "Abrir";
            // 
            // FormConsultarReceita
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DtG);
            Controls.Add(BtnFiltro);
            Controls.Add(TxtFiltro);
            Controls.Add(label1);
            Name = "FormConsultarReceita";
            Text = "FormConsultarReceita";
            FormClosed += FormConsultarReceita_FormClosed;
            Load += FormConsultarReceita_Load;
            ((System.ComponentModel.ISupportInitialize)DtG).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtFiltro;
        private Button BtnFiltro;
        private DataGridView DtG;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Descricao;
        private DataGridViewButtonColumn Abrir;
    }
}