interface ITodo{
    List<ITask> Tasks{get; set;}

    void AddTask (ITask task);
    void DeleteTask(int id);
    ITask? GetTask(int id);

    void PrintAllTasks();
}