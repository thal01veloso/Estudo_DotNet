using System;
using System.Collections.Generic;


namespace LacosEinteracoes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sacolao = new List<string>();
            sacolao.Add("Alface");
            sacolao.Add("Tomate");
            sacolao.Add("Laranja");
            sacolao.Add("Couve");
            sacolao.Add("Brocolis");
            sacolao.Add("Limão");


            BuscasPorFiltro buscas = new BuscasPorFiltro();
            buscas.BuscarListacomlinqlambda(sacolao, "l").ForEach(x => Console.WriteLine(x));
            //1ª forma de visualizar uma lista com foreach

        }

    }
}

