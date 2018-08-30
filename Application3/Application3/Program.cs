using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Expanding Quadratic Equations");
            Console.WriteLine("Format: (x + n)(x + m)");

            
            Console.WriteLine("Enter a +ve or -ve Number for n:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a +ve or -ve Number for m:");
            int m = Convert.ToInt32(Console.ReadLine());
            int c = n * m;

            if (n <= -1)
            {
                n = (-n - n) / 2;
                
            }

            else
            {
                n = n * -1;
            }


            if (m <= -1)
            {
                m = (-m - m) / 2;
                
            }

            else
            {
                m = m * -1;
            }


            int b = 0;
            if (n > m)
            {
               b = n + m;
            }
            
            else
            {
               b = m + n;
            }

            if (c <= -1)
            {
                Console.WriteLine("x^2 +{0}x {1}", b, c);
            }

            else if (b <= -1)
            {
                Console.WriteLine("x^2 {0}x +{1}", b, c);
            }

            else if (c <= -1 && b<= -1)
            {
                Console.WriteLine("x^2 {0}x {1}", b, c);
            }

            else
            {
                Console.WriteLine("x^2 +{0}x +{1}", b, c);
            }
            
    
            Console.WriteLine("Press Enter To Close Application");
            Console.ReadLine();

        }
    }
}
