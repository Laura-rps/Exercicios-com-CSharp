using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.OperacoesMatematicas.SequenciasERepeticoes
{
    internal class TabuadaDeUmNumero
    {
        public static void Main(string[] args)
        {
            int i = 1, numero;
            Console.WriteLine("Tabuada de um numero qualquer \n");
            Console.WriteLine("Digite um numero: ");
            numero = Convert.ToInt16(Console.ReadLine());
            while (i < 11)
            {
                Console.WriteLine($"{numero} * {i} = {numero * i}");
                i++;
            }
        }
    }
}
