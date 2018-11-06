using System;

// https://www.cheatography.com/laurence/cheat-sheets/c/
// https://www.thecodingguys.net/resources/cs-cheat-sheet.pdf

namespace helloworld
{
    class Program
    {
        //fields
        const double PI = 3.14159265359;

        static void Main(string[] args)
        {
            //string
            string world = " planet";
            var date = DateTime.Now;
            string msg = $"sup {world}, it's {date:HH:mm}";
            string caps = msg.ToUpper();

            //console using System
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(msg + ", press enter to move past Read()");
            Console.Read();

            //variables
            int num = 5;
            float precise = 4.5F;
            double db = precise * num;
            int cast = (int)db;
            bool isBanana = true;
            bool isBigger = precise > num;
            
            Console.WriteLine("double is {0}, {1} is casted, and the ocean is wet: {2}", db, cast, isBanana);

            //parse and conversion
            string convert = num.ToString();
            int parser = Int32.Parse(convert);
            Console.WriteLine($"'{convert}' is a string, {parser} is an int from a string from a double.");

            Console.ReadKey();
        }
    }
}
