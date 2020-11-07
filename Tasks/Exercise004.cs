using System;

// Move the first letter of each word to the end of it, then add "ay" to the end of the word. 
// Leave punctuation marks untouched.

namespace TechReturners.Tasks
{
    public class Exercise004
    {
        public static string PigIt(string str)
        {
            // given that we can access strings by index like elements of an array, it makes it easier
            // However, we still need to split the string into words to do this.
            // Can use the String.Split() function to divide the string into words

            string[] words = str.Split(' ');

            // resultant string
            string retString = "";

            foreach (string word in words)
            {
                // Lets check whether there are punctuation marks at the end of the string
                // that's my assumption that you won't have punctuation marks in the middle of a word
                // or in the middle of the string itself.
                // the most thorough method is to traverse each word to check each character is a punctuation or not.
                // then the assumoption is that once you hit a punctuation mark, the rest of the line is punctuation only.
                
                int punctIdx = -1;
                for (int i = 0; i < word.Length; i++) {
                    if ( Char.IsPunctuation(word, i) ) {
                        punctIdx = i;
                        break;
                    }
                }

                // if we have a punctuation mark, it will be identified by punctId > -1

                // take first letter, the formulate new word and append "ay"
                char c = word[0];

                string tmpWord = "";
                // now format taking into account punctuation mark.
                if ( punctIdx != -1 ) {
                    tmpWord = word.Substring(1, punctIdx -1) + c + "ay" + word.Substring(punctIdx);
                }
                else {
                    tmpWord = word.Substring(1) + c + "ay";
                }

                // now lets add this word to the result string - and add a space between words
                if ( retString == "" ) {
                    retString = tmpWord;
                }
                else {
                    retString += " ";
                    retString += tmpWord;
                }
            }

            return retString;
            // throw new NotImplementedException();
        }
    }
}

