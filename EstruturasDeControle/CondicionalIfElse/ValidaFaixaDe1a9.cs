using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.EstruturasDeControle.CondicionalIfElse
{
    internal class ValidaFaixaDe1a9
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero entre 1 e 9");

            Console.WriteLine("Digite um numero: ");
            double numero = Convert.ToDouble(Console.ReadLine());

            if(numero <= 9 && numero >= 1)
            {
                Console.WriteLine("O numero digitado esta entre 1 e 9!");
            }
            else
            {
                Console.WriteLine("O numero digitado não esta entre 1 e 9!");
            }
        }
    }
}
