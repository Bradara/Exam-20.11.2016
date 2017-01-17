using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            var daysOff = int.Parse(Console.ReadLine());
            var foodStore = int.Parse(Console.ReadLine());
            var dogFoodDay = double.Parse(Console.ReadLine());
            var catFoodDay = double.Parse(Console.ReadLine());
            var turttleFoodDay = double.Parse(Console.ReadLine())/1000;

            var foodNeeded = daysOff * (dogFoodDay + catFoodDay + turttleFoodDay);

            if (foodStore>=foodNeeded)
            {
                Console.WriteLine("{0} kilos of food left.", Math.Floor(foodStore-foodNeeded));
            }
            else Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(foodNeeded-foodStore));

        }
    }
}
