using System;
using System.Security.Cryptography.X509Certificates;

namespace HW_2_2_Online_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            store.ShowBasket(store.AddItemsToBasket(store.PrintListOfItems()));
        }
    }
}