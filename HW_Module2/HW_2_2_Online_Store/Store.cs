using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_2_Online_Store
{
    public class Store
    {
        Item potato = new Item("1.Potato", 10.1);
        Item banana = new Item("2.Banana", 15.5);
        Item milk = new Item("3.Milk", 15.1);
        Item tea = new Item("4.Tea", 16.4);
        Item bread = new Item("5.Bread", 9.8);
        Item onion = new Item("6.Onion", 5.6);
        Item knife = new Item("7.Knife", 20.7);
        Item lighter = new Item("8.Lighter", 5);
        Item carrot = new Item("9.Carrot", 7.7);
        Item beetroot = new Item("10.Beetroot", 8.8);
        Item bounty = new Item("11.Bounty", 10.1);
        Item snickers = new Item("12.Snickers", 9.9);
        Item nuts = new Item("13.Nuts", 11);

        private Item[] items = new Item[13];
        
        public Item[] PrintListOfItems() //сделать чтобы метод принимал лист оф итемс который можно будет использовать и в аддтукард
        {
            items[0] = potato;
            items[1] = banana;
            items[2] = milk;
            items[3] = tea;
            items[4] = bread;
            items[5] = onion;
            items[6] = knife;
            items[7] = lighter;
            items[8] = carrot;
            items[9] = beetroot;
            items[10] = bounty;
            items[11] = snickers;
            items[12] = nuts;

            Console.WriteLine("Products available in our store:");
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine($"{items[i].NameOfItem} - {items[i].PriceOfItem}$");
            }
            return items;
        }

        public Item[] AddItemsToBasket(Item[] items)
        {
            Item[] basket = new Item[items.Length];
            Console.WriteLine("\nWrite number of product to add to basket. You cant order more then 10 items. When you finished - write 'Confirm order'");
            for (int i = 0; i < 10; i++)
            {
                string a = Console.ReadLine(); // ввод с консоли номера желемого товара 
                if(a == "Confirm order")
                {
                    Console.Clear();
                    break;
                }
                int b = Convert.ToInt32(a);
                if (b > items.Length||b < 1)
                {
                    Console.WriteLine("You entered wrong number of item! Be careful!");
                    i = i - 1;
                    continue;
                }
                basket[i] = items[b - 1];
            }
            return basket;
        }
        public void ShowBasket(Item[] basket)
        {
            Console.WriteLine("--------------------------\nNow in your basket:");
            double SumOfOrder = 0;
            for(int i = 0; i < basket.Length;i++)
            {
                if (basket[i] == null)
                {
                    continue;
                }
                Console.WriteLine($"{basket[i].NameOfItem} - {basket[i].PriceOfItem}$");
                SumOfOrder += basket[i].PriceOfItem;
            }
            Console.WriteLine($"--------------------------\nSum of your order: {SumOfOrder}$");
            Console.WriteLine("Do you want to order this?Yes/No");

                string option = Console.ReadLine();
                if (option == "Yes")
                {
                    GiveInvoice();
                }
                else if (option == "No")
                {
                    Console.WriteLine("Ok, see you later!");
                }
        }

        public void GiveInvoice()
        {
            Random rnd = new Random();
            int orderNumber = rnd.Next(100, 999);
            Console.Write($"\nThanks for your order! Number of your order is {orderNumber}");
        }
    }
}
