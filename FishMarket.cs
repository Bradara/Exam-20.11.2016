using System;

namespace FishMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            var salomonPrice = decimal.Parse(Console.ReadLine());
            var cacaPrice = decimal.Parse(Console.ReadLine());
            var palamudKg = decimal.Parse(Console.ReadLine());
            var safridKg = decimal.Parse(Console.ReadLine());
            var midiKg = decimal.Parse(Console.ReadLine());

            var palamudPrice = salomonPrice * 1.6M;
            var safridPrice = cacaPrice * 1.8M;
            var midiPrice = 7.5M;

            var totalMoneyNeeded = palamudKg * palamudPrice + safridKg * safridPrice + midiKg * midiPrice;
            Console.WriteLine("{0:f2}", totalMoneyNeeded);
        }
    }
}
