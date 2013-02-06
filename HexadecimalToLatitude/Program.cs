using System;

namespace HexadecimalToLatitude
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Latitude: ");
            string hexString = Console.ReadLine();
            
            var parser = new LatitudeParser(hexString);
            Console.WriteLine(parser.GetLatitude());
            Console.ReadKey();
        }
    }
}
