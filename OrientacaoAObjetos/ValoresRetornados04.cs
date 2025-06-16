using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.OrientacaoAObjetos
{
    internal class ValoresRetornados04
    {
        static int Soma(int x, int y)
        {
            return x + y;
        }
        static int Subtracao (int x, int y)
        {
            return x - y;
        }
        static int Divisao(int x , int y)
        {
            return x / y;
        }
        static int Multiplicacao (int x, int y)
        {
            return x * y;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(Soma(3, 4));
            Console.WriteLine(Subtracao(4, 3));
            Console.WriteLine(Divisao(12, 4));
            Console.WriteLine(Multiplicacao(5, 5));
        }
    }
}
