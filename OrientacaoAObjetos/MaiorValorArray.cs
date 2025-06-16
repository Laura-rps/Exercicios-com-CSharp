using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.OrientacaoAObjetos
{
    internal class MaiorValorArray
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Maior valor do array\n\n");
            double[] numeros = new double[3];
            int contador = 0;

            foreach (double num in numeros)
            {
                Console.Write("Digite um valor: ");
                numeros[contador] = Convert.ToDouble(Console.ReadLine());
                contador++;
            }
            Console.WriteLine("Maior valor: " + numeros.Max());
        }
    }
}