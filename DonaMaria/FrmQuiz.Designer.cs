namespace DonaMaria
{
    partial class FrmQuiz
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            imgFood = new PictureBox();
            btnBrasil = new Button();
            btnItalia = new Button();
            btnJapao = new Button();
            btnArgentina = new Button();
            btnIniciarJogo = new Button();
            score1 = new Label();
            score2 = new Label();
            score4 = new Label();
            score3 = new Label();
            txtTituloAcertos = new Label();
            txtAcertos = new Label();
            btnReiniciar = new Button();
            ((System.ComponentModel.ISupportInitialize)imgFood).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(160, 18);
            label1.Name = "label1";
            label1.Size = new Size(506, 43);
            label1.TabIndex = 0;
            label1.Text = "Adivinhe a origem dessa receita";
            // 
            // imgFood
            // 
            imgFood.InitialImage = null;
            imgFood.Location = new Point(177, 64);
            imgFood.Name = "imgFood";
            imgFood.Size = new Size(448, 217);
            imgFood.SizeMode = PictureBoxSizeMode.Zoom;
            imgFood.TabIndex = 1;
            imgFood.TabStop = false;
            imgFood.Visible = false;
            // 
            // btnBrasil
            // 
            btnBrasil.BackColor = Color.DarkSalmon;
            btnBrasil.FlatAppearance.BorderSize = 0;
            btnBrasil.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBrasil.Location = new Point(110, 287);
            btnBrasil.Name = "btnBrasil";
            btnBrasil.RightToLeft = RightToLeft.No;
            btnBrasil.Size = new Size(180, 61);
            btnBrasil.TabIndex = 2;
            btnBrasil.Text = "Brasil";
            btnBrasil.UseVisualStyleBackColor = false;
            btnBrasil.Visible = false;
            btnBrasil.Click += RespostaSelecionada;
            // 
            // btnItalia
            // 
            btnItalia.BackColor = Color.BlanchedAlmond;
            btnItalia.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnItalia.Location = new Point(110, 354);
            btnItalia.Name = "btnItalia";
            btnItalia.Size = new Size(180, 61);
            btnItalia.TabIndex = 3;
            btnItalia.Text = "Itália";
            btnItalia.UseVisualStyleBackColor = false;
            btnItalia.Visible = false;
            btnItalia.Click += RespostaSelecionada;
            // 
            // btnJapao
            // 
            btnJapao.BackColor = Color.OliveDrab;
            btnJapao.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnJapao.Location = new Point(471, 287);
            btnJapao.Name = "btnJapao";
            btnJapao.Size = new Size(180, 61);
            btnJapao.TabIndex = 4;
            btnJapao.Text = "Japão";
            btnJapao.UseVisualStyleBackColor = false;
            btnJapao.Visible = false;
            btnJapao.Click += RespostaSelecionada;
            // 
            // btnArgentina
            // 
            btnArgentina.BackColor = Color.MediumTurquoise;
            btnArgentina.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnArgentina.Location = new Point(471, 354);
            btnArgentina.Name = "btnArgentina";
            btnArgentina.Size = new Size(180, 61);
            btnArgentina.TabIndex = 5;
            btnArgentina.Text = "Argentina";
            btnArgentina.UseVisualStyleBackColor = false;
            btnArgentina.Visible = false;
            btnArgentina.Click += RespostaSelecionada;
            // 
            // btnIniciarJogo
            // 
            btnIniciarJogo.BackColor = Color.DarkCyan;
            btnIniciarJogo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciarJogo.Location = new Point(303, 174);
            btnIniciarJogo.Name = "btnIniciarJogo";
            btnIniciarJogo.Size = new Size(208, 75);
            btnIniciarJogo.TabIndex = 6;
            btnIniciarJogo.Text = "Iniciar Jogo";
            btnIniciarJogo.UseVisualStyleBackColor = false;
            btnIniciarJogo.Click += btnIniciarJogo_Click;
            // 
            // score1
            // 
            score1.AutoSize = true;
            score1.BackColor = SystemColors.ActiveBorder;
            score1.ForeColor = SystemColors.ActiveCaption;
            score1.Location = new Point(24, 122);
            score1.Name = "score1";
            score1.Size = new Size(16, 15);
            score1.TabIndex = 7;
            score1.Text = "   ";
            score1.Visible = false;
            // 
            // score2
            // 
            score2.AutoSize = true;
            score2.BackColor = SystemColors.ActiveBorder;
            score2.ForeColor = SystemColors.ActiveCaption;
            score2.Location = new Point(46, 122);
            score2.Name = "score2";
            score2.Size = new Size(16, 15);
            score2.TabIndex = 8;
            score2.Text = "   ";
            score2.Visible = false;
            // 
            // score4
            // 
            score4.AutoSize = true;
            score4.BackColor = SystemColors.ActiveBorder;
            score4.ForeColor = SystemColors.ActiveCaption;
            score4.Location = new Point(92, 122);
            score4.Name = "score4";
            score4.Size = new Size(16, 15);
            score4.TabIndex = 10;
            score4.Text = "   ";
            score4.Visible = false;
            // 
            // score3
            // 
            score3.AutoSize = true;
            score3.BackColor = SystemColors.ActiveBorder;
            score3.ForeColor = SystemColors.ActiveCaption;
            score3.Location = new Point(70, 122);
            score3.Name = "score3";
            score3.Size = new Size(16, 15);
            score3.TabIndex = 9;
            score3.Text = "   ";
            score3.Visible = false;
            // 
            // txtTituloAcertos
            // 
            txtTituloAcertos.AutoSize = true;
            txtTituloAcertos.Font = new Font("Impact", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTituloAcertos.ForeColor = Color.Black;
            txtTituloAcertos.Location = new Point(327, 79);
            txtTituloAcertos.Name = "txtTituloAcertos";
            txtTituloAcertos.Size = new Size(145, 43);
            txtTituloAcertos.TabIndex = 11;
            txtTituloAcertos.Text = "Acertos:";
            txtTituloAcertos.Visible = false;
            // 
            // txtAcertos
            // 
            txtAcertos.BackColor = SystemColors.Info;
            txtAcertos.Font = new Font("Impact", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAcertos.ForeColor = Color.Black;
            txtAcertos.Location = new Point(364, 165);
            txtAcertos.MaximumSize = new Size(80, 80);
            txtAcertos.MinimumSize = new Size(80, 80);
            txtAcertos.Name = "txtAcertos";
            txtAcertos.Size = new Size(80, 80);
            txtAcertos.TabIndex = 12;
            txtAcertos.TextAlign = ContentAlignment.MiddleCenter;
            txtAcertos.Visible = false;
            // 
            // btnReiniciar
            // 
            btnReiniciar.BackColor = Color.DarkCyan;
            btnReiniciar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReiniciar.Location = new Point(303, 322);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(208, 75);
            btnReiniciar.TabIndex = 13;
            btnReiniciar.Text = "Reiniciar";
            btnReiniciar.UseVisualStyleBackColor = false;
            btnReiniciar.Visible = false;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // FrmQuiz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReiniciar);
            Controls.Add(txtAcertos);
            Controls.Add(txtTituloAcertos);
            Controls.Add(score4);
            Controls.Add(score3);
            Controls.Add(score2);
            Controls.Add(score1);
            Controls.Add(btnIniciarJogo);
            Controls.Add(btnArgentina);
            Controls.Add(btnJapao);
            Controls.Add(btnItalia);
            Controls.Add(btnBrasil);
            Controls.Add(imgFood);
            Controls.Add(label1);
            Name = "FrmQuiz";
            Text = "Quiz";
            FormClosed += FrmQuiz_FormClosed;
            ((System.ComponentModel.ISupportInitialize)imgFood).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox imgFood;
        private Button btnBrasil;
        private Button btnItalia;
        private Button btnJapao;
        private Button btnArgentina;
        private Button btnIniciarJogo;
        private Label score1;
        private Label score2;
        private Label score4;
        private Label score3;
        private Label txtTituloAcertos;
        private Label txtAcertos;
        private Button btnReiniciar;
    }
}