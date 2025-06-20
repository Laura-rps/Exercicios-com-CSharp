using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.EstruturasDeControle.CondicionalIfElse
{
    internal class IfTernario
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Exemplo If Ternario\n");
            Console.WriteLine("Verificar se há idade ou não para entrar na Casa Noturna\n");
            Console.WriteLine("Digite a idade: ");
            int idade = Convert.ToInt16(Console.ReadLine());
            string verificar = idade < 18 ? "Não pode entrar" : "Pode entrar"; 
            Console.WriteLine(verificar);
        }
    }
}
