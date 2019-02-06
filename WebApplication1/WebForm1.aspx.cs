using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Main_page : System.Web.UI.Page
    {
        private List<Train> fetchedTrains = new List<Train>();
        protected void Page_Load(object sender, EventArgs e)
        {
            StringWriter writer = new StringWriter();
            WebRequest myRequest = WebRequest.Create(@"https://rata.digitraffic.fi/api/v1/live-trains");
            WebResponse response = myRequest.GetResponse();
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();

            fetchedTrains = JsonConvert.DeserializeObject<List<Train>>(responseFromServer);

        }
        private List<Train> FilterTrainByCategory(string category, List<Train> originalList)
        {
            var result = new List<Train>();

            foreach (var train in originalList)
            {
                if (train.trainCategory.Equals(category))
                {
                    result.Add(train);
                }
            }

            return result;
        }
        private List<Train> FilterByRunningCurrently(List<Train> originalList)
        {
            var result = new List<Train>();

            foreach (var trainStatus in originalList)
            {
                if (trainStatus.runningCurrently)  
                {
                    result.Add(trainStatus);
                }
            }
            return result;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (fetchedTrains.Count < 1) return;

            var desireCategory = "Long-distance";
            var longDistanceTrains = FilterTrainByCategory(desireCategory, fetchedTrains);
            var longDistanceRunningTrains = FilterByRunningCurrently(longDistanceTrains);
            var resultString = "";

            resultString = Helper.PrintTrains(longDistanceRunningTrains);
            // Pass data to session
            Session[SessionKeys.longDistanceRunningTrains] = longDistanceRunningTrains;

            Response.Redirect("WebForm2.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (fetchedTrains.Count < 1) return;

            var desireCategory = "Commuter";
            var longDistanceTrains = FilterTrainByCategory(desireCategory, fetchedTrains);
            var longDistanceRunningTrains = FilterByRunningCurrently(longDistanceTrains);
            var resultString = "";

            resultString = Helper.PrintTrains(longDistanceRunningTrains);
            Session[SessionKeys.longDistanceRunningTrains] = longDistanceRunningTrains;

            Response.Redirect("WebForm2.aspx");
            
        }
    }
}