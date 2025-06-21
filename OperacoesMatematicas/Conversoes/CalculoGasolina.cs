using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.OperacoesMatematicas.Conversoes
{
    internal class CalculoGasolina
    {
        public static void Main(string[] args)
        {
            double precoLitro, desconto;

            Console.WriteLine("Digite o tipo de combustível (A - Álcool ou G - Gasolina): ");
            string tipoGasolina = Console.ReadLine().ToUpper();

            Console.WriteLine("Digite a quantidade de litros: ");
            double litros = double.Parse(Console.ReadLine());

            if (tipoGasolina == "A")
            {
                precoLitro = 2.90;
                if (litros <= 20)
                {
                    desconto = 0.03;
                }
                else
                {
                    desconto = 0.05;
                }
            }
            else if (tipoGasolina == "G")
            {
                precoLitro = 3.30;
                if (litros <= 20)
                {
                    desconto = 0.04;
                }
                else
                {
                    desconto = 0.06;
                }
            }
            else
            {
                Console.WriteLine("Tipo de combustível inválido!");
                return;
            }

            double valorBruto = litros * precoLitro;
            double valorFinal = valorBruto - (valorBruto * desconto);

            Console.WriteLine($"O valor final é R$ {valorFinal:F2}");
        }
    }
}
