using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.OperacoesMatematicas.Calculos
{
    internal class CalculoSalarioComComissao
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Quantos carros você vendeu?");
            int carrosVendidos = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual foi o valor total de suas vendas?");
            double totalVendas = Double.Parse(Console.ReadLine());

            Console.WriteLine("Qual é o valor do seu salário fixo?:");
            double salarioFixo = Double.Parse(Console.ReadLine());

            Console.WriteLine("Qual foi o valor do carro vendido?:");
            double valorCarroVendido = Double.Parse(Console.ReadLine());

            double salarioTotal = salarioFixo + (carrosVendidos * valorCarroVendido) + (totalVendas * 0.05);

            Console.WriteLine($"O salario total desse mês é {salarioTotal:F2}");
        }
    }
}
