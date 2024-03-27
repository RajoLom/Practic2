using Groups.Implementions;

namespace Students.Implementations;

public class TeacherEntity : PersonEntity
{
    public string saysomething(string word)
    {
        return word;
    }
    public string saysomething()
    {
        return "I'm teacher; i can teach";
    }
    public TeacherEntity()
    {
        this.name = "";
        this.role = "";
    }
    public TeacherEntity(string name)
    {
        this.name = name;
        this.role = "teacher";
    }
}