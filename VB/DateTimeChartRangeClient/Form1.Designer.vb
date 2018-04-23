' Developer Express Code Central Example:
' How to bind a date-time chart range control client to a datasource and customize its common settings
' 
' This example demonstrates how to set up a range control with the date-time chart
' client to display a chart with date-time data in the range control's background.
' In order to provide data to a chart date-time range control client, you need to
' access the ChartRangeControlClientDataProvider object using the
' ChartRangeControlClientBase.DataProvider property and assign a data source to
' the ChartRangeControlClientDataProvider.DataSource property. Then specify the
' required data fields via the
' ChartRangeControlClientDataProvider.ArgumentDataMember,
' ChartRangeControlClientDataProvider.ValueDataMember, and
' ChartRangeControlClientDataProvider.SeriesDataMember (optional) properties. In
' the current example, a date-time chart client is bound to a simple data table
' containing three columns ("Argument", "Value", and "Series"). In addition, this
' example shows how to customize chart client common settings (e.g., change the
' date-time range, customize template view and grid options).
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=T125884

Namespace DateTimeChartRangeClient
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim rangeControlRange1 As New DevExpress.XtraEditors.RangeControlRange()
            Me.rangeControl1 = New DevExpress.XtraEditors.RangeControl()
            Me.dateTimeChartRangeControlClient1 = New DevExpress.XtraEditors.DateTimeChartRangeControlClient()
            DirectCast(Me.rangeControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.dateTimeChartRangeControlClient1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' rangeControl1
            ' 
            Me.rangeControl1.Client = Me.dateTimeChartRangeControlClient1
            Me.rangeControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.rangeControl1.Location = New System.Drawing.Point(0, 0)
            Me.rangeControl1.Name = "rangeControl1"

            rangeControlRange1.Owner = Me.rangeControl1
            Me.rangeControl1.SelectedRange = rangeControlRange1
            Me.rangeControl1.Size = New System.Drawing.Size(705, 198)
            Me.rangeControl1.TabIndex = 0
            Me.rangeControl1.Text = "rangeControl1"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(705, 198)
            Me.Controls.Add(Me.rangeControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.rangeControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.dateTimeChartRangeControlClient1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private rangeControl1 As DevExpress.XtraEditors.RangeControl
        Private dateTimeChartRangeControlClient1 As DevExpress.XtraEditors.DateTimeChartRangeControlClient
    End Class
End Namespace

