using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.EstruturasDeControle.CondicionalIfElse.CondicionalIfElseSimples
{
    internal class MediaEscolarComCondicional
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Calculo de media escolar");

            Console.WriteLine("Digite a primeira nota: ");
            double nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota: ");
            double nota3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a quarta nota: ");
            double nota4 = Convert.ToDouble(Console.ReadLine());

            double media = (nota1 + nota2 + nota3 + nota4) / 4; 

            if (media >= 5)
            {
                Console.WriteLine("Você foi aprovado.");
            }
            else
            {
                Console.WriteLine("Você foi reprovado.");
            }

            Console.WriteLine($"Sua media é {media}");
        }
    }
}
