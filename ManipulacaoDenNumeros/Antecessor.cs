using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.ManipulacaoDenNumeros
{
    internal class Antecessor
    {
        public static void Main(string[] args)
        {
            int num1, resultado;
            Console.WriteLine("Sucessor de um numero");
            Console.WriteLine("Digite um numero numero: ");

            num1 = Convert.ToInt16(Console.ReadLine());

            resultado = num1 - 1;

            Console.WriteLine($"O antecessor de {num1} é {resultado}");
        }
    }
}