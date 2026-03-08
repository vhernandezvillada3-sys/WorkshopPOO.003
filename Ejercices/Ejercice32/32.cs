using System;

public class Ejercise32
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the size of the rhombus: ");
        int n = int.Parse(Console.ReadLine()!);

        char[,] r = new char[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                r[i, j] = ' ';
            }
        }
        int m = n / 2;

        
        for (int i = 0; i <= m; i++)
        {
            r[i, m - i] = '#';
            r[i, m + i] = '#';
            r[n - i - 1, m - i] = '#';
            r[n - i - 1, m + i] = '#';
        }

      
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(r[i, j]);
            }
            Console.WriteLine();
        }
    }
}