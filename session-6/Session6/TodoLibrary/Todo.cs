public class TodoList : ITask
{

    private List<Task> tasks{get; set;} 
    public TodoList(){
        tasks = new List<Task>();
    }
    public void DeleteTask(int id)
    {
        var r = tasks.Find(e => e.ID == id-1);
        if (r != null){
            tasks.Remove(r);
        }
    }

    public Task? GetTask(int id)
    {
        return tasks.Find(e => e.ID == id-1);
    }

    public void PrintAllTasks()
    {
        tasks.ForEach(e => Console.Write($"[ ID:{e.ID}, Task:{e.TaskName} ]\n"));
        Console.WriteLine("");
    }

    
    public void StoreTask(string task_name)
    {
        tasks.Add(new Task{
            ID = tasks.Count, 
            TaskName = task_name
            }
        );
    }
}

public record Task{
    internal int ID {get; set;}
    internal string? TaskName {get; set;}
}