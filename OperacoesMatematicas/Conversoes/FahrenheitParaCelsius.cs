using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.OperacoesMatematicas.Conversoes
{
    internal class FahrenheitParaCelsius
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Conversão de Fahrenheit para Celsius");

            Console.WriteLine("Digite a temperatura em Fahrenheit: ");
            int Fahrenheit = Convert.ToInt32(Console.ReadLine());

            double Celsius = (Fahrenheit - 32) * (5.0 / 9.0);

            Console.WriteLine($"A temperatura convertida em Celsius é {Celsius}");

        }
    }
}
