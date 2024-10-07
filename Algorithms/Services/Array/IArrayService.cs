using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Services.Array
{
    public interface IArrayService
    {
        //Two Sum: Given an array of integers, find two numbers such that they add up to a specific target number
        int[] FindTwoSum(int[] numbers, int target);
        int FindMaximumSumSubarray(int[] array);
        int FindWaterTrapped(int[] bars);
    }
}
