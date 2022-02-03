using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022__ExMAP_NegreaMadalinaFlorina_6_
{
    class Program
    {
        /*a)Sa se afiseze matricea de adiacenta a unui graf.
          b) sa se faca parcurgerea lui prin algoritmul BFS si sa se afiseze aceasta.
          c) sa se faca parcurgerea lui prin algoritmul DFS si sa se afiseze acesta.
          d) Sa se verifice daca graful este bipartit.*/
        public static int[,] matAd;
        static void Main(string[] args)
        {
            matAd = load(@"..\..\data.in");
            Console.WriteLine("Matricea:");
            view(matAd);
            Console.WriteLine("BFS:");
            BFS(1, matAd.GetLength(0));
            Console.WriteLine();
            Console.WriteLine("DFS:");
            visited = new bool[matAd.GetLength(0)];
            DFS(1, matAd.GetLength(0));
            Console.WriteLine();
            Console.WriteLine("Bipartit:");
            Console.Write(Bipartit(1, matAd.GetLength(0)));

            Console.ReadKey();
        }

        static int[,] load(string fileName)
        {
            int lines, columns;

            string buffer;
            List<string> data = new List<string>();
            System.IO.TextReader dataLoad = new System.IO.StreamReader(fileName);
            while ((buffer = dataLoad.ReadLine()) != null)
            {
                data.Add(buffer);

            }
            dataLoad.Close();

            lines = data.Count();
            columns = lines;

            int[,] toReturn = new int[lines, columns];
            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    toReturn[i, j] = int.Parse((data[i])[j].ToString());
                }
            }
            return toReturn;
        }

        static void view(int[,] toView)
        {
            int lines = toView.GetLength(0);
            int columns = toView.GetLength(1);
            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(toView[i, j] + " ");

                }
                Console.WriteLine();
            }
        }

        static void BFS(int start, int n)
        {
            Queue q = new Queue();
            q.Push(start);
            bool[] visited = new bool[n];
            visited[start] = true;
            while (q.values.Length != 0)
            {
                int nodCurent = q.Pop();
                Console.Write(nodCurent);
                for (int i = 0; i < n; i++)
                {
                    if (matAd[nodCurent, i] != 0 && visited[i] == false)
                    {
                        q.Push(i);
                        visited[i] = true;
                    }
                }
            }
        }

        private static bool[] visited;
        static void DFS(int nodCurent, int n)
        {
            Console.Write(nodCurent + " ");
            visited[nodCurent] = true;
            for (int i = 0; i < n; i++)
            {

                if (matAd[nodCurent, i] != 0 && visited[i] == false)
                {
                    DFS(i, n);
                }
            }
        }

        static bool Bipartit(int start, int n)
        {
            Queue q = new Queue();
            q.Push(start);
            int[] visited = new int[n];
            visited[start] = 1;
            while (q.values.Length != 0)
            {
                int nodCurent = q.Pop();

                for (int i = 0; i < n; i++)
                {
                    if (matAd[nodCurent, i] != 0)
                    {
                        if (visited[i] == 0)
                        {
                            q.Push(i);
                            if (visited[nodCurent] == 1)
                                visited[i] = 2;
                            else
                                visited[i] = 1;
                        }
                        else
                        {
                            if (visited[nodCurent] == visited[i])
                                return false;
                        }
                    }
                }
            }
            return true;
        }
    }
}
