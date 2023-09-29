using TaschenrechnerMitUi;

namespace TestsTaschenrechner;

[TestFixture]
public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void DisplayNumberTest()
    {
        int Expected = 1;
        int InputNumber = 1;
        int  Result = MainWindow.DisplayNumber(InputNumber);
        Assert.AreEqual(Expected, Result);
    }
}