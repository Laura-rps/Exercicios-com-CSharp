﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.OperacoesMatematicas.Porcentagens
{
    internal class CalculoPercentualVotos
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero total de eleitores: ");
            int totalEleitores = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o numero de votos brancos: ");
            int votosBrancos = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o numero de votos validos: ");
            int votosValidos = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o numero de votos nulos: ");
            int votosNulos = int.Parse(Console.ReadLine());

            double percentualBrancos = (double) votosBrancos / totalEleitores * 100;
            double percentualValidos = (double) votosValidos / totalEleitores * 100;
            double percentualNulos = (double)votosNulos / totalEleitores * 100;

            Console.WriteLine($"Percentual de votos brancos: {percentualBrancos:F2}%");
            Console.WriteLine($"Percentual de votos nulos: {percentualNulos:F2}%");
            Console.WriteLine($"Percentual de votos validos: {percentualValidos:F2}%");

        }
    }
}
