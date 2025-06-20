using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.OperacoesMatematicas.SequenciasERepeticoes
{
    internal class TabuadaDo1ateo10deumnumero
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero a ser multiplicado");
            int numero = Convert.ToInt16(Console.ReadLine()); 
            for (int multiplicacao = 1; multiplicacao <11; multiplicacao++)
            {
                int resultado = numero * multiplicacao;
                Console.WriteLine($"{numero} * {multiplicacao} = {resultado}");
            }
        }
    }
}
