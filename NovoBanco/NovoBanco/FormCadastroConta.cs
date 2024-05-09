using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NovoBanco.Contas;

namespace NovoBanco
{
    public partial class FormCadastroConta : Form
    {
        // modificando o construtor da classe FromCadastroConta para receber as instância do Form1
        private Form1 formPrincipal;
        private Conta novaConta;
        
        public FormCadastroConta(Form1 formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();

            comboTipoConta.Items.Add("Conta Corrente");
            comboTipoConta.Items.Add("Conta Poupança");
            comboTipoConta.Items.Add("Conta Investimento");
        }

        public FormCadastroConta()
        {
            InitializeComponent();
        }

        private void botaoCadastro_Click(object sender, EventArgs e)
        {
            // cadastrando uma nova instância de conta
            int indice = comboTipoConta.SelectedIndex;

            // com o switch case verifica qual o tipo de conta que selecionou para criar uma nova conta
            switch (indice)
            {
                case 0:
                    this.novaConta = new ContaCorrente();
                    novaConta.Titular = new Cliente(textoTitularCadastro.Text);
                    textoNumero.Text = Convert.ToString(Conta.ProximoNumero()); // -> a conta agora cria o próprio número, então não precisa mais do textoNumero.Text, basta utilizar o método estático

                    this.formPrincipal.AdicionaConta(novaConta);
                    break;
                case 1:
                    this.novaConta = new ContaPoupanca();
                    novaConta.Titular = new Cliente(textoTitularCadastro.Text);
                    textoNumero.Text = Convert.ToString(Conta.ProximoNumero()); 

                    this.formPrincipal.AdicionaConta(novaConta);
                    break;
                case 2:
                    this.novaConta = new ContaInvestimento();
                    novaConta.Titular = new Cliente(textoTitularCadastro.Text);
                    textoNumero.Text = Convert.ToString(Conta.ProximoNumero());

                    this.formPrincipal.AdicionaConta(novaConta);
                    break;
                default:
                    MessageBox.Show("Selecione o tipo de conta");
                    break;

            }

        }

        private void pbxConta_Click(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void textoTitularCadastro_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboTipoConta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textoNumero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
