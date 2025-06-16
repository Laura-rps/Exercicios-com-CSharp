using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.OrientacaoAObjetos
{
    internal class ValoresRetornados03
    {
        static int Conta03(int x, int y)
        {
            return x + y;
        }
        public static void Main(string[] args)
        {
            int z = Conta03(10, 9);
            Console.WriteLine(z);
        }
    }
}
