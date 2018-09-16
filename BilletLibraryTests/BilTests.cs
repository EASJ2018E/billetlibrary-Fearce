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
        public void BilK�ret�jTest()
        {
            //Arrange
            Bil bil = new Bil();
            //Act
            string k�ret�j = "Bil";
            //Assert
            Assert.AreEqual(bil.K�ret�j(), k�ret�j);
        }
    }
}
