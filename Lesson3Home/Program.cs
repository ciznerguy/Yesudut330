using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3Home
{
    internal class Program
    {
       
        
        public static void ex1()
        {
            // יש לקלוט מספר ולהדפיס אם הוא גדול ממאה
            Console.WriteLine("enter number");
            int num = int.Parse(Console.ReadLine());
            

            if (num>100)
            {
                Console.WriteLine($" the number {num} is greater than 100");
            }
        }

        public static void ex2()
        {
            // יש לכתוב תכנית הקולטת מספר דו ספרתי 
            // התכנית תדפיס למסך את סכום ספרותיו


            Console.WriteLine("enter anumber");
            int num = int.Parse((string)Console.ReadLine());
            int d1 = num % 10; // 56%10 =6
            int d10= num/10;  // 56/10 =5
            int sum = d1 + d10;
            Console.WriteLine( $"sum of digits for {num} is {sum}" );
        }
        
        static void Main(string[] args)
        {

          ex2();
        }
    }
}
