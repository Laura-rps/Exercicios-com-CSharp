using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.OrientacaoAObjetos
{
    internal class ValoresRetornados01
    {
        static int Conta1(int x)
        {
            return 5 + x;
        }

        public static void Main(string[] args) 
        {
            Console.WriteLine(Conta1(3));
        }
    }
}
