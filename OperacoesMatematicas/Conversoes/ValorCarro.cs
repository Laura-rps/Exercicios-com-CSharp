using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.OperacoesMatematicas.Conversoes
{
    internal class ValorCarro
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o custo de fabrica: ");
            double custoFabrica = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a porcentagem de impostos: ");
            double impostos = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o percentual do distribuidor: ");
            double distribuidor = Convert.ToDouble(Console.ReadLine());

            double valorImpostos = custoFabrica * (impostos / 100);
            double valorDistribuidor = custoFabrica * (distribuidor / 100);
            double custoFinal = custoFabrica + valorImpostos + valorDistribuidor;

            Console.WriteLine($"O valor final do carro é {custoFinal}.");
        }
    }
}
