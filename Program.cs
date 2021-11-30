using System;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            This program Mad Libs
            Author: Ajaya Shrestha
            */


            // Let the user know that the program is starting:
            Console.WriteLine("Mad Libs is starting!");


            // Give the Mad Lib a title:
            string title = "TITLE";

            Console.WriteLine(title);
            // Define user input and variables:
            Console.Write("Enter a name: ");
            string name = Console.ReadLine();
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            Console.Write("Enter a first adjective: ");
            string adj1 = Console.ReadLine();

            Console.Write("Enter a verb: ");
            string verb = Console.ReadLine();

            Console.Write("Enter a first noun: ");
            string noun1 = Console.ReadLine();

            Console.Write("Enter a second noun: ");
            string noun2 = Console.ReadLine();

            Console.Write("Enter one of the following(- An animal \n - A food \n - A fruit \n - A superhero \n - A country \n - A dessert \n - A year): ");
            string weird = Console.ReadLine();

            // The template for the story:

            string story = "This morning _ woke up feeling _. 'It is going to be a _ day!' Outside, a bunch of _s were protesting to keep _ in stores. They began to _ to the rhythm of the _, which made all the _s very _. Concerned, _ texted _, who flew _ to _ and dropped _ in a puddle of frozen _. _ woke up in the year _, in a world where _s ruled the world.";


            // Print the story:

        }
    }
}
