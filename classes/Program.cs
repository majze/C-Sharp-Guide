using System;

// As long as the classes share a namespace they can see each other
namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person kelly = new Person();
            kelly.UpdateName("Kelly Danaheart");
            kelly.Height = 66;
            kelly.Age = 25;
            kelly.Gretting();
            Console.WriteLine("My high score is {0}", kelly.GPA);

            Console.ReadKey();
        }
    }
}
