using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

// Одиночка — это порождающий паттерн проектирования,
// который гарантирует, что у класса есть только один экземпляр,
// и предоставляет к нему глобальную точку доступа.

namespace HW_2_6_patterns
{
    public sealed class Singleton
    {
        private Singleton() { }

        private static Singleton _instance;

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Showing info");
        }

    }
}
