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
            //1ª forma de visualizar uma lista com foreach
            Console.WriteLine(Buscarcomforeach(sacolao, "Laranja")); 

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





        }

    }
}

