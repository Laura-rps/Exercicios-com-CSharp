using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.OperacoesMatematicas
{
    internal class CelsiusParaFahrenheit
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Conversor de Celsius para Fahrenheit\n");
            Console.WriteLine("Digite a temperatura em Celsius: ");
            int celsius = Convert.ToInt32(Console.ReadLine());
            int fahrenheit = (9 * celsius + 160) / 5;
            Console.WriteLine($"A temepratura convertida em graus Celsius é {fahrenheit}");
        }
    }
}
