using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.EstruturasDeControle.While
{
    internal class TabuadaDo1ao10
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Tabuada do 1 ao 10 de qualquer numero!");

            Console.WriteLine("Digite um numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            int multiplicador = 1;

            while(multiplicador < 11)
            {
                Console.WriteLine($"{numero} x {multiplicador} = {numero * multiplicador}.");
                multiplicador++;
            }
        }
    }
}
