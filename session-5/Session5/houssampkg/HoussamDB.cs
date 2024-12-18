public class HoussamDB : IDatabase
{

    public bool IsConnected { get; set; }

    public void Connect()
    {
        Console.WriteLine("Connecting....");
        Thread.Sleep(500);
        IsConnected = true;
        Console.WriteLine("Connection Established");
    }

    public void DisConnect()
    {
        Console.WriteLine("Disconnecting....");
        Thread.Sleep(500);
        IsConnected = false;
        Console.WriteLine("Connection Abolished");
    }
}