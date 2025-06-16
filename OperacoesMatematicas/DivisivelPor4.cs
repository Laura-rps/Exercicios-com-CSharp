using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.OperacoesMatematicas
{
    internal class DivisivelPor4
    {
        public static void Main(string[] args)
        {
          for(int i = 1; i < 200; i++)
            {
                if(i % 4 == 0)
                {
                    Console.WriteLine(i);
                }
                else { }
            }
        }
    }
}
