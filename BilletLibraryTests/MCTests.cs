using System;
using BilletLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilletLibraryTests
{
    [TestClass]
    public class MCTests
    {
        /// <summary>
        /// Test pris på MC
        /// </summary>
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

        /// <summary>
        /// Test type på MC
        /// </summary>
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

        /// <summary>
        /// Test for at sikre sig at nummerpladen maks kan være 7 tegn
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void MCNummerpladeTest()
        {
            //Arrange
            MC mc = new MC();
            //Act
            mc.Nummerplade = "12345678";
            //Assert
            Assert.Fail();
        }
    }
}
