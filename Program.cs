// for (int i = 0; i <= 100; i++ )
// {
//     Console.WriteLine("iterasi ke " + i);
// }

// int j = 1;
// while (j <= 100)
// {
//     Console.WriteLine("iterasi ke " + j);
//     j++;
// }

// int k = 10;
// do
// {
//     Console.WriteLine("iterasi ke " + k);
//     k++;
// } while (k < 5);

// int l = 10;
// while (l < 5)
// {
//     Console.WriteLine("iterasi ke-" + l);
// }

// var hasilPenjumlahan = 2;
// int i = 1;

// for (i = 1; i <= 100; i++)
// {
//     hasilPenjumlahan += i;
// }

// Console.WriteLine("Hasil penjumlahan " + hasilPenjumlahan);
// Console.WriteLine("Nilai I terakhir " + i);

for (int i = 1; 1 <= 100; i++)
{
    if (i % 2 == 1) continue;
    Console.WriteLine("iterasi ke " + i);

    if (i == 50) break;
}