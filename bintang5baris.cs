using System;

class Bintang5Baris
{
    static void Main()
    {
        Console.Write("Masukkan jumlah baris: ");
        int baris = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= baris; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}