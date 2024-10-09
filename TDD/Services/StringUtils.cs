using TDD.Interfaces;

namespace TDD.Services
{
    public class StringUtils : IStringUtils
    {
        public string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        public bool IsPalindrome(string input)
        {
            var reversed = ReverseString(input);
            return string.Equals(input, reversed, StringComparison.OrdinalIgnoreCase);
        }

        public int CountVowels(string input)
        {
            int count = 0;
            foreach (var ch in input.ToLower())
            {
                if ("aeiou".Contains(ch))
                {
                    count++;
                }
            }
            return count;
        }
    }
}