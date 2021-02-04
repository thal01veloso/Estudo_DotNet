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
            sacolao.Add("Abacate");
            sacolao.Add("Couve-flor");

            Dictionary<int, string> tabela = new Dictionary<int, string>();
            tabela.Add(10, "tomates");
            tabela.Add(12, "laranjas");
            tabela.Add(8, "abacate");
            tabela.Add(15, "bananas");
            tabela.Add(9, "melancia");
            tabela.Add(20, "jabuticabas");
            tabela.Add(17, "limão");

            var total = 0;
            foreach (var item in tabela)
            {
                total = total + item.Key;
            }
            tabela.Add(total, "Total");
            
            foreach(var item in tabela)
            {
                Console.WriteLine(item);
            }




            //BuscasPorFiltro buscas = new BuscasPorFiltro();
            //buscas.BuscarListacomlinqlambda(sacolao, "a").ForEach(x => Console.WriteLine(x));
            //1ª forma de visualizar uma lista com foreach

        }

    }
}

