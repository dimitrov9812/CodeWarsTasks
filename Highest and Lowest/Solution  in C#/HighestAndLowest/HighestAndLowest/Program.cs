using System;
using System.Collections.Generic;
using System.Linq;

public static class Kata
{
    public static string HighAndLow(string numbers)
    {
        // Split the user input by space and save it in a new string array
        string[] numberArray = numbers.Split(' ');
        // Create a list for later to store our parsed to integer elements from numberArray
        List<int> intArray = new List<int>();
        // Start a foreach loop 
        foreach (var num in numberArray)
        {
            // Parsing every element to int
            int newNum = int.Parse(num);
            // Add it to the list
            intArray.Add(newNum);
        }
        // Using the Linq functions to easily find the maximum and minimum value of the list
        int max = intArray.Max();
        int min = intArray.Min();

        // Return the Max and Min value which we store in max and min variable
        return max + " " + min;
    }

}