using AutoFixture;

public class AutoFixtureTests
{
    [Fact]
    public void Add_ShouldReturnCorrectSum()
    {
        // Arrange
        var fixture = new Fixture();
        var calculator = fixture.Create<Calculator>();

        // Act
        var result = calculator.Add();

        // Assert
        Assert.Equal(calculator.Operand1 + calculator.Operand2, result);
    }

    [Fact]
    public void Subtract_ShouldReturnCorrectDifference()
    {
        // Arrange
        var fixture = new Fixture();
        var calculator = fixture.Create<Calculator>();

        // Act
        var result = calculator.Subtract();

        // Assert
        Assert.Equal(calculator.Operand1 - calculator.Operand2, result);
    }
}