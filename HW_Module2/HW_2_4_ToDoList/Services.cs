using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_4_ToDoList
{
    internal class Services
    {
        public static void StartWorkWithToDoList()
        {
            ToDoList toDoList = new ToDoList();
            string currentUserChoice;
            do
            {
                Console.WriteLine("\nWhat do you want?(add-item/add-reminder/add-reminder-rc/get all/delete/update/exit)");
                currentUserChoice = Console.ReadLine();
                switch (currentUserChoice)
                {
                    case "add-item":
                        toDoList.AddItem();
                        break;
                    case "add-reminder":
                        toDoList.AddReminder();
                        break;
                    case "add-reminder-rc":
                        toDoList.AddReminderRC();
                        break;
                    case "delete":
                        toDoList.DeleteToDo();
                        break;
                    case "get all":
                        toDoList.ShowToDoList();
                        break;
                    case "update":
                        toDoList.UpdateToDo();
                        break;
                    case "exit":
                        break;
                    default:
                        Console.WriteLine("ERROR:Invalid command inputed! Try again :)");
                        break;
                }
            } while (currentUserChoice != "exit");
        }
    }
}
