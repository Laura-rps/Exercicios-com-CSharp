using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.EstruturasDeControle
{
    internal class DoWhile
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Utilizando Do While");
                int i = 0;
                do
                {
                    i++;
                    Console.WriteLine(i);
                } while (i < 5);

            }
        }
    }

