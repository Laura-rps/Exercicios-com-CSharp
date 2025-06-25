using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.EstruturasDeControle.CondicionalIfElse.CondicionalIfElseAninhado
{
    internal class MaiorEntre3
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Mostrar o maior numero entre 3");
            Console.WriteLine("Não digite numeros iguais!");   
            Console.WriteLine("");

            Console.WriteLine("Digite o primeiro numero: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro numero: ");
            double num3 = double.Parse(Console.ReadLine());

            double maior = 0;

            if(num1 == num2 && num1 == num3 && num2 == num3)
            {
                Console.WriteLine("Numeros iguais digitados!");
            }
            else if (num1 > num2 && num1 > num3)
            {
                maior = num1;
            }
            else if (num2 > num3 && num2 > num1)
            {
                maior = num2;
            }
            else if (num3 > num1 && num3 > num2)
            {
                maior = num3;
            }

            Console.WriteLine($"O maior numero é {maior}"); 
        }
    }
}
