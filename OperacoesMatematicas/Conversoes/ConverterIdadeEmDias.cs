using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.OperacoesMatematicas.Conversoes
{
    internal class ConverterIdadeEmDias
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Conversão de idade em dias");
            Console.WriteLine("");

            Console.WriteLine("Digite sua idade em anos: ");
            int anos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite quantos meses se passaram desde o seu ultimo aniversario: ");
            int meses = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite quantos dias se passaram desse mês (se seu aniversaio foi esse mês, conte a partir do seu aniversario): ");
            int dias = Convert.ToInt32(Console.ReadLine());

            int resultado = (anos * 365) + (meses * 30) + dias;

            Console.WriteLine($"A idade em dias é {resultado}");
            
        }
    }
}
