using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
             *  -- Primeira implementação da classe Conta -- 
             *  
            Conta c = new Conta();
            c.numero = 1;
            c.titular = "maria";
            c.saldo = 100.0;

            if (c.Saca(100.0)){
                MessageBox.Show("Saque realizado com sucesso!");
            } else
            {
                MessageBox.Show("Saldo insuficiente");
            }+
            */

            /* -- Teste dos métodos transfere e deposita --
             * 
             * Conta victor = new Conta();
            Conta guilherme = new Conta();

            victor.Deposita(200.0);

            MessageBox.Show(victor.saldo.ToString());

            victor.Transfere(10.0, guilherme);
            MessageBox.Show(victor.saldo.ToString());
            MessageBox.Show(victor.titular);
            */

            /* -- Verificação se duas contas são iguais --
            
            Conta mauricio = new Conta();
            mauricio.numero = 1;
            mauricio.titular = "Mauricio";
            mauricio.saldo = 100.0;

            Conta mauricio2 = new Conta();
            mauricio2.numero = 1;
            mauricio2.titular = "Mauricio";
            mauricio2.saldo = 100.0;

            if (mauricio == mauricio2)
            {
                MessageBox.Show("As contas são iguais");
            }
            else
            {
                MessageBox.Show("As contas são diferentes");
            }
            */

            // 
            /*
            Conta mauricio = new Conta();
            mauricio.saldo = 2000.0;
            Conta copia = mauricio;
            copia.saldo = 3000.0;
            MessageBox.Show("mauricio = " + mauricio.saldo);
            MessageBox.Show("copia = " + copia.saldo);
            */

            Conta umaConta = new Conta();
            Cliente maria = new Cliente();

            //maria.nome = "Maria";
            maria.Idade = 10;

            umaConta.Numero = 2;
            umaConta.Titular = maria;
            umaConta.Saldo = 3000.0;
            umaConta.Idade = maria.Idade;

            // Outra forma de atribuição de variável
            umaConta.Titular.Nome = "Maria";
            umaConta.Titular.Rg = "12345678-9";

            /* 
              ---- Conta Guilherme ----

            Conta umaConta1 = new Conta();
            Cliente guilherme = new Cliente();
            guilherme.rg = "12345678-9";
            umaConta1.titular = guilherme;
            umaConta1.titular.rg = "98765432-1";
            MessageBox.Show(guilherme.rg);
            */

            // Implementação de gets e sets

            MessageBox.Show(umaConta.Titular.Nome);
            MessageBox.Show(maria.Rg);

            string mensagem = "Titular = " + umaConta.Titular + "\nIdade = " + umaConta.Idade + "\nSaldo = " + umaConta.Saldo + "\nMaior de Idade = "+maria.EhMaiorDeIdade();
            MessageBox.Show(mensagem);
            MessageBox.Show(umaConta.Saca(300.0).ToString());
            MessageBox.Show("Saldo atual = " + umaConta.Saldo.ToString());
        }
    }
}
