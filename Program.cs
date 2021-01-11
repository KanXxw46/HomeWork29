using System;

namespace Hw29_Paterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Mechanik mechanik = new Mechanik();
            CarBuilder carBuilder =  new Trakrot();
            var traktor = mechanik.Make(carBuilder);
            Console.WriteLine(traktor.ToString());
        }
    }
}
