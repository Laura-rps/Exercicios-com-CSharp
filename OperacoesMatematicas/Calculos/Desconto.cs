using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.OperacoesMatematicas.Calculos
{
    internal class Desconto
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do produto: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a quantidade adquirida: ");
            int quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o preco unitario: ");
            double precoUnitario = Double.Parse(Console.ReadLine());

            double total = quantidade * precoUnitario;

            double desconto;

            if(quantidade <= 5)
            {
                desconto = total * 0.02;
            }

            else if(quantidade > 5 && quantidade <= 10) 
            {
                desconto = total * 0.03;
            }
            else
            {
                desconto = total * 0.05;
            }

            double totalValor = total - desconto;

            Console.WriteLine($"Produto: {nome}");
            Console.WriteLine($"Total: R${total}");
            Console.WriteLine($"Desconto: R${desconto}");
            Console.WriteLine($"Valor total a pagar: R${totalValor}");
        }
    }
}
