using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DateTimeChartRangeClient {

    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();

            // Assign a date-time chart client to the Range control. 
            rangeControl1.Client = dateTimeChartRangeControlClient1;

            // Generate a data table and bind the date-time client to it.
            dateTimeChartRangeControlClient1.DataProvider.DataSource = CreateChartData(50, 2);

            // Specify data members to bind the client.
            dateTimeChartRangeControlClient1.DataProvider.ArgumentDataMember = "Argument";
            dateTimeChartRangeControlClient1.DataProvider.ValueDataMember = "Value";
            dateTimeChartRangeControlClient1.DataProvider.SeriesDataMember = "Series";

            // Specify the chart range control client view.       
            AreaChartRangeControlClientView areaView = new AreaChartRangeControlClientView();
            dateTimeChartRangeControlClient1.DataProvider.TemplateView = areaView;

            // Customize the area view appearance. 
            areaView.AreaOpacity = 90;
            areaView.Color = Color.Aqua;
            areaView.ShowMarkers = true;
            areaView.MarkerSize = 5;
            areaView.MarkerColor = Color.Red;

            // Format labels of the date-time chart range control client. 
            dateTimeChartRangeControlClient1.GridOptions.LabelFormat = "D";

            // Specify the palette name to get a nice-looking chart.
            dateTimeChartRangeControlClient1.PaletteName = "Office";

            // Customize grid alignment, grid spacing, snap spacing and snap alignment of the chart range control client.
            dateTimeChartRangeControlClient1.GridOptions.GridAlignment = RangeControlDateTimeGridAlignment.Day;
            dateTimeChartRangeControlClient1.GridOptions.GridSpacing = 1;
            dateTimeChartRangeControlClient1.GridOptions.SnapSpacing = 1;
            dateTimeChartRangeControlClient1.GridOptions.SnapAlignment = RangeControlDateTimeGridAlignment.Week;

            // Change the date-time range of the chart range control client.
            dateTimeChartRangeControlClient1.Range.Min = DateTime.Now;
            dateTimeChartRangeControlClient1.Range.Max = DateTime.Now.AddDays(50);
        }

        private DataTable CreateChartData(int pointCount, int seriesCount) {

            // Create an empty table.
            DataTable table = new DataTable("Table1");

            // Add three columns to the table.
            table.Columns.Add("Argument", typeof(DateTime));
            table.Columns.Add("Value", typeof(Double));
            table.Columns.Add("Series", typeof(string));

            // Add data rows to the table.
            Random rand = new Random((int)DateTime.Now.Ticks);
            DataRow row = null;
            double value = 0;

            for (int seriesIndex = 0; seriesIndex < seriesCount; seriesIndex++) {
                for (int pointIndex = 0; pointIndex < pointCount; pointIndex++) {
                    value += (rand.NextDouble() - 0.3);
                    row = table.NewRow();
                    row["Argument"] = DateTime.Now.Date.AddDays(pointIndex);
                    row["Value"] = Math.Sin(pointIndex) + value;
                    row["Series"] = seriesIndex.ToString();
                    table.Rows.Add(row);
                }
            }
            return table;
        }
    }
}

