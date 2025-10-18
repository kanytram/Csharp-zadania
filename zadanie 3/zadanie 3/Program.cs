using System;

class Program
{
    static int[] tablica = new int[4] { 1, 2, 3, 4 };
    public static void Zamiana(int a, int b)
    {
        int bufor;
        bufor = tablica[a];
        tablica[a] = tablica[b];
        tablica[b] = bufor;       

    }
    static void Main()
    {
        

        Console.Write(tablica[0] + " ");
        Console.Write(tablica[1] + " ");
        Console.Write(tablica[2] + " ");
        Console.WriteLine(tablica[3] + " ");

        Zamiana(0, 3);

        Console.WriteLine(tablica[0]);
        Console.WriteLine(tablica[1]);
        Console.WriteLine(tablica[2]);
        Console.WriteLine(tablica[3]);
    }
}