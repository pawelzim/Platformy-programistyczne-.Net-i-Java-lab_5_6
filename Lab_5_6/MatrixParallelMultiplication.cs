using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Lab_5_6
{
    public partial class MatrixParallelMultiplication : Form
    {
        private long threadTime = 0, parallelTime = 0;
        int counter = 0, multiplications = 0;
        public MatrixParallelMultiplication()
        {
            InitializeComponent();
        }

        private void sizeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(sizeTextBox.Text, out int a) && a > 0)
            {
                sizeTextBox.ForeColor = Color.Black;

                startButton.Enabled = true;
            }
            else if (string.IsNullOrEmpty(sizeTextBox.Text) || string.IsNullOrEmpty(threadsTextBox.Text))
            {
                startButton.Enabled = false;
            }
            else
            {
                sizeTextBox.ForeColor = Color.Red;

                startButton.Enabled = false;
            }
        }

        private void threadsTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(threadsTextBox.Text, out int liczba) && liczba > 0)
            {
                threadsTextBox.ForeColor = Color.Black;

                startButton.Enabled = true;
            }
            else if (string.IsNullOrEmpty(threadsTextBox.Text))
            {
                startButton.Enabled = false;
            }
            else
            {
                threadsTextBox.ForeColor = Color.Red;

                startButton.Enabled = false;
            }
        }

        // whichTable: false -> thread | true -> parallel
        private void UpdateTimeTextBox(int size, int nrOfThreads, Stopwatch time, bool whichTable)
        {
            string text = $"{counter}: rozmiar: {size}, wątków: {nrOfThreads}, czas: {time.ElapsedMilliseconds} ms" + Environment.NewLine;
            if (whichTable == false)
            {
                threadTimeTextBox.Text += text;
            }
            else
            {
                parallelTimeTextBox.Text += text;
                counter++;
            }
        }

        private void UpdateAverageTime(Stopwatch timeThread, Stopwatch timeParallel)
        {
            threadTime += timeThread.ElapsedMilliseconds;
            parallelTime += timeParallel.ElapsedMilliseconds;

            averageTimeThreadTextBox.Text = Convert.ToString(threadTime / multiplications) + " ms";
            averageTimeParallelTextBox.Text = Convert.ToString(parallelTime / multiplications) + " ms";
        }

        private async void startButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(sizeTextBox.Text) || string.IsNullOrEmpty(threadsTextBox.Text))
            {
                MessageBox.Show("Pusta wartość rozmiaru lub wątków");
                return;
            }
            int size = int.Parse(sizeTextBox.Text);
            int threads = int.Parse(threadsTextBox.Text);
            Stopwatch timeThread = new Stopwatch();
            Stopwatch timeParallel = new Stopwatch();
            Matrix matrix = new Matrix(size, threads);

            timeThread.Start();
            await Task.Run(() =>
            {
                matrix.StartThread();
            });
            timeThread.Stop();

            timeParallel.Start();
            matrix.StartParallel();
            timeParallel.Stop();

            UpdateTimeTextBox(size, threads, timeThread, false);
            UpdateTimeTextBox(size, threads, timeParallel, true);

            multiplications++;

            UpdateAverageTime(timeThread, timeParallel);
        }
    }
}
