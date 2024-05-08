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
    public partial class FormCadastroConta : Form
    {
        // modificando o construtor da classe FromCadastroConta para receber as instância do Form1
        private Form1 formPrincipal;
        public FormCadastroConta(Form1 formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();

            comboTipoConta.Items.Add("Conta Corrente");
            comboTipoConta.Items.Add("Conta Poupança");
        }

        public FormCadastroConta()
        {
            InitializeComponent();
        }

        private void botaoCadastro_Click(object sender, EventArgs e)
        {
            //cadastrando uma nova instância de conta

            Conta novaConta = new ContaCorrente(); 
            novaConta.Titular = new Cliente(textoTitularCadastro.Text);
            textoNumero.Text = Convert.ToString(Conta.ProximoNumero()); // -> a conta agora cria o próprio número, então não precisa mais do textoNumero.Text, basta utilizar o método estático

            this.formPrincipal.AdicionaConta(novaConta);

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
