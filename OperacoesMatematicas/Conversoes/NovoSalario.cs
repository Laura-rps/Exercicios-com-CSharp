using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.OperacoesMatematicas.Conversoes
{
    internal class NovoSalario
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu salario atual: ");
            double salario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a taxa de reajuste do seu salario: ");
            double reajuste = Convert.ToDouble(Console.ReadLine());

            double salarioNovo = salario + (salario *  reajuste / 100);

            Console.WriteLine($"O novo salario é {salarioNovo}.");
        }
    }
}
