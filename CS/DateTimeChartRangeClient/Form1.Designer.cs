// Developer Express Code Central Example:
// How to bind a date-time chart range control client to a datasource and customize its common settings
// 
// This example demonstrates how to set up a range control with the date-time chart
// client to display a chart with date-time data in the range control's background.
// In order to provide data to a chart date-time range control client, you need to
// access the ChartRangeControlClientDataProvider object using the
// ChartRangeControlClientBase.DataProvider property and assign a data source to
// the ChartRangeControlClientDataProvider.DataSource property. Then specify the
// required data fields via the
// ChartRangeControlClientDataProvider.ArgumentDataMember,
// ChartRangeControlClientDataProvider.ValueDataMember, and
// ChartRangeControlClientDataProvider.SeriesDataMember (optional) properties. In
// the current example, a date-time chart client is bound to a simple data table
// containing three columns ("Argument", "Value", and "Series"). In addition, this
// example shows how to customize chart client common settings (e.g., change the
// date-time range, customize template view and grid options).
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=T125884

namespace DateTimeChartRangeClient {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraEditors.RangeControlRange rangeControlRange1 = new DevExpress.XtraEditors.RangeControlRange();
            this.rangeControl1 = new DevExpress.XtraEditors.RangeControl();
            this.dateTimeChartRangeControlClient1 = new DevExpress.XtraEditors.DateTimeChartRangeControlClient();
            ((System.ComponentModel.ISupportInitialize)(this.rangeControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeChartRangeControlClient1)).BeginInit();
            this.SuspendLayout();
            // 
            // rangeControl1
            // 
            this.rangeControl1.Client = this.dateTimeChartRangeControlClient1;
            this.rangeControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rangeControl1.Location = new System.Drawing.Point(0, 0);
            this.rangeControl1.Name = "rangeControl1";
          
            rangeControlRange1.Owner = this.rangeControl1;
            this.rangeControl1.SelectedRange = rangeControlRange1;
            this.rangeControl1.Size = new System.Drawing.Size(705, 198);
            this.rangeControl1.TabIndex = 0;
            this.rangeControl1.Text = "rangeControl1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 198);
            this.Controls.Add(this.rangeControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.rangeControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeChartRangeControlClient1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.RangeControl rangeControl1;
        private DevExpress.XtraEditors.DateTimeChartRangeControlClient dateTimeChartRangeControlClient1;
    }
}

