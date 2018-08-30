using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Average of Ten Numbers");
            float userNum = 0, i = 1, total = 0, average = 0;

            while(i != 11)
            {
                Console.Write("Enter Number {0}:", i);
                userNum = float.Parse(Console.ReadLine());

                total = total + userNum;
                i++;

            }

            average = total / 10;
            Console.WriteLine("Average of these 10 Numbers is {0}", average);


            Console.WriteLine("Press Enter To Close Application");
            Console.ReadLine();


        }
    }
}
