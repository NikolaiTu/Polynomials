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
            ((System.ComponentModel.ISupportInitialize)(this.PolynomialChart)).BeginInit();
            this.SuspendLayout();
            // 
            // PolynomialChart
            // 
            chartArea1.Name = "ChartArea1";
            this.PolynomialChart.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.PolynomialChart.Legends.Add(legend1);
            this.PolynomialChart.Location = new System.Drawing.Point(-2, -13);
            this.PolynomialChart.Name = "PolynomialChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.PolynomialChart.Series.Add(series1);
            this.PolynomialChart.Size = new System.Drawing.Size(467, 468);
            this.PolynomialChart.TabIndex = 0;
            this.PolynomialChart.Text = "chart1";
            // 
            // PolyTextBox1
            // 
            this.PolyTextBox1.Location = new System.Drawing.Point(547, 29);
            this.PolyTextBox1.Name = "PolyTextBox1";
            this.PolyTextBox1.Size = new System.Drawing.Size(177, 22);
            this.PolyTextBox1.TabIndex = 1;
            // 
            // PolyTextBox2
            // 
            this.PolyTextBox2.Location = new System.Drawing.Point(547, 84);
            this.PolyTextBox2.Name = "PolyTextBox2";
            this.PolyTextBox2.Size = new System.Drawing.Size(177, 22);
            this.PolyTextBox2.TabIndex = 2;
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Location = new System.Drawing.Point(729, 29);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(28, 22);
            this.MultiplyButton.TabIndex = 3;
            this.MultiplyButton.Text = "X";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // AdditionButton
            // 
            this.AdditionButton.Location = new System.Drawing.Point(547, 135);
            this.AdditionButton.Name = "AdditionButton";
            this.AdditionButton.Size = new System.Drawing.Size(253, 27);
            this.AdditionButton.TabIndex = 4;
            this.AdditionButton.Text = "addition";
            this.AdditionButton.UseVisualStyleBackColor = true;
            this.AdditionButton.Click += new System.EventHandler(this.AdditionButton_Click);
            // 
            // ChartButton
            // 
            this.ChartButton.Location = new System.Drawing.Point(471, 29);
            this.ChartButton.Name = "ChartButton";
            this.ChartButton.Size = new System.Drawing.Size(70, 22);
            this.ChartButton.TabIndex = 5;
            this.ChartButton.Text = "chart";
            this.ChartButton.UseVisualStyleBackColor = true;
            this.ChartButton.Click += new System.EventHandler(this.ChartButton_Click);
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.AutoSize = true;
            this.AnswerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnswerLabel.Location = new System.Drawing.Point(547, 292);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(127, 39);
            this.AnswerLabel.TabIndex = 6;
            this.AnswerLabel.Text = "answer";
            // 
            // PolyMultiplyNumBox
            // 
            this.PolyMultiplyNumBox.Location = new System.Drawing.Point(762, 29);
            this.PolyMultiplyNumBox.Name = "PolyMultiplyNumBox";
            this.PolyMultiplyNumBox.Size = new System.Drawing.Size(38, 22);
            this.PolyMultiplyNumBox.TabIndex = 7;
            // 
            // PolyMultiplyNumBox2
            // 
            this.PolyMultiplyNumBox2.Location = new System.Drawing.Point(762, 85);
            this.PolyMultiplyNumBox2.Name = "PolyMultiplyNumBox2";
            this.PolyMultiplyNumBox2.Size = new System.Drawing.Size(38, 22);
            this.PolyMultiplyNumBox2.TabIndex = 8;
            // 
            // MultiplyButton2
            // 
            this.MultiplyButton2.Location = new System.Drawing.Point(729, 84);
            this.MultiplyButton2.Name = "MultiplyButton2";
            this.MultiplyButton2.Size = new System.Drawing.Size(28, 23);
            this.MultiplyButton2.TabIndex = 9;
            this.MultiplyButton2.Text = "X";
            this.MultiplyButton2.UseVisualStyleBackColor = true;
            this.MultiplyButton2.Click += new System.EventHandler(this.MultiplyButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "Form1";
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
    }
}

