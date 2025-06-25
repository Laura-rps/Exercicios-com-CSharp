using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.EstruturasDeControle.CondicionalIfElse.CondicionalIfElseAninhado
{
    internal class VerificaIdadeParaVotar
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o ano atual: ");
            int anoAtual = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o ano que voce nasceu: ");
            int anoNascimento = int.Parse(Console.ReadLine());

            int idade = anoAtual - anoNascimento;

            if(idade < 16)
            {
                Console.WriteLine("Você ainda nao pode votar.");
            }

            else if (idade >= 16 && idade < 18)
            {
                Console.WriteLine("Você pode votar, mas não é obrigatorio.");
            }
            else
            {
                Console.WriteLine("Você deve votar, ja é obrigatorio.");
            }
        }
    }
}
