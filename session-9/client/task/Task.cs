class Task : ITask
{
    public int ID { get; set; }
    public string? TaskName { get; set; }
    public bool IsCompleted { get; set; } = false;
    public string? ImportanceOfTask { get; set;}

    public Task(){}

    public Task(int id, string name, string importance){
        ID = id;
        TaskName= name;
        IsCompleted = false;
        ImportanceOfTask= importance;
    }

    public void MarkAsCompleted(int id)
    {
        IsCompleted = true;
    }

    override
    public string ToString(){
        return $"""[ "ID":"{ID}", "TaskName":"{TaskName}", "IsCompleted":"{IsCompleted}", "Imporatance":"{ImportanceOfTask}" ]""";
    }
}