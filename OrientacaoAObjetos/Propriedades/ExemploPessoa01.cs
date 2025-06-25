using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.OrientacaoAObjetos.Propriedades
{
    internal class ExemploPessoa01
    {
        public string Nome { get; set; }
        public static void Main(string[] args)
        {
            ExemploPessoa01 laura = new ExemploPessoa01();

            laura.Nome = "Laura";

            Console.WriteLine(laura.Nome);
        }
    }
}
