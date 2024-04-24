using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();

            double mean = (double)meanNum.Value, variance = (double)varianceNum.Value;
            int size = (int)sizeNum.Value, intervals = 5;

            double[] sample = new double[size];

            Random random = new Random();

            double min = 10000, max = 0;
            double a1, a2;
            double value;

            for (int i = 0; i < size; i++)
            {
                a1 = random.NextDouble(); a2 = random.NextDouble();
                value = (Math.Sqrt(-2 * Math.Log10(a1)) * Math.Cos(2 * Math.PI * a2)) * Math.Sqrt(variance) + mean;               

                if (value > max) max = value;
                if (value < min) min = value;

                sample[i] = value;
            }
            double step = (max - min) / intervals;

            int[] stat = new int[intervals];

            for (int i = 0; i < intervals; i++)
            {
                stat[i] = 0;

                for (int j = 0; j < size; j++)
                {
                    if (sample[j] > min + step * i && sample[j] <= min + step * (i + 1)) stat[i]++;            
                }
            }

            double[] frequency = new double[intervals];

            for (int i = 0; i < intervals; i++)
            {
                frequency[i] = (double)stat[i] / size;
                chart1.Series[0].Points.Add(frequency[i]);
            }

            double fvariance = 0, faverage = 0;

            for (int i = 0; i < size; i++)
            {
                faverage += sample[i];
                fvariance += sample[i] * sample[i];
            }
            faverage /= size;
            fvariance = fvariance / size - faverage * faverage;

            double averageError = Math.Abs(faverage - mean) / Math.Abs(mean);
            double varianceError = Math.Abs(fvariance - variance) / Math.Abs(variance);

            meanLabel.Text = Convert.ToString(faverage) + " (error = " + Convert.ToString(averageError * 100) + "%)";
            varianceLabel.Text = Convert.ToString(fvariance) + " (error = " + Convert.ToString(varianceError * 100) + "%)";

            double[] prob = new double[intervals];
            double plot, x;

            for (int i = 0; i < intervals; i++)
            {
                x = ((min + step * i) + (min + step * (i + 1))) / 2;
                plot = Math.Exp(Math.Pow(x, 2) / -2) / Math.Sqrt(2 * Math.PI);
                prob[i] = ((min + step * (i + 1)) - (min + step * i)) * plot;
            }

            double chi = 0, chiA = 11.07;
            for (int i = 0; i < intervals; i++)
            {
                chi += (stat[i] * stat[i]) / (size * prob[i]);               
            }
            chi -= size;

            chiLabel.Text = Convert.ToString(chi);
            if (chi > chiA)
                chiLabel.Text += " > " + Convert.ToString(chiA) + " is True";
            else chiLabel.Text += " <= " + Convert.ToString(chiA) + " is False";
        }
    }
}
