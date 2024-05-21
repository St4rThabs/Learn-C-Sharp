using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Reflection;
using System.IO;

namespace CadastroDePacientes.View.LoadFonts
{
    public class LoadFonts
    {
        // adiciona o caminho onde está o a fonte
        private string fontPathPoetsenOne = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Fonts", "PoetsenOne-Regular.ttf");
        private string fontPathMontserrat = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Fonts", "Montserrat-VariableFont_wght.ttf");
        public PrivateFontCollection PrivateFont { get; set; } = new PrivateFontCollection();

        public void LoadFontPoetsenOne()
        {
            PrivateFont.AddFontFile(fontPathPoetsenOne);
            FontFamily fontFamily = PrivateFont.Families[0];
            Font font = new Font(fontFamily, 32.0F);
        }

        public void LoadFontMontserrat()
        {
            PrivateFont.AddFontFile(fontPathMontserrat);
            FontFamily fontFamily = PrivateFont.Families[1];
            Font font = new Font(fontFamily, 12.0F);
        }
    }
}