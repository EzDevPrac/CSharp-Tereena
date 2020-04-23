using System;

namespace SpiralOrder_2
{
    public class Program
    {
        static int R = 4;
        static int C = 4;

        /* i - starting row index 
            m - ending row index 
            j - starting column index 
            n - ending column index 
            p - iterator 
            */
        static void print(int[,] arr, int i,
                          int j, int m, int n)
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();

            // If i or j lies outside the matrix 
            if (i >= m || j >= n)
            {
                return;
            }

            // Print First Row 
            for (int p = i; p < n; p++)
            {
                Console.Write(arr[i, p] + " ");
            }

            // Print Last Column 
            for (int p = i + 1; p < m; p++)
            {
                Console.Write(arr[p, n - 1] + " ");
            }

            // Print Last Row, if Last and First Row are not same 
            if ((m - 1) != i)
            {
                for (int p = n - 2; p >= j; p--)
                {
                    Console.Write(arr[m - 1, p] + " ");
                }
           }

            // Print First Column, if Last and First Column are not same 
            if ((n - 1) != j)
            {
                for (int p = m - 2; p > i; p--) 
                {
                    Console.Write(arr[p, j] + " ");
                }
            }
            
            print(arr, i + 1, j + 1, m - 1, n - 1);
            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");

        }

        public static void Main(string[] args)
        {
            int[,] a = {{1, 2, 3, 4},
                    {5, 6, 7, 8},
                    {9, 10, 11, 12},
                    {13, 14, 15, 16}};

            print(a, 0, 0, R, C);
        }
    }
}
