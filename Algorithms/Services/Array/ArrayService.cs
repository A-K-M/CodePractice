using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Services.Array
{
    public class ArrayService : IArrayService
    {
        public int[] FindTwoSum(int[] numbers, int target)
        {
            // this will store key, value pair of current number as key, index as value
            Dictionary<int, int> numMap = new Dictionary<int, int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                // find the required number to get target
                int complement = target - numbers[i];

                // check if the required number is in the dictionary
                if (numMap.ContainsKey(complement))
                {
                    // if yes, return this found indices
                    return new int[] { numMap[complement], i };
                }
                else
                {
                    // Store current number and index
                    numMap[numbers[i]] = i;
                }

            }
            return new int[0];
        }
    }
}
