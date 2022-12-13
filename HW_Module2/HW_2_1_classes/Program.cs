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
            if (logs.LogLevel == "info" || logs.LogLevel == "error" || logs.LogLevel == "warning")
            {
                logs.PrintLog();
            }
            else
            {
                Console.WriteLine("Wrong type of message!\nYou can choose only from error, warning or info  messages");
            }

        }
    }
}