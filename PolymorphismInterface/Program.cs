using System;

namespace PolymorphismInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nama \t: Naima Zulfa");
            Console.WriteLine("NIM \t: 19.11.2735");
            Console.WriteLine("Kelas \t: 19 IF 03\n");

            IPrinterWindows printer;

            Console.WriteLine("Pilih Printer: ");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. LaserJet\n");

            Console.WriteLine("Nomor Printer [1..3]: ");
            int nomorPrinter = Convert.ToInt32(Console.ReadLine());

            if (nomorPrinter == 1)
                printer = new Epson();
            else if (nomorPrinter == 2)
                printer = new Canon();
            else if (nomorPrinter == 3)
                printer = new LaserJet();
            else
            {
                Console.WriteLine("\nInput Salah\n");
                return;
            }
            printer.Show();
            printer.Print();

        }
    }
}
