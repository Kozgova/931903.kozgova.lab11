using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_11
{
    public partial class Form1 : Form
    {

        double mean, variance;
        int size;

        double empMean, empVariance;
        double errE, errD;
        double Square;
        double[] SquareValues = new double[15] {3.841, 5.991, 7.815, 9.488, 11.070, 12.592, 14.067, 15.507,
                                                    16.919, 18.307, 19.675, 21.026, 22.362, 23.685, 24.996};

        int k;
        double Length;
        int[] Count;
        double[] Frequency;
        double[] Len;
        double max = -99999, min = 99999;
        double[] normalDis = new double[10000];
        double length;

        Random rnd = new Random();
        double l1, l2;

        public Form1()
        {
            InitializeComponent();

            mean = (double)edMean.Value;
            variance = (double)edVariance.Value;
            size = (int)edSize.Value;
        }

        private void btStart1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            max = 0; min = 0; Square = 0;

            for (int i = 0; i < size; i += 2)
            {
                l1 = rnd.NextDouble();
                l2 = rnd.NextDouble();
                normalDis[i] = Math.Sqrt((-2) * Math.Log(l1)) * Math.Sin(2 * Math.PI * l2) * Math.Sqrt(variance) + mean;
                normalDis[i + 1] = Math.Sqrt((-2) * Math.Log(l1)) * Math.Cos(2 * Math.PI * l2) * Math.Sqrt(variance) + mean;
                if (normalDis[i] > max)
                    max = normalDis[i];
                if (normalDis[i] < min)
                    min = normalDis[i];
                if (normalDis[i + 1] > max)
                    max = normalDis[i + 1];
                if (normalDis[i + 1] < min)
                    min = normalDis[i + 1];

                empMean += normalDis[i] + normalDis[i + 1];
                empVariance += normalDis[i] * normalDis[i] + normalDis[i + 1] * normalDis[i + 1];
            }

            empMean = empMean / size;
            empVariance = empVariance / size - empMean * empMean;
            errE = Math.Abs(empMean - mean) / Math.Abs(mean) * 100;
            errD = Math.Abs(empVariance - variance) / Math.Abs(variance) * 100;
            lbAverage.Text = "" + Math.Round(empMean, 2).ToString() +
                                "(error = " + Math.Round(errE, 2) + "%)";
            lbVarience.Text = "" + Math.Round(empVariance, 2).ToString() +
                                "(error = " + Math.Round(errD, 2) + "%)";

            k = (int)Math.Log(size, 2) + 1;
            Length = (max - min) / k;
            Count = new int[k];
            for (int i = 0; i < size; i++)
            {
                length = min + Length;
                int j = 0;
                while (j < k)
                {
                    if (normalDis[i] < length)
                    {
                        Count[j]++;
                        break;
                    }
                    else
                    {
                        length += Length;
                        j++;
                    }
                }
                normalDis[i] = 0;
            }

            Frequency = new double[k];
            Len = new double[k + 1];
            double min1 = min;
            double pi = 0, px = 0;
            double x = 0;
            for (int i = 0; i < k; i++)
            {
                Frequency[i] = (double)Count[i] / size;
                x = (min1 + min1 + Length) / 2;
                px = (1 / (Math.Sqrt(2 * Math.PI) * Math.Sqrt(variance))) *
                    Math.Exp(-((x - mean) * (x - mean)) / (2 * variance));
                pi = ((min1 + Length) - min1) * px;
                Square += (Count[i] * Count[i]) / (double)(size * pi);
                Len[i] = min1;
                chart1.Series[0].Points.AddXY(min1, Frequency[i]);
                min1 += Length;
            }
            chart1.Series[0].Points.AddXY(min1, Frequency[k - 1]);
            chart1.ChartAreas[0].AxisX.Minimum = -5;
            chart1.ChartAreas[0].AxisX.Maximum = 5;

            Square -= size;
            lbSquare.Text = "" + Math.Round(Square, 2) + " > " + SquareValues[k - 1].ToString() + "    ";
            if (Square > SquareValues[k - 2])
            {
                lbSquare.Text += "True";
            }
            else
                lbSquare.Text += "False";
        }
    }
}
