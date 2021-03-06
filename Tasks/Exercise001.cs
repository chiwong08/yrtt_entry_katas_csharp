﻿using System;
using System.Collections.Generic;
using System.Linq;

// In this Kata, you will be given an array of numbers in which two numbers occur once and the rest occur only twice. 
// Your task will be to return the sum of the numbers that occur only once.
// For example, repeats([4,5,7,5,4,8]) = 15 because only the numbers 7 and 8 occur once, and their sum is 15.
// More examples in the test cases below.

// Good luck!

namespace TechReturners.Tasks
{
    public class Exercise001
    {
        public static int Singles(List<int> source)
        {
            // found on Google a dictionary which takes in an array as input to 
            // create a key-value pair of the occurences of each element in the array
            // so converting the initial List to array

            int[] intArray = source.ToArray();

            Dictionary<int, int> counts = intArray
                .GroupBy( num => num )
                .ToDictionary(num => num.Key, num => num.Count());

            // now that we have a dictionary of key-value pairs, we can find the ones that only occur once
            // and add to a running total (which is initialised to zero)
            int total=0;

            foreach (KeyValuePair<int, int> item in counts) {
                // Console.WriteLine("Key: {0}, count: {1}", item.Key, item.Value);
                if ( item.Value == 1) {
                    total += item.Key;
                }
            }

            // Console.WriteLine("Returning:" + total);
            return total;
            // throw new NotImplementedException();
        }
    }
}