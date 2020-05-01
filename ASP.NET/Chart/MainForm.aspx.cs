using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.DataVisualization.Charting;
using System.Web.UI.WebControls;

namespace Chart
{
    public partial class MainForm : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            this.Chart1.Series.Clear();

            double[] xArray = { Double.Parse(x1.Text), Double.Parse(x2.Text), Double.Parse(x3.Text), Double.Parse(x4.Text), Double.Parse(x5.Text) };
            double[] yArray = { Double.Parse(y1.Text), Double.Parse(y2.Text), Double.Parse(y3.Text), Double.Parse(y4.Text), Double.Parse(y5.Text) };

            Series series = this.Chart1.Series.Add("Graph");
            series.ChartType = SeriesChartType.Spline;

            for (int i = 0; i < xArray.Length; i++)
            {
                series.Points.AddXY(xArray[i], yArray[i]);
            }
        }
    }
}