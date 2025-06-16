using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.VetoresEArrays
{
    internal class ExemploArray
    {
        public static void Main(string[] args)
        {
            string[] carro = { "Volvo", "BMW", "Ford", "Mazda" };
            Array.Sort(carro);
            foreach (string marca in carro)
            {
                Console.WriteLine(marca);
            }

        }
    }
}

