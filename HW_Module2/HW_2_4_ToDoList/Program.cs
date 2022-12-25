namespace HW_2_4_ToDoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ToDoList toDoList = new ToDoList();
            toDoList.AddReminderRC();
            toDoList.AddItem();
            toDoList.AddItem();
            toDoList.ShowToDoList();
            toDoList.DeleteToDo();
            toDoList.ShowToDoList();
        }
    }
}