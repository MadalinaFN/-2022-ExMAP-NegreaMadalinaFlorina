using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022__ExMAP_NegreaMadalinaFlorina_20_
{
    class Program
    {
        /*Se dau 3 vectori care se introduc de la tastatură. Să se scrie programul de
          determinare:
          a) al produsului mixt al celor 3 vectori
          b) Să se verifice dacă vectorii sunt coplanari
          c) Să se calculeze volumul paralelogramului construit pe cei trei vectori ca
          muchii.*/
        static void Main(string[] args)
        {
            double x1, y1, z1, x2, y2, z2, x3, y3, z3, prodmixt;
            Console.WriteLine("Introduceti coordonatele primului vector:");
            x1 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());
            z1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti coordonatele la al doilea vector:");
            x2 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());
            z2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti coordonatele la al treilea vector:");
            x3 = double.Parse(Console.ReadLine());
            y3 = double.Parse(Console.ReadLine());
            z3 = double.Parse(Console.ReadLine());
            prodmixt = (x1 * y2 * z3) + (x2 * y3 * z1) + (x3 * y1 * z2) - (x3 * y2 * z1) - (x1 * y3 * z2) - (x2 * y1 * z3);
            Console.WriteLine($"Produsul mixt este:{prodmixt}");
            if (prodmixt == 0)
            {
                Console.WriteLine("Sunt coplanari");
            }
            else
            {
                Console.WriteLine("Nu sunt coplanari");
            }
            Console.WriteLine($"Volumul paralelogramului este:{Math.Sqrt(Math.Pow(prodmixt, 2))}");
        }
    }
}
