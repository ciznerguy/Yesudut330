using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nov26WhileLesson
{
    public class Program
    {
        /*יש לכתוב תכנית הקולטת מספרים
         * עד שנקלט מספר שלילי ומדפיסה את הסכום
         */
        public static void Ex1() 
        {
            Console.WriteLine("enter number and enter a negative number to stop");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            while(num >= 0) 
            {
                sum += num;
                Console.WriteLine("enter number and enter a negative number to stop");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }


        public static int fun1(int x, int y)
        {
            if (x == 0)
            {
               
                return y;
            }
            else
            {
                Console.WriteLine( $" {x-1} {x+y} ");
                return fun1(x - 1, x + y);
            }

        }



        static int fun(int a, int b)
        {
            if (b == 0)
            {
                return 0;
            }

                if (b % 2 == 0)
            {
                return fun(a + a, b / 2);
            }


            Console.WriteLine($" recursion call is fun({a + a},{b / 2}) + {a} ");
            return fun(a + a, b / 2) + a;
        }


        static void Main(string[] args)
        {
            Console.WriteLine(fun(4, 3));
        }
    }
}
