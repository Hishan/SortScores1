/*Transmax Assignment 
 Hishan de Silva for the Graduate Position
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortScores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //string sourcePath = System.Reflection.Assembly.GetExecutingAssembly().Location;

            // Read each line of the file into a string array. Each element
            // of the array is one line of the file.
            string[] lines = System.IO.File.ReadAllLines("scores.txt");
            

            //System.Console.WriteLine(sourcePath);

            // Display the file contents by using a foreach loop.
            System.Console.WriteLine("Contents of scores.txt = ");
            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
                Console.WriteLine("\t" + line);
            }
            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
