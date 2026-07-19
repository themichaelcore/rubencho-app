using Rubencho.Application;
using Xunit;

namespace Rubencho.Application.UnitTests;

public class StringExtensionsTests
{
    //[Fact]
    //public void ToTitleCase_WhenSourceIsNull_ReturnsEmptyString()
    //{
    //    // Arrange
    //    string? source = null;

    //    // Act
    //    var result = source.ToTitleCase();

    //    // Assert
    //    Assert.Equal(string.Empty, result);
    //}

    //[Fact]
    //public void ToTitleCase_WhenSourceIsEmpty_ReturnsEmptyString()
    //{
    //    // Arrange
    //    var source = string.Empty;

    //    // Act
    //    var result = source.ToTitleCase();

    //    // Assert
    //    Assert.Equal(string.Empty, result);
    //}

    //[Fact]
    //public void ToTitleCase_WhenSourceIsWhitespace_ReturnsWhitespace()
    //{
    //    // Arrange
    //    var source = "   ";

    //    // Act
    //    var result = source.ToTitleCase();

    //    // Assert
    //    Assert.Equal("   ", result);
    //}

    //[Fact]
    //public void ToTitleCase_WhenSourceIsLowerCase_ReturnsCorrectTitleCase()
    //{
    //    // Arrange
    //    var source = "hello world";

    //    // Act
    //    var result = source.ToTitleCase();

    //    // Assert
    //    Assert.Equal("Hello World", result);
    //}

    //[Fact]
    //public void ToTitleCase_WhenSourceIsUpperCase_ReturnsCorrectTitleCase()
    //{
    //    // Arrange
    //    var source = "HELLO WORLD";

    //    // Act
    //    var result = source.ToTitleCase();

    //    // Assert
    //    Assert.Equal("Hello World", result);
    //}

    //[Fact]
    //public void ToTitleCase_WhenSourceIsMixedCase_ReturnsCorrectTitleCase()
    //{
    //    // Arrange
    //    var source = "hELLo WoRLd";

    //    // Act
    //    var result = source.ToTitleCase();

    //    // Assert
    //    Assert.Equal("Hello World", result);
    //}

    //[Fact]
    //public void ToTitleCase_WhenSourceHasMultipleSpaces_PreservesSpacing()
    //{
    //    // Arrange
    //    var source = "hello   world";

    //    // Act
    //    var result = source.ToTitleCase();

    //    // Assert
    //    Assert.Equal("Hello   World", result);
    //}

    //[Fact]
    //public void ToTitleCase_WhenSourceHasSpecialCharacters_CapitalizesAfterSpecialChars()
    //{
    //    // Arrange
    //    var source = "hello-world_test.file";

    //    // Act
    //    var result = source.ToTitleCase();

    //    // Assert
    //    Assert.Equal("Hello-World_Test.File", result);
    //}

    //[Fact]
    //public void ToTitleCase_WhenSourceHasNumbers_CapitalizesCorrectly()
    //{
    //    // Arrange
    //    var source = "test123 case";

    //    // Act
    //    var result = source.ToTitleCase();

    //    // Assert
    //    Assert.Equal("Test123 Case", result);
    //}

    //[Fact]
    //public void ToTitleCase_WhenSourceHasApostrophes_HandlesCorrectly()
    //{
    //    // Arrange
    //    var source = "don't worry it's working";

    //    // Act
    //    var result = source.ToTitleCase();

    //    // Assert
    //    Assert.Equal("Don't Worry It's Working", result);
    //}

    //[Fact]
    //public void ToTitleCase_WhenSourceIsSingleCharacter_CapitalizesCorrectly()
    //{
    //    // Arrange
    //    var source = "a";

    //    // Act
    //    var result = source.ToTitleCase();

    //    // Assert
    //    Assert.Equal("A", result);
    //}

    //[Fact]
    //public void ToTitleCase_WhenSourceHasLeadingAndTrailingSpaces_PreservesSpaces()
    //{
    //    // Arrange
    //    var source = "  hello world  ";

    //    // Act
    //    var result = source.ToTitleCase();

    //    // Assert
    //    Assert.Equal("  Hello World  ", result);
    //}

    //[Theory]
    //[InlineData("the quick brown fox", "The Quick Brown Fox")]
    //[InlineData("JUMPS OVER THE LAZY DOG", "Jumps Over The Lazy Dog")]
    //[InlineData("mIxEd CaSe StRiNg", "Mixed Case String")]
    //[InlineData("123 abc XYZ", "123 Abc Xyz")]
    //[InlineData("test@email.com", "Test@Email.Com")]
    //public void ToTitleCase_WithVariousInputs_ReturnsExpectedResults(string input, string expected)
    //{
    //    // Act
    //    var result = input.ToTitleCase();

    //    // Assert
    //    Assert.Equal(expected, result);
    //}
}
