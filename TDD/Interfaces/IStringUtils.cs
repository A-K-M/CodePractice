using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.Interfaces
{
    public interface IStringUtils
    {
        string ReverseString(string input);
        bool IsPalindrome(string input);
        int CountVowels(string input);
    }
}
