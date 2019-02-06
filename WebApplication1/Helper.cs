using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Helper
    {
        public static string PrintTrains(List<Train> seekList)
        {
            string resultTrains = "";
            foreach (var train in seekList)
            {
                //trainNumberList.Add(train.trainNumber);
                resultTrains += $"Train number: {train.trainNumber}, train category: {train.trainCategory}, " +
                    $"IsRunning: {train.runningCurrently} " + "<br>";
            }
            return resultTrains;
        }
        public static string PrintOneTrainInfo(List<Train> seekList)
        {
            string resultTrainInfo = "";
            foreach (var train in seekList)
            {

                //trainNumberList.Add(train.trainNumber);
                resultTrainInfo += $"Train number: {train.trainNumber}" + "<br>"
                    + $"Train category: {train.trainCategory} " + "<br>"
                    + $"Train type: {train.trainType}" + "<br>" + $"Train operation: {train.operatorShortCode} <br>"
                     + $"Departure date: {train.departureDate} <br> <br><br>";
            }
            return resultTrainInfo;
        }
        public static string PrintScheduleInfo(List<Train> seekList, List<TimeTable> timeTable)
        {
            DateTime currentTime = System.DateTime.Now;

            string resultTrainInfo = "";
            foreach (var train in seekList)
            {
                foreach (var schedule in train.timeTableRows)
                {
                    if (schedule.type == "DEPARTURE")
                    {
                        resultTrainInfo += $"Schedule time: {schedule.scheduledTime} <br>";
                    }

                }
                //trainNumberList.Add(train.trainNumber);

            }
            return resultTrainInfo;
        }
    }
}