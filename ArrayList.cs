using System;
using System.Collections;
using System.Collections.Generic;

public class Collections
{
    public static void Main()
    {
        // Create an ArrayList
        ArrayList arrayList = new ArrayList();

        // Create - Add items to the ArrayList
        arrayList.Add("Apple");
        arrayList.Add("Banana");
        arrayList.Add("Cherry");

        // Read - Access items from the ArrayList
        Console.WriteLine("ArrayList Items:");
        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }

        // Update - Modify an item in the ArrayList
        arrayList[1] = "Blueberry";

        // Read - Access the updated ArrayList
        Console.WriteLine("\nUpdated ArrayList:");
        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }

        // Delete - Remove an item from the ArrayList
        arrayList.Remove("Cherry");

        // Read - Access the final ArrayList
        Console.WriteLine("\nArrayList after Deletion:");
        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }
    }
}
