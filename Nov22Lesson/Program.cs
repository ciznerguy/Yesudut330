using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nov22Lesson
{
    internal class Program
    {
        public static void Ex1() 
        {
            Console.Write("Hello");
            Console.WriteLine("Class");
        }
        public static void Ex2() 
        {
            int num = 100;
            int num2 = 300;
            int sum = num + num2;
            Console.WriteLine($"sum is {sum}");
        }
        public static void Ex3() 
        {
            double num1 = 100;
            double num2 = 6;
            double div = 100 / 6.0;
            Console.WriteLine($"div is {div}");
        }
        public static void Ex4() 
        {
            string name = "peter parker";
            string msg = " is spiderman";
            string full = name + msg;
            Console.WriteLine(full);
        }
        public static void Ex5() 
        {
            bool result = 100 + 110 == 200;
            Console.WriteLine(result);
        }
        public static void Ex6() 
        {
            Console.WriteLine("enter your name");
            string name = Console.ReadLine();
            Console.WriteLine($"your name is {name}");
        }
        public static void Ex7() 
        {
            Console.WriteLine("enter your age");
            int age =int.Parse( Console.ReadLine());
            Console.WriteLine($"your age is {age}");
            Console.WriteLine("please enter your salary");
            double salary = double.Parse( Console.ReadLine());
            Console.WriteLine($"your salary is {salary}");
        }
        public static void Ex8() 
        {
            Random rnd1 = new Random();
            for (int i = 0; i < 100; i++)
            {
                int num = rnd1.Next(0, 101);
                Console.WriteLine(num);
            }
            
        }
        public static void Ex9() 
        {
            Random rnd1 = new Random();
            int num = rnd1.Next(0, 101);
            Console.WriteLine(num);
            if (num < 50) 
            {
                Console.WriteLine("Less than 50");
            }
            else 
            {
                Console.WriteLine("Greater or equal to 50");
            }


        }
        public static void Ex10() 
        {
            Random rnd = new Random();
            int num = rnd.Next(0, 101);
            Console.WriteLine(num);
            if (num >= 20 && num <= 50)
            {
                Console.WriteLine("number is between 20 and 50");
            }
            else 
            {
                Console.WriteLine("not");
            }

        }
        public static void Ex11()
        {
            Random rnd = new Random();
            int num = rnd.Next(0, 101);
            Console.WriteLine(num);
            if (num < 20 || num > 60)
            {
                Console.WriteLine("number is correct");
            }
            else
            {
                Console.WriteLine("not");
            }
        }
        public static void Ex12() 
        {
            for(int i = 100; i > 0; i= i -5) 
            {
                Console.WriteLine($"number is {i}");
                
            }
            //לא יכנס ללולאה
            for (int j = 0; j < -10; j++) 
            {
                Console.WriteLine("hi");
            }


        }
        //יש לכתוב תכנית הקולטת 5 מספרים ומדפיסה את הסכום שלהם
        //תבנית לולאת סכום
        public static void Ex13() 
        {
            int sum = 0;
            for(int i = 0; i < 5; i++) 
            {
                Console.Write("enter a number >>");
                int num = int.Parse(Console.ReadLine());
                sum = sum + num;
 
            }
            Console.WriteLine($"sum is {sum}");
        }
       // יש לכתוב תכנית הקולטת חמישה מספרים ומדפיסה את המקסימום
       // תבנית מקסימום
        public static void Ex14() 
        {
            
            Console.Write("enter a number >> ");
            int max = int.Parse(Console.ReadLine());
            for (int i = 0;i < 4; i++) 
            {
                Console.Write("enter a number >> ");
                int num = int.Parse(Console.ReadLine());
                if (num > max) 
                {
                    max = num;
                }
            }
            Console.WriteLine($"max is {max}");
        }
        public static void Ex15()
        {
            int count = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("enter a number >>");
                int num = int.Parse(Console.ReadLine());
                if (num < 0) 
                {
                    count++;
                }

            }
            Console.WriteLine(count);
            
        }
        static void Main(string[] args)
        {
            Ex15();
        }

    }
}
