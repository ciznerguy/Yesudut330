using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Dec3Lesson
{
    internal class Program
    {


        static void StringLesson()
        {
            string st = "Guy Cizner";

            // מהו האורך

            //  לקלוט ולהדפיס את האות האחרונה


        }

        // יש לכתוב פעולה הקולת מחרוזת ומדפיסה כל אות בשורה נפרדת


        // יש לכתוב פעולה הקולת מחרוזת ויוצרת מחרוזת חדשה בה כל אות מופיע שלוש פעמים




        static void LoopWithLetters()
        {
            for (char c = 'a'; c <= 'z'; c++)
            {
                Console.WriteLine(c);
            }
        }

        static void LoopWithAsciiValues()
        {
            for (char c = 'a'; c <= 'z'; c++)
            {
                Console.WriteLine((int)c);
            }
        }

        //  יש לכתוב תכנית הקולטת מחרוזת וסופרת כמה אותיות גדולות יש בה

        static void CountCapitalLetters()
        {
            string check = "GUY gggg";
            int countCapital = 0;


            for (int i = 0; i < check.Length; i++)
            {
                if (check[i] < 'Z' && check[i] > 'A')
                {
                    countCapital++;
                }
            }
            Console.WriteLine(countCapital);
        }


        static void CountMisparim()
        {
            string check = "GUY 3 gggg 665";

            int countMisparim = 0;

            for (int i = 0; i < check.Length; i++)
            {
                if (check[i] >= '0' && check[i] <= '9')
                {

                    countMisparim++;
                }

            }
            Console.WriteLine(countMisparim);
        }


        // תבנית מקסימום
        // while

        // תבנית מינימום
        // while

        // תבנית סכום
        // while

        // תבנית ממוצע
        // while

        // תבנית ממוצע עם תנאי
        // while
        // לקלוט עד שנקלט מספר שלילי ולהציג ממוצע של הזוגיים

        static void Main(string[] args)
        {






        }

    }
}
