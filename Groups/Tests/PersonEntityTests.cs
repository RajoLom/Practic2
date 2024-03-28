using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Groups.Implementions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Groups.Tests
{
    [TestClass]
    public class PersonEntityTests
    {
        [TestMethod]
        public void PersonEntitySaying() 
        {
            PersonEntity entity = new PersonEntity();
            //act
            string actual = entity.saysomething("abc");
            //assert
            Assert.AreEqual("abc", actual);

        }

    }
}
