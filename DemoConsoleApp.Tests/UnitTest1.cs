using DemoConsoleApp;
using Xunit;

public class CalculatorTests
{
    [Fact]
    public void Add_ReturnsCorrectValue()
    {
        Assert.Equal(5, Calculator.Add(2, 3));
    }

    [Fact]
    public void Add_HandlesNegativeNumbers()
    {
        Assert.Equal(-1, Calculator.Add(-4, 3));
    }

    [Fact]
    public void Add_WithZeroReturnsOtherOperand()
    {
        Assert.Equal(7, Calculator.Add(0, 7));
        Assert.Equal(7, Calculator.Add(7, 0));
    }

    [Theory]
    [InlineData(1, 1, 2)]
    [InlineData(100, 250, 350)]
    [InlineData(-10, -5, -15)]
    public void Add_TheoryWithMultipleInputs(int a, int b, int expected)
    {
        Assert.Equal(expected, Calculator.Add(a, b));
    }

    [Fact]
    public void Subtract_ReturnsCorrectValue()
    {
        Assert.Equal(6, Calculator.Subtract(10, 4));
    }

    [Fact]
    public void Multiply_ReturnsCorrectValue()
    {
        Assert.Equal(42, Calculator.Multiply(6, 7));
    }

    [Fact]
    public void Multiply_ByZeroIsZero()
    {
        Assert.Equal(0, Calculator.Multiply(99, 0));
    }
}
