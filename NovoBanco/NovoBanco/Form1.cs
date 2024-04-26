using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovoBanco
{
    public partial class Form1 : Form
    {
        // Para ser utilizada em vários métodos declaramos o atributo de referência aqui
        private Conta c;
        public Form1()
        {
            InitializeComponent();
    }

        private void Form1_Load(object sender, EventArgs e)
        {
            // O this.c cria uma nova conta e guarda sua referência no atributo do formulário que está acima
            this.c = new Conta();

            c.Numero = 1;
            Cliente cliente = new Cliente("victor");
            c.Titular = cliente;

            // Para mudar o texto que aparece no textbox basta: nomeObjeto.Text = <o texto que quer>
            textoTitular.Text = c.Titular.Nome;

            // Utilizando a classe convert para mudar numero e saldo para string
            textoNumero.Text = Convert.ToString(c.Numero);
            textoSaldo.Text = Convert.ToString(c.Saldo);

            /*
            Transformando saldo e número em string sem a classe convert
          
            textoNumero.Text = c.Numero.ToString();
            textoNumero.Text = c.Saldo.ToString();
            */

        }

        private void textoTitular_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textoNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void textoSaldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textoValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void Deposita_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValor.Text;

            // Diferente de string, para converter uma string para um double/int precisa-se utilizar a classe convert
            double valorOperacao = Convert.ToDouble(valorDigitado);
            c.Deposita(valorOperacao);

            // Atualização do saldo no formulário
            textoSaldo.Text = Convert.ToString(this.c.Saldo);
            MessageBox.Show("Sucesso!");
        }

        private void botaoSaque_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);

            this.c.Saca(valorOperacao);

            textoSaldo.Text = Convert.ToString(this.c.Saldo);
            MessageBox.Show("Sucesso");
        }
    }
}
