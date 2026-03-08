using System;

public class Ejercice32
{
    public static void Main(string[] args)
    {
        Console.Write("Ingrese el tamaño del rombo: ");
        int n = int.Parse(Console.ReadLine()!);

        char[,] r = new char[n, n];

        // Inicializar la matriz con espacios en blanco
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                r[i, j] = ' ';
            }
        }

        int m = n / 2;

        // Dibujar el rombo
        for (int i = 0; i <= m; i++)
        {
            r[i, m - i] = '#';
            r[i, m + i] = '#';
            r[n - i - 1, m - i] = '#';
            r[n - i - 1, m + i] = '#';
        }

        // Mostrar el rombo
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