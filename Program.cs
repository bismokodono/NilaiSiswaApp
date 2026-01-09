using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.Title = "Aplikasi Keren by Mas 😎";
        Console.BackgroundColor = ConsoleColor.Black;
        Console.Clear();

        TulisPelan("🚀 Memulai Aplikasi Keren...\n", ConsoleColor.Cyan, 40);
        LoadingBar();

        Console.Clear();
        TulisPelan("✨ SELAMAT DATANG ✨\n", ConsoleColor.Yellow, 50);
        TulisPelan("Aplikasi Console C# Visual Studio\n", ConsoleColor.Green, 40);
        TulisPelan("Dibuat dengan ❤️ dan Logika\n\n", ConsoleColor.Magenta, 40);

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Tekan ENTER untuk keluar...");
        Console.ReadLine();
    }

    static void TulisPelan(string teks, ConsoleColor warna, int delay)
    {
        Console.ForegroundColor = warna;
        foreach (char c in teks)
        {
            Console.Write(c);
            Thread.Sleep(delay);
        }
    }

    static void LoadingBar()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("\nLoading: ");

        for (int i = 0; i <= 20; i++)
        {
            Console.Write("█");
            Thread.Sleep(100);
        }
        Thread.Sleep(500);
    }
}
