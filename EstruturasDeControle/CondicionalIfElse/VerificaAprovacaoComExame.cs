using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.EstruturasDeControle.CondicionalIfElse
{
    internal class VerificaAprovacaoComExame
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Calculo de media escolar com exame");

            Console.WriteLine("Digite a primeira nota: ");
            double nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota: ");
            double nota3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a quarta nota: ");
            double nota4 = Convert.ToDouble(Console.ReadLine());

            double media = (nota1 + nota2 + nota3 + nota4) / 4;

            if(media >= 7)
            {
                Console.WriteLine("Você foi aprovado!");
                Console.WriteLine($"Sua media é {media}");
            }
            else
            {
                if(media < 7)
                {
                    Console.WriteLine("Media abaixo do esperado! ");
                    Console.WriteLine("Digite a nota do exame: ");
                    double exame = Convert.ToDouble(Console.ReadLine());
                    double novaMedia = (media + exame) / 2;
                    if (novaMedia >= 5)
                    {
                        Console.WriteLine("Voce foi aprovado com exame!");
                        Console.WriteLine($"Sua media é {novaMedia}");
                    }
                    else
                    {
                        Console.WriteLine("Você foi reprovado!");
                        Console.WriteLine($"Sua media é {novaMedia}");
                    }
                }
                
            }
        }
    }
}
