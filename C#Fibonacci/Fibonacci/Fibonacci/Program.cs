
using System;

class Program
{
    static void Fibonacci(int n)
    {
        int a = 2;
        int b = 5;

        for (int i = 0; i < n; i++)
        {
            int volgend = a + b;
            a = b;
            b = volgend;

            Console.Write(a + " ");
        }
    }

    static void Main()
    {
        Console.Write("Voer een getal in: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Fibonacci(n);
    }
}
