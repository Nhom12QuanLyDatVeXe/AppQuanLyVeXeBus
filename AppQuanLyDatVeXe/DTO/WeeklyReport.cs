using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class WeeklyReport
    {
        public int Week { get; set; }
        public int Count { get; set; }
        public int TotalSeats { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
