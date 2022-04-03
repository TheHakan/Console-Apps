using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRainy = true;
            bool isSunny = false;
            bool isRainyAndisSunny;
            isRainyAndisSunny = isSunny || isRainy;
            Console.WriteLine(isRainyAndisSunny);
            Console.Read();
        }
    }
}
