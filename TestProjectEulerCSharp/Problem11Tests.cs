using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerCSharp;

namespace TestProjectEulerCSharp
{
    [TestClass]
    public class Problem11Tests
    {
        [TestMethod]
        public void FindGreatestProductOfFourAdjacentNumbers()
        {
            var problem11 = new Problem11();

            int result = problem11.FindGreatestProductOfFourAdjacentNumbers();

            Assert.AreEqual(-1, result);
        }
    }
}
