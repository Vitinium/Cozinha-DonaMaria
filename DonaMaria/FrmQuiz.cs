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
    public partial class FrmQuiz : Form
    {
        string respostaCorreta;
        int numeroPergunta = 1;
        int acertos = 0;

        public FrmQuiz()
        {
            InitializeComponent();

        }

        private void MudarVisibilidadeElementos()
        {
            btnBrasil.Visible = !btnBrasil.Visible;
            btnJapao.Visible = !btnJapao.Visible;

            btnItalia.Visible = !btnItalia.Visible;
            btnArgentina.Visible = !btnArgentina.Visible;

            imgFood.Visible = !imgFood.Visible;

            score1.Visible = !score1.Visible;
            score2.Visible = !score2.Visible;
            score3.Visible = !score3.Visible;
            score4.Visible = !score4.Visible;
        }



        private void btnIniciarJogo_Click(object sender, EventArgs e)
        {
            MudarVisibilidadeElementos();
            btnIniciarJogo.Visible = !btnIniciarJogo.Visible;

            MostrarPergunta();

        }

        private void RespostaSelecionada(object sender, EventArgs e)
        {
            Button btnApertado = (Button)sender;

            if (respostaCorreta == btnApertado.Text)
            {
                PreencherScore(true);
                acertos++;
            }
            else
            {
                PreencherScore(false);
            }

            numeroPergunta++;
            MostrarPergunta();
        }

        private void PreencherScore(bool respostaCorreta)
        {
            Color cor = respostaCorreta ? Color.Green : Color.Red;

            switch (numeroPergunta)
            {
                case 1:
                    score1.BackColor = cor;
                    break;

                case 2:
                    score2.BackColor = cor;
                    break;

                case 3:
                    score3.BackColor = cor;
                    break;

                case 4:
                    score4.BackColor = cor;
                    break;
            }
        }

        private void MostrarPergunta()
        {
            switch (numeroPergunta)
            {
                case 1:
                    imgFood.Image = Properties.Resources.brigadeiro;
                    respostaCorreta = "Brasil";
                    break;

                case 2:
                    imgFood.Image = Properties.Resources.macarrao;
                    respostaCorreta = "Itália";
                    break;

                case 3:
                    imgFood.Image = Properties.Resources.churrasco;
                    respostaCorreta = "Argentina";
                    break;

                case 4:
                    imgFood.Image = Properties.Resources.sushi;
                    respostaCorreta = "Japão";
                    break;

                case 5: // Finalizar Quiz
                    MudarVisibilidadeElementos();
                    MostrarTelaFinal();
                    break;
            }
        }

        private void MostrarTelaFinal()
        {
            txtTituloAcertos.Visible = !txtTituloAcertos.Visible;
            txtAcertos.Visible = !txtAcertos.Visible;

            btnReiniciar.Visible = !btnReiniciar.Visible;

            txtAcertos.Text = acertos.ToString();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void FrmQuiz_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMenu oFrm = (FormMenu)this.MdiParent;
            oFrm.quizSobreAMatériaToolStripMenuItem.Enabled = true;
            oFrm.quizToolStripMenuItem.Enabled = true;
        }
    }
}