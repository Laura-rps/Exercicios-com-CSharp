using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosComCsharp.OrientacaoAObjetos.Construtores
{
    internal class ExemploVariosParametros
    {
        public string modelo;
        public string cor;
        public int ano;
        public string marca;
        public int preco;

        public ExemploVariosParametros(string nomeModelo, string modeloCor, int modeloAno, string modeloMarca, int modeloPreco)
        {
            modelo = nomeModelo;
            cor = modeloCor;
            ano = modeloAno;
            marca = modeloMarca;
            preco = modeloPreco;
        }

        public static void Main(string[] args)
        {
            ExemploVariosParametros Chevrolet = new ExemploVariosParametros("Opala 6 CC", "Preto", 1988, "Chevrolet", 1000);

            Console.WriteLine($"Voce tem um {Chevrolet.marca}, {Chevrolet.modelo} da cor {Chevrolet.cor} que foi feito no ano {Chevrolet.ano} e custa {Chevrolet.preco}.");
        }
    }
}
