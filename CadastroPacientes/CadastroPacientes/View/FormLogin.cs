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

namespace CadastroPacientes
{
    public partial class FormLogin : Form
    {
        private LoadFonts loadFontPoetsenOne = new LoadFonts();
        private LoadFonts loadFontMontserrat = new LoadFonts();

        public FormLogin()
        {
            InitializeComponent();
            this.loadFontPoetsenOne.LoadFontPoetsenOne();
            this.loadFontMontserrat.LoadFontMontserrat();

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            #region fontes diferentes

            // titulo e subtitulo
            lblWelcome.Font = new(this.loadFontPoetsenOne.PrivateFont.Families[0], 32.0F);
            lblSubtitulo.Font = new(this.loadFontMontserrat.PrivateFont.Families[0], 9.0F);

            // botao de Login
            botaoLogin.Font =  new(this.loadFontMontserrat.PrivateFont.Families[2], 10.0F);

            // labels dos campos de texto
            lblUsername.Font = new(this.loadFontMontserrat.PrivateFont.Families[5], 9.0F);
            lblPassword.Font = new(this.loadFontMontserrat.PrivateFont.Families[5], 9.0F);
            
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
    }
}
