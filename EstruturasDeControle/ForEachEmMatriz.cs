using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.EstruturasDeControle
{
    internal class ForEachEmMatriz
    {
        public static void Main(string[] args)
        {
            int[,] numeros = { { 1, 2, 3, }, { 5, 7, 8 } };
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }
    }
}
