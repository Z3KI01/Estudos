using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculadora3
{


    public partial class Calculadora : Form
    {
        public decimal Resultado { get; set; }
        public decimal Valor { get; set; }


        private Operacao OperacaoSelecionada { get; set; }
        enum Operacao
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao,
            Nenhuma
        }
        public Calculadora()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {
            txtResultado.Height = 100;
            txtResultado.TextAlign = HorizontalAlignment.Right;
            txtResultado.Top = 35;

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
            txtConta.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
            txtConta.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
            txtConta.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
            txtConta.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
            txtConta.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
            txtConta.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
            txtConta.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
            txtConta.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
            txtConta.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
            txtConta.Text += "9";
        }


        private void btnSoma_Click(object sender, EventArgs e)
        {
            if (txtResultado.TextLength > 0)
            {
                OperacaoSelecionada = Operacao.Adicao;
                Valor = Convert.ToDecimal(txtResultado.Text);
                txtResultado.Text = "";
                txtConta.Text += "+";
            }

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (txtResultado.TextLength > 0)
            {
                OperacaoSelecionada = Operacao.Subtracao;
                Valor = Convert.ToDecimal(txtResultado.Text);
                txtResultado.Text = "";
                txtConta.Text += "-";
            }

        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            if (txtResultado.TextLength > 0)
            {
                OperacaoSelecionada = Operacao.Multiplicacao;
                Valor = Convert.ToDecimal(txtResultado.Text);
                txtResultado.Text = "";
                txtConta.Text += "*";
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (txtResultado.TextLength > 0)
            {
                OperacaoSelecionada = Operacao.Divisao;
                Valor = Convert.ToDecimal(txtResultado.Text);
                txtResultado.Text = "";
                txtConta.Text += "/";
            }

        }



        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (txtResultado.TextLength > 0)
            {

                switch (OperacaoSelecionada)
                {
                    case Operacao.Adicao:
                        Resultado = Valor + Convert.ToDecimal(txtResultado.Text);
                        break;
                    case Operacao.Subtracao:
                        Resultado = Valor - Convert.ToDecimal(txtResultado.Text);
                        break;
                    case Operacao.Multiplicacao:
                        Resultado = Valor * Convert.ToDecimal(txtResultado.Text);
                        break;
                    case Operacao.Divisao:
                        decimal valorAtual = Convert.ToDecimal(txtResultado.Text);
                        if (valorAtual == 0)
                        {
                            txtResultado.Text = "Ta burro?";
                            return;
                        }
                        break;

                }

                txtConta.Text += "=";
                txtResultado.Text = Convert.ToString(Resultado);
            }
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains(","))
            {
                txtResultado.Text += ",";
                txtConta.Text += ",";
            }
            else if (txtResultado.Text == ",")
            {
                txtResultado.Text = "0,";
                txtConta.Text = "0,";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            txtResultado.Text = "";
            txtConta.Text = "";
            Valor = 0;
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void txtConta_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
