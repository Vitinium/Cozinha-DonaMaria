using DonaMaria.Model;
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
    public partial class FormConsultarReceita : Form
    {
        public FormConsultarReceita()
        {
            InitializeComponent();
        }

        private void FormConsultarReceita_Load(object sender, EventArgs e)
        {
            DtG.AutoGenerateColumns = false;
            DtG.DataSource = Receita.SelecionarTodos();
        }

        private void BtnFiltro_Click(object sender, EventArgs e)
        {
            string nomePesquisado = TxtFiltro.Text;
            DtG.DataSource = Receita.PesquisarPorNome(nomePesquisado);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && DtG.Columns[e.ColumnIndex].Name == "Abrir")
            {
                // Pega o objeto 'Receita' da linha onde o botão 'Abrir' foi clicado
                Receita receitaSelecionada = (Receita)DtG.Rows[e.RowIndex].DataBoundItem;

                // Cria e abre o formulário de detalhes, passando a receita selecionada para ele
                FormDetalhesReceita formDetalhes = new FormDetalhesReceita(receitaSelecionada);
                formDetalhes.ShowDialog();
            }
        }

        private void FormConsultarReceita_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMenu oFrm = (FormMenu)this.MdiParent;
            oFrm.consultaReceitasToolStripMenuItem.Enabled = true;
            oFrm.consultaReceitasCToolStripMenuItem.Enabled = true;
        }
    }
}
