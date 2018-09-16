using BilletLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilletLibraryTests
{
    [TestClass]
    public class MCTests
    {
        [TestMethod]
        public void MCPrisTest()
        {
            //Arrange
            MC mc = new MC();
            //Act
            decimal pris = 125;
            //Assert
            Assert.AreEqual(mc.Pris(), pris);
        }

        [TestMethod]
        public void MCKøretøjTest()
        {
            //Arrange
            MC mc = new MC();
            //Act
            string køretøj = "MC";
            //Assert
            Assert.AreEqual(mc.KøretøjType(), køretøj);
        }
    }
}
