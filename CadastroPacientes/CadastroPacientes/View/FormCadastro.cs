using CadastroDePacientes.View.LoadFonts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace CadastroPacientes.View
{
    public partial class FormCadastro : Form
    {
        private FormLogin formLogin;

        private LoadFonts loadFontPoetsenOne = new LoadFonts();
        private LoadFonts loadFontMontserrat = new LoadFonts();

        private Usuario newUser;

        private ChecaForcaSenha validaSenha;
        private bool verSenha = false;

        public FormCadastro(FormLogin formLogin)
        {
            InitializeComponent();
            this.formLogin = new FormLogin();

            loadFontPoetsenOne.LoadFontPoetsenOne();
            loadFontMontserrat.LoadFontMontserrat();
        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {
            // titulo e subtitulo
            lblWelcome.Font = new(loadFontPoetsenOne.PrivateFont.Families[0], 32.0F);
            lblSubtitulo.Font = new(loadFontMontserrat.PrivateFont.Families[0], 9.0F);

            // botao de Login
            btnRegister.Font = new(loadFontMontserrat.PrivateFont.Families[2], 10.0F);

            // labels dos campos de texto
            lblUsername.Font = new(loadFontMontserrat.PrivateFont.Families[5], 9.0F);
            lblPassword.Font = new(loadFontMontserrat.PrivateFont.Families[5], 9.0F);
            lblConfirmPassword.Font = new(loadFontMontserrat.PrivateFont.Families[5], 9.0F);
            lblForcePassword.Font = new(loadFontMontserrat.PrivateFont.Families[2], 8.50F);
            lblPasswordError.Font = new(loadFontMontserrat.PrivateFont.Families[0], 8.50F);

        }

        private void mskPassword_KeyDown(object sender, KeyEventArgs e)
        {
            validaSenha = new ChecaForcaSenha();
            ChecaForcaSenha.ForcaDaSenha forca;

            forca = validaSenha.GetForcaDaSenha(mskPassword.Text);

            lblForcePassword.Text = forca.ToString();

            if (lblForcePassword.Text == "Inaceitavel" || lblForcePassword.Text == "Fraca")
            {
                lblForcePassword.ForeColor = Color.DarkRed;
            }

            if (lblForcePassword.Text == "Aceitavel")
            {
                lblForcePassword.ForeColor = Color.OrangeRed;
            }
            if (lblForcePassword.Text == "Forte" || lblForcePassword.Text == "Segura")
            {
                lblForcePassword.ForeColor = Color.DarkOliveGreen;
            }

        }

        private void btnVerSenha_Click(object sender, EventArgs e)
        {
            if (verSenha == false)
            {
                mskPassword.PasswordChar = '\0';
                verSenha = true;
                btnVerSenha.BackColor = Color.MediumPurple;
            }
            else
            {
                mskPassword.PasswordChar = '*';
                verSenha = false;
                btnVerSenha.BackColor = Color.Transparent;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            newUser = new Usuario();
            newUser.Username = textoUsername.Text;

            bool verificao = mskPassword.Text.Equals(mskConfirmPassword.Text);

            if (verificao == true)
            {
                formLogin.adicionaUsuario(newUser);
                MessageBox.Show("Usuário adicionado com sucesso");
            }
            else
            {
                lblPasswordError.Text = "* Senhas divergentes";
                lblPasswordError.ForeColor = Color.DarkRed;
            }

        }
    }
}
