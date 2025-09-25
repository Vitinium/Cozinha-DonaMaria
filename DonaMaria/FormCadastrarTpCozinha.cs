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
    public partial class FormCadastrarTpCozinha : Form
    {
        public FormCadastrarTpCozinha()
        {
            InitializeComponent();
        }

        private void FormCadastrarTpCozinha_Load(object sender, EventArgs e)
        {
            DtG.AutoGenerateColumns = false; // Desativa a geração automática de colunas
            DtG.DataSource = TipoCozinha.SelecionarTodos(); // Carrega os dados iniciais
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
                    TipoCozinha oTipoCozinha = new TipoCozinha();
                    oTipoCozinha.Nome = TxtNome.Text;
                    oTipoCozinha.Descricao = TxtDescricao.Text;
                    oTipoCozinha.Incluir();
                    DtG.DataSource = TipoCozinha.SelecionarTodos();
                }
                else
                {
                    TipoCozinha? oTipoCozinha = TipoCozinha.SelecionarPeloID(int.Parse(TxtCod.Text));
                    if (oTipoCozinha != null)
                    {
                        oTipoCozinha.Nome = TxtNome.Text;
                        oTipoCozinha.Descricao = TxtDescricao.Text;
                    }
                }
                LimparCampos();
                DtG.DataSource = TipoCozinha.SelecionarTodos();
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
                    TipoCozinha oTipoCozinha = (TipoCozinha)DtG.Rows[e.RowIndex].DataBoundItem;
                    TxtCod.Text = oTipoCozinha.ID.ToString();
                    TxtNome.Text = oTipoCozinha.Nome;
                    TxtDescricao.Text = oTipoCozinha.Descricao;
                    BtnSalvar.Text = "Alterar";
                }
                else if (DtG.Columns[e.ColumnIndex].Name == "Excluir")
                {
                    TipoCozinha oTipoCozinha = (TipoCozinha)DtG.Rows[e.RowIndex].DataBoundItem;
                    var confirmResult = MessageBox.Show($"Tem certeza que deseja excluir o ingrediente '{oTipoCozinha.Nome}'?",
                                                         "Confirmação de Exclusão",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question);
                    if (confirmResult == DialogResult.Yes)
                    {
                        TipoCozinha.Excluir(oTipoCozinha.ID);
                        DtG.DataSource = TipoCozinha.SelecionarTodos();
                        LimparCampos();
                    }
                }
            }
        }

        private void FormCadastrarTpCozinha_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMenu oFrm = (FormMenu)this.MdiParent;
            oFrm.cadastroTipoDeCozinhaToolStripMenuItem.Enabled = true;
            oFrm.cadastroTipoDeCozinhaCToolStripMenuItem.Enabled = true;
        }
    }
}
