using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Services
{
    public class AlgoService : IAlgoService
    {
        #region Sliding Window

        public int MaxSumOfSubarray(int[] array, int size)
        {
            int maxSum = 0;
            for (int i = 0; i < size; i++)
            {
                maxSum += array[i];
            }
            int currentSum = maxSum;

            for (int i = size; i < array.Length; i++)
            {
                currentSum += array[i] - array[i - size];
                maxSum = Math.Max(maxSum, currentSum);
            }

            return maxSum;
        }
        public int MinLengthSubarrayWithSum(int[] arr, int target)
        {
            int minLength = int.MaxValue;
            int currentSum = 0;
            int start = 0;
            // Shrink the window from the left if the sum is greater than or equal to the target
            for (int end = 0;end < arr.Length;end++)
            {
                currentSum += arr[end];
                while (currentSum >= target)
                {
                    // Update the minimum length of the subarray
                    minLength = Math.Min(minLength, end - start + 1);
                    // Subtract the element at 'start' from the current sum and move 'start' to the right
                    currentSum -= arr[start];
                    start++;
                }
            }
            return minLength == int.MaxValue ? 0 : minLength;

        }

        #endregion

        #region Array and String
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


        #endregion

    }
}
