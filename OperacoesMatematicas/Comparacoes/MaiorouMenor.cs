using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.OperacoesMatematicas.Comparacoes
{
    internal class MaiorouMenor
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            
            int resultadoMaior = Math.Max(num1, num2);
            int resultadoMenor = Math.Min(num1, num2);

            Console.WriteLine($"O maior valor entre {num1} e {num2} é {resultadoMaior}\n");
            Console.WriteLine($"O menor valor entre {num1} e {num2} é {resultadoMenor}");    
        }
    }
}
