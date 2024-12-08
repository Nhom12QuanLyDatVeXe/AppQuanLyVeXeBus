using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MonthlyReport
    {
        public int Month { get; set; }
        public int Year { get; set; }
        public int Count { get; set; }
        public int TotalSeats { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
