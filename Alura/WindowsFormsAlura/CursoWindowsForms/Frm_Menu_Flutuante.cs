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
    public partial class Frm_Menu_Flutuante : Form
    {
        public Frm_Menu_Flutuante()
        {
            InitializeComponent();
        }

        private void Frm_Menu_Flutuante_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            { 
                //MessageBox.Show("Cliquei com o botão direito do mouse. A posição relativa foi (" + posicaoX.ToString() + ", " + posicaoY.ToString() + ")");

                var ContextMenu = new ContextMenuStrip();

                var vToolTip001 = DesenhaItemMenu("Item do menu 1", "key");
                var vToolTip002 = DesenhaItemMenu("Item do menu 2", "Frm_ValidaSenha");
                var vToolTip003 = DesenhaItemMenu("Item do menu 3", "Frm_ValidaCPF");
                var vItem0031 = DesenhaItemMenu("Item do menu 3.1", "Frm_ValidaCPF2");

                ContextMenu.Items.Add(vToolTip001);
                vToolTip001.Click += new System.EventHandler(vToolTip001_Click);

                ContextMenu.Items.Add(vToolTip002);
                vToolTip002.Click += new System.EventHandler(vToolTip002_Click);

                vToolTip003.DropDownItems.Add(vItem0031);
                ContextMenu.Items.Add(vToolTip003);
                vItem0031.Click += new System.EventHandler(vItem0031_Click);


                ContextMenu.Show(this, new Point(e.X, e.Y));
            }

            void vToolTip001_Click(object sender1, EventArgs e1)
            {
                MessageBox.Show("Opção 1 do menu selecionada");
            }

            void vToolTip002_Click(object sender2, EventArgs e2)
            {
                MessageBox.Show("Opção 2 do menu selecionada");
            }

            void vItem0031_Click(object sender3, EventArgs e3)
            {
                MessageBox.Show("Opção 3.1 do menu selecionada");
            }

            ToolStripMenuItem DesenhaItemMenu(string text, string nomeImagem)
            {
                var vToolTip = new ToolStripMenuItem();
                vToolTip.Text = text;

                Image MyImage = Image.FromFile(Path.Combine(Application.StartupPath, "Imagens", $"{nomeImagem}.png"));
                vToolTip.Image = MyImage;

                return vToolTip;
            }
        }
    }
}
