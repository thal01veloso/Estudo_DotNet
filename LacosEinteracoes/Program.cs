using System;
using System.Collections.Generic;
using System.Linq;

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
            
            Console.WriteLine(Buscarcomlinqlambda(sacolao, "Laranja"));
            //1ª forma de visualizar uma lista com foreach
            static string Buscarcomforeach(List<string> lista, string filtro)
            {
                foreach (string item in lista)
                {
                    if (item.Equals(filtro))
                    {
                        return item;
                    }
                }
                return null;
            }
            //2ª forma de visualizar uma lista com linq
            static string Buscarcomlinq(List<string> lista, string filtro)
            {
                return (from item in lista where item.Equals(filtro) select item).First();
            }
            //3ª forma de visualizar uma lista com lambda
            static string Buscarcomlinqlambda(List<string> lista, string filtro)
            {
                return lista.First(x => x.Equals(filtro));
            }




        }

    }
}

