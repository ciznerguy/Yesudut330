using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeLesson3
{
    internal class Program
    {
        //יש לכתוב תכנית הקולטת מספר ומדפיסה הודעה האם הוא גדול ממאה
        public static void Ex1()
        {

            Console.WriteLine("enter number");
            int num = int.Parse(Console.ReadLine());   
            
            if (num>100)
            {
                Console.WriteLine($"the number {num} is greater than 100");
            }

           
        }

        //יש לכתוב תכנית הקולטת מספר דו ספרתי ומדפיסה את סכום ספרותיו
        
        public static void Ex2()
        {
            Console.WriteLine("enter number");
            int num = int.Parse(Console.ReadLine());

            int d1 = num % 10;  //56%10 =6
            int d10= num / 10;  //56/10 =5
            int sumDigits = d1+ d10;

            Console.WriteLine($"sum of digits in {num} is {sumDigits}");

        }

        public static void FirstRandom ()
        {
            Random rand = new Random();
            int num = rand.Next(90,101);
            Console.WriteLine($"my Random {num}");
        }
        static void Main(string[] args)
        {
            FirstRandom();
          
        }
    }
}
