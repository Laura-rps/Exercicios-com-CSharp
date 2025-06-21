using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.EstruturasDeControle.CondicionalIfElse
{
    internal class ExibirSeMenorOuIgualATres
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("O valor é igual ou menor que três?");

            Console.WriteLine("Digite um numero inteiro:");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero < 3)
            {
                Console.WriteLine("O número digitado é menor que 3!");
                Console.WriteLine("");
                Console.WriteLine($"O numero digitado foi: {numero}");
            }
            else if(numero == 3)
            {
                Console.WriteLine("O número digitado é 3!");
                Console.WriteLine("");
                Console.WriteLine($"O numero digitado foi: {numero}");
            }
            else
            {
                Console.WriteLine("O número digitado é maior que 3!");
            }
        }
    }
}
