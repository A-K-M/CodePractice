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

    }


}
