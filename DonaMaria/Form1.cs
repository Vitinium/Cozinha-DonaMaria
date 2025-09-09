using System;
using System.Windows.Forms;
using System.Linq;  // Para usar Any()

namespace DonaMaria
{
    public partial class Form1 : Form
    {
        private int editIndex = -1;

        public Form1()
        {
            InitializeComponent();
            DtG.ReadOnly = true; // evita edi��o direta na grid
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            string nome = TxtNome.Text.Trim();

            // RN01: nome obrigat�rio
            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("O campo Nome do tipo de cozinha � obrigat�rio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtNome.Focus();
                return;
            }

            // RN02: nome �nico
            bool nomeDuplicado = false;
            if (editIndex == -1)
            {
                // inclus�o: verifica se j� existe nome igual na grid
                nomeDuplicado = DtG.Rows.Cast<DataGridViewRow>()
                    .Any(r => r.Cells["Name"].Value?.ToString().Equals(nome, StringComparison.OrdinalIgnoreCase) == true);
            }
            else
            {
                // edi��o: verifica se j� existe outro registro com mesmo nome (ignorando o atual)
                nomeDuplicado = DtG.Rows.Cast<DataGridViewRow>()
                    .Where((r, idx) => idx != editIndex)
                    .Any(r => r.Cells["Name"].Value?.ToString().Equals(nome, StringComparison.OrdinalIgnoreCase) == true);
            }

            if (nomeDuplicado)
            {
                var result = MessageBox.Show($"J� existe um tipo de cozinha com o nome '{nome}'. Deseja carregar o tipo existente?",
                    "Nome duplicado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // encontra a linha existente e carrega os dados para edi��o
                    var linhaExistente = DtG.Rows.Cast<DataGridViewRow>()
                        .FirstOrDefault(r => r.Cells["Name"].Value?.ToString().Equals(nome, StringComparison.OrdinalIgnoreCase) == true);

                    if (linhaExistente != null)
                    {
                        editIndex = linhaExistente.Index;
                        TxtCod.Text = linhaExistente.Cells["Reference"].Value?.ToString();
                        TxtNome.Text = linhaExistente.Cells["Name"].Value?.ToString();
                        TxtDescricao.Text = linhaExistente.Cells["Description"].Value?.ToString();
                        BtnSalvar.Text = "Update";
                    }
                }
                else
                {
                    TxtNome.Focus();
                }
                return;
            }

            // Se passou nas valida��es, salva ou atualiza
            if (editIndex == -1)
            {
                DtG.Rows.Add(TxtCod.Text, TxtNome.Text, TxtDescricao.Text, "Alterar", "Excluir");
            }
            else
            {
                DtG.Rows[editIndex].Cells["Reference"].Value = TxtCod.Text;
                DtG.Rows[editIndex].Cells["Name"].Value = TxtNome.Text;
                DtG.Rows[editIndex].Cells["Description"].Value = TxtDescricao.Text;
                editIndex = -1;
                BtnSalvar.Text = "Save";
            }

            LimparCampos();
        }

        private void DtG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            string columnName = DtG.Columns[e.ColumnIndex].Name;

            if (columnName == "Alterar")
            {
                TxtCod.Text = DtG.Rows[e.RowIndex].Cells["Reference"].Value?.ToString();
                TxtNome.Text = DtG.Rows[e.RowIndex].Cells["Name"].Value?.ToString();
                TxtDescricao.Text = DtG.Rows[e.RowIndex].Cells["Description"].Value?.ToString();

                editIndex = e.RowIndex;
                BtnSalvar.Text = "Update";
            }
            else if (columnName == "Excluir")
            {
                // RN03: verifica se tipo est� vinculado a receitas
                string nomeExcluir = DtG.Rows[e.RowIndex].Cells["Name"].Value?.ToString();

                if (EstaTipoCozinhaUsada(nomeExcluir))
                {
                    MessageBox.Show($"N�o � permitido excluir o tipo de cozinha '{nomeExcluir}' pois est� sendo usado por receitas.",
                        "Exclus�o n�o permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var result = MessageBox.Show($"Confirma a exclus�o do tipo de cozinha '{nomeExcluir}'?",
                    "Confirma��o de exclus�o", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DtG.Rows.RemoveAt(e.RowIndex);
                    editIndex = -1;
                    BtnSalvar.Text = "Save";
                    LimparCampos();
                }
            }
        }

        private void LimparCampos()
        {
            TxtCod.Clear();
            TxtNome.Clear();
            TxtDescricao.Clear();
            editIndex = -1;
            BtnSalvar.Text = "Save";
        }

        // Simula a verifica��o da regra RN03
        private bool EstaTipoCozinhaUsada(string nomeTipoCozinha)
        {
            // Aqui voc� faria a consulta real na base de receitas para verificar se o tipo est� em uso.
            // Exemplo fict�cio: bloqueia exclus�o para "Italiana" e "Chinesa"
            if (string.IsNullOrEmpty(nomeTipoCozinha))
                return false;

            string[] tiposEmUso = { "Italiana", "Chinesa" };

            return tiposEmUso.Contains(nomeTipoCozinha, StringComparer.OrdinalIgnoreCase);
        }
    }
}
