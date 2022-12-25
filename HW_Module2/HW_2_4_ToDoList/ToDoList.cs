using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_4_ToDoList
{
    internal class ToDoList
    {
        private AbstractToDo[] _toDo = new AbstractToDo[5];
        private int _counter = 0;

        public void AddItem()
        {
            if (_counter == _toDo.Length)
            {
                Console.WriteLine($"ERROR: You cant add more than {_toDo.Length} ToDos!");
            }
            else
            {
                AbstractToDo item = new Item();
                item = item.CreateToDo();
                item.Id = _counter + 1;
                _toDo[_counter] = item;
                _counter++;
            }
        }

        public void AddReminder()
        {
            if (_counter == _toDo.Length)
            {
                Console.WriteLine($"ERROR: You cant add more than {_toDo.Length} ToDos!");
            }
            else
            {
                AbstractToDo reminder = new Reminder();
                reminder = reminder.CreateToDo();
                reminder.Id = _counter + 1;
                _toDo[_counter] = reminder;
                _counter++;
            }
            
        }

        public void AddReminderRC()
        {
            if (_counter == _toDo.Length)
            {
                Console.WriteLine($"ERROR: You cant add more than {_toDo.Length} ToDos!");
            }
            else
            {
                AbstractToDo reminderRC = new ReminderRC();
                reminderRC = reminderRC.CreateToDo();
                reminderRC.Id = _counter + 1;
                _toDo[_counter] = reminderRC;
                _counter++;
            }
            
        }

        public void ShowToDoList()
        {
            for (int i = 0; i < _toDo.Length; i++)
            {
                if (_toDo[i] == null)
                {
                    continue;
                }
                _toDo[i].ShowToDo();
            }
        }

        public void DeleteToDo()
        {
            Console.WriteLine("Write Id of ToDo you want to delete:");
            int numOfToDo = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < _toDo.Length; i++)
            {
                if (_toDo[i].Id == numOfToDo)
                {
                    _toDo[i] = null;
                }
            }
        }

        public void UpdateToDo()
        {
            Console.WriteLine("Write Id of ToDo you want to update:");
            int numOfToDo = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < _toDo.Length; i++)
            {
                if (_toDo[i].Id == numOfToDo)
                {
                    _toDo[i] = _toDo[i].CreateToDo();
                    _toDo[i].Id = i + 1;
                    break;
                }
            }
        }

        
    }
}
