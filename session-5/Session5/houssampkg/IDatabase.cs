public interface IDatabase{
    void Connect();
    void DisConnect();
    public bool IsConnected {get; set;}
}