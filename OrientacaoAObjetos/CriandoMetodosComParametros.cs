using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.OrientacaoAObjetos
{
    internal class CriandoMetodosComParametros
    {
        public static void Sobrenome(string nome)
        {
            Console.WriteLine(nome + " Silva");
        }
        public static void Main(string[] args)
        {
            Sobrenome("Felipe ");
            Sobrenome("Laura "); 
        }
    }
}
