using System;
 
namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Passing variables to methods
            //while loop
            string time, Msg = "Lollipops are not popsicles."; ;
            int countdown = 5;
            while (countdown > 3)
            {
                time = DateTime.Now.ToString("t");
                Logger(time, Msg);
                countdown--;
            }

            //Compare variables passed to methods
            compareInputs();

            //use for loop and variable arrays
            SeasonalAttire();
            
            Console.Read();
        }

        //method using passed variables
        public static void Logger(string time, string msg)
        {
            Console.WriteLine($"{time} : {msg}");
        }

        //if statement
        public static int getBigger(int parameter1, int parameter2, bool getLargeNum)
        {
            if (parameter1 > parameter2)
            {
                if (getLargeNum == false)
                    return parameter2;
                return parameter1;
            }
            else
            {
                if (getLargeNum == false)
                    return parameter1;
                return parameter2;
            }
        }

        //for loop
        public static void SeasonalAttire()
        {
            string[] attire = { "winter coat", "pants and jacket", "shorts and short shirt" };
            string[] monthName =
            {
                "Jan", "Feb", "Mar",
                "Apr", "May", "Jun",
                "Jul", "Aug", "Sept",
                "Oct", "Nov", "Dec"
            };
            for (int month = 0; month < 12; month++)
            {
                if (month < 3 || month > 9)
                {
                    Console.WriteLine("For month of {0}, wear a {1}", monthName[month], attire[0]);
                }
                else if (month < 5 || month > 7)
                {
                    Console.WriteLine("For month of {0}, wear some {1}", monthName[month], attire[1]);
                }
                else if (month >= 5 || month <= 8)
                {
                    Console.WriteLine("For month of {0}, wear {1}", monthName[month], attire[2]);
                }
            }
        }

        //try catch finally
        public static void compareInputs()
        {
            Console.WriteLine("Please enter an integer: ");
            string x1 = Console.ReadLine();
            Console.WriteLine("Great, now enter another integer: ");
            string x2 = Console.ReadLine();
            try
            {
                Console.WriteLine(getBigger(Convert.ToInt32(x1), Convert.ToInt32(x2), true) + " is larger than " + getBigger(int.Parse(x1), int.Parse(x2), false));
            }
            catch (FormatException)
            {
                Console.WriteLine("Whoops, at least one of those was not an integer!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Whoa now pardner, that integer is far too large!");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Whoops, you forgot to enter a number there.");
            }
            catch (Exception)
            {
                Console.WriteLine("Generic error is more helpful than no error.");
            }
            finally
            {
                Console.WriteLine("The 'finally' line will run anyways.");
            }
        }
    }
}
