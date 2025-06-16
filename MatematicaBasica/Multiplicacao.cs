using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCSharp.MatematicaBasica
{
    internal class Multiplicacao
    {
        public static void Main(string[] args)
        {
            int num1, num2, resultado;
            Console.WriteLine("Digite os dois numeros para a multiplicação");
            Console.Write("Digite o primeiro numero: ");

            num1 = Convert.ToInt16(Console.ReadLine());
            
            Console.Write("Digite o segundo numero: ");

            num2 = Convert.ToInt16(Console.ReadLine());

            resultado = num1 * num2;

            Console.WriteLine($"O resultado da multiplicação é: {resultado}");
        }
    }
}
