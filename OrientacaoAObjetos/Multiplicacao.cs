using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.OrientacaoAObjetos
{
    internal class MultiplicacaoCom4For
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Tabuada do 1 ao 10");
            int[,] matriz = new int[10, 10]; // Cria uma matriz (array 2D) de inteiros com 10 linhas e 10 colunas.

            for (int linha = 0; linha < 10; linha++) // Preenche as linhas
            {
                for(int coluna = 0; coluna < 10; coluna++) // Preenche as colunas
                {
                    matriz[linha, coluna] = (linha + 1) * (coluna + 1); // Armazena o valor do resultado
                }
            }
            for (int linha = 0; linha < 10; linha++) // Percorre as linhas
            {
                for(int coluna = 0; coluna < 10; coluna++) // Percorre as colunas
                {
                    Console.Write(matriz[linha, coluna].ToString().PadLeft(4)); //Imprime os resultados 
                }
                Console.WriteLine();
            }
        }
    }
}
