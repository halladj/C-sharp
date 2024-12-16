
public class Player{
    // Mutable Fields:
    public int NumberOfGoal   {get; set;}
    public int NumberOfYCards {get; set;}
    public int NumberOfRCards {get; set;}
    public int NumberOfPlayedMatches {get; set;}

    // Immutable Fields
    public string? FirstName {get;}
    public string? LastName {get;}
    public int BirthdayYear{get;}

    // Computed Fields:
    public string FullName  => $"{FirstName} {LastName}";
    public int TotallCards  => NumberOfYCards + NumberOfRCards;
    public int Age          => DateTime.Now.Year - BirthdayYear;

    // Constructor:

    public Player(string firstName, string lastName, int bdYear){
        FirstName = firstName;
        LastName  = lastName;
        BirthdayYear = bdYear;
    }

    // 1. Overload the constructor
}




public class Program
{
    
    private static void Main(string[] args)
    {
        var ronaldoInfo = new Player("cris", "Ronaldo", 1986){
            NumberOfGoal = 970, 
            NumberOfPlayedMatches= 1400, 
            NumberOfRCards=7, 
            NumberOfYCards=20,
        };

        Console.WriteLine($"""
        Number of goals   {ronaldoInfo.NumberOfGoal}
        Nof Played Games  {ronaldoInfo.NumberOfPlayedMatches}
        Number of y_cards {ronaldoInfo.NumberOfYCards}
        Number of r_cards {ronaldoInfo.NumberOfRCards}
        Totall Cards      {ronaldoInfo.NumberOfRCards}
        Full Name         {ronaldoInfo.FullName}
        Age               {ronaldoInfo.Age}
        BirdthDayYear     {ronaldoInfo.BirthdayYear}
        """);

    }
}


class Person{
    public int Age {get; set;} 
    public string? FirstName {get; set;}
    public string? LastName {get; set;}
    public string FullName => FirstName + " "+LastName; 
}
