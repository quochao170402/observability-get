namespace TestMonitoring;

public class Register
{
    public string Name { get; set; }
}

public static class Add
{
    public static void Adddd(string name)
    {
        var register = new Register();
        register.Name = name;
        Console.WriteLine("asdfasdfasdfasdfasdf"+name);
    }
}