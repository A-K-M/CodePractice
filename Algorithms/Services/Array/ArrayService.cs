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

        public int FindMaximumSumSubarray(int[] array)
        {
            // Check if the input array is empty; return 0 if it is, since there's no subarray to consider.
            if (array.Length == 0)
            {
                return 0;
            }

            // Initialize maxSum and currentSum with the first element of the array.
            // This assumes that the maximum sum starts with the first element.
            int maxSum = array[0];
            int currentSum = array[0];

            // Loop through the array starting from the second element.
            for (int i = 1; i < array.Length; i++)
            {
                // At each step, update currentSum to be either the current element (starting a new subarray)
                // or the sum of the current element and the previous currentSum (extending the existing subarray).
                currentSum = Math.Max(array[i], currentSum + array[i]);

                // Update maxSum to the maximum of itself and currentSum.
                // This ensures maxSum holds the highest sum encountered so far.
                maxSum = Math.Max(currentSum, maxSum);
            }

            // Return the maximum subarray sum found.
            return maxSum;
        }
        public int FindWaterTrapped(int[] bars)
        {
            // If the array is empty, no water can be trapped, so return 0.
            if (bars.Length == 0) return 0;

            // Initialize two pointers: 'left' starting at the beginning, and 'right' at the end of the array.
            int left = 0;
            int right = bars.Length - 1;

            // Initialize leftMax and rightMax to store the highest bars encountered so far from the left and right sides.
            int leftMax = bars[left];
            int rightMax = bars[right];

            // Variable to keep track of the total amount of water trapped.
            int water = 0;

            // Continue until the left and right pointers meet.
            while (left < right)
            {
                // If the current leftMax is less than or equal to the rightMax,
                // the trapped water is determined by the left side.
                if (leftMax <= rightMax)
                {
                    // Move the left pointer one step to the right.
                    left++;

                    // Update leftMax to the maximum of the current leftMax and the new bar at 'left'.
                    leftMax = Math.Max(leftMax, bars[left]);

                    // Calculate water trapped at the current position:
                    // If leftMax is greater than the current bar, some water can be trapped here.
                    water += Math.Max(0, leftMax - bars[left]);
                }
                // Otherwise, determine the trapped water based on the right side.
                else
                {
                    // Move the right pointer one step to the left.
                    right--;

                    // Update rightMax to the maximum of the current rightMax and the new bar at 'right'.
                    rightMax = Math.Max(rightMax, bars[right]);

                    // Calculate water trapped at the current position:
                    // If rightMax is greater than the current bar, some water can be trapped here.
                    water += Math.Max(0, rightMax - bars[right]);
                }
            }

            // Return the total amount of water trapped.
            return water;
        }
    }
}
