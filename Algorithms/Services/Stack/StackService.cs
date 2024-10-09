using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Services.Stack
{
    public class StackService : IStackService
    {
        public bool IsValidParentheses(string s)
        {
            // Stack to keep track of opening brackets
            Stack<char> stack = new Stack<char>();

            // Iterate through each character in the string
            for (int i = 0; i < s.Length; i++)
            {
                char currentChar = s[i];

                // Push opening brackets onto the stack
                if (currentChar == '(' || currentChar == '{' || currentChar == '[')
                {
                    stack.Push(currentChar);
                }
                // Handle closing brackets
                else
                {
                    // If the stack is empty, it means there's no matching opening bracket
                    if (stack.Count == 0) return false;

                    // Pop the top element from the stack
                    char top = stack.Pop();

                    // Check if the popped opening bracket matches the current closing bracket
                    if ((currentChar == ')' && top != '(') ||
                        (currentChar == '}' && top != '{') ||
                        (currentChar == ']' && top != '['))
                    {
                        return false;
                    }
                }
            }

            // At the end, the stack should be empty if all brackets matched
            return stack.Count == 0;
        }

    }
}
