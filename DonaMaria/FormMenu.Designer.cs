namespace DonaMaria
{
    partial class FormMenu
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
            menuStrip1 = new MenuStrip();
            cadastroIngredientesToolStripMenuItem = new ToolStripMenuItem();
            cadastroIngredientesToolStripMenuItem1 = new ToolStripMenuItem();
            cadastroTipoDeCozinhaToolStripMenuItem = new ToolStripMenuItem();
            cadastroReceitasToolStripMenuItem = new ToolStripMenuItem();
            consultaReceitasToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroIngredientesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastroIngredientesToolStripMenuItem
            // 
            cadastroIngredientesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastroIngredientesToolStripMenuItem1, cadastroTipoDeCozinhaToolStripMenuItem, cadastroReceitasToolStripMenuItem, consultaReceitasToolStripMenuItem });
            cadastroIngredientesToolStripMenuItem.Name = "cadastroIngredientesToolStripMenuItem";
            cadastroIngredientesToolStripMenuItem.Size = new Size(114, 20);
            cadastroIngredientesToolStripMenuItem.Text = "Menu Dona Maria";
            // 
            // cadastroIngredientesToolStripMenuItem1
            // 
            cadastroIngredientesToolStripMenuItem1.Name = "cadastroIngredientesToolStripMenuItem1";
            cadastroIngredientesToolStripMenuItem1.Size = new Size(210, 22);
            cadastroIngredientesToolStripMenuItem1.Text = "Cadastro Ingredientes";
            cadastroIngredientesToolStripMenuItem1.Click += cadastroIngredientesToolStripMenuItem1_Click;
            // 
            // cadastroTipoDeCozinhaToolStripMenuItem
            // 
            cadastroTipoDeCozinhaToolStripMenuItem.Name = "cadastroTipoDeCozinhaToolStripMenuItem";
            cadastroTipoDeCozinhaToolStripMenuItem.Size = new Size(210, 22);
            cadastroTipoDeCozinhaToolStripMenuItem.Text = "Cadastro Tipo de Cozinha";
            cadastroTipoDeCozinhaToolStripMenuItem.Click += cadastroTipoDeCozinhaToolStripMenuItem_Click;
            // 
            // cadastroReceitasToolStripMenuItem
            // 
            cadastroReceitasToolStripMenuItem.Name = "cadastroReceitasToolStripMenuItem";
            cadastroReceitasToolStripMenuItem.Size = new Size(210, 22);
            cadastroReceitasToolStripMenuItem.Text = "Cadastro Receitas";
            cadastroReceitasToolStripMenuItem.Click += cadastroReceitasToolStripMenuItem_Click;
            // 
            // consultaReceitasToolStripMenuItem
            // 
            consultaReceitasToolStripMenuItem.Name = "consultaReceitasToolStripMenuItem";
            consultaReceitasToolStripMenuItem.Size = new Size(210, 22);
            consultaReceitasToolStripMenuItem.Text = "Consulta Receitas";
            consultaReceitasToolStripMenuItem.Click += consultaReceitasToolStripMenuItem_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FormMenu";
            Text = "FormMenu";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroIngredientesToolStripMenuItem;
        private ToolStripMenuItem cadastroIngredientesToolStripMenuItem1;
        private ToolStripMenuItem cadastroTipoDeCozinhaToolStripMenuItem;
        private ToolStripMenuItem cadastroReceitasToolStripMenuItem;
        private ToolStripMenuItem consultaReceitasToolStripMenuItem;
    }
}