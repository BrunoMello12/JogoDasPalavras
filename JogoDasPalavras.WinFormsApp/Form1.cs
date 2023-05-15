using System.Text;
using System.Windows.Forms;
using static JogoDasPalavras.WinFormsApp.JogoDasPalavras;

namespace JogoDasPalavras.WinFormsApp
{
    public partial class Form1 : Form
    {
        JogoDasPalavras jogo;
        private Point posicaoLetra;

        public Form1()
        {
            InitializeComponent();

            jogo = new JogoDasPalavras();

            posicaoLetra = new Point(0, 0);

            RegistrarEventos();

            jogo.ObterPalavraSecreta();
        }

        public void RegistrarEventos()
        {
            foreach (Button botao in pnlLetras.Controls)
            {
                botao.Click += DarPalpite;
            }
        }

        public void DarPalpite(Object? sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;

            TextBox textBoxSelecionado = (TextBox)tableLayoutPanel1.GetControlFromPosition(posicaoLetra.Y, posicaoLetra.X);

            if (posicaoLetra.Y < tableLayoutPanel1.ColumnCount)
            {
                textBoxSelecionado.Text = botaoClicado.Text;
                posicaoLetra.Y++;
            }

        }

        private void button27_Click(object sender, EventArgs e)
        {
            StringBuilder palavra = new StringBuilder();

            for (int i = 0; i < tableLayoutPanel1.ColumnCount; i++)
            {

                TextBox textBoxSelecionado = (TextBox)tableLayoutPanel1.GetControlFromPosition(i, posicaoLetra.X);

                palavra.Append(textBoxSelecionado.Text);

                VerificarCor cor = VerificarCorExtensions.FromColor(jogo.AvaliarLetra(textBoxSelecionado.Text[0], i));

                switch (cor)
                {
                    case VerificarCor.Green:
                        textBoxSelecionado.BackColor = Color.Green;
                        break;
                    case VerificarCor.Yellow:
                        textBoxSelecionado.BackColor = Color.Yellow;
                        break;
                    case VerificarCor.Red:
                        textBoxSelecionado.BackColor = Color.Red;
                        break;
                }
            }


        }
    }
}