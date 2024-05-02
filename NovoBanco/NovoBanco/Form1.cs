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
        private Conta conta;
        private ContaPoupanca contaPoupanca;
        private ContaCorrente contaCorrente;
        public Form1()
        {
            InitializeComponent();
    }

        private void Form1_Load(object sender, EventArgs e)
        {
            // O this.c cria uma nova conta e guarda sua referência no atributo do formulário que está acima
            this.conta = new Conta();
            this.contaPoupanca = new ContaPoupanca();
            this.contaCorrente = new ContaCorrente(); // para utilizar o conta corrente, basta substituir tudo que tem contaPoupanca, pois ambos herdam de conta, logo tem os mesmos atributos
            TotalizadorDeContas t = new TotalizadorDeContas();

            contaCorrente.Numero = 1;
            Cliente cliente = new Cliente("Victor");
            contaCorrente.Titular = cliente;

            cliente.Idade = 20;

            // Para mudar o texto que aparece no textbox basta: nomeObjeto.Text = <o texto que quer>
            textoTitular.Text = contaCorrente.Titular.Nome;

            // Utilizando a classe convert para mudar numero e saldo para string
            textoNumero.Text = Convert.ToString(contaCorrente.Numero);
            textoSaldo.Text = Convert.ToString(contaCorrente.Saldo);

            /*
            Transformando saldo e número em string sem a classe convert
          
            textoNumero.Text = c.Numero.ToString();
            textoNumero.Text = c.Saldo.ToString();
            */

            /*
            O código não funciona pois o tipo de uma variável não pode ser trocado, ele é inferido ao declarar a variável

            var simples = new Conta(); // linha 1
            simples = new Conta(); // linha 2
            simples = new Cliente("Victoria"); // linha 3
            */

            //Criação de duas contas para ver se vai somar os saldos por mais que sejam de classes diferentes
            
            Conta c1 = new Conta();
            ContaPoupanca c2 = new ContaPoupanca();

            c1.Deposita(100.0);
            c2.Deposita(50.0);

            t.Soma(c1);
            t.Soma(c2); //funcionou!

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

        private void botaoDeposito_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValor.Text;

            // Diferente de string, para converter uma string para um double/int precisa-se utilizar a classe convert
            double valor = Convert.ToDouble(valorDigitado);
            contaCorrente.Deposita(valor);

            // Atualização do saldo no formulário
            textoSaldo.Text = Convert.ToString(this.contaCorrente.Saldo);
            MessageBox.Show("Sucesso!");
        }

        private void botaoSaque_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValor.Text;
            double valor = Convert.ToDouble(valorDigitado);

            this.contaCorrente.Saca(valor);

            textoSaldo.Text = Convert.ToString(this.contaCorrente.Saldo);
            MessageBox.Show("Sucesso!");
          
        }
    }
}
