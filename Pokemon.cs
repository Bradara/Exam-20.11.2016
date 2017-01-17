using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            var player1 = int.Parse(Console.ReadLine());
            var player2 = int.Parse(Console.ReadLine());
            var battles = int.Parse(Console.ReadLine());
            var count = 0;

            for (int pok1 = 1; pok1 <= player1; pok1++)
            {
                for (int pok2 = 1; pok2 <= player2; pok2++)
                {
                    if (count<battles)
                    {
                        Console.Write("({0} <-> {1}) ", pok1, pok2);
                    }
                    count++;
                }
            }
        }
    }
}
