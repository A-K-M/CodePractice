using System;

namespace Algorithms.Services.String;

public class StringService : IStringService
{
    public int LengthOfLongestSubstring(string s)
    {
        // Dictionary to store the last seen index of each character
        Dictionary<char, int> charMap = new Dictionary<char, int>();

        int start = 0;  // Start of the current window
        int maxLength = 0;  // To store the maximum length of substring without repeating characters

        // Loop through the string
        for (int i = 0; i < s.Length; i++)
        {
            char currentChar = s[i];

            // If the character is already in the dictionary and is within the current window
            if (charMap.ContainsKey(currentChar) && charMap[currentChar] >= start)
            {
                // Move the start of the window to the right of the last occurrence of the character
                start = charMap[currentChar] + 1;
            }

            // Update the character's index in the dictionary
            charMap[currentChar] = i;

            // Update the maximum length of the substring
            maxLength = Math.Max(maxLength, i - start + 1);
        }

        return maxLength;
    }

}
