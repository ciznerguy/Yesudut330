using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfLesson
{
    internal class Program
    {
        
        public static void If1()
        {
            Console.WriteLine("enter number");
            int num = int.Parse(Console.ReadLine());
            if (num > 100)
            {
                Console.WriteLine("number greater then 100");

            }
            if (num < 100)
            {
                Console.WriteLine("number is less then 100");
            }
            if (num == 100)
            {
                Console.WriteLine("number is 100");
            }

        }
        public static void If2()
        {
            bool myBool = 100<105;
            Console.WriteLine(myBool);
            if (myBool == true)
            {
                Console.WriteLine($"true {myBool}");
            }
        }
        public static void If3()
        {
            bool myBool = 100 > 10+91;
            int num = 100;
            if (num<100)
            
             {
                Console.WriteLine($"true {myBool}");
            }
        }
        //פתרון שאלה 2002
        public static void If4()
        {
            Console.WriteLine("enter two numbers 1-6");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            if (num1 == num2)
            {
                Console.WriteLine("double");
                
            }
            if (num1 + num2 == 11)
            {
                Console.WriteLine("sheshbesh");
            }
            /*
            if (num1 + num2 != 11)
            {
                if (num1 != num2)
                {
                    Console.WriteLine("regular");
                }

            }
            */
            if (num1 + num2 != 11 && num1 != num2)
            {
                Console.WriteLine("regular");
            }

        }
        //יש לכתוב תכנית הקולטת מספר אחד
        //התכנית תבדוק ותדפיס האם המספר זוגי או מתחלק בשלוש
        
        public static void If5()
        {
            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0 && num % 3 ==0)
            {
                Console.WriteLine("true");
            }
        }
        public static void If6()
        {
            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0 || num % 3 == 0)
            {
                Console.WriteLine("true");
            }
        }
        static void Main(string[] args)
        {
            If6();
        }
    }
}
