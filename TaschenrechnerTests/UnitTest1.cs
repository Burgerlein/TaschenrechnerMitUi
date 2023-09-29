using TaschenrechnerMitUi;
namespace TaschenrechnerTests;

public class Tests
{
    [Test]
    public void AdditionTest()
    {
        const int additionTestExpected = 3;
        var additionTestResult = Model.Addition(1, 2);
        Console.WriteLine(additionTestResult);
        Assert.That(additionTestResult, Is.EqualTo(additionTestExpected));
    }
    [Test]
    public void SubtractionTest()
    {
        const int subtractionTestExpected = 1;
        var subtractionTestResult = Model.Subtraction(3, 2);
        Console.WriteLine(subtractionTestResult);
        Assert.That(subtractionTestResult, Is.EqualTo(subtractionTestExpected));
    }
    [Test]
    public void MultiplicationTest()
    {
        const int multiplicationTestExpected = 6;
        var multiplicationTestResult = Model.Multiplication(3, 2);
        Console.WriteLine(multiplicationTestResult);
        Assert.That(multiplicationTestResult, Is.EqualTo(multiplicationTestExpected));
    }
    [Test]
    public void DivisionTest()
    {
        const int divisionTestExpected = 2;
        var divisionTestResult = Model.Division(4, 2);
        Console.WriteLine(divisionTestResult);
        Assert.That(divisionTestResult, Is.EqualTo(divisionTestExpected));
    }

}