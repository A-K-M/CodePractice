# CodePractice Solution

This solution contains various C# projects and unit tests aimed at practicing and demonstrating concepts such as **algorithm development**, **clean coding**, and **Test-Driven Development (TDD)** using **xUnit** and **Moq**.

## Table of Contents

- [Overview](#overview)
- [Projects](#projects)
- [Technologies Used](#technologies-used)
- [Running Tests](#running-tests)
- [Code Structure](#code-structure)

## Overview

This repository is structured to include different projects focused on improving coding skills and implementing various algorithms. It includes the following key areas:

1. **Algorithms**: A collection of algorithms implemented in C#.
2. **CleanCode**: A project focused on writing clean, maintainable code.
3. **TDD**: A project that implements methods using the TDD approach.
4. **Unit Tests**: Using **xUnit**, **NUnit** and **Moq** for testing, ensuring that each component behaves as expected.

## Projects

### 1. Algorithms

- Contains implementations of various algorithms, such as `LongestPalindrome`.
- The focus is on solving algorithmic problems efficiently.

### 2. Algorithms.UnitTests

- Contains unit tests for the algorithms in the `Algorithms` project.
- Tests are written using **NUnit** to ensure correctness.

### 3. CleanCode

- A project aimed at demonstrating principles of writing clean and maintainable code.
- Focuses on improving readability, reducing complexity, and adhering to best practices.

### 4. TDD

- Contains classes that follow the Test-Driven Development (TDD) approach.
- Includes methods such as `ReverseString`, `IsPalindrome`, and `CountVowels` to showcase TDD principles.

### 5. TDD.Tests

- Contains unit tests for the classes in the `TDD` project.
- Uses **Moq** to mock dependencies and **xUnit** to validate behavior.

## Technologies Used

- .NET Core
- xUnit: A testing framework for .NET.
- Moq: A mocking library for .NET to simulate object behavior.
- C#: Programming language for implementing the projects.

## Running Tests

To run all the unit tests for the solution, use the following command in the root directory:

```bash
dotnet test
```

This will execute all the tests across the solution and provide a summary of the test results.

## Code Structure

```
CodePractice/
│
├── Algorithms/
│   └── LongestPalindrome.cs        # Implementation of algorithms
│
├── Algorithms.UnitTests/
│   └── LongestPalindromeTests.cs   # Unit tests for algorithms
│
├── CleanCode/
│   └── CleanCodeExamples.cs        # Examples focusing on clean coding
│
├── TDD/
│   └── StringUtils.cs              # Implementation of TDD methods
│
├── TDD.Tests/
│   ├── UnitTests/
│   │   └── StringUtilsMoqTests.cs  # Unit tests using xUnit and Moq
│
├── .gitignore                      # Git ignore file
├── CodePractice.sln                # Solution file
└── README.md                       # Project documentation
```

## Notes

- The solution is organized into separate projects to maintain a clean structure.
- Follow TDD principles: Write tests first, then implement the functionality, and finally refactor.
- The `CleanCode` project is a reference for understanding code readability and maintainability using OOP and SOILD Principles.
