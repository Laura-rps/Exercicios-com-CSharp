using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.ManipulacaoDenNumeros
{
    internal class Sucessor
    {
        public static void Main(string[] args)
        {
            int num1, resultado;
            Console.WriteLine("Sucessor de um numero");
            Console.WriteLine("Digite um numero: ");

            num1 = Convert.ToInt16(Console.ReadLine());

            resultado = num1 + 1;

            Console.WriteLine($"O sucessor de {num1} é {resultado}");
        }
    }
}
