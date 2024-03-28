using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Groups.Implementions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Students.Implementations;

namespace Groups.Tests
{
    [TestClass]
    public class TeacherEntityTests
    {
        [TestMethod]
        public void TeacherEntitySaying()
        {
            TeacherEntity entity = new TeacherEntity();
            //act
            string actual = entity.saysomething();
            //assert
            Assert.AreEqual("I'm teacher; i can teach", actual);
        }
    }
}