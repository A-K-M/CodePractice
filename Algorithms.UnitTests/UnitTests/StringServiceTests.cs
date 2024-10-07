using Algorithms.Services.String;
using NUnit.Framework;

namespace Algorithms.UnitTests.UnitTests
{

    [TestFixture]
    public class StringServiceTests
    {
        private IStringService _stringService;

        [SetUp]
        public void Setup()
        {
            _stringService = new StringService(); // Assuming your method is inside StringService
        }

        [Test]
        public void LengthOfLongestSubstring_ShouldReturnZero_WhenEmptyString()
        {
            // Arrange
            string input = string.Empty;

            // Act
            int result = _stringService.LengthOfLongestSubstring(input);

            // Assert
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void LengthOfLongestSubstring_ShouldReturnOne_WhenSingleCharacter()
        {
            // Arrange
            string input = "a";

            // Act
            int result = _stringService.LengthOfLongestSubstring(input);

            // Assert
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void LengthOfLongestSubstring_ShouldReturnLengthOfString_WhenNoRepeatingCharacters()
        {
            // Arrange
            string input = "abc";

            // Act
            int result = _stringService.LengthOfLongestSubstring(input);

            // Assert
            Assert.That(result, Is.EqualTo(3)); // The whole string "abc" is the longest
        }

        [Test]
        public void LengthOfLongestSubstring_ShouldReturnOne_WhenAllCharactersAreSame()
        {
            // Arrange
            string input = "aaaa";

            // Act
            int result = _stringService.LengthOfLongestSubstring(input);

            // Assert
            Assert.That(result, Is.EqualTo(1)); // Only one unique character in "aaaa"
        }

        [Test]
        public void LengthOfLongestSubstring_ShouldReturnThree_WhenInputIsAbcabcbb()
        {
            // Arrange
            string input = "abcabcbb";

            // Act
            int result = _stringService.LengthOfLongestSubstring(input);

            // Assert
            Assert.That(result, Is.EqualTo(3)); // The longest substring without repeating characters is "abc"
        }

        [Test]
        public void LengthOfLongestSubstring_ShouldReturnThree_WhenInputIsPwwkew()
        {
            // Arrange
            string input = "pwwkew";

            // Act
            int result = _stringService.LengthOfLongestSubstring(input);

            // Assert
            Assert.That(result, Is.EqualTo(3)); // The longest substring without repeating characters is "wke"
        }

        [Test]
        public void LengthOfLongestSubstring_ShouldHandleSpecialCharacters()
        {
            // Arrange
            string input = "a!@#!";

            // Act
            int result = _stringService.LengthOfLongestSubstring(input);

            // Assert
            Assert.That(result, Is.EqualTo(4)); // The longest substring without repeating characters is "a!@#"
        }

        [Test]
        public void LengthOfLongestSubstring_ShouldReturnFour_WhenInputIsLongestSubstringInTheMiddle()
        {
            // Arrange
            string input = "abcbde";

            // Act
            int result = _stringService.LengthOfLongestSubstring(input);

            // Assert
            Assert.That(result, Is.EqualTo(4)); // The longest substring without repeating characters is "bcde"
        }
    }

}