// public class Box<T> 
// {
//     private T _item;
    

//     public void SetItem(T items)
//     {
//         _item = items;
//     }

//     public T GetItem()
//     {
//         return _item;
//     }

// }

public class Program
{
    public static void Main(string[] Args){
        TodoList td = new TodoList();

        td.StoreTask("friday-praier");
        td.StoreTask("Eating Breakfast");
        td.PrintAllTasks();
        Console.WriteLine(td.GetTask(2).TaskName);
        td.DeleteTask(1);
        td.PrintAllTasks();
    }

    // public static void PrintList(List<int> l){
    //     Console.Write("[");
    //     l.ForEach(e => Console.Write($" {e} "));
    //     Console.Write("]");
    //     Console.WriteLine("");
    // }
}