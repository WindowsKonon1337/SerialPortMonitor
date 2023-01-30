namespace ASPM
{
    partial class SerialChartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.SerialChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SerialChart)).BeginInit();
            this.SuspendLayout();
            // 
            // SerialChart
            // 
            this.SerialChart.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            chartArea1.Name = "ChartArea1";
            this.SerialChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.SerialChart.Legends.Add(legend1);
            this.SerialChart.Location = new System.Drawing.Point(303, 12);
            this.SerialChart.Name = "SerialChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "First Spline";
            this.SerialChart.Series.Add(series1);
            this.SerialChart.Size = new System.Drawing.Size(776, 426);
            this.SerialChart.TabIndex = 0;
            this.SerialChart.Text = "SerialChart";
            // 
            // SerialChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 450);
            this.Controls.Add(this.SerialChart);
            this.Name = "SerialChartForm";
            this.Text = "SerialChartForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SerialChartForm_FormClosed);
            this.Load += new System.EventHandler(this.SerialChartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SerialChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart SerialChart;
        private System.Windows.Forms.Timer UpdateTimer;
    }
}