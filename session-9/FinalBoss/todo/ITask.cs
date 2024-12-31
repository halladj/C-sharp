interface ITask {
    int ID {get; set;}
    string? TaskName {get; set;}
    bool IsCompleted{get; set;}
    string? ImportanceOfTask{get; set;}
    // void MarkAsCompleted(int id); 
}