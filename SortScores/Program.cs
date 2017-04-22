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
            Console.WriteLine("Hello Transmax!");
            //string sourcePath = System.Reflection.Assembly.GetExecutingAssembly().Location;

            // Read each line of the file into a string array. Each element
            // of the array is one line of the file.
            String[] lines = System.IO.File.ReadAllLines("scores.txt");
            Person[] p = new Person[lines.Length];
            int personIndex = 0;
            // Display the file contents by using a foreach loop.
            System.Console.WriteLine("Contents of scores.txt = ");
            foreach (String line in lines)
            {
                foreach (Person person in p) {
                    string[] parts = line.Split(',');
                    for (int i = 0; i < parts.Length; i++)
                    { //remove all the space characters in the line and get each word stored again in the same variable
                        parts[i] = parts[i].Trim();//trims all the trailing and leading white characters of a line
                        //Console.Write(parts[i] + "\n");
                    }
                    p[personIndex] = new Person(parts[0], parts[1], Int32.Parse(parts[2]));
                }
                personIndex++;
            }

            foreach (Person person in p) {
                Console.Write("\t" + person.firstName + ", " + person.lastName + ", " + person.score+"\n");
            }

            //Sort by score then by fistname
            IEnumerable<Person> query = p.OrderByDescending(person => person.score).ThenBy(person => person.firstName);

            Console.WriteLine("Contents of the sortedScores.txt =");

            foreach (Person person in query) {
                Console.Write("\t" + person.firstName + ", " + person.lastName + ", " + person.score + "\n");
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"SortedScores.txt", true))
                {
                    file.WriteLine(person.firstName + ", " + person.lastName + ", " + person.score);
                }
            }
            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
