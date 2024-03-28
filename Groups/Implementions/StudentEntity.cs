namespace Groups.Implementions;

public class StudentEntity : PersonEntity
{
    public string saysomething(string word)
    {
        return word;
    }
    public string saysomething()
    {
        return "I'm student; i can study";
    }
    public StudentEntity()
    {
        this.name = "";
        this.role = "";
    }
    public StudentEntity(string name)
    {
        this.name = name;
        this.role = "student";
    }
    public SubjectEntity studingsubject(string subjectname)
    {
        SubjectEntity subject = new SubjectEntity(subjectname);
        return subject;
    }
}