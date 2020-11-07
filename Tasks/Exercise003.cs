using System;

// Scenario
// Several people are standing in a row divided into two teams. The first person goes into team 1, the second goes into team 2, the third goes into team 1, and so on.

// Task
// Given an array of positive integers (the weights of the people), return a new array of two integers, where the first one is the total weight of team 1, and the second one is the total weight of team 2.

// Notes
// Array size is at least 1.
// All numbers will be positive.

// Input >> Output Examples
// rowWeights([13, 27, 49])  ==>  return (62, 27)
// Explanation:
// The first element 62 is the total weight of team 1, and the second element 27 is the total weight of team 2.

// rowWeights([50, 60, 70, 80])  ==>  return (120, 140)
// Explanation:
// The first element 120 is the total weight of team 1, and the second element 140 is the total weight of team 2.

// rowWeights([80])  ==>  return (80, 0)
// Explanation:
// The first element 80 is the total weight of team 1, and the second element 0 is the total weight of team 2.

namespace TechReturners.Tasks
{
    public class Exercise003
    {
        public static int[] RowWeights(int[] a)
        {
            // Lets initialise an output array for the running total of weights of team A and team B
            int[] teams = {0, 0};

            // now lets loop the input array with the one condition that we only cycle 
            // the output array's index with either 0 or 1 (for team A or team B)

            // start output array index at 0
            int teamsIdx = 0;
            foreach (int weight in a)
            {
                teams[teamsIdx] += weight;
                if ( teamsIdx == 0 ) {
                    teamsIdx = 1;
                }
                else {
                    teamsIdx = 0;
                }
            }

            return teams;

            // throw new NotImplementedException();
        }
    }
}

