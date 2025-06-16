using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.VetoresEArrays
{
    internal class ExemploArray02
    {
        public static void Main(string[] args)
        {
            int[] numero = { 1, 56, 21, 45, 67 };
            Array.Sort(numero);
            foreach (int numeroEx in numero)
            {
                Console.WriteLine(numeroEx);
            }
        }
    }
}
