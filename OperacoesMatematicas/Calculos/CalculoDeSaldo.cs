using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.OperacoesMatematicas.Calculos
{
    internal class CalculoDeSaldo
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite seu saldo: ");
            double saldo = Double.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu credito(Dinheiro que voce ira receber)");
            double credito = Double.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu debito (Dinheiro que ira sair da sua conta)");
            double debito = Double.Parse(Console.ReadLine());

            double saldoFinal = saldo + credito - debito;

            if (saldoFinal >= 0) {
                Console.WriteLine($"Seu saldo atualmente é: {saldoFinal}.");
                Console.WriteLine("Seu saldo é positivo:");
        }
            else
            {
                Console.WriteLine($"Seu saldo atualmente é {saldoFinal}.");
                Console.WriteLine("Seu saldo é negativo");
            }
        }
    }
}
