namespace StringShiftTest;

[TestClass]
public sealed class StringShiftTests
{
    [TestMethod]
    public void TestShiftSuccess()
    {
        string input = "pizza";
        string expected = "zapiz";
        int input2 = 2;
        string output = StringShift.Functions.shift(input, input2);
        Assert.AreEqual(output, expected);
    }
    [TestMethod]
    public void TestShiftLargerNumber()
    {
        string input = "pizza";
        string expected = "zapiz";
        int input2 = 7;
        string output = StringShift.Functions.shift(input, input2);
        Assert.AreEqual(output, expected);
    }
    [TestMethod]
    public void TestShiftSpace()
    {
        string input = "pepperoni pizza";
        string expected = "nipizzapeppero";
        int input2 = 7;
        string output = StringShift.Functions.shift(input, input2);
        Assert.AreEqual(output, expected);
    }
    [TestMethod]
    public void TestValidationSuccess()
    {
        string input = "pizza";
        string input2 = "2";
        int outInt = 0;
        bool output = StringShift.Functions.validate(input, input2, out outInt);
        Assert.AreEqual(output, true);
        Assert.AreEqual(outInt, 2);
    }
    [TestMethod]
    public void TestValidationFailure()
    {
        string? input = null;
        string? input2 = "NaN";
        int outInt = 0;
        bool output = StringShift.Functions.validate(input, input2, out outInt);
        Assert.AreEqual(output, false);
        Assert.AreEqual(outInt, 0);
    }
    [TestMethod]
    public void TestValidationFailureNumeric()
    {
        string? input = "abc123";
        string? input2 = "1";
        int outInt = 0;
        bool output = StringShift.Functions.validate(input, input2, out outInt);
        Assert.AreEqual(output, false);
        Assert.AreEqual(outInt, 1);
    }
}
