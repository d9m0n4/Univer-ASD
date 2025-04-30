using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    // Класс для задания неориентированного графа матрицей смежности
    class GraphMatrix
    {
        private int vertices;          // Количество вершин
        private int[,] adjMatrix;      // Матрица смежности

        public GraphMatrix(int v)
        {
            vertices = v;
            adjMatrix = new int[v, v];
        }

        // Свойство для чтения матрицы смежности
        public int[,] AdjMatrix => adjMatrix;

        // Установить ребро (неориентированное), индексы 0-based
        public void AddEdge(int u, int v)
        {
            if (u < 0 || u >= vertices || v < 0 || v >= vertices)
                throw new ArgumentOutOfRangeException($"Индексы должны быть в диапазоне 0..{vertices - 1}. Получено: {u}, {v}");

            adjMatrix[u, v] = 1;
            adjMatrix[v, u] = 1;
        }

        // Построить и вернуть матрицу инцидентности
        public int[,] BuildIncidenceMatrix()
        {
            int edgeCount = 0;
            for (int i = 0; i < vertices; i++)
                for (int j = i + 1; j < vertices; j++)
                    if (adjMatrix[i, j] == 1)
                        edgeCount++;

            int[,] incMatrix = new int[vertices, edgeCount];
            int edgeIndex = 0;
            for (int i = 0; i < vertices; i++)
            {
                for (int j = i + 1; j < vertices; j++)
                {
                    if (adjMatrix[i, j] == 1)
                    {
                        incMatrix[i, edgeIndex] = 1;
                        incMatrix[j, edgeIndex] = 1;
                        edgeIndex++;
                    }
                }
            }
            return incMatrix;
        }

        // Поиск в ширину (BFS) с указанной начальной вершины
        public void BFS(int start)
        {
            if (start < 0 || start >= vertices)
                throw new ArgumentOutOfRangeException($"Стартовая вершина должна быть в диапазоне 0..{vertices - 1}. Получено: {start}");

            bool[] visited = new bool[vertices];
            Queue<int> queue = new Queue<int>();

            visited[start] = true;
            queue.Enqueue(start);

            while (queue.Count > 0)
            {
                int v = queue.Dequeue();
                Console.Write(v + " ");

                for (int i = 0; i < vertices; i++)
                {
                    if (adjMatrix[v, i] == 1 && !visited[i])
                    {
                        visited[i] = true;
                        queue.Enqueue(i);
                    }
                }
            }
        }

        // Печать любой матрицы в консоль
        public static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                    Console.Write(matrix[i, j] + " ");
                Console.WriteLine();
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество вершин: ");
            int v = int.Parse(Console.ReadLine());
            var graph = new GraphMatrix(v);

            Console.Write("Введите количество рёбер: ");
            int e = int.Parse(Console.ReadLine());

            Console.WriteLine($"Введите рёбра (номера вершин от 1 до {v}, через пробел):");
            for (int i = 0; i < e; i++)
            {
                var parts = Console.ReadLine().Split();
                int u = int.Parse(parts[0]) - 1;
                int w = int.Parse(parts[1]) - 1;
                try
                {
                    graph.AddEdge(u, w);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine("Ошибка ввода ребра: " + ex.Message);
                    i--; // повторить ввод
                }
            }

            Console.WriteLine("Матрица смежности:");
            GraphMatrix.PrintMatrix(graph.AdjMatrix);

            Console.WriteLine("Матрица инцидентности:");
            var inc = graph.BuildIncidenceMatrix();
            GraphMatrix.PrintMatrix(inc);

            Console.Write($"Введите начальную вершину для BFS (1–{v}): ");
            int start = int.Parse(Console.ReadLine()) - 1;
            try
            {
                Console.WriteLine("Результат BFS:");
                graph.BFS(start);
                Console.WriteLine();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Ошибка при запуске BFS: " + ex.Message);
            }

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}