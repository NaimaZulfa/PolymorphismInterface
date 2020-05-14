using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismInterface
{
    class Epson : IPrinterWindows
    {
        public void Show()
        {
            Console.WriteLine("Epson display dimension: 10*11");
        }

        public void Print()
        {
            Console.WriteLine("Epson printer printing....");
        }
    }
}
