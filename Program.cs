using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verificador_de_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escreva uma palavra: ");
            string palavra = Console.ReadLine();

            // deixando a palavra em caixa alta para facilitar
            string palavramax = palavra.ToUpper();

            int contagem = 0;

            foreach (char c in palavramax)
            {
                if (c == 'A')
                {
                    contagem++;
                }
            }

            // Verificando a existência da letra 'A'
            if (contagem > 0)
            {
                if (contagem == 1)
                {
                    Console.WriteLine("A letra 'A' aparece " + contagem + " vez na string.");
                }
                else
                {
                    Console.WriteLine("A letra 'A' aparece " + contagem + " vezes na string.");
                }
            }
            else
            {
                Console.WriteLine("A letra 'A' não está presente na string.");
            }


            Console.ReadKey();
        }
    }
}
