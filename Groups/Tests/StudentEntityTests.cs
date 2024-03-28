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
    public class StudentEntityTests
    {
        [TestMethod]
        public void StudentEntitySaying()
        {
            StudentEntity entity = new StudentEntity();
            //act
            string actual = entity.saysomething();
            //assert
            Assert.AreEqual("I'm student; i can study", actual);
        }
    }
}
