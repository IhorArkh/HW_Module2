using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_4_ToDoList
{
    public abstract class AbstractToDo
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Time { get; set; }
        public string Repeat { get; set; }

        public abstract AbstractToDo CreateToDo();
        public abstract void ShowToDo();
    }
}
