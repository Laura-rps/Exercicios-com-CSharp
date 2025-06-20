using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.OperacoesMatematicas.SequenciasERepeticoes
{
    internal class Somados100Primeiros
    {
        public static void Main(string[] args)
        {
            int soma = 0;
            Console.WriteLine("Soma ate o 100");
            for(int contador = 1; contador <101; contador++)
            {
                soma = soma + contador;
                Console.WriteLine(soma);
            }
        }
    }
}
