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
                string input = Console.ReadLine().Trim();
                string[] parts = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                // Проверка корректности ввода
                if (parts.Length != 2)
                {
                    Console.WriteLine("Ошибка! Введите два числа через пробел.");
                    i--; // Повторяем запрос для текущего ребра
                    continue;
                }

                if (!int.TryParse(parts[0], out int u) || !int.TryParse(parts[1], out int w))
                {
                    Console.WriteLine("Ошибка! Введите целые числа.");
                    i--;
                    continue;
                }

                // Проверка существования вершин
                if (u >= v || w >= v || u < 0 || w < 0)
                {
                    Console.WriteLine($"Ошибка! Вершины должны быть в диапазоне [0, {v - 1}].");
                    i--;
                    continue;
                }

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
