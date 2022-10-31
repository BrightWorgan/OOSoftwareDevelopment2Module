using Exercise_3;

namespace Exercise3UnitTests
{
    [TestClass]
    public class TestFavourite
    {
        [TestMethod]
        public void TestValidConstructor()
        {
            Favourite fav = new Favourite("Google", "https://google.com");

            Assert.AreEqual(fav.UrlName, "Google");
        }

        private void LetMeThrowException()
        {
            new Favourite("Google", "google.com");
        }

        [TestMethod]
        public void TestInvalidURL()
        {
            Assert.ThrowsException<UriFormatException>(LetMeThrowException);
        }

        [TestMethod]
        public void TestToString()
        {
            Favourite fav = new Favourite("Google", "https://google.com");
            string str = fav.ToString();
            Assert.IsTrue(str.Contains("Google"));
            Assert.IsTrue(str.Contains("https://google.com"));
        }
        [TestMethod]
        public void TestCanHandleUTFEncoding()
        {
            Favourite fav = new Favourite("🙏", "https://google.com");
            Assert.AreEqual("🙏", fav.UrlName);
        }
    }
}