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

            if (resultado >= 0) // faz a verificação se a posição encontrada for menor que 0, quer dizer que a palavra não foi encontrada
            {
                MessageBox.Show("Texto " + busca + " encontrado");
            }
            else
            {
                MessageBox.Show("Texto não encontrado");
            }
        }

        private void botaoReplace_Click(object sender, EventArgs e)
        {
            string busca = textoBusca.Text; ;
            string textoDoEditor = textoConteudo.Text;
            string replace = textoReplace.Text;

            if (!string.IsNullOrEmpty(busca) && textoDoEditor.Contains(busca)) /* verifica se o campoBusca não está vazio e se o
                                                                               texto do editor contem o que estamos buscando */
            {
                textoConteudo.Text = textoDoEditor.Replace(busca, replace); // faz o replace do que foi encontrado em busca para o que queremos substitutir
            }
            else
            {
                MessageBox.Show("Substituição não realizada");
            }


        }

        private void botaoMaisuculo_Click(object sender, EventArgs e)
        {
            int inicioSelecao = textoConteudo.SelectionStart; /* A propriedade SelectionStart nos diz em qual posição, começando em 0, do texto
                                                              o usuário iniciou a seleção. */

            int tamanhoSelecao = textoConteudo.SelectionLength; // SelectionLength nos devolve quantos caracteres do texto estão selecionados atualmente.

            string textoSelecionado = textoConteudo.Text.Substring(inicioSelecao, tamanhoSelecao); // a substring vai armazenar a seleção feita

            string antes = textoConteudo.Text.Substring(0, inicioSelecao); // texto antes da seleção

            string depois = textoConteudo.Text.Substring(inicioSelecao + tamanhoSelecao); // texto depois da seleção

            textoConteudo.Text = antes + textoSelecionado.ToUpper() + depois; // redefinindo o texto

        }

        private void botaoMinusculo_Click(object sender, EventArgs e)
        {
            int inicioSelecao = textoConteudo.SelectionStart;
            int tamanhoSelecao = textoConteudo.SelectionLength;

            string textoSelecionado = textoConteudo.Text.Substring(inicioSelecao, tamanhoSelecao); /* o primeiro parâmetro da substring é o ponto de partida
                                                                                                   que ela vai começar a armazenar os carecteres, o segundo
                                                                                                   é a quantidade de caracteres  que ela vai armazenar. */

            string antes = textoConteudo.Text.Substring(0, inicioSelecao); // armazena o texto antes da seleção, então não vai alterar
            string depois = textoConteudo.Text.Substring(inicioSelecao + tamanhoSelecao); 

            textoConteudo.Text = antes + textoSelecionado.ToLower() + depois;


            /*  -- Deixando todo o texto em minúsculo: --
            
            string textoDoEditor = textoConteudo.Text.ToLower();

            using (StreamWriter escritor = new StreamWriter("texto.txt"))
            {
                escritor.Write(textoDoEditor); // escreve no arquivo o resultado do replace
            }

            using (StreamReader leitor = new StreamReader("texto.txt")) // lendo novaqmente o arquivo para mostrar que o replace foi feito
            {
                textoConteudo.Text = leitor.ReadToEnd();
            }
            */
        }

    }
}
