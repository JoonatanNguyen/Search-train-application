using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class ScheduleInfo
    {
        public string stationShortCode { get; set; }
        public string scheduledDate { get; set; }
        public string scheduledTime { get; set; }
        public string type { get; set; }
        public string actualTime { get; set; }
        public double differenceInMinutes { get; set; }
    }
}