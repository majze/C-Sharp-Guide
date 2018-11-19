using System;
using System.IO;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            // writing to file with local directory
            string[] wLines = { "first line", "second line", "third line" };
            File.WriteAllLines(@".\textfile2.txt", wLines);

            // reading from file with specific directory
            string text = System.IO.File.ReadAllText(@"C:\Users\Admin\source\repos\Files\Files\data.txt");
            Console.WriteLine("Text file contents: \n{0}", text);

            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Admin\source\repos\Files\Files\data.txt");
            Console.WriteLine("\nContents of text line by line:");
            foreach(string line in lines)
            {
                Console.WriteLine("\t" + line);
            }

            // writing to file from input stream
            Console.WriteLine("\nEnter a file name: ");
            string fileName = Console.ReadLine();
            Console.WriteLine("Enter text for the file: ");
            string input = Console.ReadLine();
            File.WriteAllText(@".\" + fileName + ".txt", input);

            // using streamWriter
            Console.WriteLine("\nCreating a file where lines contain \"2\". ");
            using (StreamWriter file = new StreamWriter(@".\onlyHasTwo.txt"))
            {
                foreach(string line in lines)
                {
                    if (line.Contains("2"))
                    {
                        file.WriteLine(line);
                    }
                }
            }

                Console.ReadKey();
        }
    }
}
