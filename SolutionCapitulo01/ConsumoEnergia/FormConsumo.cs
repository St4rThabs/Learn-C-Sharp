using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsumoEnergia
{
    public partial class FormConsumo : Form
    {
        private IList<Leitura> leituras = new BindingList<Leitura>();
        private BindingSource leituraSource = new BindingSource();

        public FormConsumo()
        {
            InitializeComponent();
            leituraSource.DataSource = leituras;
            dgvLeituras.DataSource = leituraSource;
        }
        private void RegistraConsumo(string casa, double consumo)
        {
            Leitura leitura = new Leitura(casa, consumo);
            if (leituras.Contains(leitura))
            {
                MessageBox.Show("A leitura para esta casa já foi registrada", "Alerta",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            else
            {
                this.leituras.Add(leitura);
                InicializaFormulario();
            }
        }

        private void InicializaFormulario()
        {
            txtCasa.Clear();
            txtConsumo.Clear();
            txtCasa.Focus();
        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            ProcessarLeituras(dgvLeituras);
        }

        private void ProcessarLeituras(DataGridView dgv)
        {
            DataGridViewCell cell = dgvLeituras.Rows[0].Cells[0];
            this.leituras.Add(new Leitura("Total", 0));

            for (int i = 0; i < 3; i++)
            {
                dgv.Rows[dgvLeituras.Rows.Count - 1].Cells[i].Style.BackColor = Color.Blue;
                dgv.Rows[dgvLeituras.Rows.Count - 1].Cells[i].Style.ForeColor = Color.Yellow;
                dgv.Rows[dgvLeituras.Rows.Count - 1].Cells[i].Style.Font = new Font(cell.InheritedStyle.Font, FontStyle.Bold);
            }
            double totalConsumo = 0, totalDesconto = 0;

            foreach (var leitura in leituras)
            {
                totalConsumo += leitura.Consumo;
                totalDesconto += leitura.Desconto;
            }

            dgv[0, dgv.Rows.Count - 1].Value = "Total";
            dgv[1, dgv.Rows.Count - 1].Value = totalConsumo.ToString("N");
            dgv[2, dgv.Rows.Count - 1].Value = totalDesconto.ToString("N");
            lblResultado.Text = "Total consumo sem desconto: " + (totalConsumo - totalDesconto).ToString("N");
        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            RegistraConsumo(txtCasa.Text,
            Convert.ToDouble(txtConsumo.Text));
        }
    }
}

class Leitura
{
    public string Casa { get; set; }
    public double Consumo { get; set; }
    public double Desconto
    {
        get { return Consumo * 0.20; }
    }
    public Leitura(string casa, double consumo)
    {
        this.Casa = casa;
        this.Consumo = consumo;
    }
    public override bool Equals(Object l)
    {
        Leitura leitura = l as Leitura;
        if (leitura == null)
            return false;
        return (Casa.Equals(leitura.Casa));
    }
    public override int GetHashCode()
    {
        return new { Casa, Consumo }.GetHashCode();
    }
}



