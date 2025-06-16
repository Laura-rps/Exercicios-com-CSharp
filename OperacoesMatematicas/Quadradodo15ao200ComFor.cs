using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.OperacoesMatematicas
{
    internal class Quadradodo15ao200ComFor
    {
        public static void Main(string[] args)
        {
            for(int i = 15; i < 201; i++)
            {
                double resultado = Math.Pow(i, 2);
                Console.WriteLine($"O quadrado de {i} é igual a {resultado}");
            }
        } 
    }
}
