using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.EstruturasDeControle
{
    internal class ForEachExemplo02
    {
        public static void Main(string[] args)
        {
            string[] aluno = { "Rodrigues", "Laura", "Breno", "Negreiros" };
            foreach(string alunoEx in aluno)
            {
                Console.WriteLine(alunoEx);
            }
        }
    }
}
