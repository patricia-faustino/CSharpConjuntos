using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhandoComConjuntos
{
    partial class Program
    {
        static void TesteSortedSet()
        {
            SortedSet<string> devedores = new SortedSet<string>();

            devedores.Add("Safira");
            devedores.Add("BOB");
            devedores.Add("Stuart");
            devedores.Add("Stevan");
            devedores.Add("Fabricio");
            devedores.Add("Fernando");
            devedores.Add("Edward");

            int elementos = devedores.Count();
            Console.WriteLine(elementos);

            //Também não é permitido adicionar itens repetidos
            devedores.Add("Safira");
            elementos = devedores.Count();

            Console.WriteLine(elementos);

            //Os elementos são guardados em ordem crescente
            foreach (var devedor in devedores)
            {
                Console.WriteLine(devedor);
            }
        }
    }
}
