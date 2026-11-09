using System;

class Faktorial5
{
    static void Main()
    {
        Console.Write("Masukkan angka: ");
        int angka = Convert.ToInt32(Console.ReadLine());

        int hasil = 1;

        for (int i = 1; i <= angka; i++)
        {
            hasil *= i;
        }

        Console.WriteLine("Hasil faktorial " + angka + " adalah " + hasil);
    }
}