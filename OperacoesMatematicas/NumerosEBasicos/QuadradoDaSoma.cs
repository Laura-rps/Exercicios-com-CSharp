using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.OperacoesMatematicas.NumerosEBasicos
{
    internal class QuadradoDaSoma
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro numero: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o terceiro numero: ");
            double numero3 = Convert.ToDouble(Console.ReadLine());

            double soma = numero1 + numero2 + numero3;
            double resultado = Math.Pow(soma, 2);

            Console.WriteLine($"O resultado do quadrado da soma dos tres numeros é: {resultado}.");
        }
    }
}
