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
            if (array.Length == 0)
            {
                return 0;
            }
            int maxSum = array[0];
            int currentSum = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                currentSum = Math.Max(array[i], currentSum + array[i]);
                maxSum = Math.Max(currentSum, maxSum);
            }

            return maxSum;
        }

        public int FindWaterTrapped(int[] bars)
        {
            if (bars.Length == 0) return 0;

            int left = 0;
            int right = bars.Length - 1;

            int leftMax = bars[left];
            int rightMax = bars[right];
            int water = 0;

            while (left < right)
            {
                if (leftMax <= rightMax)
                {
                    left++;
                    leftMax = Math.Max(leftMax, bars[left]);
                    water += Math.Max(0, leftMax - bars[left]);
                }
                else
                {
                    right--;
                    rightMax = Math.Max(rightMax, bars[right]);
                    water += Math.Max(0, rightMax - bars[right]);
                }
            }
            return water;
        }
    }
}
