using System.IO.Compression;
using Calculator.Services;

namespace CalculatorTests;

public class CalculatorTests
{
    private CalculatorImp _calc;

    public CalculatorTests()
    {
        _calc = new CalculatorImp();
    }

    [Fact]
    public void ShouldSum5Plus15AndReturn20()
    {
        // Arrange
        int num1 = 5;
        int num2 = 15;

        // Act
        int total = _calc.Sum(num1, num2);

        // Assert
        Assert.Equal(20, total);
    }

    [Fact]
    public void ShouldSum7Plus5AndReturn12()
    {
        // Arrange
        int num1 = 7;
        int num2 = 5;

        // Act
        int total = _calc.Sum(num1, num2);

        // Assert
        Assert.Equal(12, total);
    }

    [Theory]
    [InlineData(new int[] { 2, 4, 6, 8, 10 })]
    public void VerifyIfNumberIsEvenAndReturnTrue(int[] numbers)
    {
        Assert.All(numbers, num => Assert.True(_calc.EvenOdd(num)));
    }
}