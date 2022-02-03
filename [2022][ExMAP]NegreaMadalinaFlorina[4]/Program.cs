using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022__ExMAP_NegreaMadalinaFlorina_4_
{
    class Program
    {
        /*Se citeşte un număr natural nenul n. Să se afişeze, 
         * în ordine invers lexicografică, permutările mulţimii {1,2,..,n}. 
         * Fişierul de intrare permutari1.in conţine pe prima linie numărul n. 
         * Fişierul de ieşire permutari1.out va conţine pe 
         * fiecare linie elementele unei permutări, separate prin câte un spaţiu.*/
        static void Main(string[] args)
        {
            int n;
            int[] arr = new int[9];
            n = int.Parse(Console.ReadLine());

            backtracking(0, n, arr);
            Console.WriteLine();
        }
        static bool verify(int pos, int[] arr)
        {
            for (int i = 0; i < pos; i++)
            {
                if (arr[i] == arr[pos])
                {
                    return false;
                }
            }
            return true;
        }
        static void backtracking(int pos, int n, int[] arr)
        {
            for (int i = n; i > 0; i--)
            {
                arr[pos] = i;
                if (verify(pos, arr))
                {
                    if (pos == n - 1)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write($"{arr[j]} ");
                        }
                    }
                    else
                    {
                        backtracking(pos + 1, n, arr);
                    }
                }
            }
        }
    }
}
