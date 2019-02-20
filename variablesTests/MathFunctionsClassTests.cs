using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFunctions.Tests
{
    [TestClass()]
    public class MathFunctionsClassTests
    {
        MathFunctionsClass objectUnderTest = new MathFunctionsClass();

        [TestMethod]
        public void CubeTest()
        {
            Assert.AreEqual(8, objectUnderTest.Square(2));
            Assert.AreEqual(1, objectUnderTest.Square(1));
            Assert.AreEqual(125, objectUnderTest.Square(5));
            
            
        }

       
    }
}