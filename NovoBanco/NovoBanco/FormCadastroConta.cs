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
using NovoBanco.Busca;

namespace NovoBanco
{
    public partial class FormCadastroConta : Form
    {
        private ICollection<string> devedores;
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

            GeradorDeDevedores gerador = new GeradorDeDevedores();
            this.devedores = gerador.GeraList();
        }

        public FormCadastroConta()
        {
            InitializeComponent();
        }

        private void botaoCadastro_Click(object sender, EventArgs e)
        {
            // cadastrando uma nova instância de conta
            int indice = comboTipoConta.SelectedIndex;

            // verificando se o titular inserido é devedor ou não
            string titular = textoTitular.Text;
            bool ehDevedor = this.devedores.Contains(titular);

            // com o switch case verifica qual o tipo de conta que selecionou para criar uma nova conta
            switch (indice)
            {
                case 0:
                    if (!ehDevedor)
                    {
                        this.novaConta = new ContaCorrente();
                        novaConta.Titular = new Cliente(textoTitularCadastro.Text);
                        textoNumero.Text = Convert.ToString(Conta.ProximoNumero()); // -> a conta agora cria o próprio número, então não precisa mais do textoNumero.Text, basta utilizar o método estático

                        this.formPrincipal.AdicionaConta(novaConta);
                    } else
                    {
                        MessageBox.Show("devedor");
                    }

                    break;
                case 1:
                    if (!ehDevedor)
                    {
                        this.novaConta = new ContaInvestimento();
                        novaConta.Titular = new Cliente(textoTitularCadastro.Text);
                        textoNumero.Text = Convert.ToString(Conta.ProximoNumero()); // -> a conta agora cria o próprio número, então não precisa mais do textoNumero.Text, basta utilizar o método estático

                        this.formPrincipal.AdicionaConta(novaConta);
                    }
                    else
                    {
                        MessageBox.Show("devedor");
                    }
                    break;
                case 2:
                    if (!ehDevedor)
                    {
                        this.novaConta = new ContaInvestimento();
                        novaConta.Titular = new Cliente(textoTitularCadastro.Text);
                        textoNumero.Text = Convert.ToString(Conta.ProximoNumero()); // -> a conta agora cria o próprio número, então não precisa mais do textoNumero.Text, basta utilizar o método estático

                        this.formPrincipal.AdicionaConta(novaConta);
                    }
                    else
                    {
                        MessageBox.Show("devedor");
                    }
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
