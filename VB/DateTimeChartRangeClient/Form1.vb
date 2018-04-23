Imports System
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace DateTimeChartRangeClient

    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()

            ' Assign a date-time chart client to the Range control. 
            rangeControl1.Client = dateTimeChartRangeControlClient1

            ' Generate a data table and bind the date-time client to it.
            dateTimeChartRangeControlClient1.DataProvider.DataSource = CreateChartData(50, 2)

            ' Specify data members to bind the client.
            dateTimeChartRangeControlClient1.DataProvider.ArgumentDataMember = "Argument"
            dateTimeChartRangeControlClient1.DataProvider.ValueDataMember = "Value"
            dateTimeChartRangeControlClient1.DataProvider.SeriesDataMember = "Series"

            ' Specify the chart range control client view.       
            Dim areaView As New AreaChartRangeControlClientView()
            dateTimeChartRangeControlClient1.DataProvider.TemplateView = areaView

            ' Customize the area view appearance. 
            areaView.AreaOpacity = 90
            areaView.Color = Color.Aqua
            areaView.ShowMarkers = True
            areaView.MarkerSize = 5
            areaView.MarkerColor = Color.Red

            ' Format labels of the date-time chart range control client. 
            dateTimeChartRangeControlClient1.GridOptions.LabelFormat = "D"

            ' Specify the palette name to get a nice-looking chart.
            dateTimeChartRangeControlClient1.PaletteName = "Office"

            ' Customize grid alignment, grid spacing, snap spacing and snap alignment of the chart range control client.
            dateTimeChartRangeControlClient1.GridOptions.GridAlignment = RangeControlDateTimeGridAlignment.Day
            dateTimeChartRangeControlClient1.GridOptions.GridSpacing = 1
            dateTimeChartRangeControlClient1.GridOptions.SnapSpacing = 1
            dateTimeChartRangeControlClient1.GridOptions.SnapAlignment = RangeControlDateTimeGridAlignment.Week

            ' Change the date-time range of the chart range control client.
            dateTimeChartRangeControlClient1.Range.Min = Date.Now
            dateTimeChartRangeControlClient1.Range.Max = Date.Now.AddDays(50)
        End Sub

        Private Function CreateChartData(ByVal pointCount As Integer, ByVal seriesCount As Integer) As DataTable

            ' Create an empty table.
            Dim table As New DataTable("Table1")

            ' Add three columns to the table.
            table.Columns.Add("Argument", GetType(Date))
            table.Columns.Add("Value", GetType(Double))
            table.Columns.Add("Series", GetType(String))

            ' Add data rows to the table.
            Dim rand As New Random(CInt(Date.Now.Ticks))
            Dim row As DataRow = Nothing
            Dim value As Double = 0

            For seriesIndex As Integer = 0 To seriesCount - 1
                For pointIndex As Integer = 0 To pointCount - 1
                    value += (rand.NextDouble() - 0.3)
                    row = table.NewRow()
                    row("Argument") = Date.Now.Date.AddDays(pointIndex)
                    row("Value") = Math.Sin(pointIndex) + value
                    row("Series") = seriesIndex.ToString()
                    table.Rows.Add(row)
                Next pointIndex
            Next seriesIndex
            Return table
        End Function
    End Class
End Namespace

