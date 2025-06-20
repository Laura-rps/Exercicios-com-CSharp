using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.OperacoesMatematicas.Conversoes
{
    internal class ArredondarNumero
    {
        public static void Main (string[] args)
        {
            Console.WriteLine("Digite um numero com virgula: ");
            double num = Convert.ToDouble(Console.ReadLine());

            double resultado = Math.Round(num);

            Console.WriteLine($"O numero inteiro mais proximo de {num} é {resultado}");
        }
    }
}
