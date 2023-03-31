using System;
using System.Security.Cryptography.X509Certificates;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] meningar = new string[4];
            meningar[0] = "veckorna är långa, helgerna är korta.";
            meningar[1] = "gräs är grönt";
            meningar[2] = "hamnburgare är inte dålig mat";
            meningar[3] = "det är snart helg";
            int x = 0;
            do
            {
                Console.WriteLine(meningar[x]);
                Console.WriteLine(" ");
                x++;
            }
            while (x<4);
        }
    }
}
