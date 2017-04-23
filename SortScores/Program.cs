/*Transmax Assignment 
 Hishan de Silva for the Graduate Program Position 
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
                        p[personIndex] = new Person(parts[0], parts[1], float.Parse(parts[2]));
                    }
                    personIndex++;
                }

                foreach (Person person in p)
                {
                    Console.Write("\t" + person.getFirstName() + ", " + person.getLastName() + ", " + person.getScore() + "\n");
                }

                //Extracting the file name to generate the new file name from the path entered.
                String[] filePath = path.Split('\\');
                String[] filename = filePath[filePath.Length - 1].Split('.');

                //Split the folder path
                string filepath2 = path;
                System.IO.FileInfo fileinfo = new System.IO.FileInfo(filepath2);
                string foldername = fileinfo.Directory.Name;
                // Determine the full path of the file just created.
                string directoryPath = fileinfo.DirectoryName;
                string newFile = directoryPath + "\\" + filename[0] + "-graded.txt";

                //Sort by score then by fistname
                IEnumerable<Person> query = p.OrderByDescending(person => person.getScore()).ThenBy(person => person.getFirstName());

                Console.WriteLine("Contents of the sortedScores.txt =");

                foreach (Person person in query)
                {
                    Console.Write("\t" + person.getFirstName() + ", " + person.getLastName() + ", " + person.getScore() + "\n");
                    // A new - graded file is created under the same folder that your original file is located
                    //Console.WriteLine(newFile);
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(newFile, true))
                    {
                        file.WriteLine(person.getFirstName() + ", " + person.getLastName() + ", " + person.getScore());
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
