using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.OperacoesMatematicas.Conversoes
{
    internal class Prestacoes
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor cheio da conta: ");
            double valor  = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor da taxa: ");
            int taxa = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o tempo de atraso (em meses)");
            int tempo = Convert.ToInt32(Console.ReadLine());

            double valorFinal = valor + (valor * taxa/100) * tempo;

            Console.WriteLine($"O valor total que deve ser pago é R${valorFinal}");
        } 
    }
}
