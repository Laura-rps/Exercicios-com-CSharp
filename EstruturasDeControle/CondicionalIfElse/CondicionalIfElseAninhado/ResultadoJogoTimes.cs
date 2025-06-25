using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.EstruturasDeControle.CondicionalIfElse.CondicionalIfElseAninhado
{
    internal class ResultadoJogoTimes
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do primeiro time: ");
            string time1 = Console.ReadLine();

            Console.WriteLine("Digite os pontos do primeiro time: ");
            int ponto1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do segundo time: ");
            string time2 = Console.ReadLine();

            Console.WriteLine("Digite os pontos do segundo time: ");
            int ponto2 = int.Parse(Console.ReadLine());

            int diferenca = ponto1 - ponto2; 

            if(ponto1 > ponto2)
            {
                Console.WriteLine($"O {time1} venceu o {time2} por {diferenca} pontos a mais");
            }
            else if (ponto2 > ponto1)
            {
                Console.WriteLine($"O {time2} venceu o {time1} por {diferenca} pontos a mais");
            }
            else
            {
                Console.WriteLine("Empate!");
            }
        }
    }
}
