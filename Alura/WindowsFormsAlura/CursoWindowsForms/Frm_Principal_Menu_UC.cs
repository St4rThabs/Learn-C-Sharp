using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_Principal_Menu_UC : Form
    {
        int ControleHelloWorld = 0, ControleDemonstracaoKey = 0, ControleMascara = 0, ControleValidaCPF = 0, ControleValidaCPF2 = 0, ControleValidaSenha = 0;
        int ControleArquivoImagem = 0;

        public Frm_Principal_Menu_UC()
        {
            InitializeComponent();

            novoToolStripMenuItem.Enabled = false;
            apagarAbaToolStripMenuItem.Enabled = false;
            abrirImagemToolStripMenuItem.Enabled = false;
            desconectarToolStripMenuItem.Enabled = false;
        }

        private void demonstraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleDemonstracaoKey += 1;
            Frm_DemonstracaoKey_UC U = new Frm_DemonstracaoKey_UC();
            TabPage TB = new TabPage();
            U.Dock = DockStyle.Fill;
            TB.Name = "Demonstração Key " + ControleDemonstracaoKey;
            TB.Text = "Demonstração Key " + ControleDemonstracaoKey;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void helloWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleHelloWorld += 1;
            Frm_HelloWorld_UC U = new Frm_HelloWorld_UC();
            TabPage TB = new TabPage();
            U.Dock = DockStyle.Fill;
            TB.Name = "Hello World " + ControleHelloWorld;
            TB.Text = "Hello World " + ControleHelloWorld;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void máscaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleMascara += 1;
            Frm_Mascara_UC U = new Frm_Mascara_UC();
            TabPage TB = new TabPage();
            U.Dock = DockStyle.Fill;
            TB.Name = "Máscara " + ControleMascara;
            TB.Text = "Máscara " + ControleMascara;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void abrirImagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog Db = new OpenFileDialog();
            Db.InitialDirectory = (Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Imagens"));
            Db.Filter = "PNG |*.PNG";
            Db.Title = "Escolha a Imagem";

            if (Db.ShowDialog() == DialogResult.OK)
            {
                string nomeArquivoImagem = Db.FileName;

                ControleArquivoImagem += 1;
                Frm_ArquivoImagem_UC U = new Frm_ArquivoImagem_UC(nomeArquivoImagem);
                TabPage TB = new TabPage();
                U.Dock = DockStyle.Fill;
                TB.Name = "Abrir Imagem " + ControleArquivoImagem;
                TB.Text = "Abrir Imagem " + ControleArquivoImagem;
                TB.Controls.Add(U);
                Tbc_Aplicacoes.TabPages.Add(TB);
            }

        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Login F = new Frm_Login();
            F.ShowDialog();

            if (F.DialogResult == DialogResult.OK)
            {
                string senha = F.senha;
                string login = F.login;

                if (CursoWindowsFormsBiblioteca.Cls_Uteis.ValidaSenhaLogin(senha) == true)
                {
                    novoToolStripMenuItem.Enabled = true;
                    apagarAbaToolStripMenuItem.Enabled = true;
                    abrirImagemToolStripMenuItem.Enabled = true;
                    desconectarToolStripMenuItem.Enabled = true;
                    conectarToolStripMenuItem.Enabled = false;

                    MessageBox.Show("Bem vindo " + login + "!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Senha Inválida", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Questao Dd = new Frm_Questao("icons8-ponto-de-interrogação-100", "Você deseja se desconectar?");
            Dd.ShowDialog();

            // if (MessageBox.Show("Você deseja realmente validar o CPF?", "Mensagem de Validação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            if (Dd.DialogResult == DialogResult.Yes)
            {
                for (int i = Tbc_Aplicacoes.TabPages.Count - 1; i >= 0; i--)
                {
                    Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.TabPages[i]);
                }

                novoToolStripMenuItem.Enabled = false;
                apagarAbaToolStripMenuItem.Enabled = false;
                abrirImagemToolStripMenuItem.Enabled = false;
                desconectarToolStripMenuItem.Enabled = false;
                conectarToolStripMenuItem.Enabled = true;
            }
            
        }

        private void validaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleValidaCPF += 1;
            Frm_ValidaCPF_UC U = new Frm_ValidaCPF_UC();
            TabPage TB = new TabPage();
            U.Dock = DockStyle.Fill;
            TB.Name = "Valída CPF " + ControleValidaCPF;
            TB.Text = "Valída CPF " + ControleValidaCPF;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void validaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleValidaCPF2 += 1;
            Frm_ValidaCPF2_UC U = new Frm_ValidaCPF2_UC();
            TabPage TB = new TabPage();
            U.Dock = DockStyle.Fill;
            TB.Name = "Valída CPF 2 " + ControleValidaCPF2;
            TB.Text = "Valída CPF 2 " + ControleValidaCPF2;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void validaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleValidaSenha += 1;
            Frm_ValidaSenha_UC U = new Frm_ValidaSenha_UC();
            TabPage TB = new TabPage();
            U.Dock = DockStyle.Fill;
            TB.Name = "Valída Senha " + ControleValidaSenha;
            TB.Text = "Valída Senha " + ControleValidaSenha;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void apagarAbaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(Tbc_Aplicacoes.SelectedTab == null))
            {
                Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.SelectedTab);
            }

        }
    }
}
