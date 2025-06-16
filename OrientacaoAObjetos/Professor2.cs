using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.OrientacaoAObjetos
{
    internal class Professor2
    {
        string nome = "Jailson";
        string nacionalidade = "Brasileira";
        string estado = "São Paulo";

        public static void Main(string[] args)
        {
            Professor2 MeuObj1 = new Professor2();
            Professor2 MeuObj2 = new Professor2();

            Console.WriteLine($"A nacionalidade do professor {MeuObj1.nome} é {MeuObj1.nacionalidade} e ele reside no estado de {MeuObj1.estado}");
            MeuObj2.nome = "Aurora";
            Console.WriteLine($"A nacionalidade da professora {MeuObj2.nome} é {MeuObj2.nacionalidade} e ela reside no estado de {MeuObj2.estado}");
        } 
    }
}
