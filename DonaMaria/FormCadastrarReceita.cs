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
    public partial class FormCadastrarReceita : Form
    {
        private List<IngredienteReceita> ingredientesDaReceitaAtual = new List<IngredienteReceita>();
        private Receita receitaParaEditar = null;
        public FormCadastrarReceita(Receita receitaSelecionada)
        {
            InitializeComponent();
            this.receitaParaEditar = receitaSelecionada;
        }

        public FormCadastrarReceita()
        {
            InitializeComponent();
        }

        private void FormCadastrarReceita_Load(object sender, EventArgs e)
        {
            cmbTipoCozinha.DataSource = TipoCozinha.SelecionarTodos();
            cmbTipoCozinha.DisplayMember = "Nome"; // Mostra o nome do tipo de cozinha
            cmbTipoCozinha.ValueMember = "ID";   // Guarda o ID internamente

            cmbIngredientes.DataSource = Ingrediente.SelecionarTodos();
            cmbIngredientes.DisplayMember = "Nome";
            cmbIngredientes.ValueMember = "ID";

            // Configura o grid de ingredientes da receita
            DtG.AutoGenerateColumns = false;
            if (receitaParaEditar != null)
            {
                // Preenche os campos com os dados da receita
                TxtNome.Text = receitaParaEditar.Nome;
                txtModoPreparo.Text = receitaParaEditar.ModoPreparo;
                cmbTipoCozinha.SelectedValue = receitaParaEditar.TipoCozinha.ID;

                // Carrega a lista de ingredientes da receita para a lista temporária da tela
                ingredientesDaReceitaAtual = new List<IngredienteReceita>(receitaParaEditar.Ingredientes);
                AtualizarGridIngredientes();

                // Muda o texto do botão
                BtnSalvar.Text = "Atualizar";
            }
        }

        private bool VerificaControles()
        {
            if (TxtNome.Text.Trim() == "")
            {
                MessageBox.Show("O campo Nome é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void BtnAddIngrediente_Click(object sender, EventArgs e)
        {
            Ingrediente ingSelecionado = (Ingrediente)cmbIngredientes.SelectedItem;
            decimal quantidade = numQuantidade.Value;

            if (ingSelecionado == null || quantidade <= 0)
            {
                MessageBox.Show("Selecione um ingrediente e uma quantidade válida.", "Atenção");
                return;
            }

            // Cria o objeto que representa a linha do grid
            IngredienteReceita novoItem = new IngredienteReceita();
            novoItem.Ingrediente = ingSelecionado;
            novoItem.Quantidade = (float)quantidade;

            // Adiciona na lista temporária e atualiza o grid
            ingredientesDaReceitaAtual.Add(novoItem);
            AtualizarGridIngredientes();
            cmbIngredientes.SelectedIndex = -1;
            numQuantidade.Value = 1;
        }

        private void AtualizarGridIngredientes()
        {
            DtG.DataSource = null;
            DtG.DataSource = ingredientesDaReceitaAtual;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (VerificaControles())
            {
                if (receitaParaEditar == null)
                {
                    Receita novaReceita = new Receita();

                    novaReceita.Nome = TxtNome.Text;
                    novaReceita.ModoPreparo = txtModoPreparo.Text;
                    novaReceita.TipoCozinha = (TipoCozinha)cmbTipoCozinha.SelectedItem;
                    novaReceita.Ingredientes = new List<IngredienteReceita>(ingredientesDaReceitaAtual);
                    // =========================================================

                    novaReceita.Incluir();
                    MessageBox.Show("Receita salva com sucesso!");
                    LimparCampos();
                }
                // Se não, é uma ATUALIZAÇÃO (seu código de 'else' já está correto)
                else
                {
                    receitaParaEditar.Nome = TxtNome.Text;
                    receitaParaEditar.ModoPreparo = txtModoPreparo.Text;
                    receitaParaEditar.TipoCozinha = (TipoCozinha)cmbTipoCozinha.SelectedItem;
                    receitaParaEditar.Ingredientes = new List<IngredienteReceita>(ingredientesDaReceitaAtual);

                    MessageBox.Show("Receita atualizada com sucesso!");
                    LimparCampos();
                    this.Close(); // Fecha o formulário após a atualização
                }
            }
        }

        private void LimparCampos()
        {
            TxtNome.Clear();
            txtModoPreparo.Clear();
            txtModoPreparo.Clear();
            ingredientesDaReceitaAtual.Clear();
            AtualizarGridIngredientes();
            cmbTipoCozinha.SelectedIndex = -1;
            cmbIngredientes.SelectedIndex = -1;
            numQuantidade.Value = 1;
        }

        private void FormCadastrarReceita_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.MdiParent != null)
            {
                FormMenu ofrm = (FormMenu)this.MdiParent;
                ofrm.cadastroReceitasToolStripMenuItem.Enabled = true;
                ofrm.cadastroReceitasCToolStripMenuItem.Enabled = true;
            }
        }

        private void DtG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DtG.Rows[e.RowIndex].DataBoundItem != null)
            {
                IngredienteReceita itemSelecionado = (IngredienteReceita)DtG.Rows[e.RowIndex].DataBoundItem;
                if (DtG.Columns[e.ColumnIndex].Name == "Alterar")
                {
                    cmbIngredientes.SelectedValue = itemSelecionado.Ingrediente.ID;
                    numQuantidade.Value = (decimal)itemSelecionado.Quantidade;

                    ingredientesDaReceitaAtual.Remove(itemSelecionado);

                    // 3. Atualiza o grid
                    AtualizarGridIngredientes();
                }
                else if (DtG.Columns[e.ColumnIndex].Name == "Excluir")
                {
                    var confirmResult = MessageBox.Show("Tem certeza que deseja remover este ingrediente da receita?",
                                             "Confirmar Exclusão",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                    if (confirmResult == DialogResult.Yes)
                    {
                        // Remove o item da lista temporária
                        ingredientesDaReceitaAtual.Remove(itemSelecionado);

                        // Atualiza o grid para refletir a remoção
                        AtualizarGridIngredientes();
                    }
                }
            }
        }
    }
}
