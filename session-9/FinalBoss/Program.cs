var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();



app.Run();

Task t1 = new Task(1, "Do my homework", "Important");
Task t2 = new Task(2, "Watch Real Madrid vs Barcelone", "Important");
Task t3 = new Task(3, "Go to drink coffee", "Important");

TodoStore s = new TodoStore();
s.AddTask(t1);
s.AddTask(t2);
s.AddTask(t3);


s.PrintAllTasks();
s.DeleteTask(1);
s.PrintAllTasks();
