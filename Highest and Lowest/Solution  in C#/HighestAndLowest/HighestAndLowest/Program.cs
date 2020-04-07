using System;
using System.Collections.Generic;
using System.Linq;

public static class Kata
{
    public static string HighAndLow(string numbers)
    {
        string[] numberArray = numbers.Split(' ');
        List<int> intArray = new List<int>();
        foreach (var num in numberArray)
        {
            int newNum = int.Parse(num);
            intArray.Add(newNum);
        }
        int max = intArray.Max();
        int min = intArray.Min();

        return max + " " + min;
    }

}