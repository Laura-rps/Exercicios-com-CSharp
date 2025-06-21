using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.OperacoesMatematicas.Calculos
{
    internal class Aposentadoria
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o ano atual: ");
            int anoAtual = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o codigo do empregado: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o ano quye você nasceu: ");
            int anoNascimento = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o ano que você entrou na empresa: ");
            int anoIngresso = int.Parse(Console.ReadLine());

            int idade = anoAtual - anoNascimento;
            int tempoTrabalho = anoAtual - anoIngresso;
            
            if(idade <= 65 || tempoTrabalho >= 30 || (idade >= 60 && tempoTrabalho >= 25))
            {
                Console.WriteLine("Requerer aposentadoria.");
            }
            else
            {
                Console.WriteLine("Não requerer aposentadoria.");
            }
            Console.WriteLine($"Idade: {idade} anos.");
            Console.WriteLine($"Tempo trabalhado: {tempoTrabalho} anos.");
        }
    }
}
