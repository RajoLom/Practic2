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
    public class GroupEntityTests
    {
        [TestMethod]
        public void StudentEntitySaying()
        {
            GroupEntity entity = new GroupEntity();
            //act
            entity.setgroupname("TestName");
            TeacherEntity teacherEntity = new TeacherEntity("TeacherNameTest");
            entity.setteacher(teacherEntity);
            for (int i = 0; i < 5; i++) 
            {
                StudentEntity studentEntity = new StudentEntity("StudentNameTest" + i.ToString());
                entity.addstudent(studentEntity);
            }
            //assert
            Assert.AreEqual(entity.teacher.name, "TeacherNameTest");
            Assert.AreEqual(5, entity.students.Count);
            Assert.AreEqual(entity.groupname, "TestName");
        }
    }
}