using System;
using System.Collections.Generic;

public class Dictionary
{
    public static void Main()
    {
        // Create a Dictionary with string keys and int values
        Dictionary<string, int> dictionary = new Dictionary<string, int>();

        // Create - Add key-value pairs to the Dictionary
        dictionary.Add("Ananya", 25);
        dictionary.Add("Honey", 30);
        dictionary.Add("Suhas", 35);

        // Read - Access values by keys
        Console.WriteLine("Dictionary Items:");
        foreach (var key in dictionary.Keys)
        {
            Console.WriteLine($"{key}: {dictionary[key]} years old");
        }

        // Update - Modify a value in the Dictionary
        dictionary["Suhas"] = 31;

        // Read - Access the updated Dictionary
        Console.WriteLine("\nUpdated Dictionary:");
        foreach (var key in dictionary.Keys)
        {
            Console.WriteLine($"{key}: {dictionary[key]} years old");
        }

        // Delete - Remove a key-value pair from the Dictionary
        dictionary.Remove("Honey");

        // Read - Access the final Dictionary
        Console.WriteLine("\nDictionary after Deletion:");
        foreach (var key in dictionary.Keys)
        {
            Console.WriteLine($"{key}: {dictionary[key]} years old");
        }
    }
}
