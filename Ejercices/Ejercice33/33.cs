using System;

public class Exercise33
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the value of m: ");
        int m = int.Parse(Console.ReadLine()!);

        Console.Write("Enter the value of n: ");
        int n = int.Parse(Console.ReadLine()!);

        Console.Write("Enter the value of p: ");
        int p = int.Parse(Console.ReadLine()!);

    
        int[,] a = new int[m, n];
        int[,] b = new int[n, p];
        int[,] c = new int[m, p];

    
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                a[i, j] = (i + 1) * j;
            }
        }

       
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < p; j++)
            {
                b[i, j] = (j + 1) * i;
            }
        }

     
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < p; j++)
            {
                for (int k = 0; k < n; k++)
                {
                    c[i, j] += a[i, k] * b[k, j];
                }
            }
        }

       
        Console.WriteLine("*** A ***");
        ShowMatrix(a, m, n);

        Console.WriteLine("*** B ***");
        ShowMatrix(b, n, p);

        Console.WriteLine("*** C ***");
        ShowMatrix(c, m, p);
    }

    public static void ShowMatrix(int[,] matrix, int rows, int columns)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}