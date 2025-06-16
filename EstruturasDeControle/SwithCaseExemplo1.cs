using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.EstruturasDeControle
{
    internal class SwithCaseExemplo1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número para ver a qual dia da semana ele corresponde: ");
            int diaDaSemana = Convert.ToInt16(Console.ReadLine());

            switch (diaDaSemana)
            {
                case 1:
                    Console.WriteLine("Domingo");
                    break;
                case 2:
                    Console.WriteLine("Segunda");
                    break;
                case 3:
                    Console.WriteLine("Terça");
                    break;
                case 4:
                    Console.WriteLine("Quarta");
                    break;
                case 5:
                    Console.WriteLine("Quinta");
                    break;
                case 6:
                    Console.WriteLine("Sexta");
                    break;
                case 7:
                    Console.WriteLine("Sábado");
                    break;
                default:
                    Console.WriteLine("Valor inválido");
                    break;
            }

          }
    }
}