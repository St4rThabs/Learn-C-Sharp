using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CadastroDePacientes.View.LoadFonts;
using CadastroPacientes.View;

namespace CadastroPacientes
{
    public partial class FormLogin : Form
    {
        private List<Usuario> users;

        private LoadFonts loadFontPoetsenOne = new LoadFonts();
        private LoadFonts loadFontMontserrat = new LoadFonts();

        public FormLogin()
        {
            InitializeComponent();
            loadFontPoetsenOne.LoadFontPoetsenOne();
            loadFontMontserrat.LoadFontMontserrat();

        }

        public void adicionaUsuario(Usuario user)
        {
            users.Add(user);
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            #region fontes diferentes

            // titulo e subtitulo
            lblWelcome.Font = new(loadFontPoetsenOne.PrivateFont.Families[0], 32.0F);
            lblSubtitulo.Font = new(loadFontMontserrat.PrivateFont.Families[0], 9.0F);

            // botao de Login
            botaoLogin.Font = new(loadFontMontserrat.PrivateFont.Families[2], 10.0F);

            // labels dos campos de texto
            lblUsername.Font = new(loadFontMontserrat.PrivateFont.Families[5], 9.0F);
            lblPassword.Font = new(loadFontMontserrat.PrivateFont.Families[5], 9.0F);

            #endregion


        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void lblSubtitulo_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void linkFormCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormCadastro formCadastro = new FormCadastro(this);
            formCadastro.ShowDialog();
        }
    }
}
