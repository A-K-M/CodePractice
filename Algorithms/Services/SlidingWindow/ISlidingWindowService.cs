using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Services.SlidingWindow
{
    public interface ISlidingWindowService
    {
        // to find the max sum of a subarray of given size
        int MaxSumOfSubarray(int[] array, int size);
        // to find the Minimum Length Subarray with a Sum Greater than or Equal to Target
        int MinLengthSubarrayWithSum(int[] arr, int target);
    }
}
