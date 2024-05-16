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

namespace EditorDeTexto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("texto.txt")) // se o arquivo texto.txt não existir, ele vai criar o arquivo na pasta bin/debug
            {
                // o using já fecha automaticamente o arquivo quando terminado de trabalhar com eles

                using (Stream entrada = File.Open("texto.txt", FileMode.Open))
                { // inicializando a variavel entrada dentro do using para abrir o arquivo
                    using (StreamReader leitor = new StreamReader(entrada)) // inicializando a variavel leitor para fazer a leitura do arquivo
                    {

                        textoConteudo.Text = leitor.ReadToEnd(); // utilizando o método ReadToEnd para ler todo o contéudo de uma vez

                        /*
                        string linha = leitor.ReadLine();
                        while (linha != null) // verifica se a linha não está vazia
                        {
                            textoConteudo.Text += linha; 
                            linha = leitor.ReadLine(); // lê a próxima linha
                        }
                        */
                    }
                }
            }
        }

        private void botaoGrava_Click(object sender, EventArgs e)
        {
            using (StreamWriter escritor = new StreamWriter("texto.txt"))
            {
                escritor.Write(textoConteudo.Text); // escrevendo o que foi inserido no textBox
            }
        }

        private void botaoBusca_Click(object sender, EventArgs e)
        {
            string busca = textoBusca.Text; // a variavel recebe o que foi digitado no campo de busca
            string textoDoEditor = textoConteudo.Text; // recebe o que está escrito no campo de texto do editor
            int resultado = textoDoEditor.IndexOf(busca); // retorna a posição da onde está escrito o que foi inserido no campo de busca

            if (resultado >= 0) // faz a verificação se a posição encontrada é maior que 0. Se for, quer dizer que foi encontrado
            {
                MessageBox.Show("Texto " + busca + " encontrado");
            }
            else
            {
                MessageBox.Show("Texto não encontrado");
            }
        }
    }
}
