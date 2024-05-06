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
        private Conta[] contas; 

        private int numeroDeContas; // atributo que será utilizado para saber o numero de contas existentes

        //private ContaPoupanca contaPoupanca;
        //private ContaCorrente contaCorrente;


        // adicionando um método para adiocionar a conta cadastrada no FromCadastroConta
        public void AdicionaConta(Conta conta)
        {
            this.contas[this.numeroDeContas] = conta;
            this.numeroDeContas++;
            comboContas.Items.Add(conta.Titular.Nome); //adicionando no comboBox
        }

        public Form1()
        {
            InitializeComponent();
    }

        private void Form1_Load(object sender, EventArgs e)
        {
            // O this.c cria uma nova conta e guarda sua referência no atributo do formulário que está acima
            this.contas = new Conta[3]; // instânciando um array de contas
            //this.contaPoupanca = new ContaPoupanca();
            //this.contaCorrente = new ContaCorrente(); // para utilizar o conta corrente, basta substituir tudo que tem contaPoupanca, pois ambos herdam de conta, logo tem os mesmos atributos

            TotalizadorDeContas t = new TotalizadorDeContas();


            /*
            ---- Primeira inicialização sem a utilização de array ----

            contaCorrente.Numero = 1;
            Cliente cliente = new Cliente("Victor");
            contaCorrente.Titular = cliente;

            cliente.Idade = 20;
            */

            //Inicializando contas com array
            this.contas[0] = new Conta();
            this.contas[0].Titular = new Cliente("victor");
            this.contas[0].Numero = 1;

            this.contas[1] = new ContaPoupanca();
            this.contas[1].Titular = new Cliente("mauricio");
            this.contas[1].Numero = 2;

            this.contas[2] = new ContaCorrente();
            this.contas[2].Titular = new Cliente("osni");
            this.contas[2].Numero = 3;

            // Para mudar o texto que aparece no textbox basta: nomeObjeto.Text = <o texto que quer>
            // textoTitular.Text = contas[indice].Titular.Nome;

            // Utilizando a classe convert para mudar numero e saldo para string
            //textoNumero.Text = Convert.ToString(contaCorrente.Numero);
            // textoSaldo.Text = Convert.ToString(contaCorrente.Saldo);

            /*
            ---- Transformando saldo e número em string sem a classe convert ----
          
            textoNumero.Text = c.Numero.ToString();
            textoNumero.Text = c.Saldo.ToString();
            */

            /*
             ---- O código não funciona pois o tipo de uma variável não pode ser trocado, ele é inferido ao declarar a variável ----

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

            // comboContas.Items.Add("Texto que aparecerá no combo box"); -> adiona itens ao comboBox

            foreach (Conta conta in contas)
            {
                comboContas.Items.Add(conta.Titular.Nome);
            }

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
            int indice = Convert.ToInt32(comboContas.SelectedIndex); //o indice escolhido serve para saber de qual elemento do array queremos pegar os dados

            Conta selecionada = this.contas[indice]; // a variável existe para armazenar os dados da conta do indice escolhido

            // Diferente de string, para converter uma string para um double/int precisa-se utilizar a classe convert
            double valor = Convert.ToDouble(valorDigitado);
            selecionada.Deposita(valor);

            // Atualização do saldo no formulário
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
            MessageBox.Show("Sucesso!");
        }

        private void botaoSaque_Click(object sender, EventArgs e)
        {
            int indice = Convert.ToInt32(comboContas.SelectedIndex);
            Conta selecionada = this.contas[indice];

            string valorDigitado = textoValor.Text;
            double valor = Convert.ToDouble(valorDigitado);
       
            selecionada.Saca(valor);

            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
            MessageBox.Show("Sucesso!");
          
        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex; // o SelectedIndex serve para recuperar o índice selecionado pelo usuário
            Conta selecionada = contas[indice];

            textoTitular.Text = selecionada.Titular.Nome;
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
            textoNumero.Text = Convert.ToString(selecionada.Numero);
        }
    }
}
