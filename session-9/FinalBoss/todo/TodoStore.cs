using System.Text.Json;

class TodoStore : ITodo
{
    public List<ITask> Tasks { get; set; }
    private const string FILE_NAME = "TODOS_DB.json";

    public TodoStore(){

        Tasks = new List<ITask>();

        if (File.Exists(FILE_NAME))
        {
            var content = File.ReadAllLines(FILE_NAME);

            foreach (var item in content)
            {
                if(!string.IsNullOrWhiteSpace(item))
                {
                    var o = JsonSerializer.Deserialize<Task>(item);
                    if (o != null){
                        Tasks.Add((Task)o);
                    }
                }
            }
            Console.WriteLine("Tasks Loaded Succesfully....");
        }
        else
        {
            using (var file = File.Create(FILE_NAME))
            {
                file.Close();
                Console.WriteLine("Tasks Store Created Succesfully....");
            }
        }
    }

    public void AddTask(ITask task)
    {
        Tasks.Add(task);
        // TODO: Add it to the file. store()
        var s = JsonSerializer.Serialize<ITask>(task);
        File.AppendAllLines(FILE_NAME,[s]);
    }

    public void DeleteTask(int id)
    {
        var t = Tasks.Find(e => e.ID == id);
        if (t != null){

            Tasks.Remove(t);

            File.WriteAllText(FILE_NAME, "");
            foreach (var item in Tasks)
            {
                var temp = JsonSerializer.Serialize<ITask>(item);
                File.AppendAllLines(FILE_NAME, [temp]);
            }
        }
    }

    public ITask? GetTask(int id)
    {
        return Tasks.Find(e => e.ID == id);
    }


    public void PrintAllTasks()
    {
        Console.WriteLine("[");
        foreach (var item in Tasks)
        {
            Console.WriteLine("    "+item);
        }
        Console.WriteLine("]");
    }

}