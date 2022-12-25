using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_4_ToDoList
{
    internal class ReminderRC : Reminder
    {
        public override AbstractToDo CreateToDo()
        {
            Reminder reminderRC = new ReminderRC();
            Console.WriteLine("Add text please:");
            reminderRC.Text = Console.ReadLine();
            Console.WriteLine("Add reminder time:");
            reminderRC.Time = Console.ReadLine();
            Console.WriteLine("Add repetition interval:");
            reminderRC.Repeat = Console.ReadLine();
            return reminderRC;
        }

        public override void ShowToDo()
        {
            Console.WriteLine($"ID:{Id}, Text:{Text}, Remind:{Time}, Repeat:{Repeat}");
        }
    }
}
