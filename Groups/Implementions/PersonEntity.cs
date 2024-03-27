namespace Groups.Implementions;

public class PersonEntity
{
    public string role;
    public string name;
    public string saysomething(string word)
    {
        return word;
    }
    public string saysomething()
    {
        return "null";
    }
    public PersonEntity()
    {
        this.name = "";
        this.role = "";
    }
    public PersonEntity(string name, string role)
    {
        this.name = name;
        this.role = role;
    }
    public void rename(string newname)
    {
        name = newname;
    }
}