using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.OperacoesMatematicas.Geometria
{
    internal class RaizQuadrada
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Descobrir a raiz quadrada de um numero.");
            int num = Convert.ToInt32(Console.ReadLine());

            double resultado = Math.Sqrt(num);

            Console.WriteLine($"A raiz quadrada de {num} é igual a {resultado}.");
        }
    }
}
