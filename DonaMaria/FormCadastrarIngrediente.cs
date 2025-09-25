using System;
using System.Windows.Forms;
using DonaMaria.Model;

namespace DonaMaria
{
    public partial class FormCadastrarIngrediente : Form
    {
        public FormCadastrarIngrediente()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DtG.AutoGenerateColumns = false; // Desativa a geração automática de colunas
            DtG.DataSource = Ingrediente.SelecionarTodos(); // Carrega os dados iniciais
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

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (VerificaControles())
            {
                if (BtnSalvar.Text == "Salvar")
                {
                    Ingrediente oIngrediente = new Ingrediente();
                    oIngrediente.Nome = TxtNome.Text;
                    oIngrediente.Descricao = TxtDescricao.Text;
                    oIngrediente.Incluir();
                    DtG.DataSource = Ingrediente.SelecionarTodos();
                }
                else 
                {
                    Ingrediente? oIngrediente = Ingrediente.SelecionarPeloID(int.Parse(TxtCod.Text));
                    if (oIngrediente != null)
                    {
                        oIngrediente.Nome = TxtNome.Text;
                        oIngrediente.Descricao = TxtDescricao.Text;
                    }
                }
                LimparCampos();
                DtG.DataSource = Ingrediente.SelecionarTodos();
            }
        }

        private void LimparCampos()
        {
            TxtCod.Clear();
            TxtNome.Clear();
            TxtDescricao.Clear();
            BtnSalvar.Text = "Salvar";
            TxtNome.Focus();
        }

        private void DtG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DtG.Rows[e.RowIndex].DataBoundItem != null)
            {
                if (DtG.Columns[e.ColumnIndex].Name == "Alterar")
                {
                    Ingrediente oIngrediente = (Ingrediente)DtG.Rows[e.RowIndex].DataBoundItem;
                    TxtCod.Text = oIngrediente.ID.ToString();
                    TxtNome.Text = oIngrediente.Nome;
                    TxtDescricao.Text = oIngrediente.Descricao;
                    BtnSalvar.Text = "Alterar";
                }
                else if (DtG.Columns[e.ColumnIndex].Name == "Excluir")
                {
                    Ingrediente oIngrediente = (Ingrediente)DtG.Rows[e.RowIndex].DataBoundItem;
                    var confirmResult = MessageBox.Show($"Tem certeza que deseja excluir o ingrediente '{oIngrediente.Nome}'?", 
                                                         "Confirmação de Exclusão", 
                                                         MessageBoxButtons.YesNo, 
                                                         MessageBoxIcon.Question);
                    if (confirmResult == DialogResult.Yes)
                    {    
                        Ingrediente.Excluir(oIngrediente.ID);
                        DtG.DataSource = Ingrediente.SelecionarTodos();
                        LimparCampos();
                    }
                }
            }

        }
    }
}