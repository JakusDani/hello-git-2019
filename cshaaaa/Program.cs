using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cshaaaa {
    class Program {
        static void Main(string[] args) 
        {
            List<int> lista = new List<int>();
            int szamlalo = 0;
            int ertek = 0;
            int max = 0;
            int min = 1000000000;

            Console.Write("kérem adja meg a darabszámot: ");
            szamlalo = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < szamlalo; i++) 
            {
                Console.Write("kérem adjon meg egy számot: ");
                ertek = Convert.ToInt32(Console.ReadLine());
                lista.Add(ertek);
                //szamlalo++;
            }    
            for (int i = 0; i < szamlalo; i++) 
            {
                if (lista[i] > max)
                {
                    max = lista[i];
                }
            }
            for (int i = 0; i < szamlalo; i++) 
            {
                if (lista[i] < min) 
                {
                    min = lista[i];
                }
            }
            Console.WriteLine("A legnagyobb szám a {0}",max);
            Console.WriteLine("A legkisebb szám a {0}",min);
            Console.ReadLine();
        }
    }
}
