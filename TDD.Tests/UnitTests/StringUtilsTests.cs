using Xunit;
using Moq;
using TDD.Interfaces;
using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.X86;
using System;

#region logic of Xunit and Moq
//What Are xUnit and Moq?
//xUnit: A testing framework for .NET, similar to other frameworks like NUnit and MSTest. It allows you to write unit tests for your code to ensure it works as expected. A unit test is a small, isolated test that checks a specific part of your application.
//Moq: A mocking library for .NET that works with testing frameworks like xUnit. It allows you to create mock objects that mimic the behavior of real objects. This is useful when you want to test a specific component without relying on the behavior of other parts of your application.

//Key Concepts in Unit Testing with xUnit
//Unit Test: Tests a small, isolated part of your application (usually a single method). It checks if the method behaves correctly given a set of inputs.
//Fact: In xUnit, a Fact attribute is used to indicate that a method is a test. Each method marked with [Fact] is a test case that xUnit will run.

//Key Concepts in Mocking with Moq
//Mock Object: A "fake" version of a real object that you can control.You can specify what methods on the mock should return and verify that they are called with expected arguments.
//Setup: This is how you define what a mock should do when a specific method is called.
//Verify: After calling a method, you use Verify to ensure that the method was called as expected, such as how many times it was called or with what parameters.

#endregion

namespace TDD.Tests.UnitTests
{
    // This class contains unit tests for the StringUtils using Moq to mock its behavior.
    public class StringUtilsMoqTests
    {
        // A mock object of the IStringUtils interface.
        private readonly Mock<IStringUtils> _mockStringUtils;

        // Constructor to initialize the mock object.
        public StringUtilsMoqTests()
        {
            // Create a new mock of the IStringUtils interface.
            _mockStringUtils = new Mock<IStringUtils>();
        }

        // Test to verify that the ReverseString method is called with the correct parameter.
        [Fact]
        public void ReverseString_ShouldBeCalledWithCorrectParameter()
        {
            // Arrange: Prepare the input and expected result.
            var input = "hello";
            var expected = "olleh";

            // Set up the mock to return "olleh" when ReverseString is called with "hello".
            _mockStringUtils.Setup(x => x.ReverseString(input)).Returns(expected);

            // Act: Call the ReverseString method using the mock object.
            var result = _mockStringUtils.Object.ReverseString(input);

            // Assert: Verify the result and that ReverseString was called exactly once with the correct input.
            Assert.Equal(expected, result);
            _mockStringUtils.Verify(x => x.ReverseString(input), Times.Once,
                "ReverseString should be called exactly once with the correct input.");
        }

        // Test to verify that the IsPalindrome method returns true for a palindrome input.
        [Fact]
        public void IsPalindrome_ShouldReturnTrueForPalindrome()
        {
            // Arrange: Prepare the input and expected result.
            var input = "racecar";

            // Set up the mock to return true when IsPalindrome is called with "racecar".
            _mockStringUtils.Setup(x => x.IsPalindrome(input)).Returns(true);

            // Act: Call the IsPalindrome method using the mock object.
            var result = _mockStringUtils.Object.IsPalindrome(input);

            // Assert: Verify that the result is true and that IsPalindrome was called exactly once.
            Assert.True(result, "IsPalindrome should return true for a palindrome.");
            _mockStringUtils.Verify(x => x.IsPalindrome(input), Times.Once,
                "IsPalindrome should be called exactly once.");
        }

        // Test to verify that the CountVowels method returns the correct vowel count.
        [Fact]
        public void CountVowels_ShouldReturnCorrectCount()
        {
            // Arrange: Prepare the input and expected result.
            var input = "hello";
            var expectedCount = 2;

            // Set up the mock to return 2 when CountVowels is called with "hello".
            _mockStringUtils.Setup(x => x.CountVowels(input)).Returns(expectedCount);

            // Act: Call the CountVowels method using the mock object.
            var result = _mockStringUtils.Object.CountVowels(input);

            // Assert: Verify that the result matches the expected count and that CountVowels was called exactly once.
            Assert.Equal(expectedCount, result);
            _mockStringUtils.Verify(x => x.CountVowels(input), Times.Once,
                "CountVowels should be called exactly once with the correct input.");
        }
    }
}
