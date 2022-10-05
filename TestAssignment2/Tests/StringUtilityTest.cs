using TestAssignment2.Classes;

namespace TestAssignment2.Tests
{
    internal class StringUtilityTest
    {
        private StringUtility su;

        public StringUtilityTest()
        {
            su = new StringUtility();
        }

        [Test]
        public void ReverseStringTest()
        {
            string reversed = su.Reverse("abc");

            Assert.That(reversed == "cba");
        }

        [Test]
        public void UpperCaseTest()
        {
            string result = su.ToUpperCase("abc");

            Assert.That(result == "ABC");
        }

        [Test]
        public void LowerCaseTest()
        {
            string result = su.ToLowerCase("ABC");

            Assert.That(result == "abc");
        }
    }
}