public interface ITask{
    Task? GetTask(int id);
    void StoreTask(string task_name);
    void PrintAllTasks();
    void DeleteTask(int id);
}