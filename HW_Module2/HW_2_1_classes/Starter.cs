using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_1_classes
{
    public static class Starter
    {
        public static void Run(Logger logger) // метод в котором рандомно вызываются методы класса Actions, а объекты типа Result которые они возвращают записываются в логгер(массив)
        {
            for (int i = 0; i < 20; i++)
            {
                Result result = new();
                Random random = new Random();
                int randomNumbers = random.Next(1, 4);
                switch (randomNumbers)
                {
                    case 1:
                        result = Actions.ErrorAction();
                        break;
                    case 2:
                        result = Actions.WarningAction();
                        break;
                    case 3:
                        result = Actions.InfoAction();
                        break;
                }

                logger.AddLog(result);
            }
        }
    }
}
