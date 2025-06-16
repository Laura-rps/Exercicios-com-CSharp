using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.ExerciciosComMetodos
{
    internal class MetodoSobrecargaExemplo02
    {
        static int Soma (int valor1, int valor2)
        {
            return valor1 + valor2;
        }

        static double Soma(double valor3, double valor4)
        {
            return valor3 + valor4;
        } 

        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro numero: ");
            int valor1 = Convert.ToInt16 (Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            int valor2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Digite o terceiro numero: ");
            double valor3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o quarto numero: ");
            double valor4 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("A soma dos valores inteiros é:" +Soma(valor1, valor2));
            Console.WriteLine("A soma dos valores double é:" + Soma(valor3, valor4));
        }
    }
}
