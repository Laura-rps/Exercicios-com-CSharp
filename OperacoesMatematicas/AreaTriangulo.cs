using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.OperacoesMatematicas
{
    internal class AreaTriangulo
    {
        public static void Main(string[] args)
        {
            int baseTriangulo, alturaTriangulo, resultado;
            Console.WriteLine("Calculo da area de um triangulo.");
            Console.WriteLine("Digite a base do triangulo: ");

            baseTriangulo = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Digite a altura do triangulo: ");

            alturaTriangulo = Convert.ToInt16(Console.ReadLine());

            if (baseTriangulo == 0 || alturaTriangulo == 0)
            {
                Console.WriteLine("Numero inserido incorreto! Insira um numero maior que 0");
            }
            else { 
            resultado = (alturaTriangulo + baseTriangulo) / 2;
                Console.WriteLine($"A area do triangulo é: {resultado}");
            }
        }
    }
}
