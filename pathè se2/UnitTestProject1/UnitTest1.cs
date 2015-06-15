using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using pathese2.dll; 
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void addfilm(int id, string FILMNAAM, string GENRE, int DUUR, string REGISSEUR, string TAAL, string LINK)
        {
            onderdeel film = new Kijkfilm(id, FILMNAAM, GENRE, DUUR, REGISSEUR, TAAL, LINK);
            onderdelen.Add(film);
        }
    }
}
