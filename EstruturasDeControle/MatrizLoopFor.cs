﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.EstruturasDeControle
{
    internal class MatrizLoopFor
    {
        public static void Main(string[] args)
        {
            int[,] numero = { { 1, 2, 3 }, { 8, 54, 52 } };
            for (int i = 0; i < numero.GetLength(0); i++)
            {
                for (int j = 0; j < numero.GetLength(1); j++)
                {
                    Console.WriteLine(numero[i, j]);
                }

            }
        }
    }
}
