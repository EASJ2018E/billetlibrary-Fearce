using System;
using BilletLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilletLibraryTests
{
    [TestClass]
    public class BilTests
    {
        /// <summary>
        /// Test pris p� Bil
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
        /// Test type p� Bil
        /// </summary>
        [TestMethod]
        public void BilK�ret�jTest()
        {
            //Arrange
            Bil bil = new Bil();
            //Act
            string k�ret�j = "Bil";
            //Assert
            Assert.AreEqual(bil.K�ret�jType(), k�ret�j);
        }

        /// <summary>
        /// Test for at sikre sig at nummerpladen maks kan v�re 7 tegn
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
