using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022__ExMAP_NegreaMadalinaFlorina_15_
{
    class Program
    {
        /*Scrieţi un program care citeşte de la tastatură numere naturale din intervalul [3,102], 
         * în această ordine: n şi m, apoi elementele unui tablou bidimensional cu n linii şi m coloane, 
         * iar la final un număr x. Programul afişează pe ecran mesajul DA, dacă există cel puțin un 
         * element egal cu x aflat pe conturul tabloului 
         * (format din prima linie, ultima linie, prima coloană și ultima coloană), sau mesajul NU în caz contrar.*/
        static void Main(string[] args)
        {
            int n, m, x, ok = 0;
            int[,] a = new int[101, 101];

            Console.WriteLine("Introduceti numarul de linii:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numarul de coloane:");
            m = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti valorile matricei:");
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Introduceti un numar oarecare:");
            x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (a[i, 1] == x || a[i, m] == x)
                {
                    ok = 1;
                }
            }
            for (int j = 1; j <= m; j++)
            {
                if (a[1, j] == x || a[n, j] == x)
                {
                    ok = 1;
                }
            }
            if (ok == 1)
            {
                Console.WriteLine("DA");
            }
            else
            {
                Console.WriteLine("NU");
            }
        }
    }
}
