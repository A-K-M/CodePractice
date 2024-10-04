using NUnit.Framework;
using Algorithms.Services;
using Algorithms.Services.SlidingWindow;

namespace Algorithms.UnitTests.UnitTests
{
    [TestFixture]
    public class SlidingWindowTests
    {
        private ISlidingWindowService _slidingWindowService;

        [SetUp]
        public void Setup()
        {
            _slidingWindowService = new SlidingWindowService(); // Setup before each test
        }

        [Test]
        public void MaxSumOfSubarray_ReturnsCorrectMaxSum()
        {
            // Arrange
            int[] array = { 1, 3, -1, -3, 5, 3, 6, 7 };
            int size = 3;

            // Act
            int result = _slidingWindowService.MaxSumOfSubarray(array, size);

            // Assert
            Assert.That(result, Is.EqualTo(16)); // Expected max sum of subarray of size 3 is 16
        }

        [Test]
        public void MinLengthSubarrayWithSum_ReturnsCorrectMinLength()
        {
            // Arrange
            int[] array = { 1, 3, -1, -3, 5, 3, 6, 7 };
            int target = 7;

            // Act
            int result = _slidingWindowService.MinLengthSubarrayWithSum(array, target);

            // Assert
            Assert.That(result, Is.EqualTo(1)); // Expected min length is 1 (subarray [7])
        }
    }
}
