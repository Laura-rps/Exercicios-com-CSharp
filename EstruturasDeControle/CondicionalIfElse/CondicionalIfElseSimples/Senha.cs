using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.EstruturasDeControle.CondicionalIfElse.CondicionalIfElseSimples
{
    internal class Senha
    {
        public static void Main(string[] args)
        {
            int senha;

            Console.WriteLine("Digite o codigo do usuario: ");
            int usuario = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("Usuario Invalido!");
                Console.WriteLine("Digite o codigo do usuario: ");
                usuario = int.Parse(Console.ReadLine());
            } while (usuario != 1234);

            if(usuario == 1234)
            {
                Console.WriteLine("Digite a senha: ");
                senha = int.Parse(Console.ReadLine());
            }
            do
            {
                Console.WriteLine("Senha invalida!");
                Console.WriteLine("Digite a senha: ");
                senha = int.Parse(Console.ReadLine());
            } while (senha != 9999);

            if(senha == 9999)
            {
                Console.WriteLine("Usuario aprovado!");
            }
        }
    }
}
