namespace Апроксимация
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.Dot1 = new System.Windows.Forms.Button();
            this.Dot2 = new System.Windows.Forms.Button();
            this.Dot3 = new System.Windows.Forms.Button();
            this.Dot4 = new System.Windows.Forms.Button();
            this.Dot5 = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.chart1.BackSecondaryColor = System.Drawing.Color.Black;
            this.chart1.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            this.chart1.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            chartArea1.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea1.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea1.AxisX.Crossing = 0D;
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.IntervalOffset = 1D;
            chartArea1.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.LabelStyle.Angle = 1;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            chartArea1.AxisX.LabelStyle.IsEndLabelVisible = false;
            chartArea1.AxisX.MajorGrid.Interval = 0D;
            chartArea1.AxisX.MajorGrid.IntervalOffset = 1D;
            chartArea1.AxisX.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.None;
            chartArea1.AxisX.Maximum = 6D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.ScaleBreakStyle.MaxNumberOfBreaks = 1;
            chartArea1.AxisX.ScaleBreakStyle.Spacing = 1D;
            chartArea1.AxisX.ScaleBreakStyle.StartFromZero = System.Windows.Forms.DataVisualization.Charting.StartFromZero.No;
            chartArea1.AxisX.Title = "x";
            chartArea1.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX2.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea1.AxisX2.InterlacedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            chartArea1.AxisX2.LineColor = System.Drawing.Color.Maroon;
            chartArea1.AxisX2.MajorGrid.Interval = 0D;
            chartArea1.AxisX2.MajorGrid.IntervalOffset = 0D;
            chartArea1.AxisX2.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX2.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX2.MajorGrid.LineColor = System.Drawing.Color.DarkRed;
            chartArea1.AxisX2.MajorGrid.LineWidth = 5;
            chartArea1.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.Maroon;
            chartArea1.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea1.AxisY.Crossing = 0D;
            chartArea1.AxisY.Interval = 1D;
            chartArea1.AxisY.IntervalOffset = 1D;
            chartArea1.AxisY.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisY.IsMarginVisible = false;
            chartArea1.AxisY.Maximum = 10D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.AxisY.ScrollBar.BackColor = System.Drawing.Color.Red;
            chartArea1.AxisY.ScrollBar.ButtonColor = System.Drawing.Color.Purple;
            chartArea1.AxisY.ScrollBar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea1.AxisY.Title = "y";
            chartArea1.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 90F;
            chartArea1.InnerPlotPosition.Width = 90F;
            chartArea1.InnerPlotPosition.X = 5F;
            chartArea1.InnerPlotPosition.Y = 3F;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 90F;
            chartArea1.Position.Width = 90F;
            chartArea1.Position.X = 5F;
            chartArea1.Position.Y = 3F;
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Arrow;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.ItemColumnSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.DotLine;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.BackImageTransparentColor = System.Drawing.Color.White;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Maroon;
            series1.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.Black;
            series1.MarkerSize = 2;
            series1.Name = "MNK";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Lagrangian";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(740, 617);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.label1.Location = new System.Drawing.Point(576, 599);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // Dot1
            // 
            this.Dot1.Cursor = System.Windows.Forms.Cursors.NoMoveVert;
            this.Dot1.Location = new System.Drawing.Point(165, 480);
            this.Dot1.Name = "Dot1";
            this.Dot1.Size = new System.Drawing.Size(10, 10);
            this.Dot1.TabIndex = 2;
            this.Dot1.UseVisualStyleBackColor = true;
            this.Dot1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            this.Dot1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Dot1_MouseMove);
            this.Dot1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // Dot2
            // 
            this.Dot2.Cursor = System.Windows.Forms.Cursors.NoMoveVert;
            this.Dot2.Location = new System.Drawing.Point(265, 480);
            this.Dot2.Name = "Dot2";
            this.Dot2.Size = new System.Drawing.Size(10, 10);
            this.Dot2.TabIndex = 2;
            this.Dot2.UseVisualStyleBackColor = true;
            this.Dot2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button2_MouseDown);
            this.Dot2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Dot2_MouseMove);
            this.Dot2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button2_MouseUp);
            // 
            // Dot3
            // 
            this.Dot3.Cursor = System.Windows.Forms.Cursors.NoMoveVert;
            this.Dot3.Location = new System.Drawing.Point(365, 480);
            this.Dot3.Name = "Dot3";
            this.Dot3.Size = new System.Drawing.Size(10, 10);
            this.Dot3.TabIndex = 2;
            this.Dot3.UseVisualStyleBackColor = true;
            this.Dot3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button3_MouseDown);
            this.Dot3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Dot3_MouseMove);
            this.Dot3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button3_MouseUp);
            // 
            // Dot4
            // 
            this.Dot4.Cursor = System.Windows.Forms.Cursors.NoMoveVert;
            this.Dot4.Location = new System.Drawing.Point(465, 480);
            this.Dot4.Name = "Dot4";
            this.Dot4.Size = new System.Drawing.Size(10, 10);
            this.Dot4.TabIndex = 2;
            this.Dot4.UseVisualStyleBackColor = true;
            this.Dot4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button4_MouseDown);
            this.Dot4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Dot4_MouseMove);
            this.Dot4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button4_MouseUp);
            // 
            // Dot5
            // 
            this.Dot5.Cursor = System.Windows.Forms.Cursors.NoMoveVert;
            this.Dot5.Location = new System.Drawing.Point(565, 480);
            this.Dot5.Name = "Dot5";
            this.Dot5.Size = new System.Drawing.Size(10, 10);
            this.Dot5.TabIndex = 2;
            this.Dot5.UseVisualStyleBackColor = true;
            this.Dot5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button5_MouseDown);
            this.Dot5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Dot5_MouseMove);
            this.Dot5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button5_MouseUp);
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start.Location = new System.Drawing.Point(317, 558);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(213, 54);
            this.Start.TabIndex = 3;
            this.Start.Text = "Approximation!";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(747, 624);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Dot5);
            this.Controls.Add(this.Dot4);
            this.Controls.Add(this.Dot3);
            this.Controls.Add(this.Dot2);
            this.Controls.Add(this.Dot1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Approximation of the function";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Dot1;
        private System.Windows.Forms.Button Dot2;
        private System.Windows.Forms.Button Dot3;
        private System.Windows.Forms.Button Dot4;
        private System.Windows.Forms.Button Dot5;
        private System.Windows.Forms.Button Start;

    }
}

