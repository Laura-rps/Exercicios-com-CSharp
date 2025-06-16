using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.OrientacaoAObjetos
{
    internal class ValoresRetornados02
    {
        static int Conta2(int x,int z)
        {
            return x + z;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(Conta2(5, 4));
        }
    }
}
