using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.VetoresEArrays
{
    internal class CalcularValoresVetor
    {
        public static void Main(string[] args)
        {
            int[] valores = { 5, 10, 15, 30, 50 };
            int soma = 0;
            for (int i = 0; i < valores.Length; i++) {
                soma += valores[i];
            }
            Console.WriteLine(soma);
        }
    }
}
