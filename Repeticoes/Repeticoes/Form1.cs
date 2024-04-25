using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Repeticoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valorInvestido = 1000.0;
            int i = 1;
            while (i <= 12)
            {
                valorInvestido = valorInvestido * 1.01;
                i += 1;
            }

            MessageBox.Show("Valor investido agora é " + valorInvestido);

            /*
                for(int i = 1; i<=12; i += 1)
                {
                    valorInvestido = valorInvestido * 1.01;
                }
                MessageBox.Show("Valor investido agora é " + valorInvestido);
            */

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int total = 2;

            for (int i = 0; i < 5; i += 1)
            {
                total = total * 2;
            }
            MessageBox.Show("O total é: " + total);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < 1000; i++)
            {
                i++;
            }
            MessageBox.Show("" + i);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    MessageBox.Show("" + i);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int soma = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 != 0)
                {
                    soma += i;
                }
            }
            MessageBox.Show("A soma é " + soma);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 30; i++)
            {
                if (i % 3 == 0 || i % 4 == 0)
                {
                    MessageBox.Show("" + i);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int fatorial = 1;

            for (int n = 1; n <= 10; n++)
            {
                fatorial = fatorial * n;
                MessageBox.Show("O fatorial de " + n + " é (" + (n - 1) + "!) * " + n + " = " + fatorial);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int x = 0, y = 1, z;
            for (int i = 0; i <= 10; i++)
            {
                z = x + y;
                MessageBox.Show("" + z);
                x = y;
                y = z;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int num = 4;

            string mensagem = "";

            for (int linha = 1; linha <= num; linha++)
            {
                mensagem += "\n";

                for (int coluna = 1; coluna <= linha; coluna++)
                {
                    mensagem += linha * coluna + " ";
                }
            }

            MessageBox.Show(mensagem);
        }
    }
}
