using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DailyReport
    {
        public DateTime Date { get; set; }
        public int DatVe { get; set; } 
        public int DaHuy { get; set; }       
        public int DaThanhToan { get; set; }
    }
}
