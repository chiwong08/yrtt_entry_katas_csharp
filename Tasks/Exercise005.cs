using System;
using System.Collections.Generic;

// Introduction
// The wave (known as the Mexican wave in the English-speaking world outside North America) is an example of metachronal rhythm achieved in a packed 
// stadium when successive groups of spectators briefly stand, yell, and raise their arms. Immediately upon stretching to full height, the spectator 
// returns to the usual seated position.

// The result is a wave of standing spectators that travels through the crowd, even though individual spectators never move away from their seats. 
// In many large arenas the crowd is seated in a contiguous circuit all the way around the sport field, and so the wave is able to travel continuously 
// around the arena; in discontiguous seating arrangements, the wave can instead reflect back and forth through the crowd. When the gap in seating is narrow, 
// the wave can sometimes pass through it. Usually only one wave crest will be present at any given time in an arena, although simultaneous, counter-rotating 
// waves have been produced. (Source Wikipedia)

// Task
// In this simple Kata your task is to create a function that turns a string into a Mexican Wave. You will be passed a string and you must return that string in an array where an uppercase letter is a person standing up. 

// Rules
//  1.  The input string will always be lower case but maybe empty.
//  2.  If the character in the string is whitespace then pass over it as if it was an empty seat
// Example
// wave("hello") => ["Hello", "hEllo", "heLlo", "helLo", "hellO"]

namespace TechReturners.Tasks
{
    public class Exercise005
    {
        public static List<string> Wave(string str)
        {
            // assume that we ignore whitespace as part of he wave
            // We read through the string as an array would be easiest to manipulate
            // as basically, the idea is to make the index'th letter of the loop upper case
            // so if a word is 10 letters long, there will be up to 10 words returned, 
            // with each successive letter being upper case in the words sequence

            List<string> result = new List<string>();

            if ( str == "" ) {
                return result;
            }
            
            for (int i = 0; i < str.Length; i++) {
                string aWord = "";
                char c = Char.ToUpper(str[i]);
                if ( Char.IsWhiteSpace(c) ) {
                    // do nothing as it's not part of the wave or word
                }
                else {
                    if ( i == 0 ) {
                        aWord = Char.ToString(c);
                    }
                    else if ( i == 1 ) {
                        aWord = str.Substring(0,1) + c;
                    }
                    else {
                        aWord = str.Substring(0,i) + c;
                    }
                    aWord += str.Substring(i+1);
// Console.WriteLine("aWord = " + aWord);
                    result.Add(aWord);
                }
            }

            return result;
            // throw new NotImplementedException();
        }
    }
}

