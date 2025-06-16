using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.OrientacaoAObjetos
{
    internal class SomarElementosArray
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Somar todas os elementos de um array");
            double[] numero = new double[5];
            Console.WriteLine("Digite o primeiro valor: ");
            for (int i = 0; i < numero.Length; i++)
            {
                numero[i] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o proximo valor: ");
            }
            Console.WriteLine(numero.Sum());
        }
    }
}
