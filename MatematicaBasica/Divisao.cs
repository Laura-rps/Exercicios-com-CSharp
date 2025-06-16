using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCSharp.MatematicaBasica
{
    internal class Divisao
    {
        public static void Main(string[] args)
        {
            int num1, num2, divisao;
            Console.WriteLine("Digite os dois numeros para a divisão");
            Console.Write("Digite o primeiro numero: ");

            num1 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Digite o segundo numero: ");

            num2 = Convert.ToInt16(Console.ReadLine());

            if (num2 == 0 || num1 ==0)
            {
                Console.WriteLine("Erro: Divisão por zero não é permitida.");
            }
            else
            {
                divisao = num1 / num2;
                Console.WriteLine($"O resultado da divisão é: {divisao}");
            }
        }
    }
}
