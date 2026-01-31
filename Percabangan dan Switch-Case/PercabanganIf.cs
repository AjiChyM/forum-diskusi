using System;

class Program
{
    static void Main()
    {
        int nilai = 75;
        
        Console.WriteLine($"Nilai Anda: {nilai}");

        if (nilai >= 80)
        {
            Console.WriteLine("Status: Lulus dengan Sangat Baik (A)");
        }
        else if (nilai >= 70)
        {
            Console.WriteLine("Status: Lulus (B)");
        }
        else if (nilai >= 60)
        {
            Console.WriteLine("Status: Lulus Bersyarat (C)");
        }
        else
        {
            Console.WriteLine("Status: Tidak Lulus (D)");
        }
    }
}