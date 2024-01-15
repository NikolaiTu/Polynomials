namespace Polynomials
{
    partial class Form1
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
            this.PolynomialChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PolyTextBox1 = new System.Windows.Forms.TextBox();
            this.PolyTextBox2 = new System.Windows.Forms.TextBox();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.AdditionButton = new System.Windows.Forms.Button();
            this.ChartButton = new System.Windows.Forms.Button();
            this.AnswerLabel = new System.Windows.Forms.Label();
            this.PolyMultiplyNumBox = new System.Windows.Forms.TextBox();
            this.PolyMultiplyNumBox2 = new System.Windows.Forms.TextBox();
            this.MultiplyButton2 = new System.Windows.Forms.Button();
            this.ChartButton2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PolynomialChart)).BeginInit();
            this.SuspendLayout();
            // 
            // PolynomialChart
            // 
            this.PolynomialChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.PolynomialChart.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.PolynomialChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.PolynomialChart.BorderlineWidth = 7;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BackSecondaryColor = System.Drawing.Color.Black;
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.PolynomialChart.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.PolynomialChart.Legends.Add(legend1);
            this.PolynomialChart.Location = new System.Drawing.Point(-20, -7);
            this.PolynomialChart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PolynomialChart.Name = "PolynomialChart";
            this.PolynomialChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(192)))), ((int)(((byte)(127)))));
            series1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsXValueIndexed = true;
            series1.LabelAngle = 20;
            series1.LabelBackColor = System.Drawing.Color.Transparent;
            series1.LabelBorderColor = System.Drawing.Color.Transparent;
            series1.LabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(85)))), ((int)(((byte)(39)))));
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.Transparent;
            series1.MarkerColor = System.Drawing.Color.Transparent;
            series1.MarkerImageTransparentColor = System.Drawing.Color.Transparent;
            series1.MarkerSize = 0;
            series1.Name = "Series1";
            series1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(145)))), ((int)(((byte)(97)))));
            series1.ShadowOffset = 1;
            series1.YValuesPerPoint = 2;
            this.PolynomialChart.Series.Add(series1);
            this.PolynomialChart.Size = new System.Drawing.Size(367, 387);
            this.PolynomialChart.TabIndex = 0;
            this.PolynomialChart.Text = "Polynomial Chart";
            // 
            // PolyTextBox1
            // 
            this.PolyTextBox1.Location = new System.Drawing.Point(394, 25);
            this.PolyTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PolyTextBox1.Name = "PolyTextBox1";
            this.PolyTextBox1.Size = new System.Drawing.Size(145, 20);
            this.PolyTextBox1.TabIndex = 1;
            // 
            // PolyTextBox2
            // 
            this.PolyTextBox2.Location = new System.Drawing.Point(395, 69);
            this.PolyTextBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PolyTextBox2.Name = "PolyTextBox2";
            this.PolyTextBox2.Size = new System.Drawing.Size(144, 20);
            this.PolyTextBox2.TabIndex = 2;
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Location = new System.Drawing.Point(542, 25);
            this.MultiplyButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(21, 20);
            this.MultiplyButton.TabIndex = 3;
            this.MultiplyButton.Text = "X";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // AdditionButton
            // 
            this.AdditionButton.Location = new System.Drawing.Point(352, 109);
            this.AdditionButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AdditionButton.Name = "AdditionButton";
            this.AdditionButton.Size = new System.Drawing.Size(245, 22);
            this.AdditionButton.TabIndex = 4;
            this.AdditionButton.Text = "addition";
            this.AdditionButton.UseVisualStyleBackColor = true;
            this.AdditionButton.Click += new System.EventHandler(this.AdditionButton_Click);
            // 
            // ChartButton
            // 
            this.ChartButton.Location = new System.Drawing.Point(352, 25);
            this.ChartButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChartButton.Name = "ChartButton";
            this.ChartButton.Size = new System.Drawing.Size(38, 20);
            this.ChartButton.TabIndex = 5;
            this.ChartButton.Text = "Chart";
            this.ChartButton.UseVisualStyleBackColor = true;
            this.ChartButton.Click += new System.EventHandler(this.ChartButton_Click);
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.AutoSize = true;
            this.AnswerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnswerLabel.Location = new System.Drawing.Point(351, 161);
            this.AnswerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(102, 31);
            this.AnswerLabel.TabIndex = 6;
            this.AnswerLabel.Text = "answer";
            // 
            // PolyMultiplyNumBox
            // 
            this.PolyMultiplyNumBox.Location = new System.Drawing.Point(567, 25);
            this.PolyMultiplyNumBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PolyMultiplyNumBox.Name = "PolyMultiplyNumBox";
            this.PolyMultiplyNumBox.Size = new System.Drawing.Size(30, 20);
            this.PolyMultiplyNumBox.TabIndex = 7;
            // 
            // PolyMultiplyNumBox2
            // 
            this.PolyMultiplyNumBox2.Location = new System.Drawing.Point(567, 70);
            this.PolyMultiplyNumBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PolyMultiplyNumBox2.Name = "PolyMultiplyNumBox2";
            this.PolyMultiplyNumBox2.Size = new System.Drawing.Size(30, 20);
            this.PolyMultiplyNumBox2.TabIndex = 8;
            // 
            // MultiplyButton2
            // 
            this.MultiplyButton2.Location = new System.Drawing.Point(542, 69);
            this.MultiplyButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MultiplyButton2.Name = "MultiplyButton2";
            this.MultiplyButton2.Size = new System.Drawing.Size(21, 21);
            this.MultiplyButton2.TabIndex = 9;
            this.MultiplyButton2.Text = "X";
            this.MultiplyButton2.UseVisualStyleBackColor = true;
            this.MultiplyButton2.Click += new System.EventHandler(this.MultiplyButton2_Click);
            // 
            // ChartButton2
            // 
            this.ChartButton2.Location = new System.Drawing.Point(352, 69);
            this.ChartButton2.Name = "ChartButton2";
            this.ChartButton2.Size = new System.Drawing.Size(38, 21);
            this.ChartButton2.TabIndex = 10;
            this.ChartButton2.Text = "Chart";
            this.ChartButton2.UseVisualStyleBackColor = true;
            this.ChartButton2.Click += new System.EventHandler(this.ChartButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(607, 366);
            this.Controls.Add(this.ChartButton2);
            this.Controls.Add(this.MultiplyButton2);
            this.Controls.Add(this.PolyMultiplyNumBox2);
            this.Controls.Add(this.PolyMultiplyNumBox);
            this.Controls.Add(this.AnswerLabel);
            this.Controls.Add(this.ChartButton);
            this.Controls.Add(this.AdditionButton);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.PolyTextBox2);
            this.Controls.Add(this.PolyTextBox1);
            this.Controls.Add(this.PolynomialChart);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(623, 405);
            this.MinimumSize = new System.Drawing.Size(623, 405);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PolynomialChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart PolynomialChart;
        private System.Windows.Forms.TextBox PolyTextBox1;
        private System.Windows.Forms.TextBox PolyTextBox2;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Button AdditionButton;
        private System.Windows.Forms.Button ChartButton;
        private System.Windows.Forms.Label AnswerLabel;
        private System.Windows.Forms.TextBox PolyMultiplyNumBox;
        private System.Windows.Forms.TextBox PolyMultiplyNumBox2;
        private System.Windows.Forms.Button MultiplyButton2;
        private System.Windows.Forms.Button ChartButton2;
    }
}

