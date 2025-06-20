using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.EstruturasDeControle.CondicionalIfElse
{
    internal class ValorAbsoluto
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Sempre numero positivo");

            Console.WriteLine("Digite um numero positivo ou negativo: ");
            double numero = Convert.ToDouble(Console.ReadLine());

            double resultado;

            if(numero < 0)
            {
                resultado = numero * -1;
            }
            else
            {
                resultado = numero;
            }

            Console.WriteLine($"O numero digitado em forma positiva é {resultado}");
        }
    }
}
