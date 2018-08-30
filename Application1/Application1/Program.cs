using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application1
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("\nODD OR EVEN");
            Console.WriteLine("\nEnter any whole number between 1 and 1000");
            int userNum = Convert.ToInt32(Console.ReadLine());

            int  check = userNum % 2;

            if (check == 0)
            {
                Console.WriteLine("\n{0} is Even",userNum );
            }

            else
            {
                Console.WriteLine("\n{0} is Odd", userNum);
            }


            Console.WriteLine("\nPress Enter To Close Appliaction");
            Console.ReadLine();


        }
    }
}
