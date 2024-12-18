// Football player register.

// 1- Syntax.
// using System.Net.NetworkInformation;

// Console.Write("Whats ur possition: ");
// string? position = Console.ReadLine();

// switch (position)
// {
//     case "GK":
//         Console.WriteLine("New GoalKeeper have been registered.");
//         break;
//     case "CB":
//         Console.WriteLine("New CenterBack have been registered.");
//         break;
//     case "LB":
//         Console.WriteLine("New LeftBack have been registered.");
//         break;
//     case "RB":
//         Console.WriteLine("New RightBack have been registered.");
//         break;       
//     case "MD":
//         Console.WriteLine("New Midfielder have been registered.");
//         break;
//     case "ST":
//         Console.WriteLine("New Stricker have been registered.");
//         break;
//     default:
//         Console.WriteLine("This is not a real football possition");
//         break;
// }


// // 2- Syntax
// Console.Write("Whats ur possition: ");
// position = Console.ReadLine();

// string FullPossition = position switch 
// {
//     "GK" => "GoalKeeper",
//     "CB" => "CenterBack",
//     "LB" => "LeftBack",
//     "RB" => "RightBack",
//     "CM" => "CenteralMiddfilder",
//     "ST" => "Striker",
//     _    => "",
// };

// Console.WriteLine($"Possition is {FullPossition}");

// ------------------------------------------------------------------------------
//| Create a BankAccount class, Fields: accountNumber, ownerName, Balance         |
//| make accountNumber Immutable, and the others mutable.                         |
//|                                                                               |
//| Create Multiple constuctors.                                                  |
//| create these following methods, GetBalance,                                   |
//| Deposite(decimal amount), withdraw(decimal amount)                            |
//-------------------------------------------------------------------------------



// public class BankAccount{

//     private long accountNumber {get;}
//     private string ownerName{get; set;}
//     private decimal balance{get; set;}
//     public BankAccount(long an, string on, decimal b){
//         accountNumber = an;
//         ownerName     = on;
//         balance       = b;
//     }

//     public BankAccount(long an, string ao ){
//         accountNumber  = an;
//         ownerName      = ao;
//         balance        = 0;
//     }

//     public decimal GetBalance(){
//         return balance;
//     }

//     public void Deposite(decimal amount){
//         if (amount <= 0){
//             throw new Exception("Cant not deposite nagative value.");
//         }
//         balance += amount;
//         Console.WriteLine($"Deposited: {amount}");
//     }

//     public void Withdraw(decimal amount){
//         if (amount <= 0){
//             throw new Exception("Cant not withdraw nagative value.");
//         }
//         if (balance < amount){
//             throw new Exception("Error: Cant not withdraw more than balance.");
//         }
//         balance -= amount;
//         Console.WriteLine($"Withdraw: {amount}");
//     }

// }



// public class BaseEmployee{
//     public string? FirstName {get; set;}
//     public string? LastName {get; set;}

//     public virtual string GetEmployeeDetails()
//     {
//         return $"{FirstName} {LastName}";
//     }
// }


// public class HourlyEmployee: BaseEmployee{
//     public decimal HourRate {get; set;}
//     public decimal CalculateMonthPay(int hourseWorked){
//         return HourRate * hourseWorked;
//     }

//     override
//    public string GetEmployeeDetails()
//     {
//         return $"{FirstName} {LastName}: Hour Rate {HourRate}";
//     } 

// }




// public abstract class Employee{
//     public string? LastName {get; set;}
//     public string? FirstName {get; set;}

//     // abstract method
//     public abstract decimal CalculateMonthPay();
//     // virtual methods.
//     public virtual string GetEmployeeDetails()
//     {
//         return $"{FirstName} {LastName}";
//     }
//     // sealed methods.
//     public sealed override string ToString()
//     {
//         return GetEmployeeDetails();
//     }
// }


// public class HourlyEmployee : Employee
// {
//     public decimal HourRate {get; set;}
//     public int HoursWorked {get; set;}
//     public override decimal CalculateMonthPay()
//     {
//         return HourRate * HoursWorked;
//     }
// }

// public class SalariEmployee : Employee
// {
//     public decimal Salary {get; set;}
//     public override decimal CalculateMonthPay()
//     {
//         return Salary/52;
//     }
// }



using System.Security.Cryptography;
using System.Text;

public class Program
{
    public static void Main(string[] args){
        var databaseConn = new HoussamDB();

        databaseConn.Connect();

        Console.WriteLine("Import Work in progress....");
            Thread.Sleep(1000);
        databaseConn.DisConnect();
    }

    // public static Point? OneStep (Point xy, int direction){

    //     // 0->forward, 1->right, 2-left, 3->backwards
    //     switch(direction){
    //         case 0:
    //             return new Point(xy.X, xy.Y+1);
    //         case 1:
    //             return new Point(xy.X+1, xy.Y);
    //         case 2:
    //             return new Point(xy.X-1, xy.Y);
    //         case 3:
    //             return new Point(xy.X, xy.Y-1);
    //         default:
    //         return null;
    //     }
    // }
}


// public struct Point 
// {
//     public int X {get; set;}
//     public int Y {get; set;}

//     public Point(int x, int y){
//         X =x;
//         Y =y;
//     }

//     public override bool Equals(object obj)
//     {
//         if (obj == null || GetType() != obj.GetType())
//         {
//             return false;
//         }
        
//         Point otherPoint = (Point)obj;
//         return X == otherPoint.X && Y == otherPoint.Y;
//     }
    
  
// }

// public record Person{
//     public string? Name{get; set;}
//     public int Age{get; set;}
//     public Person(){}

//     public Person(string name){
//         Name = name;
//         Age  = 0;
//     }
// }