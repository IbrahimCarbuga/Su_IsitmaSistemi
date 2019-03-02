namespace Su_Isıtma_Sistemi
{
    partial class GirisGrafik
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.sicaklikGrafigi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.seviyeGrafigi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnGirisKirmiziCizgi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sicaklikGrafigi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seviyeGrafigi)).BeginInit();
            this.SuspendLayout();
            // 
            // sicaklikGrafigi
            // 
            chartArea3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea3.Name = "ChartArea1";
            this.sicaklikGrafigi.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.sicaklikGrafigi.Legends.Add(legend3);
            this.sicaklikGrafigi.Location = new System.Drawing.Point(12, 23);
            this.sicaklikGrafigi.Name = "sicaklikGrafigi";
            this.sicaklikGrafigi.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series13.BorderWidth = 3;
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series13.Legend = "Legend1";
            series13.Name = "Çok Düşük";
            series13.XValueMember = "15";
            series13.YValueMembers = "1515";
            series13.YValuesPerPoint = 2;
            series14.BorderWidth = 3;
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series14.Legend = "Legend1";
            series14.Name = "Düşük";
            series15.BorderWidth = 3;
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series15.Legend = "Legend1";
            series15.Name = "Orta";
            series16.BorderWidth = 3;
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series16.Legend = "Legend1";
            series16.Name = "Yüksek";
            series17.BorderWidth = 3;
            series17.ChartArea = "ChartArea1";
            series17.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series17.Legend = "Legend1";
            series17.Name = "Çok Yüksek";
            series18.BorderWidth = 3;
            series18.ChartArea = "ChartArea1";
            series18.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series18.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series18.Legend = "Legend1";
            series18.Name = "Giriş";
            this.sicaklikGrafigi.Series.Add(series13);
            this.sicaklikGrafigi.Series.Add(series14);
            this.sicaklikGrafigi.Series.Add(series15);
            this.sicaklikGrafigi.Series.Add(series16);
            this.sicaklikGrafigi.Series.Add(series17);
            this.sicaklikGrafigi.Series.Add(series18);
            this.sicaklikGrafigi.Size = new System.Drawing.Size(462, 300);
            this.sicaklikGrafigi.TabIndex = 0;
            this.sicaklikGrafigi.Text = "chart1";
            // 
            // seviyeGrafigi
            // 
            chartArea4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea4.Name = "ChartArea1";
            this.seviyeGrafigi.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.seviyeGrafigi.Legends.Add(legend4);
            this.seviyeGrafigi.Location = new System.Drawing.Point(480, 23);
            this.seviyeGrafigi.Name = "seviyeGrafigi";
            this.seviyeGrafigi.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series19.BorderWidth = 3;
            series19.ChartArea = "ChartArea1";
            series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series19.Legend = "Legend1";
            series19.Name = "Çok Düşük";
            series19.XValueMember = "15";
            series19.YValueMembers = "1515";
            series19.YValuesPerPoint = 2;
            series20.BorderWidth = 3;
            series20.ChartArea = "ChartArea1";
            series20.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series20.Legend = "Legend1";
            series20.Name = "Düşük";
            series21.BorderWidth = 3;
            series21.ChartArea = "ChartArea1";
            series21.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series21.Legend = "Legend1";
            series21.Name = "Orta";
            series22.BorderWidth = 3;
            series22.ChartArea = "ChartArea1";
            series22.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series22.Legend = "Legend1";
            series22.Name = "Yüksek";
            series23.BorderWidth = 3;
            series23.ChartArea = "ChartArea1";
            series23.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series23.Legend = "Legend1";
            series23.Name = "Çok Yüksek";
            series24.BorderWidth = 3;
            series24.ChartArea = "ChartArea1";
            series24.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series24.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series24.Legend = "Legend1";
            series24.Name = "Giriş";
            this.seviyeGrafigi.Series.Add(series19);
            this.seviyeGrafigi.Series.Add(series20);
            this.seviyeGrafigi.Series.Add(series21);
            this.seviyeGrafigi.Series.Add(series22);
            this.seviyeGrafigi.Series.Add(series23);
            this.seviyeGrafigi.Series.Add(series24);
            this.seviyeGrafigi.Size = new System.Drawing.Size(462, 300);
            this.seviyeGrafigi.TabIndex = 0;
            this.seviyeGrafigi.Text = "chart1";
            // 
            // btnGirisKirmiziCizgi
            // 
            this.btnGirisKirmiziCizgi.Location = new System.Drawing.Point(426, 345);
            this.btnGirisKirmiziCizgi.Name = "btnGirisKirmiziCizgi";
            this.btnGirisKirmiziCizgi.Size = new System.Drawing.Size(106, 23);
            this.btnGirisKirmiziCizgi.TabIndex = 1;
            this.btnGirisKirmiziCizgi.Text = "Girişleri Göster";
            this.btnGirisKirmiziCizgi.UseVisualStyleBackColor = true;
            this.btnGirisKirmiziCizgi.Click += new System.EventHandler(this.btnGirisKirmiziCizgi_Click);
            // 
            // GirisGrafik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 392);
            this.Controls.Add(this.btnGirisKirmiziCizgi);
            this.Controls.Add(this.seviyeGrafigi);
            this.Controls.Add(this.sicaklikGrafigi);
            this.Name = "GirisGrafik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Girişler";
            this.Load += new System.EventHandler(this.GirisGrafik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sicaklikGrafigi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seviyeGrafigi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart sicaklikGrafigi;
        private System.Windows.Forms.DataVisualization.Charting.Chart seviyeGrafigi;
        private System.Windows.Forms.Button btnGirisKirmiziCizgi;
    }
}