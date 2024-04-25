using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OiMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double saldo = 100.0;
            double valorDoSaque = 10.0;
            

            if (saldo >= valorDoSaque)
            {
                saldo -= valorDoSaque;
                MessageBox.Show("Saque realizado com sucesso!");
            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }
            
            //comentário de linha

            /* comentário 
             * de
             * bloco
             */

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idade1 = 19;
            int idade2 = 22;
            int idade3 = 25;

            MessageBox.Show("Média de idades: "+((idade1 + idade2 + idade3) / 3));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double pi = 3.14;
            int piQuebrado = (int)pi;

            MessageBox.Show("piQuebrado = " + piQuebrado);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = 4; 
            int b = -10; 
            int c = 2;

            double delta, a1, a2;

            delta = b * b - 4 * a * c;
            a1 = (-b + Math.Sqrt(delta)) / (2 * a);
            a2 = (-b - Math.Sqrt(delta)) / (2 * a);

            MessageBox.Show("a1 = " + a1 + "\na2 = " + a2);
        }
    }
}
