using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      This program Madlibs
      Author: Eugene Johnson
      */


      // Let the user know that the program is starting:
  

      // Give the Mad Lib a title:
      string title = "The Old Man";

      Console.WriteLine(title);
      // Define user input and variables:
      //Console.WriteLine("Welcome to The Old Man!");

      Console.WriteLine("Enter Adjective: ");
      string adjectiveOne = Console.ReadLine();

      Console.WriteLine("Enter Adjective: ");
      string adjectiveTwo = Console.ReadLine();

      Console.WriteLine("Enter Adjective: ");
      string adjectiveThree = Console.ReadLine();

      Console.WriteLine("Enter Verb: ");
      string verbOne = Console.ReadLine();

      Console.WriteLine("Enter Noun: ");
      string nounOne = Console.ReadLine();

      Console.WriteLine("Enter a Noun: ");
      string nounTwo = Console.ReadLine();

      Console.WriteLine("Enter Name: ");
      string name = Console.ReadLine();

      Console.WriteLine("Enter an animal: ");
      string animal = Console.ReadLine();  

      Console.WriteLine("Enter A food: ");
      string food = Console.ReadLine();

      Console.WriteLine("Enter A fruit: ");
      string fruit = Console.ReadLine();

      Console.WriteLine("Enter A superhero: ");
      string superhero = Console.ReadLine();

      Console.WriteLine("Enter A country: ");
      string country = Console.ReadLine();

      Console.WriteLine("Enter A dessert: ");
      string dessert = Console.ReadLine();

      Console.WriteLine("Enter A year: ");
      string year = Console.ReadLine();



      // The template for the story:

      string story = $"This morning {name} woke up feeling {adjectiveOne}. 'It is going to be a {adjectiveTwo} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verbOne} to the rhythm of the {nounOne}, which made all the {fruit}s very {adjectiveThree}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {nounTwo}s ruled the world.";


      // Print the story:
      Console.WriteLine(story);


    }
  }
}