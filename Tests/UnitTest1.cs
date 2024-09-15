using Library;

namespace Tests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestAdd()
    {
        const int a = 1;
        const int b = 2;
        const int expected = 3;

        var actual = Class1.Add(a, b);

        Assert.AreEqual(expected, actual);
    }
}
