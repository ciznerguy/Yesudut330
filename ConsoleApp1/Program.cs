using System;
namespace Example1
{
    internal class Program
    {
    
    public static void targil1()

           {
            Console.WriteLine("1");
           }
        public static void targil2()
        {
            Console.WriteLine("2");
        }

        public static void Ex1()
        {
            int num = 100;
            double num2 = 100.05;
            string name = "peter";
            Console.WriteLine($"number is {num} other number is {num2} ");


        }
        public static void Ex2()
        {
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            Console.WriteLine($"name is {name}");
        }

        public static void Ex3()
        {
            Console.WriteLine("enter your age");
            int age =int.Parse( Console.ReadLine());
            Console.WriteLine($"age is {age}");
        }
        public static void Ex4()
        {
            Console.WriteLine("enter your age");
            double age = double.Parse(Console.ReadLine());
            Console.WriteLine($"age is {age}");
        }
        public static void Ex5()
        {
            int num1 = 1234;
            int num2 = 10;
            int result = num1 / num2;
            int ahadot = num1 % num2;
            int asarot = num1 % 100 / 10;
            Console.WriteLine($"result is {result}");
            Console.WriteLine($"ahadot is {ahadot}");
            Console.WriteLine($"asarot is {asarot}");
        }

        static void Main(string[] args)
        {
            Ex5();
        }
    }
}
