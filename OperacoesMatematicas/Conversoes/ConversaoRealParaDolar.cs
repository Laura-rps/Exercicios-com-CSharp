using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.OperacoesMatematicas.Conversoes
{
    internal class ConversaoRealParaDolar
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Conversão de real para dolar");

            Console.WriteLine("Digite a cotação atual do dolar");
            double cotacao = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite quantos reais voce tem: ");
            double real = Convert.ToDouble(Console.ReadLine());

            double resultado = real / cotacao;

            Console.WriteLine($"A conversão dos reais inseridos é: {resultado:F2}");
        }
    }
}
