using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        class Graph
        {
            private int vertices;                   // Количество вершин
            private List<int>[] adjList;           // Список смежности

            public Graph(int v)
            {
                vertices = v;
                adjList = new List<int>[v];
                for (int i = 0; i < v; i++)
                {
                    adjList[i] = new List<int>();
                }
            }

            // Добавление ребра (неориентированное)
            public void AddEdge(int v, int w)
            {
                adjList[v].Add(w);
                adjList[w].Add(v);
            }

            // Поиск в глубину с указанной начальной вершины
            public void DFS(int start)
            {
                bool[] visited = new bool[vertices];
                DFSUtil(start, visited);
            }

            // Вспомогательный метод рекурсивного обхода
            private void DFSUtil(int v, bool[] visited)
            {
                visited[v] = true;
                Console.Write(v + " ");

                foreach (int neighbor in adjList[v])
                {
                    if (!visited[neighbor])
                    {
                        DFSUtil(neighbor, visited);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введите количество вершин: ");
            int v = int.Parse(Console.ReadLine());

            Graph graph = new Graph(v);

            Console.Write("Введите количество ребер: ");
            int e = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите ребра (u v):");
            for (int i = 0; i < e; i++)
            {
                string[] parts = Console.ReadLine().Split();
                int u = int.Parse(parts[0]);
                int w = int.Parse(parts[1]);
                graph.AddEdge(u, w);
            }

            Console.Write("Введите начальную вершину для DFS: ");
            int start = int.Parse(Console.ReadLine());

            Console.WriteLine("Результат DFS:");
            graph.DFS(start);

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
