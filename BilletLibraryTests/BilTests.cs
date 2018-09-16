using BilletLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilletLibraryTests
{
    [TestClass]
    public class BilTests
    {
        [TestMethod]
        public void BilPrisTest()
        {
            //Arrange
            Bil bil = new Bil();
            //Act
            decimal pris = 240;
            //Assert
            Assert.AreEqual(bil.Pris(), pris);
        }

        [TestMethod]
        public void BilKøretøjTest()
        {
            //Arrange
            Bil bil = new Bil();
            //Act
            string køretøj = "Bil";
            //Assert
            Assert.AreEqual(bil.Køretøj(), køretøj);
        }
    }
}
