using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Services;

namespace Algorithms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region Sliding Window
            IAlgoService algoService = new AlgoService();
            int[] SWArray = new int[] { 1, 3, -1, -3, 5, 3, 6, 7 };
            int maxSum = algoService.MaxSumOfSubarray(SWArray, 3);

            int minLength = algoService.MinLengthSubarrayWithSum(SWArray, 2);


            #endregion
        }
    }
}
