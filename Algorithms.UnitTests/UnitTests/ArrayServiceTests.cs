using Algorithms.Services;
using Algorithms.Services.Array;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.UnitTests.UnitTests
{
    [TestFixture]
    public class ArrayServiceTests
    {

        private IArrayService _arrayService;

        [SetUp]
        public void Setup()
        {
            _arrayService = new ArrayService();
        }
        [Test]
        public void FindTwoSum_ReturnsCorrectIndices()
        {
            // Arrange
            int[] numbers = { 2, 7, 11, 15 };
            int target = 9;

            // Act
            int[] result = _arrayService.FindTwoSum(numbers, target);

            // Assert
            Assert.That(result, Is.EqualTo(new int[] { 0, 1 })); // Expected indices for 2 + 7 = 9 are [0, 1]
        }

        [Test]
        public void FindTwoSum_ReturnsEmptyArray_WhenNoPairExists()


        {
            // Arrange
            int[] numbers = { 1, 2, 3 };
            int target = 10;

            // Act
            int[] result = _arrayService.FindTwoSum(numbers, target);

            // Assert
            Assert.IsEmpty(result); // No two numbers add up to 10, so the result should be an empty array
        }

        [Test]
        public void FindMaximumSumSubarray_AllPositiveNumbers_ReturnsSumOfAllElements()
        {
            // Arrange
            int[] array = { 1, 2, 3, 4, 5 };

            // Act
            int result = _arrayService.FindMaximumSumSubarray(array);

            // Assert
            Assert.AreEqual(15, result); // Sum of all elements is 15
        }

        [Test]
        public void FindMaximumSumSubarray_AllNegativeNumbers_ReturnsMaximumSingleElement()
        {
            // Arrange
            int[] array = { -5, -1, -8, -9 };

            // Act
            int result = _arrayService.FindMaximumSumSubarray(array);

            // Assert
            Assert.AreEqual(-1, result); // Maximum element is -1
        }

        [Test]
        public void FindMaximumSumSubarray_MixedPositiveAndNegativeNumbers_ReturnsMaxSumSubarray()
        {
            // Arrange
            int[] array = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };

            // Act
            int result = _arrayService.FindMaximumSumSubarray(array);

            // Assert
            Assert.AreEqual(6, result); // The subarray [4, -1, 2, 1] has the maximum sum of 6
        }

        [Test]
        public void FindMaximumSumSubarray_EmptyArray_ReturnsZero()
        {
            // Arrange
            int[] array = new int[] { };

            // Act
            int result = _arrayService.FindMaximumSumSubarray(array);

            // Assert
            Assert.AreEqual(0, result); // An empty array should return 0 or some default value
        }

        [Test]
        public void FindMaximumSumSubarray_SingleElementArray_ReturnsThatElement()
        {
            // Arrange
            int[] array = { 5 };

            // Act
            int result = _arrayService.FindMaximumSumSubarray(array);

            // Assert
            Assert.AreEqual(5, result); // The single element should be returned as is
        }
    }



}
