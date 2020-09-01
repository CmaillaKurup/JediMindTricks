using System;
using System.Collections.Generic;

namespace JediMindTricks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating a Dictonary
            Dictionary<string, int> people = new Dictionary<string, int>();
            //two diffrent ways to add something to the dictionary
            people.Add("Camilla", 32);
            people["Mickey"] = 11;

            // A KeyValuePair provides the string as the Key property
            foreach (KeyValuePair<string, int> pair in people)
            {
                Console.WriteLine(pair.Key + pair.Value);
            }
            
            //Creating another Dictionary
            Dictionary<string, bool> characters = new Dictionary<string, bool>()
            {
                { "Luke", true },
                { "Han", false },
                { "Chewbacca", false }
            };
            //removing "Han" from the dictionary
            characters.Remove("Han");
            
            foreach (KeyValuePair<string, bool> pair in characters)
            {
                Console.WriteLine(pair.Key);
            }
            
            foreach (var pair in people)
            {
                Console.WriteLine("Name: " + pair.Key + " Age: " + pair.Value);
            }
        }
    }
}