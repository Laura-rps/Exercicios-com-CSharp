using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.EstruturasDeControle
{
    internal class TesteSubString
    {
        public static void Main(string[] args)
        {
            string nome = "Laura Roberto";
            int charPos = nome.IndexOf("R");
            string sobrenome = nome.Substring(charPos);
            Console.WriteLine(sobrenome);
        }
    }
}
