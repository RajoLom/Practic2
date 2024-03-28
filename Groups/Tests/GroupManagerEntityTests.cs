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
    public class GroupManagerEntityTests
    {
        [TestMethod]
        public void groupmanager()
        {
            GroupManagerEntity entity = new GroupManagerEntity();
            //act
            entity.Creategroup("firstgroup");
            entity.setteachertogroup("TeacherNameTest", "firstgroup");
            entity.atudentmanipulationtogroup(true, "firstStudent", "firstgroup");
            entity.atudentmanipulationtogroup(true, "secondStudent", "firstgroup");
            entity.atudentmanipulationtogroup(false, "firstStudent", "firstgroup");
            //assert
            Assert.AreEqual(entity.scool[0].groupname, "firstgroup");
            Assert.AreEqual(entity.scool[0].teacher.name, "TeacherNameTest");
            Assert.AreEqual(entity.scool[0].students.Count, 1);
        }
    }
}
