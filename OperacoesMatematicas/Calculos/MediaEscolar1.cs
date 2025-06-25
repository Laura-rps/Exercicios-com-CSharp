using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.OperacoesMatematicas.Calculos
{
    internal class MediaEscolar1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite a primeira nota: ");
            double nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota: ");
            double nota3 = Convert.ToDouble(Console.ReadLine());

            double nota1Peso = nota1 * 2;
            double nota2Peso = nota2 * 3;
            double nota3Peso = nota3 * 5;

            double media = (nota1Peso + nota2Peso + nota3Peso) / 3;

            Console.WriteLine($"Sua nota final é {media}.");
        }
    }
}
