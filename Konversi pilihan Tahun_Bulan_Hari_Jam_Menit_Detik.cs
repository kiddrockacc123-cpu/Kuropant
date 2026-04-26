class Program
{
    static void Main()
    {
        Console.WriteLine("=== KONVERSI WAKTU ===");
        Console.WriteLine("1. Detik");
        Console.WriteLine("2. Menit");
        Console.WriteLine("3. Jam");
        Console.WriteLine("4. Hari");
        Console.WriteLine("5. Bulan");
        Console.WriteLine("6. Tahun");

        Console.Write("Pilih satuan (1-6): ");
        int pilihan = int.Parse(Console.ReadLine());

        Console.Write("Masukkan nilai: ");
        double nilai = double.Parse(Console.ReadLine());

        // Konversi ke detik (base)
        double detik = 0;

        switch (pilihan)
        {
            case 1: detik = nilai; break;
            case 2: detik = nilai * 60; break;
            case 3: detik = nilai * 3600; break;
            case 4: detik = nilai * 86400; break;
            case 5: detik = nilai * 2592000; break; // 30 hari
            case 6: detik = nilai * 31536000; break; // 365 hari
            default:
                Console.WriteLine("Pilihan tidak valid!");
                return;
        }

        // Konversi ke semua satuan
        double menit = detik / 60;
        double jam = detik / 3600;
        double hari = detik / 86400;
        double bulan = detik / 2592000;
        double tahun = detik / 31536000;

        Console.WriteLine("\n=== HASIL KONVERSI ===");
        Console.WriteLine($"Detik : {detik}");
        Console.WriteLine($"Menit : {menit}");
        Console.WriteLine($"Jam   : {jam}");
        Console.WriteLine($"Hari  : {hari:F0}");
        Console.WriteLine($"Bulan : {bulan:F0}");
        Console.WriteLine($"Tahun : {tahun:F0}");
    }
}