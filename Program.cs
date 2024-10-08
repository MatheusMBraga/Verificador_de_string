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
            Console.WriteLine("Versao 1");
            Console.WriteLine();

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
            if (contagem >= 0)
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

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Versao 2");
            Console.WriteLine();

            // versao 2.0
            Console.Write("Escreva uma palavra: ");
            string palavra1 = Console.ReadLine();

            Console.Write("Digite a letra que quer contar: ");
            char l = Console.ReadKey().KeyChar;

            // deixando a palavra em caixa alta para facilitar
            string palavramax1 = palavra1.ToUpper();
            char l_max = char.ToUpper(l);
            Console.WriteLine();

            int contagem1 = 0;

            for (int i = 0; i < palavramax1.Length; i++)
            {
                if (palavramax1[i] == l_max)
                {
                    contagem1++;
                }
            }
            Console.WriteLine();
            if (contagem1 == 1)
            {
                Console.WriteLine("A paravra '" + palavra1 + "' contém " + contagem1 + " letra '" + l_max + "'");
            }
            else
            {
                Console.WriteLine("A paravra '" + palavra1 + "' contém " + contagem1 + " letras '" + l_max + "'");
            }

            Console.ReadKey();
        }
    }
}
