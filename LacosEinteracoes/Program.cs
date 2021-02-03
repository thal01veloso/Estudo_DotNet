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
            //1ª forma de visualizar uma lista
            foreach (var item in sacolao)
            {
                Console.WriteLine(item);
            };



        }
    }

}
