using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAssignment2.Classes
{
    internal class StringUtility
    {
        private static List<char> _charsLower = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };
        private static List<char> _charsUpper = new List<char>() { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };

        public string Reverse(string Input)
        {

            // Converting string to character array
            char[] charArray = Input.ToCharArray();

            // Declaring an empty string
            string reversedString = string.Empty;

            // Iterating the each character from right to left
            for (int i = charArray.Length - 1; i > -1; i--)
            {

                // Append each character to the reversedstring.
                reversedString += charArray[i];
            }

            // Return the reversed string.
            return reversedString;
        }

        public string ToUpperCase(string text)
        {
            string result = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (_charsLower.Contains(text[i]))
                {
                    var index = i;
                    result += _charsUpper[index];
                }
            }

            return result;
        }
        public string ToLowerCase(string text)
        {
            string result = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (_charsUpper.Contains(text[i]))
                {
                    var index = i;
                    result += _charsLower[index];
                }
            }

            return result;
        }
    }
}
