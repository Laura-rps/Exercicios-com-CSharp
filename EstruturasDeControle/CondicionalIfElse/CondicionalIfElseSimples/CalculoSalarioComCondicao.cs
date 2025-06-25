using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.EstruturasDeControle.CondicionalIfElse.CondicionalIfElseSimples
{
    internal class CalculoSalarioComCondicao
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite seu salario total: ");
            double salarioInicial = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o total das suas vendas: ");
            double totalVendas = double.Parse(Console.ReadLine());

            double salarioFinal;

            if (totalVendas <= 1500)
            {
                salarioFinal = salarioInicial + totalVendas * 0.3; 
            }
            else
            {
                salarioFinal = salarioInicial + totalVendas * 0.5;
            }

            Console.WriteLine($"O salario final é R${salarioFinal}.");
        }
    }
}
