using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokemonApp.Models.Pokemon;

namespace PokemonTest
{
    [TestClass]
    public class PokemonStatFamilyTest
    {
        [TestMethod]
        public void TestStatFamily()
        {
            int hp = 11;
            int atk = 12, def = 14, spec_atk = 23, spec_def = 22, speed = 19;
            PokemonStatFamily normal_psf = new PokemonStatFamily(hp, atk, def, spec_atk, spec_def, speed);
            Console.WriteLine(normal_psf.ToString());
            Assert.AreEqual(normal_psf.Hp, hp);
            Assert.AreEqual(normal_psf.Atk, atk);
            Assert.AreEqual(normal_psf.Def, def);
            Assert.AreEqual(normal_psf.SpecAtk, spec_atk);
            Assert.AreEqual(normal_psf.SpecDef, spec_def);
            Assert.AreEqual(normal_psf.Speed, speed);
        }
    }
}
