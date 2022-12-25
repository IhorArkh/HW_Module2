using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_4_ToDoList
{
    internal class Item : AbstractToDo
    {
        public override AbstractToDo CreateToDo() 
        {
            Item item = new Item();
            Console.WriteLine("Add text please:");
            item.Text = Console.ReadLine();
            return item;
        }

        public override void ShowToDo()
        {
            Console.WriteLine($"ID:{Id}  Text:{Text}");
        }
    }
}
