using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.OperacoesMatematicas
{
    internal class SomaDosValoresParesAte500
    {
        public static void Main(string[] args)
        {
            int i = 2, totalSoma = 0;

            while (i <= 500)
            {
                totalSoma += i;
                i += 2;
            }

            Console.WriteLine($"A soma dos números pares de 2 até 500 é: {totalSoma}");
        }
    }
}
