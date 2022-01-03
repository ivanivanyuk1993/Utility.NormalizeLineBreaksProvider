using Microsoft.VisualStudio.TestTools.UnitTesting;
using NormalizeLineBreaksProviderNS;

namespace NormalizeLineBreaksProviderTestNS;

[TestClass]
public class NormalizeLineBreaksProviderTest
{
    [TestMethod]
    public void TestMethod1()
    {
        const string stringToNormalize = "\r\n\r\n\r\n\n\n\n\r\r\r\r\n";
        var normalizedString = stringToNormalize.NormalizeLineBreaks();

        Assert.AreEqual(
            actual: normalizedString,
            expected: "\n\n\n\n\n\n\n\n\n\n"
        );
    }
}