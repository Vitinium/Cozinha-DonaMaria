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
            Receita receitaSelecionada = (Receita)DtG.Rows[e.RowIndex].DataBoundItem;
            if (e.RowIndex >= 0 && DtG.Columns[e.ColumnIndex].Name == "Abrir")
            {

                // Cria e abre o formulário de detalhes, passando a receita selecionada para ele
                FormDetalhesReceita formDetalhes = new FormDetalhesReceita(receitaSelecionada);
                formDetalhes.ShowDialog();
            }
            else if (e.RowIndex >= 0 && DtG.Columns[e.ColumnIndex].Name == "Excluir")
            {
                var confirmResult = MessageBox.Show($"Tem certeza que deseja excluir a receita '{receitaSelecionada.Nome}'?",
                                             "Confirmação de Exclusão",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    // Chama o método para remover da lista em memória
                    Receita.Excluir(receitaSelecionada.ID);

                    // Atualiza o grid para refletir a exclusão
                    DtG.DataSource = Receita.SelecionarTodos();
                }
            }
            else if (e.RowIndex >= 0 && DtG.Columns[e.ColumnIndex].Name == "Alterar")
            {
                FormCadastrarReceita formCadastro = new FormCadastrarReceita(receitaSelecionada);
                formCadastro.ShowDialog();

                // Após fechar a tela de cadastro, atualiza o grid para mostrar as possíveis alterações
                DtG.DataSource = Receita.SelecionarTodos();
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
