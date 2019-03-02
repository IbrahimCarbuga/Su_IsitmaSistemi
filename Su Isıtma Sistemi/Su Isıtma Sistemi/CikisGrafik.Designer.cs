namespace Su_Isıtma_Sistemi
{
    partial class CikisGrafik
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.rezistantGrafigi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnCikisKirmiziCizgi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rezistantGrafigi)).BeginInit();
            this.SuspendLayout();
            // 
            // rezistantGrafigi
            // 
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea1.Name = "ChartArea1";
            this.rezistantGrafigi.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.rezistantGrafigi.Legends.Add(legend1);
            this.rezistantGrafigi.Location = new System.Drawing.Point(12, 12);
            this.rezistantGrafigi.Name = "rezistantGrafigi";
            this.rezistantGrafigi.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Çok Düşük";
            series1.XValueMember = "15";
            series1.YValueMembers = "1515";
            series1.YValuesPerPoint = 2;
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Düşük";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Orta";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Yüksek";
            series5.BorderWidth = 3;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Çok Yüksek";
            series6.BorderWidth = 3;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series6.Legend = "Legend1";
            series6.Name = "Çıkış";
            this.rezistantGrafigi.Series.Add(series1);
            this.rezistantGrafigi.Series.Add(series2);
            this.rezistantGrafigi.Series.Add(series3);
            this.rezistantGrafigi.Series.Add(series4);
            this.rezistantGrafigi.Series.Add(series5);
            this.rezistantGrafigi.Series.Add(series6);
            this.rezistantGrafigi.Size = new System.Drawing.Size(462, 300);
            this.rezistantGrafigi.TabIndex = 1;
            this.rezistantGrafigi.Text = "chart1";
            // 
            // btnCikisKirmiziCizgi
            // 
            this.btnCikisKirmiziCizgi.Location = new System.Drawing.Point(137, 329);
            this.btnCikisKirmiziCizgi.Name = "btnCikisKirmiziCizgi";
            this.btnCikisKirmiziCizgi.Size = new System.Drawing.Size(106, 23);
            this.btnCikisKirmiziCizgi.TabIndex = 2;
            this.btnCikisKirmiziCizgi.Text = "Çıkışı Göster";
            this.btnCikisKirmiziCizgi.UseVisualStyleBackColor = true;
            this.btnCikisKirmiziCizgi.Click += new System.EventHandler(this.btnCikisKirmiziCizgi_Click);
            // 
            // CikisGrafik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 383);
            this.Controls.Add(this.btnCikisKirmiziCizgi);
            this.Controls.Add(this.rezistantGrafigi);
            this.Name = "CikisGrafik";
            this.Text = "CikisGrafik";
            this.Load += new System.EventHandler(this.CikisGrafik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rezistantGrafigi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart rezistantGrafigi;
        private System.Windows.Forms.Button btnCikisKirmiziCizgi;
    }
}