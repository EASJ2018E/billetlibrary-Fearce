using System;
using BilletLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilletLibraryTests
{
    [TestClass]
    public class BilTests
    {
        /// <summary>
        /// Test pris på Bil
        /// </summary>
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


        /// <summary>
        /// Test type på Bil
        /// </summary>
        [TestMethod]
        public void BilKøretøjTest()
        {
            //Arrange
            Bil bil = new Bil();
            //Act
            string køretøj = "Bil";
            //Assert
            Assert.AreEqual(bil.KøretøjType(), køretøj);
        }

        /// <summary>
        /// Test for at sikre sig at nummerpladen maks kan være 7 tegn
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void BilNummerpladeTest()
        {
            //Arrange
            Bil bil = new Bil();
            //Act
            bil.Nummerplade = "12345678";
            //Assert
            Assert.Fail();
        }
    }
}
