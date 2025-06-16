using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.OperacoesMatematicas
{
    internal class TrigoXadrez
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Somatorio do numero de grãos de trigo \n");
            int i = 0, anterior = 0, atual = 1, somaTrigo = 0;
            do
            {             
                atual += anterior;

                somaTrigo += atual;

                anterior = atual;

                atual += 2;

                i++;

            } while (i < 64);
            Console.WriteLine($"Somatorio de trigos = {somaTrigo}");
        }
    }
}
