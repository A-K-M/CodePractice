using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Services
{
    public interface IAlgoService
    {
        #region Sliding Window
        // to find the max sum of a subarray of given size
        int MaxSumOfSubarray(int[] array, int size);
        // to find the Minimum Length Subarray with a Sum Greater than or Equal to Target
        int MinLengthSubarrayWithSum(int[] arr, int target);

        #endregion

        #region Array and String

        //Two Sum: Given an array of integers, find two numbers such that they add up to a specific target number
        int[] FindTwoSum(int[] numbers, int target);

        #endregion
    }

}
