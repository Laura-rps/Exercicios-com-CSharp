using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.VetoresEArrays
{
    internal class Vetor
    {
        public static void Main(string[] args)
        {
            string[] carro = { "Volvo", "BMW", "Ford", "Mazda" };
            int[] numero = { 10, 20, 30,40 };
            for(int i = 0; i < 4; i++)
            {
                Console.Write(carro[i]);
                Console.WriteLine(numero[i]);
            }
        }
    }
}
