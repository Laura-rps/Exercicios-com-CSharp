using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.OperacoesMatematicas.Geral
{
    internal class Matematica
    {
        public static void Main(string[] args)
        {
            //Math.Max mostra o valor mais alto entre os numeros inseridos.
            Console.WriteLine("Esse math mostra o numero maximo.");
            Console.WriteLine(Math.Max(5, 10));

            //Math.Min mostra o valor mais baixo entre os numeros inseridos.
            Console.WriteLine("Esse math mostra o numero minimo.");
            Console.WriteLine(Math.Min(5, 10));

            //Math.Sqrt mostra a raiz quadrada do numero inserido. 
            Console.WriteLine("Esse math mostra a raiz quadrada de um numero.");
            Console.WriteLine(Math.Sqrt(64));

            //Math.Abs mostra o numero absoluto (positivo) de um x.
            Console.WriteLine("Esse math retorna o valor absoluto (positivo) de x.");
            Console.WriteLine(Math.Abs(-4.7));

            //Math.Round arredonda um numero float para o numero inteiro mais proximo.
            Console.WriteLine("Esse math arredonda um número para o número inteiro mais próximo.");
            Console.WriteLine(Math.Round(9.49));
        }
    }
}
