using System;
using Core.Services.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebArchitecture.DAL.Tests
{
    [TestClass]
    public class AddTest
    {
        [TestMethod]
        public void AddReturnIntWhenProvidedWithTwoInts()
        {
            var mathematics = new MathematicsService();
            var ans = mathematics.Add(2, 4);
            Assert.IsTrue(ans == 6);
            Assert.Equals(ans,6); 
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void AddReturnsExceptionWhenProvidedWithaString()
        {
            var mathematics = new MathematicsService();
            var s = Int32.Parse("a");
            mathematics.Add(s, 2);
        }
    }
}
