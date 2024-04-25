using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Condicoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idade = 18;
            bool brasileira = true;

            if(idade > 16 && brasileira == true)
            {
                MessageBox.Show("Essa pessoa está apta para votar");
            }
            else
            {
                MessageBox.Show("Essa não pessoa está apta para votar");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double valorDaNotaFiscal = 7000.0, imposto;

            if(valorDaNotaFiscal <= 999)
            {
                imposto = 0.02;
                MessageBox.Show("Imposto = "+imposto*100+"%");
            } 
            else if(valorDaNotaFiscal>999 && valorDaNotaFiscal <= 2999)
            {
                imposto = 0.025;
                MessageBox.Show("Imposto = " + imposto * 100 + "%");
            }
            else if(valorDaNotaFiscal>2999 && valorDaNotaFiscal <= 6999)
            {
                imposto = 0.028;
                MessageBox.Show("Imposto = " + imposto * 100 + "%");
            }
            else
            {
                imposto = 0.03;
                MessageBox.Show("Imposto = " + imposto * 100 + "%");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int valor = 5;
            //int x;

            MessageBox.Show(valor > 10 ? "Maior que 10" : "Menor que 10");

            //x = valor > 10 ? valor + 5 : valor - 10; - outro exemplo utilizando o operador ternário
        }
    }
}
