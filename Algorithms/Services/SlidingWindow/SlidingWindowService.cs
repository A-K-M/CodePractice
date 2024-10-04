using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Services.SlidingWindow
{
    public class SlidingWindowService : ISlidingWindowService
    {
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
            for (int end = 0; end < arr.Length; end++)
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
    }
}
