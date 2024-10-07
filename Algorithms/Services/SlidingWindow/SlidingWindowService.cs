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
            // Initialize maxSum to 0. This will hold the maximum sum of any subarray of the given size.
            int maxSum = 0;

            // First, calculate the sum of the initial subarray of the specified size.
            for (int i = 0; i < size; i++)
            {
                maxSum += array[i];
            }

            // Set currentSum to the sum of the first subarray, which we'll use for sliding the window across the array.
            int currentSum = maxSum;

            // Now slide the window of size 'size' across the array, starting from the element after the initial subarray.
            for (int i = size; i < array.Length; i++)
            {
                // Update the current sum by adding the new element (array[i]) and subtracting the element that is now out of the window (array[i - size]).
                currentSum += array[i] - array[i - size];

                // Update maxSum to the maximum of itself and currentSum.
                // This ensures maxSum holds the highest sum encountered so far.
                maxSum = Math.Max(maxSum, currentSum);
            }

            // Return the maximum sum of any subarray of the given size.
            return maxSum;
        }
        public int MinLengthSubarrayWithSum(int[] arr, int target)
        {
            // Initialize minLength to the maximum possible value. This will track the shortest subarray length found.
            int minLength = int.MaxValue;

            // currentSum will hold the sum of the current subarray.
            int currentSum = 0;

            // 'start' is the beginning index of the sliding window.
            int start = 0;

            // Iterate through the array, with 'end' representing the right side of the sliding window.
            for (int end = 0; end < arr.Length; end++)
            {
                // Add the current element at 'end' to the current sum.
                currentSum += arr[end];

                // Shrink the window from the left (by moving 'start') as long as the current sum is greater than or equal to the target.
                while (currentSum >= target)
                {
                    // Update minLength with the current subarray length if it's smaller than the previous minLength.
                    minLength = Math.Min(minLength, end - start + 1);

                    // Subtract the element at the 'start' index from currentSum to shrink the window.
                    currentSum -= arr[start];

                    // Move the 'start' index to the right to continue shrinking the window.
                    start++;
                }
            }

            // If minLength remains unchanged (meaning no valid subarray was found), return 0.
            // Otherwise, return the minimum length of a subarray that sums to at least the target.
            return minLength == int.MaxValue ? 0 : minLength;
        }
    }
}
