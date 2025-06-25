using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.EstruturasDeControle.CondicionalIfElse.CondicionalIfElseAninhado
{
    internal class PositivoNegativoOuZero
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero: ");
            double numero = double.Parse(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine("O numero é positivo");
            }
            else if(numero == 0)
            {
                Console.WriteLine("O numero é zero");
            }
            else
            {
                Console.WriteLine("O numero é negativo");
            }
            Console.WriteLine($"O numero digitado foi: {numero}");
        }
    }
}
