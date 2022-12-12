using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_1_classes
{
    public class Logger
    {
        public Result[] _logs = new Result[20];
        private int _counter = 0;

        public string LogLevel { get; set; }

        public void AddLog(Result log) // метод для добавления логов в логгер
        {
            _logs[_counter] = log;
            _counter++;
        }

        public void PrintLog() // метод который выводит логи в консоль
        {
            for (int i = 0; i < _logs.Length; i++)
            {
                if (_logs[i].Status == LogLevel)
                {
                    Console.WriteLine($"{_logs[i].DateTime} --- {_logs[i].Status} --- {_logs[i].Message}");
                }
            }
        }
    }
}
