using Groups.Implementions;
using Students.Implementations;

namespace Groups.Implementions;

public class GroupEntity
{
    public string groupname;
    public TeacherEntity teacher;
    public List<StudentEntity> students;
    public GroupEntity() { }
    public void setgroupname(string groupname)
    {
        this.groupname = groupname;
    }

    public void setteacher(TeacherEntity teacher)
    {
        this.teacher = teacher;  
    }
    public void addstudent(StudentEntity student)
    {
        students.Add(student);
    }
    public bool removestudent(string name)
    {
        for(int i = 0; i < students.Count; i++) 
        {
            if (students[i].name == name)
            {
                students.RemoveAt(i);
                return true;
            }

        }
        return false;
    }
}