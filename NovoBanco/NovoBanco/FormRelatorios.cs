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
                                   select new { c.Titular.Nome, c.Numero, c.Saldo };

            foreach (var c in maiorQueCincoMil)
            {
                listaResultado.Items.Add(c);
            }
        }

        private void botaoAntigas_Click(object sender, EventArgs e)
        {
            listaResultado.Items.Clear();
            var antigas = from c in contas
                          where c.Saldo > 1000 && c.Numero < 10
                          select new { c.Titular.Nome, c.Numero, c.Saldo };

            foreach (var c in antigas)
            {
                listaResultado.Items.Add(c);
            }

        }
    }
}
