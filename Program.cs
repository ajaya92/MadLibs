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
            Console.Write("Enter a second adjective: ");
            string adj2 = Console.ReadLine();
            Console.Write("Enter a third adjective: ");
            string adj3 = Console.ReadLine();

            Console.Write("Enter a verb: ");
            string verb = Console.ReadLine();

            Console.Write("Enter a first noun: ");
            string noun1 = Console.ReadLine();

            Console.Write("Enter a second noun: ");
            string noun2 = Console.ReadLine();

            Console.Write("Enter one of the following(- An animal \n - A food \n - A fruit \n - A superhero \n - A country \n - A dessert \n - A year): ");
            string weird = Console.ReadLine();

            // The template for the story:

            string story = $"This morning {name} woke up feeling {adj1}. 'It is going to be a {adj2} day!' Outside, a bunch of {weird}s were protesting to keep {weird} in stores. They began to {verb} to the rhythm of the {noun1}, which made all the {weird}s very {adj3}. Concerned, {name} texted {weird}, who flew {name} to {weird} and dropped {name} in a puddle of frozen {weird}. {name} woke up in the year {weird}, in a world where {noun2}s ruled the world.";


            // Print the story:
            Console.WriteLine(story);

        }
    }
}
