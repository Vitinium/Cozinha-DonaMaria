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
    public partial class cadastroTpCozinha : Form
    {
        // Armazena o índice da linha que está sendo editada. -1 significa que é uma nova inclusão.
        private int editIndex = -1;

        public cadastroTpCozinha()
        {
            InitializeComponent();
        }

        private void cadastroTpCozinha_Load(object sender, EventArgs e)
        {
            // Garante que o usuário não possa editar o conteúdo da tabela diretamente.
            dgvTiposCozinha.ReadOnly = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();

             // RN01: O campo nome do tipo de cozinha é de preenchimento obrigatório. [cite: 33]
            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("O campo 'Nome' do tipo de cozinha é obrigatório.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return;
            }

            // RN02: Não é permitido tipos de cozinha com o mesmo nome. [cite: 34]
            bool nomeDuplicado = false;
            if (editIndex > -1)
            {
                // Modo de edição: verifica se o nome já existe em OUTRA linha.
                nomeDuplicado = dgvTiposCozinha.Rows.Cast<DataGridViewRow>()
                    .Where((r, i) => i != editIndex)
                    .Any(r => r.Cells["Nome"].Value?.ToString().Equals(nome, StringComparison.OrdinalIgnoreCase) == true);
            }
            else
            {
                // Modo de inclusão: verifica se o nome já existe em qualquer linha.
                nomeDuplicado = dgvTiposCozinha.Rows.Cast<DataGridViewRow>()
                    .Any(r => r.Cells["Nome"].Value?.ToString().Equals(nome, StringComparison.OrdinalIgnoreCase) == true);
            }

            if (nomeDuplicado)
            {
                // Fluxo de Exceção: Violação da RN02 [cite: 28]
                var result = MessageBox.Show($"Já existe um tipo de cozinha com o nome '{nome}'.\nDeseja carregar os dados do tipo existente?",
                    "Nome Duplicado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                   // Carrega os dados do item existente para edição. [cite: 29]
                    var linhaExistente = dgvTiposCozinha.Rows.Cast<DataGridViewRow>()
                        .First(r => r.Cells["Nome"].Value?.ToString().Equals(nome, StringComparison.OrdinalIgnoreCase) == true);

                    CarregarDadosParaEdicao(linhaExistente.Index);
                }
                else
                {
                    txtNome.Focus(); // Mantém o foco no campo nome para alteração. [cite: 30]
                }
                return;
            }

            // Se todas as validações passaram, salva ou atualiza os dados.
            if (editIndex == -1)
            {
                // Fluxo Alternativo: Incluir Tipo de Cozinha [cite: 12]
               // Inclui um novo registro na tabela. [cite: 14]
                dgvTiposCozinha.Rows.Add(txtCodigo.Text, txtNome.Text, txtDescricao.Text, "Alterar", "Excluir");
            }
            else
            {
                // Fluxo Alternativo: Alterar tipo de cozinha. [cite: 15]
                // Altera o registro existente. [cite: 19]
                DataGridViewRow row = dgvTiposCozinha.Rows[editIndex];
                row.Cells["Codigo"].Value = txtCodigo.Text;
                row.Cells["Nome"].Value = txtNome.Text;
                row.Cells["Descricao"].Value = txtDescricao.Text;
            }

            LimparCampos(); // Limpa os campos e recarrega o estado inicial. [cite: 14, 19]
        }

        private void dgvTiposCozinha_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignora cliques no cabeçalho da tabela.
            if (e.RowIndex < 0) return;

            string nomeColuna = dgvTiposCozinha.Columns[e.ColumnIndex].Name;

            // Se o botão "Alterar" foi clicado:
            if (nomeColuna == "Alterar")
            {
               // Carrega os dados da linha selecionada para os campos de edição. [cite: 17]
                CarregarDadosParaEdicao(e.RowIndex);
            }
            // Se o botão "Excluir" foi clicado:
            else if (nomeColuna == "Excluir")
            {
                // Fluxo Alternativo: Excluir tipo de cozinha. [cite: 20, 21]
                string nomeParaExcluir = dgvTiposCozinha.Rows[e.RowIndex].Cells["Nome"].Value?.ToString();

                // RN03: Não é permitido excluir um tipo de cozinha que esteja sendo utilizado. [cite: 35]
                if (TipoDeCozinhaEstaEmUso(nomeParaExcluir))
                {
                    // Fluxo de Exceção: Violação da RN03. [cite: 31, 32]
                    MessageBox.Show($"O tipo de cozinha '{nomeParaExcluir}' não pode ser excluído, pois está sendo utilizado em uma ou mais receitas.",
                        "Exclusão não permitida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Solicita confirmação do usuário. [cite: 22]
                var result = MessageBox.Show($"Tem certeza que deseja excluir o tipo de cozinha '{nomeParaExcluir}'?",
                    "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Remove a linha da tabela e limpa os campos. [cite: 24]
                    dgvTiposCozinha.Rows.RemoveAt(e.RowIndex);
                    LimparCampos();
                }
            }
        }

        private void CarregarDadosParaEdicao(int rowIndex)
        {
            DataGridViewRow row = dgvTiposCozinha.Rows[rowIndex];

            txtCodigo.Text = row.Cells["Codigo"].Value?.ToString();
            txtNome.Text = row.Cells["Nome"].Value?.ToString();
            txtDescricao.Text = row.Cells["Descricao"].Value?.ToString();

            txtCodigo.Enabled = false; // Bloqueia o campo código. [cite: 17]
            btnSalvar.Text = "Atualizar";
            editIndex = rowIndex;
        }

        private void LimparCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtDescricao.Clear();

            txtCodigo.Enabled = true;
            btnSalvar.Text = "Salvar";
            editIndex = -1; // Reseta o índice de edição.
            txtNome.Focus();
        }

        // Função para simular a verificação da RN03.
        private bool TipoDeCozinhaEstaEmUso(string nomeTipoCozinha)
        {
            // Em uma aplicação real, aqui haveria uma consulta ao banco de dados
            // para verificar se existem receitas usando este tipo de cozinha.

            // Exemplo fictício para simular o bloqueio.
            string[] tiposEmUso = { "Italiana", "Japonesa", "Brasileira" };
            return tiposEmUso.Contains(nomeTipoCozinha, StringComparer.OrdinalIgnoreCase);
        }
    }
}