using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.EstruturasDeControle.CondicionalIfElse.CondicionalIfElseAninhado
{
    internal class MediaEscolar3
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite a primeira nota: ");
            double nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota:");
            double nota3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a media dos exercicios: ");
            int mediaExercicios = int.Parse(Console.ReadLine());

            double mediaAproveitamento = (nota1 + nota2 * 2 + nota3 * 3 + mediaExercicios) / 7;

            string conceito;

            if(mediaAproveitamento >= 9)
            {
                conceito = "A";
            }
            else if(mediaAproveitamento >= 7.5)
            {
                conceito = "B";
            }
            else if(mediaAproveitamento >= 6)
            {
                conceito = "C";
            }
            else
            {
                conceito = "D";
            }

            Console.WriteLine($"Sua media é {mediaAproveitamento}");
            Console.WriteLine($"Conceito: {conceito}");
        }
    }
}
