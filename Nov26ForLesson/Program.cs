using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nov26ForLesson
{
    public class Program
    {
        /*
        למספר 2025 יש את התכונה הבאה: 
        2^(20+25)=2025. כתוב תוכנית בה הקלט הוא מספר חיובי 
        בעל 4 ספרות והפלט הוא הודעה האם המספר מקיים את התכונה הנ"ל.
שנה את התוכנית כך שהפלט בה יהיה כל המספרים בעלי 4
        ספרות המקיימים תכונה זו. 
       1. צור לולאה מ1000 עד 9999
        1.2. חשב את הספרות השמאליות והימניות
        1.3. חשב את הסכום בריבוע
        1.4. בדוק והדפס אם שווה

        * */


        public static void Ex1() 
        {
            Console.WriteLine("enter a number please");
            int num = int.Parse(Console.ReadLine());
            int num1 = num / 100;
            int num2 = num % 100;
            int result = (int)Math.Pow(num2 + num1, 2);
            //double resultDouble = Math.Pow(7, 2.5);
            if (result == num)
            {
                Console.WriteLine("sababa");
            }

        }
        public static void Ex1Part2() 
        {
            for (int i = 1000; i < 10000; i++) 
            {
                int num1 = i / 100;
                int num2 = i% 100;
                int result = (int)Math.Pow(num2 + num1, 2);
                //double resultDouble = Math.Pow(7, 2.5);
                if (result == i)
                {
                    Console.WriteLine($"sababa number is {i} ");
                }
            }
        }
        /*
         * כתבו תוכנית המייצרת 10 מספרים אקראיים בתחום שבין 1-100,
         * ואז מדפיסה את המספר הגדול ביותר שהוגרל, והקטן ביותר
        הריצו שוב עבור 1000 מספרים אקראים                     
        האם  התוצאה תואמת את ציפיותיכם?


         * */
        public static void Ex2() 
        {
            Random random = new Random();
            int max = 0;
            for (int i = 0; i < 10; i++) 
            {
                int num = random.Next(1, 101);
                if (num > max)
                {
                    max = num;
                }

            }
            Console.WriteLine($"max is {max}");
        }
        public static void Ex2Part2()
        {
            Random random = new Random();
            int min = 101;
            for (int i = 0; i < 10; i++)
            {
                int num = random.Next(1, 101);
                if (num < min)
                {
                    min = num;
                }

            }
            Console.WriteLine($"min is {min}");
        }


        /*
         * כתבו תוכנית שסורקת את המספרים בין 1 ל 99. 
         * במקרה שהמספר מתחלק ב 7 או מכיל את הספרה 7,
         * 
         * התוכנית תדפיס את המספר ואז boom! 

        */
        public static void Ex3() 
        {
            for (int i = 1; i <100; i++) 
            {
                if(i % 7 == 0 || i % 10 == 7 || i/10 == 7 ) 
                {
                    Console.WriteLine($"boom {i}");
                }
            }
        }


        /*יש לכתוב תכנית הקולטת מספר בעל
        חמש ספרות ומדפיסה אותן בנפרד החל מספרת האחדות
        */
        public static void Ex4() 
        {
            Console.WriteLine("Enter a 5 digit number");
            int num = int.Parse( Console.ReadLine() );
            if(num > 9999 && num < 100000) 
            {
                for (int i = 0; i < 5; i++) 
                {
                    int d1 = num % 10;
                    num = num / 10;
                    Console.WriteLine(d1);
                }
            }
        }

        /*
         * כתבו תוכנית שבה המשתמש מזין את שמו המלא (כולל משפחה).
         * התוכנית תדפיס את כל האותיות של השם, כל אות בשורה נפרדת
         */

        public static void Ex5() 
        {
            Console.WriteLine("Enter your full name");
            string name = Console.ReadLine();
            for(int i = 0; i < name.Length; i++) 
            {
                Console.WriteLine($"letter {i} is {name[i]}");
            }
        }
        /*
         כתבו תוכנית הקולטת מהמשתמש מחרוזת, 

        ומדפיסה אותה בסדר הפוך, כך שהאות האחרונה תהפוך לראשונה, וכן הלאה
        */
        public static void Ex6() 
        {
            Console.WriteLine("enter string");
            string st = Console.ReadLine() ;
            for (int i = st.Length - 1; i >= 0; i--) 
            {
                Console.WriteLine($"letter {i} is {st[i]}");
            }
        }

        static void Main(string[] args)
{
            Ex6();
}
}
}
