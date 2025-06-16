using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.OrientacaoAObjetos
{
    internal class ContadorDeVogais
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase: ");
            string frase = Console.ReadLine();

            frase = frase.ToLower();

            int contadorVogais = 0;

            string vogais = "aeiouáàãâéêíóôõúü";

            foreach (char c in frase)
            {
                if (vogais.Contains(c))
                {
                    contadorVogais++;
                }
            }
            Console.WriteLine($"Numero total de vogais é {contadorVogais}");
        }
    }
}
