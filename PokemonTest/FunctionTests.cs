using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PokemonTest
{
    [TestClass]
    public class FunctionTests
    {
        [TestMethod]
        public void TestOneOrGreater()
        {
            int negativeTestValue = PokemonApp.Functions.Validate.OneOrGreater(-2);
            Assert.AreEqual(1, negativeTestValue);

            int positveTestValue = PokemonApp.Functions.Validate.OneOrGreater(23);
            Assert.AreEqual(23, positveTestValue);
        }
    }
}
