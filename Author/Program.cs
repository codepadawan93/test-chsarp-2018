using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Author
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" --Instantiate a new Author\n\r");
            Author aut = new Author("Stefan Zweig", new String[] { "24h from the Life of a Woman", "The Chess Player", "Tormented Souls" });
            Console.Write(aut.ToString());

            Console.Write("\n\r --Instantiate an Author array \n\r");
            Author[] autharr = new Author[] {
                aut,
                new Author("Mihail Sadoveanu", new String[] { "Mara", "Baltagu"}),
                new Author("Mihai Eminescu", new String[] { "Luceafarul", "FLoare Albastra", "Rugaciunea unui Dac", "Melancolie"})
            };

            foreach(Author author in autharr)
            {
                Console.Write(author.ToString());
            }

            // Sort the array in descending order by multiplying the result of each comparison w/ -1 using a delegate
            Console.Write("\n\r --Sort the array \n\r");
            Array.Sort(autharr, new Comparison<Author>(
                    (i1, i2) => -i1.CompareTo(i2)
            ));

            foreach (Author author in autharr)
            {
                Console.Write(author.ToString());
            }

            Console.Write("\n\r --The original author is: \n\r");
            Console.Write(aut.ToString());
            Author authobj = (Author)aut.Clone();
            // change the original's name
            aut.Name = "Ionel Teodoreanu";
            Console.Write("\n\r --The clone author is still the same: \n\r");
            Console.Write(authobj.ToString());

            Console.Write("\n\r --But the original has a different name: \n\r");
            // explicitly cast the author to int
            Console.WriteLine(aut.Name + " has " + (int)aut + " works.\n\r");
        }
    }
}
