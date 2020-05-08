using System;
using System.Text.RegularExpressions;

namespace Masterclass_RegEx
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Hello World!");


             string pattern = @"\d";
             Regex regex = new Regex(pattern);

             string text = "number is 12340";

             MatchCollection matches = regex.Matches(text);

             Console.WriteLine("{0} hits found in\n {1}", matches.Count, text);

             foreach(Match hit in matches)
             {
                 GroupCollection group = hit.Groups;
                 Console.WriteLine("{0} found at {1}", group[0].Value, group[0].Index);
             }*/

            DateTime dateTime = new DateTime();
            DateTime now = DateTime.Now;


            /*Console.WriteLine("Date: {0}", dateTime);
            Console.WriteLine(DateTime.Today.AddDays(1));
            Console.WriteLine(DateTime.Now);*/

            Console.WriteLine("When is your birthday? ");
            string input = Console.ReadLine();

            if(DateTime.TryParse(input,out dateTime))
            {
                Console.WriteLine(dateTime);
                TimeSpan daysPassed = now.Subtract(dateTime);

                Console.WriteLine("Days since birthday {0}", daysPassed);
            }
        }
    }
}
