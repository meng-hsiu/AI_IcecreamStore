namespace WindowsFormsApp1
{
    partial class StoreSystem
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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbltotalsell = new System.Windows.Forms.Label();
            this.lblIcecream = new System.Windows.Forms.Label();
            this.lblpop = new System.Windows.Forms.Label();
            this.lblsun = new System.Windows.Forms.Label();
            this.lbldrink = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(736, 53);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(430, 395);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // lbltotalsell
            // 
            this.lbltotalsell.AutoSize = true;
            this.lbltotalsell.Location = new System.Drawing.Point(471, 190);
            this.lbltotalsell.Name = "lbltotalsell";
            this.lbltotalsell.Size = new System.Drawing.Size(75, 26);
            this.lbltotalsell.TabIndex = 1;
            this.lbltotalsell.Text = "label1";
            // 
            // lblIcecream
            // 
            this.lblIcecream.AutoSize = true;
            this.lblIcecream.Location = new System.Drawing.Point(76, 190);
            this.lblIcecream.Name = "lblIcecream";
            this.lblIcecream.Size = new System.Drawing.Size(75, 26);
            this.lblIcecream.TabIndex = 2;
            this.lblIcecream.Text = "label1";
            // 
            // lblpop
            // 
            this.lblpop.AutoSize = true;
            this.lblpop.Location = new System.Drawing.Point(76, 261);
            this.lblpop.Name = "lblpop";
            this.lblpop.Size = new System.Drawing.Size(75, 26);
            this.lblpop.TabIndex = 3;
            this.lblpop.Text = "label1";
            // 
            // lblsun
            // 
            this.lblsun.AutoSize = true;
            this.lblsun.Location = new System.Drawing.Point(76, 337);
            this.lblsun.Name = "lblsun";
            this.lblsun.Size = new System.Drawing.Size(75, 26);
            this.lblsun.TabIndex = 4;
            this.lblsun.Text = "label1";
            // 
            // lbldrink
            // 
            this.lbldrink.AutoSize = true;
            this.lbldrink.Location = new System.Drawing.Point(76, 411);
            this.lbldrink.Name = "lbldrink";
            this.lbldrink.Size = new System.Drawing.Size(75, 26);
            this.lbldrink.TabIndex = 5;
            this.lbldrink.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(414, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 61);
            this.label1.TabIndex = 6;
            this.label1.Text = "總營業額";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(57, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 61);
            this.label2.TabIndex = 7;
            this.label2.Text = "販售比例";
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(50, 12);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(200, 35);
            this.dateStart.TabIndex = 8;
            this.dateStart.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(297, 12);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(200, 35);
            this.dateEnd.TabIndex = 9;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(513, 12);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(93, 35);
            this.btnCreate.TabIndex = 10;
            this.btnCreate.Text = "生成";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "到";
            // 
            // StoreSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 475);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbldrink);
            this.Controls.Add(this.lblsun);
            this.Controls.Add(this.lblpop);
            this.Controls.Add(this.lblIcecream);
            this.Controls.Add(this.lbltotalsell);
            this.Controls.Add(this.chart1);
            this.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "StoreSystem";
            this.Text = "StoreSystem";
            this.Load += new System.EventHandler(this.StoreSystem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lbltotalsell;
        private System.Windows.Forms.Label lblIcecream;
        private System.Windows.Forms.Label lblpop;
        private System.Windows.Forms.Label lblsun;
        private System.Windows.Forms.Label lbldrink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label3;
    }
}