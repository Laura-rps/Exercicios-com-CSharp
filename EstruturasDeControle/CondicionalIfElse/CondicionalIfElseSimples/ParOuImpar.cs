using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.EstruturasDeControle.CondicionalIfElse.CondicionalIfElseSimples
{
    internal class ParOuImpar
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Par ou impar?");

            Console.WriteLine("Digite um numero inteiro: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("O numero digitado é par!");
            }
            else
            {
                Console.WriteLine("O numero digitado é impar!");
            }
        }
    }
}
