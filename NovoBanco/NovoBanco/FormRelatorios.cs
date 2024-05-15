using NovoBanco.Contas;
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
    public partial class FormRelatorios : Form
    {
        private List<Conta> contas;

        public FormRelatorios(List<Conta> contas)
        {
            this.contas = contas;
            InitializeComponent();
        }

        private void botaoFiltroSaldo_Click(object sender, EventArgs e)
        {
            listaResultado.Items.Clear();
            var maiorQueCincoMil = from c in contas
                                   where c.Saldo > 5000
                                   orderby c.Titular.Nome, c.Numero
                                   select new { c.Titular.Nome, c.Numero, c.Saldo }; // buscando utilizando a sintaxe de queries e devolvendo um objeto anônimo 

            foreach (var c in maiorQueCincoMil)
            {
                listaResultado.Items.Add(c); // mostrando o objeto anônimo
            }
        }

        private void botaoAntigas_Click(object sender, EventArgs e)
        {
            listaResultado.Items.Clear();
            var antigas = contas.Where(c => c.Saldo > 1000 && c.Numero < 10)
                                .OrderBy(c => c.Titular.Nome)
                                .Select(c => new { c.Titular.Nome, c.Numero, c.Saldo });

            foreach (var c in antigas)
            {
                listaResultado.Items.Add(c);
            }

        }

        private void botaoMedia_Click(object sender, EventArgs e)
        {
            listaResultado.Items.Clear();
            var media = contas.Average(c => c.Saldo); // utilizando lambda e o método average do linq para pegar a média de saldos

            listaResultado.Items.Add("Média = " + Math.Round(media, 2));

            var saldoTotal = contas.Sum(c => c.Saldo);
            var maiorSaldo = contas.Max(c => c.Saldo);

            labelSaldoTotal.Text = Convert.ToString(saldoTotal); // atualizando a label para mostrar o saldo total
            labelMaiorSaldo.Text = Convert.ToString(maiorSaldo); // atualizando a label para mostrar o maior saldo
        }
    }
}
