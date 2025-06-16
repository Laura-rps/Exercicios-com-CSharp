using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.ManipulacaoDenNumeros
{
    internal class Cronometro
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Cronometro");
            for (int hora = 0; hora < 24; hora++)
            {
                for (int minuto = 0; minuto < 60; minuto++)
                {
                    for (int segundo = 0; segundo < 60; segundo++)
                    {
                        Console.WriteLine($"{hora} : {minuto} : {segundo}");
                    }
                }
            }
        }
    }
}
