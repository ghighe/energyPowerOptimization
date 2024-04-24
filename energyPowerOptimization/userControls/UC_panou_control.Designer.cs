
namespace energyPowerOptimization.userControls
{
    partial class UC_panou_control
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label1 = new System.Windows.Forms.Label();
            this.products_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.products_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Violet;
            this.label1.Location = new System.Drawing.Point(204, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(673, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Grafic Optimizare curent folosind Panouri Votovoltaice si Turbine Eoliene";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // products_chart
            // 
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.BackColor = System.Drawing.Color.Violet;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.Name = "ChartArea1";
            this.products_chart.ChartAreas.Add(chartArea1);
            this.products_chart.Cursor = System.Windows.Forms.Cursors.Hand;
            legend1.Name = "Legend1";
            this.products_chart.Legends.Add(legend1);
            this.products_chart.Location = new System.Drawing.Point(176, 151);
            this.products_chart.Name = "products_chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "consumInitialTotal";
            series1.ToolTip = "#VAL{N}";
            series1.XValueMember = "consumInitial";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "consumOptimizatCuPanouri";
            series2.ToolTip = "#VAL{N}";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "consumOptimizatCuEoliane";
            series3.ToolTip = "#VAL{N}";
            this.products_chart.Series.Add(series1);
            this.products_chart.Series.Add(series2);
            this.products_chart.Series.Add(series3);
            this.products_chart.Size = new System.Drawing.Size(817, 373);
            this.products_chart.TabIndex = 2;
            this.products_chart.Text = "chart1";
            title1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.Violet;
            title1.Name = "Title1";
            title1.Text = "Optimizarea consumului de curent";
            title1.TextStyle = System.Windows.Forms.DataVisualization.Charting.TextStyle.Shadow;
            this.products_chart.Titles.Add(title1);
            // 
            // UC_panou_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.products_chart);
            this.Controls.Add(this.label1);
            this.Name = "UC_panou_control";
            this.Size = new System.Drawing.Size(1167, 616);
            ((System.ComponentModel.ISupportInitialize)(this.products_chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart products_chart;
    }
}
