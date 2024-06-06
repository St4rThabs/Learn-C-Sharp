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
    public partial class Frm_Questao : Form
    {
        public Frm_Questao(string nomeImagem, string mensagem)
        {
            InitializeComponent();
            //Image MyImage = (Image)global::CursoWindowsFormsAlura.Properties.Resources.ResourceManager.GetObject(nomeImagem);
            //Image MyImage = Image.FromFile($@"C:\Users\thabata.lima\source\repos\WindowsFormsAlura\CursoWindowsFormsAlura\Imagens\{nomeImagem}.png");
            Image MyImage = Image.FromFile(Path.Combine(Application.StartupPath, "Imagens", $"{nomeImagem}.png"));
            Pic_Imagem.Image = MyImage;
            Lbl_Questao.Text = mensagem;
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
