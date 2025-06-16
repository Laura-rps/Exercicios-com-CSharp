using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.ManipulacaoDenNumeros
{
    internal class NegativoParaPositivo
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero negativo");
            double num = Convert.ToInt32(Console.ReadLine());

            double resultado = Math.Abs(num);

            Console.WriteLine($"{num} em versão positiva é {resultado}.");
        }
    }
}
