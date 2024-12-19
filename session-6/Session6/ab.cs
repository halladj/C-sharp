public abstract class Human{
    public string? Name {get; set;}
    public int Age {get ;set;}

    public abstract string SayMyName();
}


public class Player : Human
{
    public override string SayMyName()
    {
        return $"My name is {Name} and im a player";
    }
}


public class Employee : Human
{
    public override string SayMyName()
    {
        return $"My name is {Name} and im a Employee";
    }
}