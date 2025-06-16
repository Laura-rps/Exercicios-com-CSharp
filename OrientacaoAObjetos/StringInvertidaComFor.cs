using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.OrientacaoAObjetos
{
    internal class StringInvertidaComFor
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite uma palavra: ");
            string palavra = Console.ReadLine();

            string invertida = "";

            for (int i = palavra.Length - 1; i >= 0; i--)
            {
                invertida += palavra[i];
            }
            Console.WriteLine($"Palavra invertida {invertida}");
        }
    }
}
