using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.OperacoesMatematicas.NumerosEBasicos
{
    internal class SomaDosQuadrados
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Soma dos quadrados de três valores");

            Console.WriteLine("Digite o primeiro numero: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o terceiro numero: ");
            double numero3 = Convert.ToDouble(Console.ReadLine());

            double quadrado1 = Math.Pow(numero1, 2);
            double quadrado2 = Math.Pow(numero2, 2);
            double quadrado3 = Math.Pow(numero3, 2);

            double resultadoSoma = quadrado1 + quadrado2 + quadrado3;

            Console.WriteLine($"O resultado da soma dos tres quadrados é {resultadoSoma:F2}.");
        }
    }
}
