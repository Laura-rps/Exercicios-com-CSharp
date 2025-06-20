using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.OperacoesMatematicas.NumerosEBasicos
{
    internal class QuadradoDaDiferenca
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Quadrado da diferença entre dois numeros inteiros");

            Console.WriteLine("Digite o primeiro numero: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            int diferenca = numero1 - numero2;
            double resultado = Math.Pow(diferenca, 2);

            Console.WriteLine($"O resultado do quadrado da diferença é {resultado}.");
        }
    }
}
