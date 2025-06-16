using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.DatasETempo
{
    internal class Temporizador
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Temporizador com entrada de Dados \n\n");
            Console.WriteLine("Digite o valor da hora: ");
            int horasDigitadas = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Digite o valor dos minutos: ");
            int minutosDigitados = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Digite o valor dos segundos: ");
            int segundosDigitados = Convert.ToInt16(Console.ReadLine());

            for (int hora = horasDigitadas; hora > -1; hora--)
            {
                for (int minuto = minutosDigitados; minuto > -1; minuto--)
                {
                    for (int segundo = segundosDigitados; segundo > -1; segundo--)
                    {
                        Console.WriteLine(hora + " : " + minuto + " : " + segundo);
                        segundosDigitados = 59;
                    }
                    minutosDigitados = 59;
                }
            }

        }
    }
}
