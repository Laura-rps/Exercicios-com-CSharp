using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.OrientacaoAObjetos
{
    internal class StringInvertida
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite uma palavra: ");
            string palavra = Console.ReadLine();

            string invertida = new string(palavra.Reverse().ToArray());

            Console.WriteLine(invertida);
        }
    }
}
