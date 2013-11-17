using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SintegraIe;

namespace SintegraIe.Tests
{
    [TestClass]
    public class InscricaoEstadualTest
    {
        [TestMethod]
        public void ValidateReturnsFalseIfUFIsNull()
        {
            var isValid = InscricaoEstadual.Validate(null, "112388853119");

            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void ValidateReturnsFalseIfInscricaoEstadualIsNull()
        {
            var isValid = InscricaoEstadual.Validate("SP", null);

            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void ValidateReturnsFalseIfInscricaoEstadualIsSPAndInvalid()
        {
            var isValid = InscricaoEstadual.Validate("SP", "123456789");

            Assert.IsFalse(isValid);
        }
        
        [TestMethod]
        public void ValidateReturnsTrueIfInscricaoEstadualIsSPAndValid()
        {
            var isValid = InscricaoEstadual.Validate("SP", "112388853119");

            Assert.IsTrue(isValid);
        }        
    }
}
