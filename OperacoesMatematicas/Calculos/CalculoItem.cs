using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.OperacoesMatematicas.Calculos
{
    internal class CalculoItem
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Calculo de quantidade em estoque");
            Console.WriteLine("");

            Console.WriteLine("Digite a quantidade atual do produto no estoque: ");
            int quantidadeAtual = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade maxima do estoque: ");
            int quantidadeMaxima = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade minima do estoque: ");
            int quantidadeMinima = int.Parse(Console.ReadLine());

            int quantidadeMedia = (quantidadeMaxima + quantidadeMinima) / 2;

            if(quantidadeAtual >= quantidadeMedia)
            {
                Console.WriteLine("Não efetuar a compra");
            }
            else
            {
                Console.WriteLine("Efetuar a compra");
            }
        }
    }
}
