using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.OperacoesMatematicas.Calculos
{
    internal class CalculoDeFrutas
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de morangos (em Kg): ");
            double qtdMorango = Double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de maçã (em Kg):");
            double qtdMaca = Double.Parse(Console.ReadLine());

            
            double valorMorango;
            double valorMaca;

            if (qtdMaca <= 5)
            {
                valorMaca = qtdMaca * 1.80;
            }
            else
            {
                valorMaca = qtdMaca * 1.50;
            }

            if (qtdMorango <= 5)
            {
                valorMorango = qtdMorango * 2.20;
            }
            else
            {
                valorMorango = qtdMorango * 2.50;
            }

            double ValorTotal = valorMaca + valorMorango;

            if(qtdMorango + qtdMaca > 8 || ValorTotal > 25)
            {
                double desconto = ValorTotal * 0.10;
                ValorTotal = ValorTotal - desconto; 
            }

            Console.WriteLine($"O valor a ser pago é {ValorTotal}");
        }
    }
}
