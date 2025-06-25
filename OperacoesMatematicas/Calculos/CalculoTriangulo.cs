using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.OperacoesMatematicas.Calculos
{
    internal class CalculoTriangulo
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro lado: ");
            double lado1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo lado: ");
            double lado2 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro lado: ");
            double lado3 = Double.Parse(Console.ReadLine());

            string mensagem;

            if (lado1 < lado2 + lado3 && lado2 < lado1 + lado3 && lado3 < lado1 + lado2)
            {
                mensagem = "Triângulo Equilátero";
            }
            else if(lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
            {
                mensagem = "Triângulo Isósceles";
            }
            else
            {
                mensagem = "Triângulo Escaleno";
            }

            Console.WriteLine(mensagem);
        }
    }
}
