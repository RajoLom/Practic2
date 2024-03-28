using Students.Implementations;
using System.Xml.Linq;

namespace Groups.Implementions;

public class GroupManagerEntity
{
    public List<GroupEntity> scool;
    public void Creategroup(string name)
    {
        GroupEntity group = new GroupEntity();
        group.setgroupname(name);
        scool.Add(group);
    }
    public bool setteachertogroup(string teachername, string groupname)
    {
        for (int i = 0; i < scool.Count; i++)
        {
            if (scool[i].groupname == groupname)
            {
                TeacherEntity teacher = new TeacherEntity(teachername);
                scool[i].setteacher(teacher);
                return true;
            }

        }
        return false;
    }
    public bool atudentmanipulationtogroup(bool status, string studentname, string groupname)
    {
        for (int i = 0; i < scool.Count; i++)
        {
            if (scool[i].groupname == groupname)
            {
                if(status == true)
                {
                    StudentEntity student = new StudentEntity();
                    student.name = studentname;
                    scool[i].addstudent(student);
                    return true;
                }
                else
                {
                    for(int j = 0; j < scool[i].students.Count; j++)
                    {
                        if (scool[i].students[j].name == studentname)
                        {
                            scool[i].students.Remove(scool[i].students[j]);
                            return true;
                        }
                    }
                    return false;
                }
                
            }
            return false;
        }
        return false;
    }
}