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
                Receita novaReceita = new Receita();
                novaReceita.Nome = TxtNome.Text;
                novaReceita.ModoPreparo = txtModoPreparo.Text;
                novaReceita.TipoCozinha = (TipoCozinha)cmbTipoCozinha.SelectedItem;

                // Atribui a lista de ingredientes que montamos
                novaReceita.Ingredientes = new List<IngredienteReceita>(ingredientesDaReceitaAtual);

                // Salva na "memória"
                novaReceita.Incluir();

                MessageBox.Show("Receita salva com sucesso!");
                LimparCampos();
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
    }
}
