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
            form.MdiParent = this;
            form.Show();

        }

        private void cadastroTipoDeCozinhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastrarTpCozinha form = new FormCadastrarTpCozinha();
            form.MdiParent = this;
            form.Show();
        }

        private void cadastroReceitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastrarReceita form = new FormCadastrarReceita();
            form.MdiParent = this;
            form.Show();
        }

        private void consultaReceitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultarReceita form = new FormConsultarReceita();
            form.MdiParent = this;
            form.Show();
        }
    }
}
