namespace VillageNewbies.UI
{
    partial class Raportointi
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Btn_mokit = new System.Windows.Forms.Button();
            this.chart_mokit = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart_mokit)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_mokit
            // 
            this.Btn_mokit.Location = new System.Drawing.Point(31, 57);
            this.Btn_mokit.Name = "Btn_mokit";
            this.Btn_mokit.Size = new System.Drawing.Size(75, 23);
            this.Btn_mokit.TabIndex = 0;
            this.Btn_mokit.Text = "Mökit";
            this.Btn_mokit.UseVisualStyleBackColor = true;
            this.Btn_mokit.Click += new System.EventHandler(this.Btn_mokit_Click);
            // 
            // chart_mokit
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_mokit.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_mokit.Legends.Add(legend1);
            this.chart_mokit.Location = new System.Drawing.Point(374, 23);
            this.chart_mokit.Name = "chart_mokit";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Varauksien lkm";
            this.chart_mokit.Series.Add(series1);
            this.chart_mokit.Size = new System.Drawing.Size(670, 325);
            this.chart_mokit.TabIndex = 1;
            this.chart_mokit.Text = "chart1";
            // 
            // Raportointi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 547);
            this.Controls.Add(this.chart_mokit);
            this.Controls.Add(this.Btn_mokit);
            this.Name = "Raportointi";
            this.Text = "Raportointi";
            this.Load += new System.EventHandler(this.Raportointi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_mokit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_mokit;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_mokit;
    }
}