﻿using System;
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
            AbstractToDo item = new Item();
            item = item.CreateToDo();
            item.Id = _counter + 1;
            _toDo[_counter] = item;
            _counter++;
        }

        public void AddReminder()
        {
            AbstractToDo reminder = new Reminder();
            reminder = reminder.CreateToDo();
            reminder.Id = _counter + 1;
            _toDo[_counter] = reminder;
            _counter++;
        }

        public void AddReminderRC()
        {
            AbstractToDo reminderRC = new ReminderRC();
            reminderRC = reminderRC.CreateToDo();
            reminderRC.Id = _counter + 1;
            _toDo[_counter] = reminderRC;
            _counter++;
        }
    }
}