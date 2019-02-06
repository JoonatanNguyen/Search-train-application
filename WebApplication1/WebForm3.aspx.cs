using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var longDistanceRunningTrains = (List<Train>)Session[SessionKeys.longDistanceRunningTrains];
            var selectedTrain = (Train)Session[SessionKeys.selectedTrain];

            infomationTable.DataSource = GetTheTimeTable(selectedTrain);
            infomationTable.DataBind();
        }
        protected List<ScheduleInfo> GetTheTimeTable(Train selectedTrain)
        {
            if (selectedTrain == null)
                return new List<ScheduleInfo>();

            DateTime currentTime = DateTime.Now;
            var trainSchedule = new List<ScheduleInfo>();
            var longDistanceRunningTrains = (List<Train>)Session[SessionKeys.longDistanceRunningTrains];

            currentSearchTime.InnerHtml = Convert.ToString(currentTime);

            foreach (var train in longDistanceRunningTrains)
            {
                scheduleTrain.InnerHtml = Helper.PrintOneTrainInfo(new List<Train> { train });
                break;
            }
            foreach (var row in selectedTrain.timeTableRows)
            {
                ScheduleInfo scheduleInfo = new ScheduleInfo();
                scheduleInfo.scheduledDate = row.scheduledTime.ToString("dd/MM/yyyy");
                scheduleInfo.scheduledTime = row.scheduledTime.ToString("HH:mm:ss");
                scheduleInfo.stationShortCode = row.stationShortCode;
                scheduleInfo.type = row.type;
                scheduleInfo.actualTime = row.actualTime.ToString("HH:mm:ss");
                scheduleInfo.differenceInMinutes = row.differenceInMinutes;
                 
                trainSchedule.Add(scheduleInfo);
            }
            return trainSchedule;
        }
    }
}