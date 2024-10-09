
# StringUtils TDD Project

This project demonstrates the use of **Test-Driven Development (TDD)** with **xUnit** and **Moq** for a simple string manipulation utility. It includes methods to reverse a string, check if a string is a palindrome, and count the number of vowels in a string.

## Table of Contents

- [Overview](#overview)
- [Technologies Used](#technologies-used)
- [Running Tests](#running-tests)
- [Code Structure](#code-structure)
- [Implemented Methods](#implemented-methods)

## Overview

The `StringUtils` class implements the `IStringUtils` interface and provides three main functionalities:

1. `ReverseString`: Reverses a given string.
2. `IsPalindrome`: Checks if a given string is a palindrome.
3. `CountVowels`: Counts the number of vowels in a given string.

Unit tests are written using **xUnit** and **Moq** to verify the correctness of each method and ensure they behave as expected.

## Technologies Used

- .NET Core
- xUnit: Testing framework for .NET.
- Moq: Mocking library for .NET to simulate object behavior.

## Running Tests

To run the unit tests, use the following command:

```bash
dotnet test
```

This will execute all the tests and provide a report on the test results, indicating which tests passed and which tests failed.

## Code Structure

```
TDD/
├── README.md                 # TDD Project documentation
├── TDD.Interfaces/
│   └── IStringUtils.cs       # Interface for the string utility methods
│
├── TDD.Services/
│   └── StringUtils.cs        # Implementation of IStringUtils
└── 
TDD.Tests/
├─ UnitTests/
│   │   └── StringUtilsMoqTests.cs   # Unit tests using xUnit and Moq
└── 
```

### Implemented Methods

- **ReverseString(string input)**: Reverses the input string and returns it.
- **IsPalindrome(string input)**: Returns `true` if the input string is a palindrome; otherwise, returns `false`.
- **CountVowels(string input)**: Returns the number of vowels (`a`, `e`, `i`, `o`, `u`) in the input string.
