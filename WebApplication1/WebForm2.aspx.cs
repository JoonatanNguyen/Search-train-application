using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class train_list : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            //Response.Write(Session[SessionKeys.longDistanceRunningTrains]);

            var longDistanceRunningTrains = (List<Train>)Session[SessionKeys.longDistanceRunningTrains];
            var trainNumberList = GetTrainNumberList(longDistanceRunningTrains);
           

            numberList.DataSource = trainNumberList;
            numberList.DataTextField = "Value";
            numberList.DataValueField = "Key";
            numberList.DataBind();
        }
        private Dictionary<int, int> GetTrainNumberList(List<Train> longDistanceRunningTrains)
        {
            var trainNumberList = new Dictionary<int, int>();

            foreach (var train in longDistanceRunningTrains)
            {
                trainNumberList.Add(train.trainNumber, train.trainNumber);
            }
            
            return trainNumberList;
        }

        protected void numberList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Response.Write(sender);
            //Response.Write(e);
            var longDistanceRunningTrains = (List<Train>)Session[SessionKeys.longDistanceRunningTrains];
            /*
            foreach (var train in longDistanceRunningTrains)
            {
                if (train.trainNumber == int.Parse(numberList.SelectedValue))
                {
                    //Response.Write(Helper.PrintOneTrainInfo(new List<Train> { train } ));
                    scheduleTrain.InnerHtml = Helper.PrintOneTrainInfo(new List<Train> { train });
                    break;
                }
            }*/
            foreach (var train in longDistanceRunningTrains)
            {
                foreach (var schedule in train.timeTableRows)
                {
                    if (train.trainNumber == int.Parse(numberList.SelectedValue))
                    {
                        Response.Write(Helper.PrintScheduleInfo(new List<Train> { train }, new List<TimeTable> { schedule }));
                        Session[SessionKeys.selectedTrain] = train;
                        Response.Redirect("WebForm3.aspx");
                        break;
                    }
                }
            }
        }
    }
}