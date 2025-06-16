using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.OrientacaoAObjetos
{
    internal class Computador
    {
        string ram = "16GB RAM";
        string monitor = "24 polegadas";
        string processador = "AMD Rayzen 5200";
        int memoria = 512;

        public static void Main(string[] args)
        {
            Computador novo = new Computador();
            Console.WriteLine( $"Memoria RAM {novo.ram}");
            Console.WriteLine($"Monitor {novo.monitor}");
            Console.WriteLine($"Processador {novo.processador}");
            Console.WriteLine($"Memoria {novo.memoria}");
        } 
    }
}
