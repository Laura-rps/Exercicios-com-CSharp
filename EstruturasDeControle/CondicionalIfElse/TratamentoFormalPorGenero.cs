using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.EstruturasDeControle.CondicionalIfElse
{
    internal class TratamentoFormalPorGenero
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Saudação personalizada");

            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite seu sobrenome: ");
            string sobrenome = Console.ReadLine();

            Console.WriteLine("Qual é o seu genero? F/M");
            string genero = Console.ReadLine().ToUpper();

            if(genero == "F")
            {
                Console.WriteLine($"Seja bem vinda {nome} {sobrenome}!");
            }
            else{
                Console.WriteLine($"Seja bem vindo {nome} {sobrenome}!");
            }
        }
    }
}
