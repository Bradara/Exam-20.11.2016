using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var mature = int.Parse(Console.ReadLine());
            var students = int.Parse(Console.ReadLine());
            var nights = int.Parse(Console.ReadLine());
            var transport = Console.ReadLine();

            var transPriceMature = 0M;
            var transPriceStudent = 0M;

            switch (transport)
            {
                case "train":
                    if ((mature + students) >= 50)
                    {
                        transPriceMature = 24.99M / 2;
                        transPriceStudent = 14.99M / 2; break;
                    }
                    else
                    {
                        transPriceMature = 24.99M;
                        transPriceStudent = 14.99M; break;
                    }

                case "bus":
                    transPriceMature = 32.50M;
                    transPriceStudent = 28.50M; break;
                case "boat":
                    transPriceMature = 42.99M;
                    transPriceStudent = 39.99M; break;
                case "airplane":
                    transPriceMature = 70M;
                    transPriceStudent = 50M; break;
            }

            decimal totalCost = (nights * 82.99M + mature * transPriceMature*2 + students * transPriceStudent*2) * 1.10M;

            Console.WriteLine("{0:f2}", totalCost);
        }
    }
}
