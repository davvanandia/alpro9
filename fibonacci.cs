using System;

class Fibonacci
{
    static void Main()
    {
        Console.Write("Masukkan jumlah angka: ");
        int jumlah = Convert.ToInt32(Console.ReadLine());

        int a = 0;
        int b = 1;
        int i = 0;

        Console.WriteLine("Deret Fibonacci:");

        while (i < jumlah)
        {
            Console.Write(a + " ");

            int berikutnya = a + b;
            a = b;
            b = berikutnya;

            i++;
        }
    }
}