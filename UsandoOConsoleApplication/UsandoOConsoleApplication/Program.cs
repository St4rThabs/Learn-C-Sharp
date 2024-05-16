using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsandoOConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            /*TextReader leitor = Console.In; // TextReader serve para ler uma linha que foi escrita no terminal

            string linha = leitor.ReadLine(); // lê a linha que o usuário digitar

            while (linha != null)
            {
                // usa o texto da linha atual
                linha = leitor.ReadLine(); // lê a próxima linha até o usuário faça a combinação ctrl + z

                // o ctrl + z retorna uma string vazia, logo, faz com que o while se encerre
            }
            */

            using (Stream entrada = File.Open("entrada.txt", FileMode.Open))
            using (TextReader leitor = Console.In)
            {
                string linha = leitor.ReadLine(); ;

                while(linha != null)
                {
                    linha = leitor.ReadLine();
                }
                
            }

            Console.WriteLine("Olá mundo!");
            Console.ReadLine();
        }
    }
}
