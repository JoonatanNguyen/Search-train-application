using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class TimeTable
    {
        public string stationShortCode { get; set; }
        public int stationUICCode { get; set; }
        public string countryCode { get; set; }
        public string type { get; set; }
        public bool trainStopping { get; set; }
        public bool commercialStop { get; set; }
        public string commercialTrack { get; set; }
        public bool cancelled { get; set; }
        public DateTime scheduledTime { get; set; }
        public DateTime actualTime { get; set; }
        public int differenceInMinutes { get; set; }
        public List<object> causes { get; set; }
        public TrainReady trainReady { get; set; }
        public DateTime? liveEstimateTime { get; set; }
    }
}