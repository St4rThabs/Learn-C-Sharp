namespace TrocaDeValores
{
    public partial class frmTrocaDeValores : Form
    {
        public frmTrocaDeValores()
        {
            InitializeComponent();
        }

        private void botaoTrocar_Click(object sender, EventArgs e)
        {
            string auxiliar = txtPrimeiroValor.Text; ;
            txtPrimeiroValor.Text = txtSegundoValor.Text;
            txtSegundoValor.Text = auxiliar;
            MessageBox.Show("Troca de valores concluída", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
