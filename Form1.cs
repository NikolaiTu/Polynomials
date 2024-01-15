using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MathNet.Numerics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Polynomials
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //mutliply polynomial with num
            //polynomial additionn
            //graph a polynomial

            //Polynomial PolyNums = new Polynomial(1, 2, 3);
            //Polynomial PolyNums2 = new Polynomial(0, 1);

            //var Multiplication = PolyNums * 3;

            //var Addition = PolyNums + PolyNums2;

            //for (int i = -20; i <= 20; i++)
            //{
            //    PolynomialChart.Series[0].Points.Add(PolyNums.Evaluate(i));
            //}

            Console.WriteLine("thingamajig");
        }

        public double[] GetCoefficient(string input)
        {
            string[] values = input.Split(' ');
            double[] Coefficients = new double[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                Coefficients[i] = double.Parse(values[i]); // * double.Parse(numBoxText);
            }
            return Coefficients;
        }

        public void DrawChart(Polynomial PolyNums)
        {
            PolynomialChart.Series[0].Points.Clear();
            for (int i = -20; i <= 20; i++)
            {
                PolynomialChart.Series[0].Points.Add(PolyNums.Evaluate(i));
            }
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            var Coefficients = GetCoefficient(PolyTextBox1.Text);

            Polynomial PolyNums = new Polynomial(Coefficients);
            var Answer = PolyNums * int.Parse(PolyMultiplyNumBox.Text);
            AnswerLabel.Text = Answer.ToString();
        }

        private void MultiplyButton2_Click(object sender, EventArgs e)
        {
            var Coefficients = GetCoefficient(PolyTextBox2.Text);

            Polynomial PolyNums = new Polynomial(Coefficients);
            var Answer = PolyNums * int.Parse(PolyMultiplyNumBox2.Text);
            AnswerLabel.Text = Answer.ToString();
        }

        private void AdditionButton_Click(object sender, EventArgs e)
        {
            var Coefficient1 = GetCoefficient(PolyTextBox1.Text);
            var Coefficient2 = GetCoefficient(PolyTextBox2.Text);

            Polynomial PolyNums = new Polynomial(Coefficient1);
            Polynomial PolyNums2 = new Polynomial(Coefficient2);

            var Answer = PolyNums + PolyNums2;
            AnswerLabel.Text = Answer.ToString();
        }

        private void ChartButton_Click(object sender, EventArgs e)
        {
            var Coefficient = GetCoefficient(PolyTextBox1.Text);
            Polynomial PolyNums = new Polynomial(Coefficient);
            DrawChart(PolyNums);
        }

        private void ChartButton2_Click(object sender, EventArgs e)
        {
            var Coefficient = GetCoefficient(PolyTextBox2.Text);
            Polynomial PolyNums = new Polynomial(Coefficient);
            DrawChart(PolyNums);
        }
    }
}
