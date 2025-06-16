using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.OrientacaoAObjetos
{
    internal class ArgumentosNomeados
    {
        static void Criancas(string crianca1, string crianca2, string crianca3)
        {
            Console.WriteLine($"A criança mais nova é: {crianca3}");
        }
        public static void Main(string[] args)
        {
            Criancas(crianca1: "Lucas", crianca2: "Vitoria", crianca3: "Felipe");
        }
    }
}
