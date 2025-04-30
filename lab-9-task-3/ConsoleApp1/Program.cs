using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    // Класс для представления взвешенного неориентированного графа списком смежности
    class WeightedGraph
    {
        private int vertices;
        private List<(int to, int weight)>[] adjList;

        public WeightedGraph(int v)
        {
            vertices = v;
            adjList = new List<(int to, int weight)>[v];
            for (int i = 0; i < v; i++)
                adjList[i] = new List<(int to, int weight)>();
        }

        public void AddEdge(int u, int v, int w)
        {
            if (u < 0 || u >= vertices || v < 0 || v >= vertices)
                throw new ArgumentOutOfRangeException($"Индексы вершин должны быть в диапазоне 0..{vertices - 1}.");
            if (w < 0)
                throw new ArgumentOutOfRangeException("Вес ребра не может быть отрицательным.");

            adjList[u].Add((v, w));
            adjList[v].Add((u, w)); // для неориентированного графа
        }

        // Реализация алгоритма Дейкстры от стартовой вершины
        public int[] Dijkstra(int start)
        {
            const int INF = int.MaxValue;
            int[] dist = new int[vertices];
            bool[] used = new bool[vertices];
            for (int i = 0; i < vertices; i++)
                dist[i] = INF;

            dist[start] = 0;
            var pq = new SortedSet<(int dist, int vertex)>();
            pq.Add((0, start));

            while (pq.Count > 0)
            {
                var current = pq.Min;
                pq.Remove(current);
                int u = current.vertex;
                int d = current.dist;

                if (used[u]) continue;
                used[u] = true;

                foreach (var (to, weight) in adjList[u])
                {
                    if (dist[u] != INF && dist[to] > dist[u] + weight)
                    {
                        int old = dist[to];
                        dist[to] = dist[u] + weight;
                        if (old != INF)
                            pq.Remove((old, to));
                        pq.Add((dist[to], to));
                    }
                }
            }
            return dist;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество вершин: ");
            if (!int.TryParse(Console.ReadLine(), out int v) || v <= 0)
            {
                Console.WriteLine("Ошибка: введите целое положительное число вершин.");
                return;
            }
            var graph = new WeightedGraph(v);

            Console.Write("Введите количество рёбер: ");
            if (!int.TryParse(Console.ReadLine(), out int e) || e < 0)
            {
                Console.WriteLine("Ошибка: введите неотрицательное целое число рёбер.");
                return;
            }

            Console.WriteLine($"Введите {e} рёбер в формате: u v вес (номера вершин от 1 до {v}, вес >= 0)");
            int count = 0;
            while (count < e)
            {
                var input = Console.ReadLine();
                var parts = input.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length != 3
                    || !int.TryParse(parts[0], out int u1)
                    || !int.TryParse(parts[1], out int v1)
                    || !int.TryParse(parts[2], out int w)
                    )
                {
                    Console.WriteLine("Неверный формат. Повторите ввод: u v вес");
                    continue;
                }
                int u = u1 - 1;
                int vv = v1 - 1;
                try
                {
                    graph.AddEdge(u, vv, w);
                    count++;
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine("Ошибка ввода: " + ex.Message);
                }
            }

            Console.Write($"Введите начальную вершину для Дейкстры (1–{v}): ");
            if (!int.TryParse(Console.ReadLine(), out int start1) || start1 < 1 || start1 > v)
            {
                Console.WriteLine("Ошибка: неверный номер стартовой вершины.");
                return;
            }
            int start = start1 - 1;

            Console.WriteLine($"Кратчайшие расстояния от вершины {start1}:");
            try
            {
                var distances = graph.Dijkstra(start);
                for (int i = 0; i < distances.Length; i++)
                {
                    string dStr = distances[i] == int.MaxValue ? "∞" : distances[i].ToString();
                    Console.WriteLine($"до вершины {i + 1}: {dStr}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при выполнении алгоритма: " + ex.Message);
            }

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}