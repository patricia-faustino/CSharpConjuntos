using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhandoComConjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> devedores = new HashSet<string>();

            devedores.Add("Safira");
            devedores.Add("Bob");

            int elementos = devedores.Count();

            Console.WriteLine(elementos);

            //Não é possível adicionar elementos repetidos

            devedores.Add("Safira");

            elementos = devedores.Count();

            bool contem = devedores.Contains("Safira");

            Console.WriteLine(contem);

            //Não é possível acessar a posição do conjuntos. pois seus elementos não possuem ordenação bem determinada
            //devedores[0];

            foreach (var devedor in devedores)
            {
                Console.WriteLine(devedor);
            }

            Console.ReadLine();

        }
    }
}
