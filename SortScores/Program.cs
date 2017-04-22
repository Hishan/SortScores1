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
            try {
                Console.WriteLine("Hello Peeps!");
                Console.WriteLine("Lets sort scores\n Please enter the full path to the file\n including the file extension : ");
                String path = Console.ReadLine();
                // Read each line of the file into a string array. Each element
                // of the array is one line of the file.
                //String[] lines = System.IO.File.ReadAllLines("scores.txt");
                String[] lines = System.IO.File.ReadAllLines(path);
                Person[] p = new Person[lines.Length];
                int personIndex = 0;
                // Display the file contents by using a foreach loop.
                System.Console.WriteLine("Contents of scores.txt = ");
                foreach (String line in lines)
                {
                    foreach (Person person in p)
                    {
                        string[] parts = line.Split(',');
                        for (int i = 0; i < parts.Length; i++)
                        { //remove all the space characters in the line and get each word stored again in the same variable
                            parts[i] = parts[i].Trim();//trims all the trailing and leading white characters of a line
                        }
                        p[personIndex] = new Person(parts[0], parts[1], Int32.Parse(parts[2]));
                    }
                    personIndex++;
                }

                foreach (Person person in p)
                {
                    Console.Write("\t" + person.firstName + ", " + person.lastName + ", " + person.score + "\n");
                }

                //Extracting the file name to generate the new file name from the path entered.
                String[] filePath = path.Split('\\');
                String[] filename = filePath[filePath.Length - 1].Split('.');

                //Sort by score then by fistname
                IEnumerable<Person> query = p.OrderByDescending(person => person.score).ThenBy(person => person.firstName);

                Console.WriteLine("Contents of the sortedScores.txt =");

                foreach (Person person in query)
                {
                    Console.Write("\t" + person.firstName + ", " + person.lastName + ", " + person.score + "\n");
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(@filename[0]+"-graded.txt", true))
                    {
                        file.WriteLine(person.firstName + ", " + person.lastName + ", " + person.score);
                    }
                }
                // Keep the console window open in debug mode.
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
            } catch (Exception ex) {
                Console.WriteLine("\n\nCannot open the file in the path you have entered\n Is the path valid?\n Exception raised - " + ex.Message);
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
            }
        }
    }
}
