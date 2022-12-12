using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_1_classes
{
    //внутри класса находятся функции которые создают объект метода Result и возаращают этот объект в Actions
    public static class Actions
    {
        public static Result ErrorAction()
        {
            Result result = new Result();
            result.Status = "error";
            result.Message = "OOOps... ERROR 404!";
            result.DateTime = DateTime.UtcNow;
            return result;
        }

        public static Result InfoAction()
        {
            Result result = new Result();
            result.Status = "info";
            result.Message = "Read this info please! It may be helpful!";
            result.DateTime = DateTime.UtcNow;
            return result;
        }

        public static Result WarningAction()
        {
            Result result = new Result();
            result.Status = "warning";
            result.Message = "Pay attencion! Your code can work wrong!";
            result.DateTime = DateTime.UtcNow;
            return result;
        }
    }
}
