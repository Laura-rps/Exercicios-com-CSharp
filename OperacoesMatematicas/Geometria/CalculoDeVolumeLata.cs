using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.OperacoesMatematicas.Geometria
{
    internal class CalculoDeVolumeLata
    {
        public static void Main(string[] args)
        {
            double pi = Math.PI;
            Console.WriteLine("Digite o raio da lata: ");
            double raio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a altura da lata: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double volume = pi * Math.Pow(raio,2) * altura;

            Console.WriteLine($"O volume da lata é {volume:F2}");
        }
    }
}
