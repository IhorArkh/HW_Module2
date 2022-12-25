using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_4_ToDoList
{
    internal class Reminder : Item
    {
        public override AbstractToDo CreateToDo()
        {
            Reminder reminder = new Reminder();
            Console.WriteLine("Add text please:");
            reminder.Text = Console.ReadLine();
            Console.WriteLine("Add reminder time:");
            reminder.Time = Console.ReadLine();
            return reminder;
        }

        public override void ShowToDo()
        {
            Console.WriteLine($"ID:{Id}, Text:{Text}, Remind:{Time}");
        }
    }
}
