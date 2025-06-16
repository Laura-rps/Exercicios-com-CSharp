using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExerciciosComCsharp.EstruturasDeControle;

namespace ExerciciosComCsharp.OrientacaoAObjetos
{
    internal class CestaDeFrutas
    {
        public static void Main(string[] args)
        {
            Fruta fruta = new Fruta();
            Console.WriteLine($"Fruta: {fruta.nome}");
            Console.WriteLine($"Preço: {fruta.preco}");
        }
    }
}
