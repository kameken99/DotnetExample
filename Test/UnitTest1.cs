namespace Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        // Arrange
        var value1 = 2;
        var value2 = 3;
        var expected = 5;

        // Act
        var actual = value1 + value2;

        // Assert
        Assert.Equal(expected, actual);
    }
}