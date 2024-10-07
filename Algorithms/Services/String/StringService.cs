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

    public string LongestPalindrome(string s)
    {
        // Edge case: if the string is empty or has only one character, return it as is
        if (string.IsNullOrEmpty(s)) return s;

        int start = 0;  // Start index of the longest palindromic substring
        int maxLength = 1;  // Length of the longest palindromic substring

        // Helper function to expand around the center and update the longest palindrome
        void ExpandFromMiddle(int left, int right)
        {
            // Expand while the characters on both sides are equal (palindromic) and within bounds
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                int currentLength = right - left + 1;  // Current palindrome length

                // If the current palindrome is longer than the previous longest one, update
                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    start = left;  // Update the start index of the longest palindrome
                }

                left--;  // Move left pointer outward
                right++;  // Move right pointer outward
            }
        }

        // Loop through each character in the string
        for (int i = 0; i < s.Length; i++)
        {
            // Expand around the center for odd-length palindromes (single character center)
            ExpandFromMiddle(i - 1, i + 1);

            // Expand around the center for even-length palindromes (two characters center)
            ExpandFromMiddle(i, i + 1);
        }

        // Return the longest palindromic substring found
        return s.Substring(start, maxLength);
    }
}
