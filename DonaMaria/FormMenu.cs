using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonaMaria
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void cadastroIngredientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormCadastrarIngrediente form = new FormCadastrarIngrediente();
            cadastroIngredientesToolStripMenuItem1.Enabled = false;
            cadastroIngredientesCToolStripMenuItem1.Enabled = false;
            form.MdiParent = this;
            form.Show();
        }

        private void cadastroTipoDeCozinhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastrarTpCozinha form = new FormCadastrarTpCozinha();
            cadastroTipoDeCozinhaToolStripMenuItem.Enabled = false;
            cadastroTipoDeCozinhaCToolStripMenuItem.Enabled = false;
            form.MdiParent = this;
            form.Show();
        }

        private void cadastroReceitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastrarReceita form = new FormCadastrarReceita();
            cadastroReceitasToolStripMenuItem.Enabled = false;
            cadastroReceitasCToolStripMenuItem.Enabled = false;
            form.MdiParent = this;
            form.Show();
        }

        private void consultaReceitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultarReceita form = new FormConsultarReceita();
            consultaReceitasToolStripMenuItem.Enabled = false;
            consultaReceitasCToolStripMenuItem.Enabled = false;
            form.MdiParent = this;
            form.Show();
        }


        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var x = MessageBox.Show("Você tem certeza que deseja fechar o Sistema?", "Atenção", MessageBoxButtons.YesNo);
            if (x == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;

            }

        }

        private void quizSobreAMatériaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQuiz form = new FrmQuiz();
            quizSobreAMatériaToolStripMenuItem.Enabled = false;
            quizToolStripMenuItem.Enabled = false;
            form.MdiParent = this;
            form.Show();

        }
    }
}
