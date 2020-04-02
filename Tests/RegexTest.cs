using BlazorMaskedFields;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class RegexTest
    {
        [TestMethod]
        public void InputChassiTest()
        {
            InputChassiBase input = new InputChassiBase();
            var masked1 = input.ApplyMask("9XXX");

            Assert.AreEqual("9XX.X", masked1);


            var masked2 = input.ApplyMask("9XX.XX99X99");

            Assert.AreEqual("9XX.XX99X9.9", masked2);


            var masked3 = input.ApplyMask("9XX.XX99X9.9X9");

            Assert.AreEqual("9XX.XX99X9.9X.9", masked3);

            var masked4 = input.ApplyMask("9XX.XX99X9.9X.999999");

            Assert.AreEqual("9XX.XX99X9.9X.999999", masked4);

        }
    }
}
