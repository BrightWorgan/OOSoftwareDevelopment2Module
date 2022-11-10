using Parser_mini_project;

namespace ParserMiniTests
{
    [TestClass]
    public class ParserTest
    {
        [TestMethod]
        public void TestShouldBalance()
        {
            bool shouldBalance = Parsar.IsBalanced("(())");

            Assert.IsTrue(shouldBalance);
        }
        [TestMethod]
        public void TestShouldNotBalance()
        {
            bool shouldBalance = Parsar.IsBalanced("(()))");

            Assert.IsFalse(shouldBalance);
        }

        [TestMethod]
        public void TestOnlyCloseBracket()
        {
            int shouldBalance = Parsar.FindImbalance(")");
            Assert.AreEqual(shouldBalance, -1);
        }

        [TestMethod]
        public void TestNoCloseBracket()
        {
            int shouldBalance = Parsar.FindImbalance("()()");
            Assert.AreEqual(shouldBalance, -1);
        }

        [TestMethod]
        public void TestImbalBracket()
        {
            int shouldBalance = Parsar.FindImbalance("()(");
            Assert.AreEqual(shouldBalance, 2);
        }
    }
}