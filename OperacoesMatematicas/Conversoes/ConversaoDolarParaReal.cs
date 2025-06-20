using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.OperacoesMatematicas.Conversoes
{
    internal class ConversaoDolarParaReal
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Conversão de dolar para real");

            Console.WriteLine("Digite a cotação atual do dolar");
            double cotacao = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite quantos dolares voce tem: ");
            double dolar = Convert.ToDouble(Console.ReadLine());

            double resultado = cotacao * dolar;

            Console.WriteLine($"A conversão dos dolares inseridos é: {resultado:F2}");
        }
    }
}
