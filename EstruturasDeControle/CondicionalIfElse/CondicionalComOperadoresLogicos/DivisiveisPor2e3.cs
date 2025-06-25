using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.EstruturasDeControle.CondicionalIfElse.CondicionalComOperadoresLogicos
{
    internal class DivisiveisPor2e3
    {
        public static void Main(string[] args)
        {
            int[] numeros = new int[4];

            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Digite o {i + 1} número: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nVerificação dos números:");

            foreach (int numero in numeros)
            {
                if (numero % 2 == 0 && numero % 3 == 0)
                {
                    Console.WriteLine($"{numero} é divisível por 2 e 3.");
                }
                else
                {
                    Console.WriteLine($"{numero} NÃO é divisível por 2 e 3.");
                }
            }
        }
    }
}
