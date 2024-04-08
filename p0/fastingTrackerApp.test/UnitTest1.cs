namespace fastingTrackerApp.test;

public class UnitTest1
{
    [Theory]
    [InlineData("200.2", 200.2)]
    [InlineData("Its a sting", 0)]
    public void ConvertToDouble_returnsDouble(string value, double expected){
        var input = new StringReader(value);
        Console.SetIn(input);
        var result = Logic.ConvertToDouble();
        Console.WriteLine(result);
        Assert.Equal(typeof(double), result.GetType());
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("100", 100)]
    [InlineData("Its a sting", 0)]
    public void ConvertToInt_returnsInt(string value, double expected){
        var input = new StringReader(value);
        Console.SetIn(input);
        var result = Logic.ConvertToInt();
        Console.WriteLine(result);
        Assert.Equal(typeof(int), result.GetType());
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("I feel good", "I feel good")]
    [InlineData("", "No symptoms today")]
    public void ValidateString_returnsStr(string value, string expected){
        var input = new StringReader(value);
        Console.SetIn(input);
        var result = Logic.ValidateString();
        Console.WriteLine(result);
        Assert.Equal(typeof(string), result.GetType());
        Assert.Equal(expected, result);
    }
}