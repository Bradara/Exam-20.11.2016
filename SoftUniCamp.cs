using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            var groups = int.Parse(Console.ReadLine());

            double totalStudents = 0;
            var byCar = 0;
            var byMiniBus = 0;
            var byBus = 0;
            var byBigBus = 0;
            var byTrain = 0;


            for (int i = 0; i < groups; i++)
            {
                var studentsPerGroup = int.Parse(Console.ReadLine());
                totalStudents += studentsPerGroup;
                if (studentsPerGroup<=5)
                {
                    byCar += studentsPerGroup;
                }
                else if (studentsPerGroup <= 12 && studentsPerGroup >= 6)
                {
                    byMiniBus += studentsPerGroup;
                }
                else if (studentsPerGroup <= 25 && studentsPerGroup >= 13)
                {
                    byBus += studentsPerGroup;
                }
                else if (studentsPerGroup <= 40 && studentsPerGroup >= 26)
                {
                    byBigBus += studentsPerGroup;
                }
                else if (studentsPerGroup >40)
                {
                    byTrain += studentsPerGroup;
                }
            }
            Console.WriteLine("{0:f2}%", byCar/totalStudents*100);
            Console.WriteLine("{0:f2}%", byMiniBus/totalStudents*100);
            Console.WriteLine("{0:f2}%", byBus/totalStudents*100);
            Console.WriteLine("{0:f2}%", byBigBus/totalStudents*100);
            Console.WriteLine("{0:f2}%", byTrain/totalStudents*100);
        }
    }
}
