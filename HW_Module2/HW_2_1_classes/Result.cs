using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_1_classes
{
    // структура объекты которой будут записываться в логер 
    public struct Result
    {
        public string Status { get; set; }

        public string Message { get; set; }

        public DateTime DateTime { get; set; }
    }
}
