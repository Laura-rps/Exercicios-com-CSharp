using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.OperacoesMatematicas
{
    internal class SomaPares1a500
    {
        public static void Main(string[] args)
        {
            int soma = 0;
            for (int contador = 1; contador < 501; contador++)
            {
                if(contador % 2 == 0)
                {
                    soma = soma + contador;
                }
                else { }
             
            }
            Console.WriteLine($"A soma dos números pares de 1 até 500 é: {soma}");
        }
    }
}
