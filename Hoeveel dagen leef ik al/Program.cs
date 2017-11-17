using System;

namespace Hoeveel_dagen_leef_ik_al
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime verjaardag = new DateTime(2001, 9, 11, 12, 0, 5);
            TimeSpan ts = DateTime.Now - verjaardag;
            Console.WriteLine(ts + " dagen !");
        }
    }
}
