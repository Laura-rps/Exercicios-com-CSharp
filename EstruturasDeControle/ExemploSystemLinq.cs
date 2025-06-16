using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.EstruturasDeControle
{
    internal class ExemploSystemLinq
    {
        public static void Main(string[] args)
        {
            int[] numero = { 1, 2, 3, 4, 5 };
            Console.WriteLine(numero.Max()); //Mostra o maior numero
            Console.WriteLine(numero.Min()); // Mostra o menor numero
            Console.WriteLine(numero.Sum()); // Mostra a soma de todos os valores
        }
    }
}
