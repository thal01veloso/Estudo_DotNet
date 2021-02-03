using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LacosEinteracoes
{
    public class BuscasPorFiltro
    {
        public string Buscarcomforeach(List<string> lista, string filtro)
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
        public string Buscarcomlinq(List<string> lista, string filtro)
        {
            return (from item in lista where item.Equals(filtro) select item).First();
        }
        //3ª forma de visualizar uma lista com lambda
        public string Buscarcomlinqlambda(List<string> lista, string filtro)
        {
            return lista.First(x => x.Equals(filtro));
        }

        //4ª forma de visualizar uma lista com linklambda que contém
        public List<string> BuscarListacomlinq(List<string> lista, string filtro)
        {
            return (from item in lista where item.Contains(filtro) select item).ToList();
        }

        //5ª forma de visualizar uma lista com lambda que contém
        public List<string> BuscarListacomlinqlambda(List<string> lista, string filtro)
        {
            return (from item in lista where item.Contains(filtro) select item).ToList();
        }
    }
}
