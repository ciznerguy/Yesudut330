using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nov19Lesson
{
    internal class Program
    {


        //יש לכתוב תכנית המגרילה 20 מספרים רנדומליים 
        // טווח המספרים בין 1 ל-100
        // ומדפיסה את סכומם
        // תבנית סכום

        public static void q1()
        {
            Random rnd = new Random();
            int sum = 0;
            for (int i = 0; i < 20; i++)
            {
              int num = rnd.Next(1,101);
              sum =sum+ num; // sum+=num;
                
            }
            Console.WriteLine(sum);
        }

        // יש לכתוב תכנית הקולטת שני מספרים שלמים
        // התכנית תבדוק את סכום המספרים
        // התכנית תדפיס האם הסכום זוגי או אי-זוגי
        public static void q2()
        {
            Console.WriteLine("enter first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number");
            int num2 = int.Parse(Console.ReadLine());
            int sum = num1 + num2;

            if (sum % 2 == 0)

            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }

        //יש לכתוב תכנית המגרילה 20 מספרים רנדומליים 
        // טווח המספרים בין 100- ל-100
        // ומדפיסה את הגדול מבניהם
        // תבנית מקסימום

        public static void q3()
        {
            int max = -101;
            Random rnd1 = new Random();

            for (int i = 0; i < 20; i++)
            {
                int num = rnd1.Next(-100, 101);
                if (max < num)
                {
                    max = num;
                }
            }
            Console.WriteLine(  max);

        }


        

        //יש לכתוב תכנית הקולטת 5 מספרים  
        // ומדפיסה את הקטן מביניהם
        // תבנית מינימום

    public static void q4()
    {
            // 20,40,10,2,5

            /*
             1. min = 20
             2. min =20
             3. min=10
             4. min =2
             5. min =2
             * */


            Console.WriteLine("enter first number");
            int min = int.Parse(Console.ReadLine());

            for ( int i = 0;i<4;i++)
            {
                Console.WriteLine("enter first number");
                int num = int.Parse(Console.ReadLine());

                if (num<min)

                {
                    min = num;
                }

            }
            Console.WriteLine( min);

    }

        /*
         * כתבו תוכנית לקליטת הגיל של 5 מועמדים
         * לעבודה במפעל.
         * יש להדפיס את מספר המועמדים שגילם בין 30-40
         * תבנית מניה הכוללת תנאי
          */

        /*
            1. להגדיר משתנה מונה ולאפס אותו
            2. לבצע לולאה 5 פעמים
               2.1 הודעה למשתמש
               2.2 קלט של גיל
               2.3 תנאי האם הגיל בטווח
                   2.3.1 הוספת 1 למונה

            3. הדפסת המונה

        
         */
        public static void q5()
        {
            int count = 0;
            for (int i=0; i<5;i++)
            {
                Console.WriteLine(  "enter age");
                int age = int.Parse(Console.ReadLine());
                // אני מניחה שזה כולל את 30 ו-40
                if (age>=30 && age<=40)
                {
                    count++;
                }
            }
            Console.WriteLine( count);
        }
        /*
         * כתבו תוכנית הקולטת 10 זוגות של מספרים.
         * התוכנית תדפיס רק את הזוגות שבהם שני
         * המספרים חיוביים ואי-זוגיים,
         * ובסוף תדפיס כמה זוגות כאלה היו
         * לולאה הכוללת תנאי מורכב
         * תבנית מניה (ספירה
          */

        public static void q6() 
        {
            int count = 0;

            for (int i=0;i<10;i++)
            {
                Console.WriteLine("enter first number");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("enter second number");
                int num2 = int.Parse(Console.ReadLine());
                if (num1>0 && num2>0&&num1%2==1&&num2%2==1)
                {
                    count++;
                    Console.WriteLine($"num1 {num1} num2{num2}");
                }
            }
            Console.WriteLine(  count);

        }


        /*
          יש לכתוב תכנית הקולטת מספר.
        התכנית תדפיס את המספר כאשר המספר הוא
        תלת ספרתי וסכום ספרותיו זוגי

        1. הודעה למשתמש
        2. קלט
        3. תנאי האם המספר תלת ספרתי
             3.1 לבודד ספרת אחדות
             3.2 לבודד ספרת עשרות
             3.3 לבודד ספרת מאות
             3.4 סכום ספרות
             3.5 תנאי האם הסכום זוגי
                  3.5.1 מדפיס את המספר

        
         
         */

        public static void q7()
        {
            Console.WriteLine("enter first number");
            int num = int.Parse(Console.ReadLine());

            if (num>=100 && num <=999)
            {
                int d1 = num % 10;  // 123%10 =3
                int d10 = num % 100/10;  // 123%100 = 23 /10 =2
                int d100 = num / 100;   // 123/100 =1
                int sum = d1+ d10 + d100;  // sum=6
                if (sum %2 ==0)
                {
                    Console.WriteLine(  num);
                }
            }
        }



        static void Main(string[] args)
        {
        }
    }
}

