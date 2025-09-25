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
    public partial class FormDetalhesReceita : Form
    {
        private Receita receitaParaExibir;
        public FormDetalhesReceita(Model.Receita receitaSelecionada)
        {
            InitializeComponent();
            this.receitaParaExibir = receitaSelecionada;

        }

        private void FormDetalhesReceita_Load(object sender, EventArgs e)
        {
            if (receitaParaExibir != null)
            {
                // Preenche os campos de texto/labels
                txtID.Text = receitaParaExibir.ID.ToString();
                txtNome.Text = receitaParaExibir.Nome;
                txtModoPreparo.Text = receitaParaExibir.ModoPreparo;
                txtTpCozinha.Text = receitaParaExibir.TipoCozinha?.Nome;

                // Preenche o grid com a lista de ingredientes da receita
                Dtg.AutoGenerateColumns = false;
                Dtg.DataSource = receitaParaExibir.Ingredientes;
            }
        }

    }
}
