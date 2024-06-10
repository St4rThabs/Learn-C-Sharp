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
        int ControleHelloWorld = 0, 
            ControleDemonstracaoKey = 0, 
            ControleMascara = 0, 
            ControleValidaCPF = 0, ControleValidaCPF2 = 0, 
            ControleValidaSenha = 0,
            ControleArquivoImagem = 0, 
            ControleCadastroClientes = 0;

        public Frm_Principal_Menu_UC()
        {
            InitializeComponent();

            novoToolStripMenuItem.Enabled = false;
            apagarAbaToolStripMenuItem.Enabled = false;
            abrirImagemToolStripMenuItem.Enabled = false;
            desconectarToolStripMenuItem.Enabled = false;
            cadastrosToolStripMenuItem.Enabled = false;
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
                    cadastrosToolStripMenuItem.Enabled = true;
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
                    ApagaAba(Tbc_Aplicacoes.TabPages[i]);
                }

                novoToolStripMenuItem.Enabled = false;
                apagarAbaToolStripMenuItem.Enabled = false;
                abrirImagemToolStripMenuItem.Enabled = false;
                desconectarToolStripMenuItem.Enabled = false;
                cadastrosToolStripMenuItem.Enabled = false;
                conectarToolStripMenuItem.Enabled = true;
            }

        }

        private void Tbc_Aplicacoes_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                //MessageBox.Show("Cliquei com o botão direito do mouse. A posição relativa foi (" + posicaoX.ToString() + ", " + posicaoY.ToString() + ")");

                var ContextMenu = new ContextMenuStrip();

                var vToolTip001 = DesenhaItemMenu("Apagar a Aba", "DeleteTab");
                var vToolTip002 = DesenhaItemMenu("Apagar Todas a Esquerda", "DeleteLeft");
                var vToolTip003 = DesenhaItemMenu("Apagar Todas a Direita", "DeleteRight");
                var vToolTip004 = DesenhaItemMenu("Apagar Todoas Menos Esta", "DeleteAll");
                var vToolTip005 = DesenhaItemMenu("Apagar Todoas as Abas", "DeleteAll");

                ContextMenu.Items.Add(vToolTip001);
                vToolTip001.Click += new System.EventHandler(vToolTip001_Click);

                ContextMenu.Items.Add(vToolTip002);
                vToolTip002.Click += new System.EventHandler(vToolTip002_Click);

                ContextMenu.Items.Add(vToolTip003);
                vToolTip003.Click += new System.EventHandler(vToolTip003_Click);

                ContextMenu.Items.Add(vToolTip004);
                vToolTip004.Click += new System.EventHandler(vToolTip004_Click);

                ContextMenu.Items.Add(vToolTip005);
                vToolTip005.Click += new System.EventHandler(vToolTip005_Click);

                ContextMenu.Show(this, new Point(e.X, e.Y));
            }

        }

        void vToolTip001_Click(object sender1, EventArgs e1)
        {
            if (!(Tbc_Aplicacoes.SelectedTab == null))
            {
                ApagaAba(Tbc_Aplicacoes.SelectedTab);
            }
        }

        void vToolTip002_Click(object sender1, EventArgs e1)
        {
            if (!(Tbc_Aplicacoes.SelectedTab == null))
            {
                ApagaEsquerda(Tbc_Aplicacoes.SelectedIndex);
            }
        }

        void vToolTip003_Click(object sender1, EventArgs e1)
        {
            if (!(Tbc_Aplicacoes.SelectedTab == null))
            {
                ApagaDireita(Tbc_Aplicacoes.SelectedIndex);
            }

        }

        void vToolTip004_Click(object sender1, EventArgs e1)
        {
            if (!(Tbc_Aplicacoes.SelectedTab == null))
            {
                ApagaEsquerda(Tbc_Aplicacoes.SelectedIndex);
                ApagaDireita(Tbc_Aplicacoes.SelectedIndex);
            }
        }

        void vToolTip005_Click(object sender1, EventArgs e1)
        {
            for (int i = Tbc_Aplicacoes.TabPages.Count - 1; i >= 0; i--)
            {
                ApagaAba(Tbc_Aplicacoes.TabPages[i]);
            }
        }

        ToolStripMenuItem DesenhaItemMenu(string text, string nomeImagem)
        {
            var vToolTip = new ToolStripMenuItem();
            vToolTip.Text = text;

            Image MyImage = Image.FromFile(Path.Combine(Application.StartupPath, "Imagens", $"{nomeImagem}.png"));
            vToolTip.Image = MyImage;

            return vToolTip;
        }

        void ApagaDireita(int itemSelecionado)
        {
            for (int i = Tbc_Aplicacoes.TabCount - 1; i > itemSelecionado; i--)
            {
                ApagaAba(Tbc_Aplicacoes.TabPages[i]);
            }
        }

        void ApagaEsquerda(int itemSelecionado)
        {
            for (int i = itemSelecionado - 1; i >= 0; i--)
            {
                ApagaAba(Tbc_Aplicacoes.TabPages[i]);
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ControleCadastroClientes == 0)
            {
                ControleCadastroClientes += 1;
                Frm_CadastroCliente_UC U = new Frm_CadastroCliente_UC();
                TabPage TB = new TabPage();
                U.Dock = DockStyle.Fill;
                TB.Name = "Cadastro de Clientes";
                TB.Text = "Cadastro de Clientes";
                TB.Controls.Add(U);
                Tbc_Aplicacoes.TabPages.Add(TB);
            }
            else
            {
                MessageBox.Show("Cadastro de Clientes já está aberto", "Banco ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        void ApagaAba(TabPage TB)
        {
            if(TB.Name == "Cadastro de Clientes")
            {
                ControleCadastroClientes = 0;
            }

            Tbc_Aplicacoes.TabPages.Remove(TB);
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
                ApagaAba(Tbc_Aplicacoes.SelectedTab);
            }

        }
    }
}
