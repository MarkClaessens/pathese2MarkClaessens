using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using oim;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void add_getbioscoop()
        {
            Zoekers zoeker = new Zoekers();
            zoeker.addbioscoop("kaas","dikkelol","geen path");
            Bioscoop actual = zoeker.getbioscoop("kaas");
            Bioscoop expected = new Bioscoop("kaas","dikkelol","geen path");
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
        [TestMethod]
        public void add_getfilm()
        {
            Zoekers zoeker = new Zoekers();
            zoeker.addfilm(1, "dikkelol", "geen path", 100, "tom", "nl", "pad");
            Kijkfilm actual = zoeker.getfilm("dikkelol");
            Kijkfilm expected = new Kijkfilm(1, "dikkelol", "geen path", 100, "tom", "nl", "pad");
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
        [TestMethod]
        public void add_getgebruiker()
        {
            Zoekers zoeker = new Zoekers();
            zoeker.addgebruiker(1,"kaas","broodje","M","mark-claessens@hotmail.com","broodjekaas");
            Gebruiker actual = zoeker.login("mark-claessens@hotmail.com", "broodjekaas");
            Gebruiker expected = new Gebruiker(1, "kaas", "broodje", "M", "mark-claessens@hotmail.com", "broodjekaas");
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
    }
}
