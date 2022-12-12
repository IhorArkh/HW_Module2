using System.Net.NetworkInformation;
using System.Text;

namespace HW_2_1_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger logs = new Logger();
            Console.WriteLine("Enter please which logs you want to see: error, warning or info");
            logs.LogLevel = Console.ReadLine(); // значение введенное с консоли присваиваем logs объекту класса Logger, который необходим для Starter.Run();

            Starter.Run(logs);

            logs.PrintLog();
        }
    }
}